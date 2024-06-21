<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReadName = New System.Windows.Forms.TextBox()
        Me.txtReadEmail = New System.Windows.Forms.TextBox()
        Me.txtReadGithub = New System.Windows.Forms.TextBox()
        Me.txtReadPhone = New System.Windows.Forms.TextBox()
        Me.labName = New System.Windows.Forms.Label()
        Me.labEmail = New System.Windows.Forms.Label()
        Me.labPhone = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReadTime = New System.Windows.Forms.TextBox()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(577, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanmay Bhansali, Slidely Task 2 - View Submissions"
        '
        'txtReadName
        '
        Me.txtReadName.AccessibleName = "txtReadName"
        Me.txtReadName.Location = New System.Drawing.Point(341, 110)
        Me.txtReadName.Name = "txtReadName"
        Me.txtReadName.ReadOnly = True
        Me.txtReadName.Size = New System.Drawing.Size(213, 22)
        Me.txtReadName.TabIndex = 1
        '
        'txtReadEmail
        '
        Me.txtReadEmail.AccessibleName = "txtReadEmail"
        Me.txtReadEmail.Location = New System.Drawing.Point(341, 147)
        Me.txtReadEmail.Name = "txtReadEmail"
        Me.txtReadEmail.ReadOnly = True
        Me.txtReadEmail.Size = New System.Drawing.Size(213, 22)
        Me.txtReadEmail.TabIndex = 2
        '
        'txtReadGithub
        '
        Me.txtReadGithub.AccessibleName = "txtReadGithub"
        Me.txtReadGithub.Location = New System.Drawing.Point(341, 235)
        Me.txtReadGithub.Name = "txtReadGithub"
        Me.txtReadGithub.ReadOnly = True
        Me.txtReadGithub.Size = New System.Drawing.Size(213, 22)
        Me.txtReadGithub.TabIndex = 3
        '
        'txtReadPhone
        '
        Me.txtReadPhone.AccessibleName = "txtReadPhone"
        Me.txtReadPhone.Location = New System.Drawing.Point(341, 192)
        Me.txtReadPhone.Name = "txtReadPhone"
        Me.txtReadPhone.ReadOnly = True
        Me.txtReadPhone.Size = New System.Drawing.Size(213, 22)
        Me.txtReadPhone.TabIndex = 4
        '
        'labName
        '
        Me.labName.AccessibleName = "labName"
        Me.labName.AutoSize = True
        Me.labName.Location = New System.Drawing.Point(273, 113)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(44, 16)
        Me.labName.TabIndex = 5
        Me.labName.Text = "Name"
        '
        'labEmail
        '
        Me.labEmail.AccessibleName = "labEmail"
        Me.labEmail.AutoSize = True
        Me.labEmail.Location = New System.Drawing.Point(273, 150)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(41, 16)
        Me.labEmail.TabIndex = 6
        Me.labEmail.Text = "Email"
        '
        'labPhone
        '
        Me.labPhone.AccessibleName = "labPhone"
        Me.labPhone.AutoSize = True
        Me.labPhone.Location = New System.Drawing.Point(248, 195)
        Me.labPhone.Name = "labPhone"
        Me.labPhone.Size = New System.Drawing.Size(77, 16)
        Me.labPhone.TabIndex = 7
        Me.labPhone.Text = "Phone Num"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(248, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Github Link " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Task 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(253, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 32)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Stopwatch " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "time"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtReadTime
        '
        Me.txtReadTime.AccessibleName = "txtReadTime"
        Me.txtReadTime.Location = New System.Drawing.Point(341, 285)
        Me.txtReadTime.Name = "txtReadTime"
        Me.txtReadTime.ReadOnly = True
        Me.txtReadTime.Size = New System.Drawing.Size(213, 22)
        Me.txtReadTime.TabIndex = 10
        '
        'btnPrev
        '
        Me.btnPrev.AccessibleName = "btnPrev"
        Me.btnPrev.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnPrev.ForeColor = System.Drawing.Color.IndianRed
        Me.btnPrev.Location = New System.Drawing.Point(242, 350)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 29)
        Me.btnPrev.TabIndex = 11
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.AccessibleName = "btnNext"
        Me.btnNext.BackColor = System.Drawing.Color.SkyBlue
        Me.btnNext.ForeColor = System.Drawing.Color.IndianRed
        Me.btnNext.Location = New System.Drawing.Point(529, 350)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 29)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleName = "btnDelete"
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(96, 83)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 28)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleName = "btnEdit"
        Me.btnEdit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEdit.Location = New System.Drawing.Point(177, 83)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 28)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.txtReadTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labPhone)
        Me.Controls.Add(Me.labEmail)
        Me.Controls.Add(Me.labName)
        Me.Controls.Add(Me.txtReadPhone)
        Me.Controls.Add(Me.txtReadGithub)
        Me.Controls.Add(Me.txtReadEmail)
        Me.Controls.Add(Me.txtReadName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtReadName As TextBox
    Friend WithEvents txtReadEmail As TextBox
    Friend WithEvents txtReadGithub As TextBox
    Friend WithEvents txtReadPhone As TextBox
    Friend WithEvents labName As Label
    Friend WithEvents labEmail As Label
    Friend WithEvents labPhone As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtReadTime As TextBox
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class
