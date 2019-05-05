Public Class frmTeam18Login
    '**************************************************************************************************************************
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Team18: Creating a new ObjectCreator and running the method that creates all objects and lists
        Dim myObjectCreator As New ObjectCreator
        myObjectCreator.CreateObjectsAndLists()
    End Sub

    Private Sub btnTeam18Login_Click(sender As Object, e As EventArgs) Handles btnTeam18Login.Click
        Me.Close()
        frmTeam18CarInfo.Show()

    End Sub

    Private Sub btnTeam18ExitWelcome_Click(sender As Object, e As EventArgs) Handles btnTeam18ExitWelcome.Click
        Me.Close()
    End Sub

    Private Sub btnTeam18CreateAccountWelcome_Click(sender As Object, e As EventArgs) Handles btnTeam18CreateAccountWelcome.Click
        Me.Close()
        frmTeam18CreateAccount.Show()
    End Sub
    '**************************************************************************************************************************
End Class

