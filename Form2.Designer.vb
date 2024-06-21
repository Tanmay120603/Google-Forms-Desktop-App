<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.labPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.labGithub = New System.Windows.Forms.Label()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.labName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStopWatchTime = New System.Windows.Forms.TextBox()
        Me.btnStopWatch = New System.Windows.Forms.Button()
        Me.stopWatchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.AccessibleName = "btnSubmit"
        Me.btnSubmit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSubmit.Location = New System.Drawing.Point(331, 318)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(171, 40)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(584, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tanmay Bhansali, Slidely Task 2 - Create Submission"
        '
        'labEmail
        '
        Me.labEmail.AccessibleName = "labEmail"
        Me.labEmail.AutoSize = True
        Me.labEmail.Location = New System.Drawing.Point(214, 113)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labEmail.Size = New System.Drawing.Size(41, 16)
        Me.labEmail.TabIndex = 3
        Me.labEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.AccessibleName = "txtEmail"
        Me.txtEmail.Location = New System.Drawing.Point(284, 110)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(329, 22)
        Me.txtEmail.TabIndex = 4
        '
        'labPhone
        '
        Me.labPhone.AccessibleName = "labPhone"
        Me.labPhone.AutoSize = True
        Me.labPhone.Location = New System.Drawing.Point(187, 155)
        Me.labPhone.Name = "labPhone"
        Me.labPhone.Size = New System.Drawing.Size(77, 16)
        Me.labPhone.TabIndex = 5
        Me.labPhone.Text = "Phone Num"
        '
        'txtPhone
        '
        Me.txtPhone.AccessibleName = "txtPhone"
        Me.txtPhone.Location = New System.Drawing.Point(284, 152)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(329, 22)
        Me.txtPhone.TabIndex = 6
        '
        'labGithub
        '
        Me.labGithub.AccessibleName = "labGithub"
        Me.labGithub.AutoSize = True
        Me.labGithub.Location = New System.Drawing.Point(187, 187)
        Me.labGithub.Name = "labGithub"
        Me.labGithub.Size = New System.Drawing.Size(75, 32)
        Me.labGithub.TabIndex = 7
        Me.labGithub.Text = "Github Link " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Task 2"
        '
        'txtGithub
        '
        Me.txtGithub.AccessibleName = "txtGithub"
        Me.txtGithub.Location = New System.Drawing.Point(284, 197)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(329, 22)
        Me.txtGithub.TabIndex = 8
        '
        'labName
        '
        Me.labName.AccessibleName = "labName"
        Me.labName.AutoSize = True
        Me.labName.Location = New System.Drawing.Point(214, 73)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(44, 16)
        Me.labName.TabIndex = 9
        Me.labName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AccessibleName = "txtName"
        Me.txtName.Location = New System.Drawing.Point(284, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(329, 22)
        Me.txtName.TabIndex = 10
        '
        'txtStopWatchTime
        '
        Me.txtStopWatchTime.AccessibleName = "txtStopWatchTime"
        Me.txtStopWatchTime.Location = New System.Drawing.Point(464, 258)
        Me.txtStopWatchTime.Name = "txtStopWatchTime"
        Me.txtStopWatchTime.ReadOnly = True
        Me.txtStopWatchTime.Size = New System.Drawing.Size(100, 22)
        Me.txtStopWatchTime.TabIndex = 11
        Me.txtStopWatchTime.Text = "0:0:0"
        '
        'btnStopWatch
        '
        Me.btnStopWatch.AccessibleName = "btnStopWatch"
        Me.btnStopWatch.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnStopWatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopWatch.ForeColor = System.Drawing.Color.IndianRed
        Me.btnStopWatch.Location = New System.Drawing.Point(235, 248)
        Me.btnStopWatch.Name = "btnStopWatch"
        Me.btnStopWatch.Size = New System.Drawing.Size(191, 42)
        Me.btnStopWatch.TabIndex = 12
        Me.btnStopWatch.Text = "Start"
        Me.btnStopWatch.UseVisualStyleBackColor = False
        '
        'stopWatchTimer
        '
        Me.stopWatchTimer.Interval = 1000
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 378)
        Me.Controls.Add(Me.btnStopWatch)
        Me.Controls.Add(Me.txtStopWatchTime)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.labName)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.labGithub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.labPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.labEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents labEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents labPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents labGithub As Label
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents labName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStopWatchTime As TextBox
    Friend WithEvents btnStopWatch As Button
    Friend WithEvents stopWatchTimer As Timer
End Class
