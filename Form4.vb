Imports System
Imports System.IO
Public Class Form4

    Private Sub Btn_SelectProducts_Click(sender As Object, e As EventArgs) Handles Btn_SelectProducts.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Title = "Open File..."
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "All Files|*.txt"
        OpenFileDialog1.ShowDialog()
        Txt_Products.Text = OpenFileDialog1.FileName

    End Sub


    Private Sub Btn_SelectProds_Click(sender As Object, e As EventArgs) Handles Btn_SelectCSV.Click
        Dim OpenFileDialog2 As New OpenFileDialog
        OpenFileDialog2.Title = "Open File..."
        OpenFileDialog2.Multiselect = False
        OpenFileDialog2.Filter = "All Files|*.txt"
        OpenFileDialog2.ShowDialog()
        Txt_CSV.Text = OpenFileDialog2.FileName

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_SelectUsers.Click

        Dim OpenFileDialog3 As New OpenFileDialog
        OpenFileDialog3.Title = "Open File..."
        OpenFileDialog3.Multiselect = False
        OpenFileDialog3.Filter = "All Files|*.txt"
        OpenFileDialog3.ShowDialog()
        Txt_Users.Text = OpenFileDialog3.FileName


    End Sub

    Private Sub Btn_SelectClients_Click(sender As Object, e As EventArgs) Handles Btn_SelectClients.Click

        Dim OpenFileDialog4 As New OpenFileDialog
        OpenFileDialog4.Title = "Open File..."
        OpenFileDialog4.Multiselect = False
        OpenFileDialog4.Filter = "All Files|*.txt"
        OpenFileDialog4.ShowDialog()
        Txt_Clients.Text = OpenFileDialog4.FileName

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Close()
    End Sub

    Private Sub btnNextWizard_Click(sender As Object, e As EventArgs) Handles Btn_NextWizard.Click
        My.Settings.Product = Txt_Products.Text
        My.Settings.Salespeople = Txt_Users.Text
        My.Settings.Client = Txt_Clients.Text
        My.Settings.CSVFile = Txt_CSV.Text
        Close()
        Form5.ShowDialog()

    End Sub
End Class
