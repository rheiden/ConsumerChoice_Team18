Public Class frmTeam18CarInfo
    Private Sub btnTeam18GoBackCarInfo_Click(sender As Object, e As EventArgs) Handles btnTeam18GoBackCarInfo.Click
        Me.Hide()
        frmTeam18Login.Show()
    End Sub

    Private Sub btnTeam18ExitCarInfo_Click(sender As Object, e As EventArgs) Handles btnTeam18ExitCarInfo.Click
        Me.Close()
    End Sub

    Private Sub btnTeam18ConfirmInfo_Click(sender As Object, e As EventArgs) Handles btnTeam18ConfirmInfo.Click
        'Team18: We create variables for all user input values for the goals
        Dim condition As Integer
        If cbxTeam18Condition.SelectedItem = "Used" Then
            condition = 5
        Else
            condition = 10
        End If

        Dim engineType As Integer
        If cbxTeam18Engine.SelectedItem = "Gas" Then
            engineType = 6
        ElseIf cbxTeam18Engine.SelectedItem = "Hybrid" Then
            engineType = 8
        Else
            engineType = 10
        End If

        Dim transmission As Integer
        If cbxTeam18Transmission.SelectedItem = "5-Speed" Then
            transmission = 4
        ElseIf cbxTeam18Transmission.SelectedItem = "6-Speed" Then
            transmission = 7
        Else
            transmission = 10
        End If

        Dim bodyType As Integer
        If cbxTeam18Model.SelectedItem = "SUV" Then
            bodyType = 3
        ElseIf cbxTeam18Model.SelectedItem = "Truck" Then
            bodyType = 6
        ElseIf cbxTeam18Model.SelectedItem = "Sedan" Then
            bodyType = 8
        Else
            bodyType = 10
        End If

        'Team18: We create variables for all user input values for the positive goal weights
        Dim conditionPosWeight As Integer = CInt(cbxTeam18ConditionWeight.SelectedItem) * 10
        Dim engineTypePosWeight As Integer = CInt(cbxTeam18EngineWeight.SelectedItem) * 10
        Dim transmissionPosWeight As Integer = CInt(cbxTeam18TransmissionWeight.SelectedItem) * 10
        Dim bodyTypePosWeight As Integer = CInt(cbxTeam18ModelWeight.SelectedItem) * 10

        'Team18: We create variables for all user input values for negative goal weights by subtracting positive
        Dim conditionNegWeight As Integer = 100 - conditionPosWeight
        Dim engineTypeNegWeight As Integer = 100 - engineTypePosWeight
        Dim transmissionNegWeight As Integer = 100 - transmissionPosWeight
        Dim bodyTypeNegWeight As Integer = 100 - bodyTypePosWeight

        'Team18: We create error trapping for catching errors made by the user 
        If cbxTeam18Condition.SelectedIndex = -1 Then
            MsgBox("You must selected a Car Condition", vbCritical, "Error!")
            Exit Sub
        End If
        If cbxTeam18Engine.SelectedIndex = -1 Then
            MsgBox("You must selected an Engine Type", vbCritical, "Error!")
        End If
        If cbxTeam18Transmission.SelectedIndex = -1 Then
            MsgBox("You must selected a Transmission", vbCritical, "Error!")
            Exit Sub
        End If
        If cbxTeam18Model.SelectedIndex = -1 Then
            MsgBox("You must selected a Body Type", vbCritical, "Error!")
            Exit Sub
        End If

        If cbxTeam18ConditionWeight.SelectedIndex = -1 Then
            MsgBox("You must selected a Priority (1-10) for Condition", vbCritical, "Error!")
            Exit Sub
        End If
        If cbxTeam18EngineWeight.SelectedIndex = -1 Then
            MsgBox("You must selected a Priority (1-10) for Engine Type", vbCritical, "Error!")
            Exit Sub
        End If
        If cbxTeam18TransmissionWeight.SelectedIndex = -1 Then
            MsgBox("You must selected a Priority (1-10) for Transmission", vbCritical, "Error!")
            Exit Sub
        End If
        If cbxTeam18ModelWeight.SelectedIndex = -1 Then
            MsgBox("You must selected a Priority (1-10) for Body Type", vbCritical, "Error!")
            Exit Sub
        End If

        'Team18: We create an instance of the CreateObjects class and run the method to import data and create objects and lists of objects
        Dim Team18CreateObjects As New ObjectCreator
        Team18CreateObjects.CreateObjectsAndLists()
        '
        'Team18: Now we create an Optimization object to build an run the linear program
        Dim Team18Optimization As New Optimization
        Team18Optimization.BuildModel()
        Team18Optimization.RunModel()





    End Sub
End Class