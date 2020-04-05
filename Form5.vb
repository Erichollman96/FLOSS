Public Class Form5
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Txt_DBPassword.TextChanged

    End Sub

    Private Sub BtnSaveAndExit_Click(sender As Object, e As EventArgs) Handles BtnSaveAndExit.Click
        My.Settings.ServerName = Txt_ServerName.Text
        My.Settings.DBName = Txt_DBName.Text
        My.Settings.DBPassword = Txt_DBPassword.Text
        My.Settings.DBUsername = Txt_DBUsername.Text
        Me.Refresh()
        Dim result As DialogResult = MessageBox.Show("Settings hve been changed. You must close the application to apply settings. " & vbCrLf & vbCrLf & "Close now?", "Settings Changed", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Close()
        ElseIf result = DialogResult.Yes Then
            Form1.Close()
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class
