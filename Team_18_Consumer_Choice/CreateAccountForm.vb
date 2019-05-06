Public Class frmTeam18CreateAccount
    Private Sub btnTeam18GoBackNewUser_Click(sender As Object, e As EventArgs) Handles btnTeam18GoBackNewUser.Click
        Me.Close()
        frmTeam18Login.Show()
    End Sub

    Private Sub btnTeam18CreateAccount_Click(sender As Object, e As EventArgs) Handles btnTeam18CreateAccount.Click

        'Team18 Updates the login list to accomadate the new entry
        Dim user As String
        Dim password As String
        Dim budget As Single

        If txtTeam18NewUsername.Text = "" Then
            MessageBox.Show("A username was not entered in the text box. Please try again", "Username Error")
        ElseIf txtTeam18NewPass.Text = "" Then
            MessageBox.Show("A password was not entered in the text box. Please try again", "Password Error")
        ElseIf txtTeam18Budget.Text = "" Then
            MessageBox.Show("A budget was not entered in the text box. Please try again", "Budget Error")
        End If

        user = txtTeam18NewUsername.Text
        password = txtTeam18NewPass.Text
        budget = CSng(txtTeam18Budget.Text)

        Dim l As New Login
        l.UserName = user
        l.Password = password

        Login.LoginList.Add(l)

        Me.Close()
        frmTeam18Login.Show()
    End Sub

    Private Sub btnTeam18ExitNewUser_Click(sender As Object, e As EventArgs) Handles btnTeam18ExitNewUser.Click
        Me.Close()
    End Sub

End Class