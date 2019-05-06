<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTeam18CreateAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtTeam18Budget = New System.Windows.Forms.TextBox()
        Me.lblTeam18Budget = New System.Windows.Forms.Label()
        Me.btnTeam18GoBackNewUser = New System.Windows.Forms.Button()
        Me.btnTeam18CreateAccount = New System.Windows.Forms.Button()
        Me.btnTeam18ExitNewUser = New System.Windows.Forms.Button()
        Me.txtTeam18NewPass = New System.Windows.Forms.TextBox()
        Me.txtTeam18NewUsername = New System.Windows.Forms.TextBox()
        Me.lblTeam18NewPassword = New System.Windows.Forms.Label()
        Me.lblTeam18NewUsername = New System.Windows.Forms.Label()
        Me.lblTeam18NewUserTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTeam18Budget
        '
        Me.txtTeam18Budget.Location = New System.Drawing.Point(158, 157)
        Me.txtTeam18Budget.Name = "txtTeam18Budget"
        Me.txtTeam18Budget.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam18Budget.TabIndex = 21
        '
        'lblTeam18Budget
        '
        Me.lblTeam18Budget.AutoSize = True
        Me.lblTeam18Budget.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Budget.Location = New System.Drawing.Point(77, 162)
        Me.lblTeam18Budget.Name = "lblTeam18Budget"
        Me.lblTeam18Budget.Size = New System.Drawing.Size(60, 15)
        Me.lblTeam18Budget.TabIndex = 20
        Me.lblTeam18Budget.Text = "Budget: $"
        '
        'btnTeam18GoBackNewUser
        '
        Me.btnTeam18GoBackNewUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18GoBackNewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTeam18GoBackNewUser.Location = New System.Drawing.Point(1, 2)
        Me.btnTeam18GoBackNewUser.Name = "btnTeam18GoBackNewUser"
        Me.btnTeam18GoBackNewUser.Size = New System.Drawing.Size(85, 34)
        Me.btnTeam18GoBackNewUser.TabIndex = 19
        Me.btnTeam18GoBackNewUser.Text = "<--- Go Back"
        Me.btnTeam18GoBackNewUser.UseVisualStyleBackColor = True
        '
        'btnTeam18CreateAccount
        '
        Me.btnTeam18CreateAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18CreateAccount.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnTeam18CreateAccount.Location = New System.Drawing.Point(139, 297)
        Me.btnTeam18CreateAccount.Name = "btnTeam18CreateAccount"
        Me.btnTeam18CreateAccount.Size = New System.Drawing.Size(100, 34)
        Me.btnTeam18CreateAccount.TabIndex = 18
        Me.btnTeam18CreateAccount.Text = "Create Account"
        Me.btnTeam18CreateAccount.UseVisualStyleBackColor = True
        '
        'btnTeam18ExitNewUser
        '
        Me.btnTeam18ExitNewUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18ExitNewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTeam18ExitNewUser.Location = New System.Drawing.Point(11, 297)
        Me.btnTeam18ExitNewUser.Name = "btnTeam18ExitNewUser"
        Me.btnTeam18ExitNewUser.Size = New System.Drawing.Size(75, 34)
        Me.btnTeam18ExitNewUser.TabIndex = 17
        Me.btnTeam18ExitNewUser.Text = "Exit"
        Me.btnTeam18ExitNewUser.UseVisualStyleBackColor = True
        '
        'txtTeam18NewPass
        '
        Me.txtTeam18NewPass.Location = New System.Drawing.Point(158, 112)
        Me.txtTeam18NewPass.Name = "txtTeam18NewPass"
        Me.txtTeam18NewPass.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam18NewPass.TabIndex = 13
        '
        'txtTeam18NewUsername
        '
        Me.txtTeam18NewUsername.Location = New System.Drawing.Point(158, 72)
        Me.txtTeam18NewUsername.Name = "txtTeam18NewUsername"
        Me.txtTeam18NewUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam18NewUsername.TabIndex = 11
        '
        'lblTeam18NewPassword
        '
        Me.lblTeam18NewPassword.AutoSize = True
        Me.lblTeam18NewPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18NewPassword.Location = New System.Drawing.Point(77, 117)
        Me.lblTeam18NewPassword.Name = "lblTeam18NewPassword"
        Me.lblTeam18NewPassword.Size = New System.Drawing.Size(66, 15)
        Me.lblTeam18NewPassword.TabIndex = 15
        Me.lblTeam18NewPassword.Text = "Password: "
        '
        'lblTeam18NewUsername
        '
        Me.lblTeam18NewUsername.AutoSize = True
        Me.lblTeam18NewUsername.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18NewUsername.Location = New System.Drawing.Point(73, 74)
        Me.lblTeam18NewUsername.Name = "lblTeam18NewUsername"
        Me.lblTeam18NewUsername.Size = New System.Drawing.Size(70, 15)
        Me.lblTeam18NewUsername.TabIndex = 14
        Me.lblTeam18NewUsername.Text = "Username: "
        '
        'lblTeam18NewUserTitle
        '
        Me.lblTeam18NewUserTitle.AutoSize = True
        Me.lblTeam18NewUserTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18NewUserTitle.Location = New System.Drawing.Point(92, 9)
        Me.lblTeam18NewUserTitle.Name = "lblTeam18NewUserTitle"
        Me.lblTeam18NewUserTitle.Size = New System.Drawing.Size(242, 19)
        Me.lblTeam18NewUserTitle.TabIndex = 12
        Me.lblTeam18NewUserTitle.Text = "Please Enter The Following Fields: "
        '
        'frmTeam18CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(339, 343)
        Me.Controls.Add(Me.txtTeam18Budget)
        Me.Controls.Add(Me.lblTeam18Budget)
        Me.Controls.Add(Me.btnTeam18GoBackNewUser)
        Me.Controls.Add(Me.btnTeam18CreateAccount)
        Me.Controls.Add(Me.btnTeam18ExitNewUser)
        Me.Controls.Add(Me.txtTeam18NewPass)
        Me.Controls.Add(Me.txtTeam18NewUsername)
        Me.Controls.Add(Me.lblTeam18NewPassword)
        Me.Controls.Add(Me.lblTeam18NewUsername)
        Me.Controls.Add(Me.lblTeam18NewUserTitle)
        Me.Name = "frmTeam18CreateAccount"
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTeam18Budget As TextBox
    Friend WithEvents lblTeam18Budget As Label
    Friend WithEvents btnTeam18GoBackNewUser As Button
    Friend WithEvents btnTeam18CreateAccount As Button
    Friend WithEvents btnTeam18ExitNewUser As Button
    Friend WithEvents txtTeam18NewPass As TextBox
    Friend WithEvents txtTeam18NewUsername As TextBox
    Friend WithEvents lblTeam18NewPassword As Label
    Friend WithEvents lblTeam18NewUsername As Label
    Friend WithEvents lblTeam18NewUserTitle As Label
End Class
