Public Class Form5
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Txt_DBPassword.TextChanged

    End Sub

    Private Sub BtnSaveAndExit_Click(sender As Object, e As EventArgs) Handles BtnSaveAndExit.Click
        My.Settings.ServerName = Txt_ServerName.Text
        My.Settings.DBName = Txt_DBName.Text
        My.Settings.DBPassword = Txt_DBPassword.Text
        My.Settings.DBUsername = Txt_DBUsername.Text
        Close()
    End Sub
End Class
