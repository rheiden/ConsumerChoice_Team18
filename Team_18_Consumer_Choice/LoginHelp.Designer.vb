﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginHelp
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
        Me.lblTeam18LoginHelpTitle = New System.Windows.Forms.Label()
        Me.lblTeam18LoginHelp2 = New System.Windows.Forms.Label()
        Me.lblTeam18LoginHelp1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTeam18LoginHelpTitle
        '
        Me.lblTeam18LoginHelpTitle.AutoSize = True
        Me.lblTeam18LoginHelpTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18LoginHelpTitle.Location = New System.Drawing.Point(359, 127)
        Me.lblTeam18LoginHelpTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeam18LoginHelpTitle.Name = "lblTeam18LoginHelpTitle"
        Me.lblTeam18LoginHelpTitle.Size = New System.Drawing.Size(254, 55)
        Me.lblTeam18LoginHelpTitle.TabIndex = 5
        Me.lblTeam18LoginHelpTitle.Text = "Login Help"
        '
        'lblTeam18LoginHelp2
        '
        Me.lblTeam18LoginHelp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18LoginHelp2.Location = New System.Drawing.Point(25, 296)
        Me.lblTeam18LoginHelp2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeam18LoginHelp2.Name = "lblTeam18LoginHelp2"
        Me.lblTeam18LoginHelp2.Size = New System.Drawing.Size(892, 129)
        Me.lblTeam18LoginHelp2.TabIndex = 4
        Me.lblTeam18LoginHelp2.Text = "2. If you have not created a username and password, please click on the ""Create N" &
    "ew Account"" button and you will be redirected to the ""Create Account"" page." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTeam18LoginHelp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTeam18LoginHelp1
        '
        Me.lblTeam18LoginHelp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18LoginHelp1.Location = New System.Drawing.Point(25, 221)
        Me.lblTeam18LoginHelp1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeam18LoginHelp1.Name = "lblTeam18LoginHelp1"
        Me.lblTeam18LoginHelp1.Size = New System.Drawing.Size(892, 48)
        Me.lblTeam18LoginHelp1.TabIndex = 3
        Me.lblTeam18LoginHelp1.Text = "1. Please enter your username and password."
        Me.lblTeam18LoginHelp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(943, 552)
        Me.Controls.Add(Me.lblTeam18LoginHelpTitle)
        Me.Controls.Add(Me.lblTeam18LoginHelp2)
        Me.Controls.Add(Me.lblTeam18LoginHelp1)
        Me.Name = "LoginHelp"
        Me.Text = "LoginHelp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTeam18LoginHelpTitle As Label
    Friend WithEvents lblTeam18LoginHelp2 As Label
    Friend WithEvents lblTeam18LoginHelp1 As Label
End Class
