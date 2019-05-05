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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtTeam18FuelEfficiency = New System.Windows.Forms.TextBox()
        Me.cbxTeam18Model = New System.Windows.Forms.ComboBox()
        Me.cbxTeam18Transmission = New System.Windows.Forms.ComboBox()
        Me.cbxTeam18Engine = New System.Windows.Forms.ComboBox()
        Me.lblTeam18UsedNew = New System.Windows.Forms.Label()
        Me.lblTeam18Fuel = New System.Windows.Forms.Label()
        Me.lblTeam18Engine = New System.Windows.Forms.Label()
        Me.lblTeam18Transmission = New System.Windows.Forms.Label()
        Me.lblTeam18Model = New System.Windows.Forms.Label()
        Me.cbxTeam18UsedNew = New System.Windows.Forms.ComboBox()
        Me.lblTeam18TitleCarInfo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTeam18ExitCarInfo
        '
        Me.btnTeam18ExitCarInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18ExitCarInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTeam18ExitCarInfo.Location = New System.Drawing.Point(46, 692)
        Me.btnTeam18ExitCarInfo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnTeam18ExitCarInfo.Name = "btnTeam18ExitCarInfo"
        Me.btnTeam18ExitCarInfo.Size = New System.Drawing.Size(150, 65)
        Me.btnTeam18ExitCarInfo.TabIndex = 15
        Me.btnTeam18ExitCarInfo.Text = "Exit"
        Me.btnTeam18ExitCarInfo.UseVisualStyleBackColor = True
        '
        'btnTeam18ConfirmInfo
        '
        Me.btnTeam18ConfirmInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18ConfirmInfo.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnTeam18ConfirmInfo.Location = New System.Drawing.Point(440, 692)
        Me.btnTeam18ConfirmInfo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnTeam18ConfirmInfo.Name = "btnTeam18ConfirmInfo"
        Me.btnTeam18ConfirmInfo.Size = New System.Drawing.Size(150, 65)
        Me.btnTeam18ConfirmInfo.TabIndex = 14
        Me.btnTeam18ConfirmInfo.Text = "Confirm"
        Me.btnTeam18ConfirmInfo.UseVisualStyleBackColor = True
        '
        'btnTeam18GoBackCarInfo
        '
        Me.btnTeam18GoBackCarInfo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam18GoBackCarInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTeam18GoBackCarInfo.Location = New System.Drawing.Point(22, 27)
        Me.btnTeam18GoBackCarInfo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnTeam18GoBackCarInfo.Name = "btnTeam18GoBackCarInfo"
        Me.btnTeam18GoBackCarInfo.Size = New System.Drawing.Size(174, 65)
        Me.btnTeam18GoBackCarInfo.TabIndex = 13
        Me.btnTeam18GoBackCarInfo.Text = "<--- Go Back"
        Me.btnTeam18GoBackCarInfo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtTeam18FuelEfficiency, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxTeam18Model, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxTeam18Transmission, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxTeam18Engine, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTeam18UsedNew, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTeam18Fuel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTeam18Engine, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTeam18Transmission, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTeam18Model, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxTeam18UsedNew, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(130, 181)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(692, 398)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'txtTeam18FuelEfficiency
        '
        Me.txtTeam18FuelEfficiency.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTeam18FuelEfficiency.Location = New System.Drawing.Point(352, 261)
        Me.txtTeam18FuelEfficiency.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTeam18FuelEfficiency.Name = "txtTeam18FuelEfficiency"
        Me.txtTeam18FuelEfficiency.Size = New System.Drawing.Size(238, 31)
        Me.txtTeam18FuelEfficiency.TabIndex = 8
        '
        'cbxTeam18Model
        '
        Me.cbxTeam18Model.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18Model.FormattingEnabled = True
        Me.cbxTeam18Model.Items.AddRange(New Object() {"Sedan", "SUV", "Sports", "Truck"})
        Me.cbxTeam18Model.Location = New System.Drawing.Point(352, 340)
        Me.cbxTeam18Model.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbxTeam18Model.Name = "cbxTeam18Model"
        Me.cbxTeam18Model.Size = New System.Drawing.Size(238, 33)
        Me.cbxTeam18Model.TabIndex = 11
        '
        'cbxTeam18Transmission
        '
        Me.cbxTeam18Transmission.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18Transmission.FormattingEnabled = True
        Me.cbxTeam18Transmission.Items.AddRange(New Object() {"5-Speed", "6-Speed", "Automatic"})
        Me.cbxTeam18Transmission.Location = New System.Drawing.Point(352, 181)
        Me.cbxTeam18Transmission.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbxTeam18Transmission.Name = "cbxTeam18Transmission"
        Me.cbxTeam18Transmission.Size = New System.Drawing.Size(238, 33)
        Me.cbxTeam18Transmission.TabIndex = 9
        '
        'cbxTeam18Engine
        '
        Me.cbxTeam18Engine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18Engine.FormattingEnabled = True
        Me.cbxTeam18Engine.Items.AddRange(New Object() {"Gas", "Hybrid", "Electric"})
        Me.cbxTeam18Engine.Location = New System.Drawing.Point(352, 102)
        Me.cbxTeam18Engine.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbxTeam18Engine.Name = "cbxTeam18Engine"
        Me.cbxTeam18Engine.Size = New System.Drawing.Size(238, 33)
        Me.cbxTeam18Engine.TabIndex = 8
        '
        'lblTeam18UsedNew
        '
        Me.lblTeam18UsedNew.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18UsedNew.AutoSize = True
        Me.lblTeam18UsedNew.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18UsedNew.Location = New System.Drawing.Point(198, 23)
        Me.lblTeam18UsedNew.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTeam18UsedNew.Name = "lblTeam18UsedNew"
        Me.lblTeam18UsedNew.Size = New System.Drawing.Size(142, 32)
        Me.lblTeam18UsedNew.TabIndex = 2
        Me.lblTeam18UsedNew.Text = "Used/New: "
        '
        'lblTeam18Fuel
        '
        Me.lblTeam18Fuel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Fuel.AutoSize = True
        Me.lblTeam18Fuel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Fuel.Location = New System.Drawing.Point(160, 260)
        Me.lblTeam18Fuel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTeam18Fuel.Name = "lblTeam18Fuel"
        Me.lblTeam18Fuel.Size = New System.Drawing.Size(180, 32)
        Me.lblTeam18Fuel.TabIndex = 5
        Me.lblTeam18Fuel.Text = "Fuel Efficiency: "
        '
        'lblTeam18Engine
        '
        Me.lblTeam18Engine.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Engine.AutoSize = True
        Me.lblTeam18Engine.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Engine.Location = New System.Drawing.Point(240, 102)
        Me.lblTeam18Engine.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTeam18Engine.Name = "lblTeam18Engine"
        Me.lblTeam18Engine.Size = New System.Drawing.Size(100, 32)
        Me.lblTeam18Engine.TabIndex = 3
        Me.lblTeam18Engine.Text = "Engine: "
        '
        'lblTeam18Transmission
        '
        Me.lblTeam18Transmission.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Transmission.AutoSize = True
        Me.lblTeam18Transmission.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Transmission.Location = New System.Drawing.Point(174, 181)
        Me.lblTeam18Transmission.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTeam18Transmission.Name = "lblTeam18Transmission"
        Me.lblTeam18Transmission.Size = New System.Drawing.Size(166, 32)
        Me.lblTeam18Transmission.TabIndex = 4
        Me.lblTeam18Transmission.Text = "Transmission: "
        '
        'lblTeam18Model
        '
        Me.lblTeam18Model.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTeam18Model.AutoSize = True
        Me.lblTeam18Model.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18Model.Location = New System.Drawing.Point(200, 341)
        Me.lblTeam18Model.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTeam18Model.Name = "lblTeam18Model"
        Me.lblTeam18Model.Size = New System.Drawing.Size(140, 32)
        Me.lblTeam18Model.TabIndex = 6
        Me.lblTeam18Model.Text = "Body Type: "
        '
        'cbxTeam18UsedNew
        '
        Me.cbxTeam18UsedNew.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTeam18UsedNew.FormattingEnabled = True
        Me.cbxTeam18UsedNew.Items.AddRange(New Object() {"Used", "New"})
        Me.cbxTeam18UsedNew.Location = New System.Drawing.Point(352, 23)
        Me.cbxTeam18UsedNew.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbxTeam18UsedNew.Name = "cbxTeam18UsedNew"
        Me.cbxTeam18UsedNew.Size = New System.Drawing.Size(238, 33)
        Me.cbxTeam18UsedNew.TabIndex = 7
        '
        'lblTeam18TitleCarInfo
        '
        Me.lblTeam18TitleCarInfo.AutoSize = True
        Me.lblTeam18TitleCarInfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam18TitleCarInfo.Location = New System.Drawing.Point(220, 40)
        Me.lblTeam18TitleCarInfo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTeam18TitleCarInfo.Name = "lblTeam18TitleCarInfo"
        Me.lblTeam18TitleCarInfo.Size = New System.Drawing.Size(550, 39)
        Me.lblTeam18TitleCarInfo.TabIndex = 11
        Me.lblTeam18TitleCarInfo.Text = "Please Enter the Following Information: "
        '
        'frmTeam18CarInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(990, 777)
        Me.Controls.Add(Me.btnTeam18ExitCarInfo)
        Me.Controls.Add(Me.btnTeam18ConfirmInfo)
        Me.Controls.Add(Me.btnTeam18GoBackCarInfo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblTeam18TitleCarInfo)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmTeam18CarInfo"
        Me.Text = "Car Information"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTeam18ExitCarInfo As Button
    Friend WithEvents btnTeam18ConfirmInfo As Button
    Friend WithEvents btnTeam18GoBackCarInfo As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtTeam18FuelEfficiency As TextBox
    Friend WithEvents cbxTeam18Model As ComboBox
    Friend WithEvents cbxTeam18Transmission As ComboBox
    Friend WithEvents cbxTeam18Engine As ComboBox
    Friend WithEvents lblTeam18UsedNew As Label
    Friend WithEvents lblTeam18Fuel As Label
    Friend WithEvents lblTeam18Engine As Label
    Friend WithEvents lblTeam18Transmission As Label
    Friend WithEvents lblTeam18Model As Label
    Friend WithEvents cbxTeam18UsedNew As ComboBox
    Friend WithEvents lblTeam18TitleCarInfo As Label
End Class
