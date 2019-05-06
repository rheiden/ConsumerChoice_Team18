Public Class frmTeam18Login
    '**************************************************************************************************************************
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Team18: Creating a new ObjectCreator and running the method that creates all objects and lists
        Dim myObjectCreator As New ObjectCreator
        myObjectCreator.CreateObjectsAndLists()
    End Sub

    Private Sub btnTeam18Login_Click(sender As Object, e As EventArgs) Handles btnTeam18Login.Click

        Dim user As String
        Dim password As String
        Dim i As Integer = 0

        If txtTeam18Username.Text = "" Then     'Team 18: Checks if the username box is empty
            MessageBox.Show("A username was not entered in the text box. Please try again", "Username Error")
        ElseIf txtTeam18Password.Text = "" Then 'Team 18: Checks if the password box is empty
            MessageBox.Show("A password was not entered in the text box. Please try again", "Password Error")
        Else
            user = txtTeam18Username.Text       'Team 18: Gets the username that was entered
            password = txtTeam18Password.Text   'Team 18: Gets the password that was entered
            'Team 18 checks if the login info added matches with one in the database
            For Each log As Login In Login.LoginList
                If log.UserName = user And log.Password = password Then
                    Me.Hide()                   'Team 18: If login was successful close the form and move on to next one
                    frmTeam18CarInfo.Show()
                    Exit For
                End If
                i = i + 1
            Next
        End If

        'Team 18: ran if the passwored and usernmane does not match with a pre-existing login
        If i = Login.LoginList.Count Then
            MessageBox.Show("The password or the username was incorrect, please try again", "Entry error")
        End If



    End Sub

    Private Sub btnTeam18ExitWelcome_Click(sender As Object, e As EventArgs) Handles btnTeam18ExitWelcome.Click
        Me.Close()
    End Sub

    Private Sub btnTeam18CreateAccountWelcome_Click(sender As Object, e As EventArgs) Handles btnTeam18CreateAccountWelcome.Click
        Me.Hide()
        frmTeam18CreateAccount.Show()
    End Sub
    '**************************************************************************************************************************
End Class

