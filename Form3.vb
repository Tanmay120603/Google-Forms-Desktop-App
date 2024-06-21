Imports System.Net.Http
Imports System.Security
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form3
    Private currIndex As Integer = 0
    Private maxLength As Integer = 0
    Private Editing As Boolean = False
    Private Async Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ping As JToken = Await FetchDataFromUrl($"http://localhost:8080/api/form/ping")
        If TypeOf ping IsNot JObject Then
            MsgBox("Data not loaded successfully")
            Exit Sub
        End If
        maxLength = ping("submittedCount")
        If maxLength = 0 Then
            MsgBox("No Data Exist")
            Me.Hide()
            Form2.Show()
            Exit Sub
        End If
        Dim res As JToken = Await FetchDataFromUrl($"http://localhost:8080/api/form/read/{currIndex}")
        setReadData(res)
    End Sub

    Private Sub setReadData(obj As JObject)
        txtReadName.Text = obj("name")
        txtReadEmail.Text = obj("email")
        txtReadPhone.Text = obj("phone")
        txtReadGithub.Text = obj("github_link")
        txtReadTime.Text = obj("stopWatch_time")
    End Sub
    Public Async Function FetchDataFromUrl(url As String) As Task(Of JToken)
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(url)

                response.EnsureSuccessStatusCode()

                Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                Dim responseData As JToken = JToken.Parse(responseBody)

                Return responseData

            Catch ex As HttpRequestException
                Return $"Request error: {ex.Message}"
            Catch ex As JsonException
                Return $"Request error :{ex.Message}"

            End Try
        End Using
    End Function

    Public Async Function DeleteSubmission(url As String) As Task(Of Boolean)
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync(url)
                response.EnsureSuccessStatusCode()
                Dim res As String = Await response.Content.ReadAsStringAsync()
                Return True

            Catch ex As HttpRequestException
                Return False
            End Try
        End Using
    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        NextResponse()
    End Sub
    Private Sub btnNext_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnNext.KeyPress
        If Asc(e.KeyChar) = 14 Then NextResponse()
    End Sub

    Private Async Sub NextResponse()
        If currIndex = maxLength - 1 Then Exit Sub
        currIndex = currIndex + 1
        Dim res As JToken = Await FetchDataFromUrl($"http://localhost:8080/api/form/read/{currIndex}")
        If TypeOf res IsNot JObject Then
            MsgBox("Something went wrong")
            Exit Sub
        End If
        setReadData(res)
    End Sub

    Private Async Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        PrevResponse()
    End Sub
    Private Sub btnPrev_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnPrev.KeyPress
        If Asc(e.KeyChar) = 16 Then PrevResponse()
    End Sub
    Private Async Sub PrevResponse()
        If currIndex = 0 Then Exit Sub
        currIndex = currIndex - 1
        Dim res As JToken = Await FetchDataFromUrl($"http://localhost:8080/api/form/read/{currIndex}")
        If TypeOf res IsNot JObject Then
            MsgBox("Something went wrong")
            Exit Sub
        End If
        setReadData(res)
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim deleteStatus As Boolean = Await DeleteSubmission($"http://localhost:8080/api/form/delete/{currIndex}")

        If Not deleteStatus Then
            MsgBox("Something went wrong")
            Exit Sub
        End If

        maxLength = maxLength - 1

        If maxLength = 0 Then
            Me.Hide()
            Form2.Show()
            Exit Sub
        End If

        If currIndex = maxLength Then
            PrevResponse()
            Exit Sub
        End If

        Dim res As JToken = Await FetchDataFromUrl($"http://localhost:8080/api/form/read/{currIndex}")
        setReadData(res)
    End Sub

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not Editing Then
            btnEdit.Text = "Save"
            Editing = True
            ChangeTextBoxMode(False)
            Exit Sub
        End If
        Dim notValid As Boolean = False
        Dim userData As UserData = New UserData() With {
            .email = txtReadEmail.Text,
            .name = txtReadName.Text,
            .github_link = txtReadGithub.Text,
            .phone = txtReadPhone.Text,
            .stopWatch_time = txtReadTime.Text
            }
        Dim Validate As Validation = New Validation()
        Validate.ValidateForm(notValid, userData)
        If notValid Then Exit Sub
        btnEdit.Text = "Edit"
        Editing = False
        Dim serializedJson As String = JsonConvert.SerializeObject(userData)
        Dim responseMsg As String = Await SendPutRequest($"http://localhost:8080/api/form/edit/{currIndex}", serializedJson)
        MsgBox(responseMsg)
        ChangeTextBoxMode(True)
    End Sub

    Async Function SendPutRequest(url As String, jsonData As String) As Task(Of String)
        Using client As New HttpClient()
            Try
                Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PutAsync(url, content)
                response.EnsureSuccessStatusCode()
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                Return responseContent
            Catch ex As HttpRequestException
                Console.WriteLine(ex.Message)
                Return "Something Went wrong data not modified in database Please try again"
            End Try
        End Using
    End Function

    Private Sub ChangeTextBoxMode(isRead As Boolean)
        txtReadEmail.ReadOnly = isRead
        txtReadName.ReadOnly = isRead
        txtReadGithub.ReadOnly = isRead
        txtReadPhone.ReadOnly = isRead
    End Sub

End Class