﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarInfoHelp
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
        Me.lblTeam18Help3 = New System.Windows.Forms.Label()
        Me.lblTeam18Help2 = New System.Windows.Forms.Label()
        Me.lblTeam18Help1 = New System.Windows.Forms.Label()
        Me.lblTeam18CarInfoHelp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTeam18Help3
        '
        Me.lblTeam18Help3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Help3.Location = New System.Drawing.Point(89, 410)
        Me.lblTeam18Help3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeam18Help3.Name = "lblTeam18Help3"
        Me.lblTeam18Help3.Size = New System.Drawing.Size(740, 87)
        Me.lblTeam18Help3.TabIndex = 7
        Me.lblTeam18Help3.Text = "3. Once you have clicked ""Confirm"", you will be redirected to the ""Results"" page." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTeam18Help3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTeam18Help2
        '
        Me.lblTeam18Help2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Help2.Location = New System.Drawing.Point(89, 254)
        Me.lblTeam18Help2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeam18Help2.Name = "lblTeam18Help2"
        Me.lblTeam18Help2.Size = New System.Drawing.Size(740, 127)
        Me.lblTeam18Help2.TabIndex = 6
        Me.lblTeam18Help2.Text = "2. Please select the rest of of the required information in the table below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " and" &
    " click ""Confirm""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTeam18Help2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTeam18Help1
        '
        Me.lblTeam18Help1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Help1.Location = New System.Drawing.Point(89, 119)
        Me.lblTeam18Help1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeam18Help1.Name = "lblTeam18Help1"
        Me.lblTeam18Help1.Size = New System.Drawing.Size(740, 112)
        Me.lblTeam18Help1.TabIndex = 5
        Me.lblTeam18Help1.Text = "1. Please enter a budget you are willing to spend on a car."
        Me.lblTeam18Help1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTeam18CarInfoHelp
        '
        Me.lblTeam18CarInfoHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18CarInfoHelp.Location = New System.Drawing.Point(231, 35)
        Me.lblTeam18CarInfoHelp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeam18CarInfoHelp.Name = "lblTeam18CarInfoHelp"
        Me.lblTeam18CarInfoHelp.Size = New System.Drawing.Size(480, 69)
        Me.lblTeam18CarInfoHelp.TabIndex = 4
        Me.lblTeam18CarInfoHelp.Text = "Car Information Help"
        '
        'CarInfoHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(918, 533)
        Me.Controls.Add(Me.lblTeam18Help3)
        Me.Controls.Add(Me.lblTeam18Help2)
        Me.Controls.Add(Me.lblTeam18Help1)
        Me.Controls.Add(Me.lblTeam18CarInfoHelp)
        Me.Name = "CarInfoHelp"
        Me.Text = "CarInfoHelp"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTeam18Help3 As Label
    Friend WithEvents lblTeam18Help2 As Label
    Friend WithEvents lblTeam18Help1 As Label
    Friend WithEvents lblTeam18CarInfoHelp As Label
End Class
