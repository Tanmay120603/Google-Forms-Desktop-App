﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.AccessibleName = "btnView"
        Me.btnView.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnView.ForeColor = System.Drawing.Color.IndianRed
        Me.btnView.Location = New System.Drawing.Point(242, 183)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(316, 40)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "View Submissions"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AccessibleName = "labFormHeader"
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(565, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tanmay Bhansali, Slidely Task 2 - Slidely Form App"
        '
        'btnCreate
        '
        Me.btnCreate.AccessibleDescription = ""
        Me.btnCreate.AccessibleName = "btnCreate"
        Me.btnCreate.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCreate.ForeColor = System.Drawing.Color.IndianRed
        Me.btnCreate.Location = New System.Drawing.Point(242, 229)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(316, 43)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create new Submission"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnView As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreate As Button
End Class
