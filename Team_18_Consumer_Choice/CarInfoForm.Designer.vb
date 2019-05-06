<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeam18CarInfo
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
        Me.btnTeam18ExitCarInfo = New System.Windows.Forms.Button()
        Me.btnTeam18ConfirmInfo = New System.Windows.Forms.Button()
        Me.btnTeam18GoBackCarInfo = New System.Windows.Forms.Button()
        Me.tblTeam18CarInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxTeam18Model = New System.Windows.Forms.ComboBox()
        Me.cbxTeam18Transmission = New System.Windows.Forms.ComboBox()
        Me.cbxTeam18Engine = New System.Windows.Forms.ComboBox()
        Me.lblTeam18Condition = New System.Windows.Forms.Label()
        Me.lblTeam18Engine = New System.Windows.Forms.Label()
        Me.lblTeam18Transmission = New System.Windows.Forms.Label()
        Me.lblTeam18Model = New System.Windows.Forms.Label()
        Me.cbxTeam18Condition = New System.Windows.Forms.ComboBox()
        Me.cbxTeam18ConditionWeight = New System.Windows.Forms.ComboBox()
        Me.cbxTeam18EngineWeight = New System.Windows.Forms.ComboBox()
        Me.cbxTeam18TransmissionWeight = New System.Windows.Forms.ComboBox()
        Me.cbxTeam18ModelWeight = New System.Windows.Forms.ComboBox()
        Me.lblTeam18TitleCarInfo = New System.Windows.Forms.Label()
        Me.lblTeam18Option = New System.Windows.Forms.Label()
        Me.lblTeam18Choice = New System.Windows.Forms.Label()
        Me.lblTeam18Priority = New System.Windows.Forms.Label()
        Me.tblTeam18CarInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTeam18ExitCarInfo
        '
        Me.btnTeam18ExitCarInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18ExitCarInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTeam18ExitCarInfo.Location = New System.Drawing.Point(23, 360)
        Me.btnTeam18ExitCarInfo.Name = "btnTeam18ExitCarInfo"
        Me.btnTeam18ExitCarInfo.Size = New System.Drawing.Size(75, 34)
        Me.btnTeam18ExitCarInfo.TabIndex = 15
        Me.btnTeam18ExitCarInfo.Text = "Exit"
        Me.btnTeam18ExitCarInfo.UseVisualStyleBackColor = True
        '
        'btnTeam18ConfirmInfo
        '
        Me.btnTeam18ConfirmInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18ConfirmInfo.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnTeam18ConfirmInfo.Location = New System.Drawing.Point(220, 360)
        Me.btnTeam18ConfirmInfo.Name = "btnTeam18ConfirmInfo"
        Me.btnTeam18ConfirmInfo.Size = New System.Drawing.Size(75, 34)
        Me.btnTeam18ConfirmInfo.TabIndex = 14
        Me.btnTeam18ConfirmInfo.Text = "Confirm"
        Me.btnTeam18ConfirmInfo.UseVisualStyleBackColor = True
        '
        'btnTeam18GoBackCarInfo
        '
        Me.btnTeam18GoBackCarInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18GoBackCarInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTeam18GoBackCarInfo.Location = New System.Drawing.Point(11, 14)
        Me.btnTeam18GoBackCarInfo.Name = "btnTeam18GoBackCarInfo"
        Me.btnTeam18GoBackCarInfo.Size = New System.Drawing.Size(87, 34)
        Me.btnTeam18GoBackCarInfo.TabIndex = 13
        Me.btnTeam18GoBackCarInfo.Text = "<--- Go Back"
        Me.btnTeam18GoBackCarInfo.UseVisualStyleBackColor = True
        '
        'tblTeam18CarInfo
        '
        Me.tblTeam18CarInfo.ColumnCount = 3
        Me.tblTeam18CarInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblTeam18CarInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblTeam18CarInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblTeam18CarInfo.Controls.Add(Me.cbxTeam18Model, 1, 3)
        Me.tblTeam18CarInfo.Controls.Add(Me.cbxTeam18Transmission, 1, 2)
        Me.tblTeam18CarInfo.Controls.Add(Me.cbxTeam18Engine, 1, 1)
        Me.tblTeam18CarInfo.Controls.Add(Me.lblTeam18Condition, 0, 0)
        Me.tblTeam18CarInfo.Controls.Add(Me.lblTeam18Engine, 0, 1)
        Me.tblTeam18CarInfo.Controls.Add(Me.lblTeam18Transmission, 0, 2)
        Me.tblTeam18CarInfo.Controls.Add(Me.lblTeam18Model, 0, 3)
        Me.tblTeam18CarInfo.Controls.Add(Me.cbxTeam18Condition, 1, 0)
        Me.tblTeam18CarInfo.Controls.Add(Me.cbxTeam18ConditionWeight, 2, 0)
        Me.tblTeam18CarInfo.Controls.Add(Me.cbxTeam18EngineWeight, 2, 1)
        Me.tblTeam18CarInfo.Controls.Add(Me.cbxTeam18TransmissionWeight, 2, 2)
        Me.tblTeam18CarInfo.Controls.Add(Me.cbxTeam18ModelWeight, 2, 3)
        Me.tblTeam18CarInfo.Location = New System.Drawing.Point(65, 94)
        Me.tblTeam18CarInfo.Name = "tblTeam18CarInfo"
        Me.tblTeam18CarInfo.RowCount = 4
        Me.tblTeam18CarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTeam18CarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTeam18CarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTeam18CarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTeam18CarInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblTeam18CarInfo.Size = New System.Drawing.Size(346, 207)
        Me.tblTeam18CarInfo.TabIndex = 12
        '
        'cbxTeam18Model
        '
        Me.cbxTeam18Model.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18Model.FormattingEnabled = True
        Me.cbxTeam18Model.Items.AddRange(New Object() {"Sedan", "SUV", "Sports", "Truck"})
        Me.cbxTeam18Model.Location = New System.Drawing.Point(118, 169)
        Me.cbxTeam18Model.Name = "cbxTeam18Model"
        Me.cbxTeam18Model.Size = New System.Drawing.Size(109, 21)
        Me.cbxTeam18Model.TabIndex = 11
        '
        'cbxTeam18Transmission
        '
        Me.cbxTeam18Transmission.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18Transmission.FormattingEnabled = True
        Me.cbxTeam18Transmission.Items.AddRange(New Object() {"5-Speed", "6-Speed", "Automatic"})
        Me.cbxTeam18Transmission.Location = New System.Drawing.Point(118, 117)
        Me.cbxTeam18Transmission.Name = "cbxTeam18Transmission"
        Me.cbxTeam18Transmission.Size = New System.Drawing.Size(109, 21)
        Me.cbxTeam18Transmission.TabIndex = 9
        '
        'cbxTeam18Engine
        '
        Me.cbxTeam18Engine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18Engine.FormattingEnabled = True
        Me.cbxTeam18Engine.Items.AddRange(New Object() {"Gas", "Hybrid", "Electric"})
        Me.cbxTeam18Engine.Location = New System.Drawing.Point(118, 66)
        Me.cbxTeam18Engine.Name = "cbxTeam18Engine"
        Me.cbxTeam18Engine.Size = New System.Drawing.Size(109, 21)
        Me.cbxTeam18Engine.TabIndex = 8
        '
        'lblTeam18Condition
        '
        Me.lblTeam18Condition.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Condition.AutoSize = True
        Me.lblTeam18Condition.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Condition.Location = New System.Drawing.Point(45, 18)
        Me.lblTeam18Condition.Name = "lblTeam18Condition"
        Me.lblTeam18Condition.Size = New System.Drawing.Size(67, 15)
        Me.lblTeam18Condition.TabIndex = 2
        Me.lblTeam18Condition.Text = "Condition: "
        '
        'lblTeam18Engine
        '
        Me.lblTeam18Engine.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Engine.AutoSize = True
        Me.lblTeam18Engine.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Engine.Location = New System.Drawing.Point(62, 69)
        Me.lblTeam18Engine.Name = "lblTeam18Engine"
        Me.lblTeam18Engine.Size = New System.Drawing.Size(50, 15)
        Me.lblTeam18Engine.TabIndex = 3
        Me.lblTeam18Engine.Text = "Engine: "
        '
        'lblTeam18Transmission
        '
        Me.lblTeam18Transmission.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Transmission.AutoSize = True
        Me.lblTeam18Transmission.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Transmission.Location = New System.Drawing.Point(29, 120)
        Me.lblTeam18Transmission.Name = "lblTeam18Transmission"
        Me.lblTeam18Transmission.Size = New System.Drawing.Size(83, 15)
        Me.lblTeam18Transmission.TabIndex = 4
        Me.lblTeam18Transmission.Text = "Transmission: "
        '
        'lblTeam18Model
        '
        Me.lblTeam18Model.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Model.AutoSize = True
        Me.lblTeam18Model.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Model.Location = New System.Drawing.Point(42, 172)
        Me.lblTeam18Model.Name = "lblTeam18Model"
        Me.lblTeam18Model.Size = New System.Drawing.Size(70, 15)
        Me.lblTeam18Model.TabIndex = 6
        Me.lblTeam18Model.Text = "Body Type: "
        '
        'cbxTeam18Condition
        '
        Me.cbxTeam18Condition.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18Condition.FormattingEnabled = True
        Me.cbxTeam18Condition.Items.AddRange(New Object() {"Used", "New"})
        Me.cbxTeam18Condition.Location = New System.Drawing.Point(118, 15)
        Me.cbxTeam18Condition.Name = "cbxTeam18Condition"
        Me.cbxTeam18Condition.Size = New System.Drawing.Size(109, 21)
        Me.cbxTeam18Condition.TabIndex = 7
        '
        'cbxTeam18ConditionWeight
        '
        Me.cbxTeam18ConditionWeight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18ConditionWeight.FormattingEnabled = True
        Me.cbxTeam18ConditionWeight.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbxTeam18ConditionWeight.Location = New System.Drawing.Point(233, 15)
        Me.cbxTeam18ConditionWeight.Name = "cbxTeam18ConditionWeight"
        Me.cbxTeam18ConditionWeight.Size = New System.Drawing.Size(109, 21)
        Me.cbxTeam18ConditionWeight.TabIndex = 12
        '
        'cbxTeam18EngineWeight
        '
        Me.cbxTeam18EngineWeight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18EngineWeight.FormattingEnabled = True
        Me.cbxTeam18EngineWeight.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbxTeam18EngineWeight.Location = New System.Drawing.Point(233, 66)
        Me.cbxTeam18EngineWeight.Name = "cbxTeam18EngineWeight"
        Me.cbxTeam18EngineWeight.Size = New System.Drawing.Size(109, 21)
        Me.cbxTeam18EngineWeight.TabIndex = 13
        '
        'cbxTeam18TransmissionWeight
        '
        Me.cbxTeam18TransmissionWeight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18TransmissionWeight.FormattingEnabled = True
        Me.cbxTeam18TransmissionWeight.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbxTeam18TransmissionWeight.Location = New System.Drawing.Point(233, 117)
        Me.cbxTeam18TransmissionWeight.Name = "cbxTeam18TransmissionWeight"
        Me.cbxTeam18TransmissionWeight.Size = New System.Drawing.Size(109, 21)
        Me.cbxTeam18TransmissionWeight.TabIndex = 14
        '
        'cbxTeam18ModelWeight
        '
        Me.cbxTeam18ModelWeight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18ModelWeight.FormattingEnabled = True
        Me.cbxTeam18ModelWeight.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbxTeam18ModelWeight.Location = New System.Drawing.Point(233, 169)
        Me.cbxTeam18ModelWeight.Name = "cbxTeam18ModelWeight"
        Me.cbxTeam18ModelWeight.Size = New System.Drawing.Size(109, 21)
        Me.cbxTeam18ModelWeight.TabIndex = 15
        '
        'lblTeam18TitleCarInfo
        '
        Me.lblTeam18TitleCarInfo.AutoSize = True
        Me.lblTeam18TitleCarInfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18TitleCarInfo.Location = New System.Drawing.Point(110, 21)
        Me.lblTeam18TitleCarInfo.Name = "lblTeam18TitleCarInfo"
        Me.lblTeam18TitleCarInfo.Size = New System.Drawing.Size(283, 19)
        Me.lblTeam18TitleCarInfo.TabIndex = 11
        Me.lblTeam18TitleCarInfo.Text = "Please Enter the Following Information: "
        '
        'lblTeam18Option
        '
        Me.lblTeam18Option.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Option.AutoSize = True
        Me.lblTeam18Option.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Option.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTeam18Option.Location = New System.Drawing.Point(84, 76)
        Me.lblTeam18Option.Name = "lblTeam18Option"
        Me.lblTeam18Option.Size = New System.Drawing.Size(76, 16)
        Me.lblTeam18Option.TabIndex = 12
        Me.lblTeam18Option.Text = "Car Option"
        '
        'lblTeam18Choice
        '
        Me.lblTeam18Choice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTeam18Choice.AutoSize = True
        Me.lblTeam18Choice.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Choice.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTeam18Choice.Location = New System.Drawing.Point(196, 75)
        Me.lblTeam18Choice.Name = "lblTeam18Choice"
        Me.lblTeam18Choice.Size = New System.Drawing.Size(96, 16)
        Me.lblTeam18Choice.TabIndex = 16
        Me.lblTeam18Choice.Text = "Select Choice"
        '
        'lblTeam18Priority
        '
        Me.lblTeam18Priority.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Priority.AutoSize = True
        Me.lblTeam18Priority.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Priority.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTeam18Priority.Location = New System.Drawing.Point(309, 76)
        Me.lblTeam18Priority.Name = "lblTeam18Priority"
        Me.lblTeam18Priority.Size = New System.Drawing.Size(98, 16)
        Me.lblTeam18Priority.TabIndex = 17
        Me.lblTeam18Priority.Text = "Select Priority"
        '
        'frmTeam18CarInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(495, 398)
        Me.Controls.Add(Me.lblTeam18Priority)
        Me.Controls.Add(Me.lblTeam18Choice)
        Me.Controls.Add(Me.lblTeam18Option)
        Me.Controls.Add(Me.btnTeam18ExitCarInfo)
        Me.Controls.Add(Me.btnTeam18ConfirmInfo)
        Me.Controls.Add(Me.btnTeam18GoBackCarInfo)
        Me.Controls.Add(Me.tblTeam18CarInfo)
        Me.Controls.Add(Me.lblTeam18TitleCarInfo)
        Me.Name = "frmTeam18CarInfo"
        Me.Text = "Car Information"
        Me.tblTeam18CarInfo.ResumeLayout(False)
        Me.tblTeam18CarInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTeam18ExitCarInfo As Button
    Friend WithEvents btnTeam18ConfirmInfo As Button
    Friend WithEvents btnTeam18GoBackCarInfo As Button
    Friend WithEvents tblTeam18CarInfo As TableLayoutPanel
    Friend WithEvents cbxTeam18Model As ComboBox
    Friend WithEvents cbxTeam18Transmission As ComboBox
    Friend WithEvents cbxTeam18Engine As ComboBox
    Friend WithEvents lblTeam18Condition As Label
    Friend WithEvents lblTeam18Engine As Label
    Friend WithEvents lblTeam18Transmission As Label
    Friend WithEvents lblTeam18Model As Label
    Friend WithEvents cbxTeam18Condition As ComboBox
    Friend WithEvents lblTeam18TitleCarInfo As Label
    Friend WithEvents cbxTeam18ConditionWeight As ComboBox
    Friend WithEvents cbxTeam18EngineWeight As ComboBox
    Friend WithEvents cbxTeam18TransmissionWeight As ComboBox
    Friend WithEvents cbxTeam18ModelWeight As ComboBox
    Friend WithEvents lblTeam18Option As Label
    Friend WithEvents lblTeam18Choice As Label
    Friend WithEvents lblTeam18Priority As Label
End Class
