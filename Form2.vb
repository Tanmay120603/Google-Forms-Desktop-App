Imports System.ComponentModel.Design
Imports System.Net.Http
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class Form2
    Private intSec As Integer = 0
    Private intMin As Integer = 0
    Private intHour As Integer = 0
    Private stopWatchRunning As Boolean = False
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles stopWatchTimer.Tick
        intSec = intSec + 1
        If intSec = 60 Then
            intSec = 0
            intMin = intMin + 1
            If intMin = 60 Then
                intMin = 0
                intHour = intHour + 1
            End If
        End If
        txtStopWatchTime.Text = intHour & ":" & intMin & ":" & intSec
    End Sub

    Private Sub btnStopWatch_Click(sender As Object, e As EventArgs) Handles btnStopWatch.Click
        ToggleStopWatch()
    End Sub

    Private Sub btnStopWatch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnStopWatch.KeyPress
        If (Asc(e.KeyChar) = 20) Then ToggleStopWatch()
    End Sub

    Private Sub ToggleStopWatch()
        If Not stopWatchRunning Then
            stopWatchRunning = True
            btnStopWatch.Text = "Stop"
            stopWatchTimer.Start()
        Else
            stopWatchRunning = False
            btnStopWatch.Text = "Start"
            stopWatchTimer.Stop()
        End If
    End Sub
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SubmitForm()
    End Sub
    Private Sub btnSubmit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSubmit.KeyPress
        If Asc(e.KeyChar) = 19 Then SubmitForm()
    End Sub

    Private Async Sub SubmitForm()
        Dim notValid As Boolean = False
        Dim jsonString As String
        Dim responseMsg As String
        Dim userData As UserData = New UserData() With {
            .email = txtEmail.Text,
            .name = txtName.Text,
            .github_link = txtGithub.Text,
            .phone = txtPhone.Text,
            .stopWatch_time = txtStopWatchTime.Text
            }
        Dim Validate As Validation = New Validation()
        Validate.ValidateForm(notValid, userData)
        If (notValid) Then Exit Sub
        jsonString = JsonConvert.SerializeObject(userData)
        responseMsg = Await SendPostRequest("http://localhost:8080/api/form/submit", jsonString)
        MsgBox(responseMsg)
        intSec = 0
        intMin = 0
        intHour = 0
        If stopWatchRunning = True Then ToggleStopWatch()
        txtStopWatchTime.Text = intHour & ":" & intMin & ":" & intSec
    End Sub

    Async Function SendPostRequest(ByVal url As String, ByVal jsonData As String) As Task(Of String)
        Using client As New HttpClient()
            Try
                Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

                response.EnsureSuccessStatusCode()

                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                Return responseContent
            Catch ex As HttpRequestException
                Return $"Something Went wrong Reason --> {ex.Message}"
            End Try
        End Using
    End Function
End Class

Public Class Validation
    Public Sub ValidateForm(ByRef notValid As Boolean, userData As UserData)
        If (Not Regex.IsMatch(userData.name, "^(?!\s*$).+")) Then
            MsgBox("Name can not be empty")
            notValid = True
        ElseIf (Not Regex.IsMatch(userData.email, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")) Then
            MsgBox("Email is not valid")
            notValid = True
        ElseIf (Not Regex.IsMatch(userData.phone, "^[0-9]{10}$")) Then
            MsgBox("Phone number is not valid")
            notValid = True
            Exit Sub
        ElseIf (Not Regex.IsMatch(userData.github_link, "^(?!\s*$).+")) Then
            MsgBox("Github link can not be empty")
            notValid = True
        End If
    End Sub

End Class

Public Class UserData
    Public name As String
    Public email As String
    Public github_link As String
    Public phone As String
    Public stopWatch_time As String
End Class