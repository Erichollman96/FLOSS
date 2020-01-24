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


    Private Sub Btn_SelectProds_Click(sender As Object, e As EventArgs) Handles Btn_SelectProds.Click
        Dim OpenFileDialog2 As New OpenFileDialog
        OpenFileDialog2.Title = "Open File..."
        OpenFileDialog2.Multiselect = False
        OpenFileDialog2.Filter = "All Files|*.txt"
        OpenFileDialog2.ShowDialog()
        TextBox2.Text = OpenFileDialog2.FileName

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_SelectSalespeople.Click

        Dim OpenFileDialog3 As New OpenFileDialog
        OpenFileDialog3.Title = "Open File..."
        OpenFileDialog3.Multiselect = False
        OpenFileDialog3.Filter = "All Files|*.txt"
        OpenFileDialog3.ShowDialog()
        Txt_Salespeople.Text = OpenFileDialog3.FileName

    End Sub


End Class
