Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form2

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Close() ' Closes the window
    End Sub

    Public Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles Btn_Confirm.Click
        Dim connection As New MySqlConnection("server=localhost; user=root; password=; database=test;")

        Try ' Checks the conenction to the database upon user attempting to sign in

            connection.Open()

        Catch ex As Exception

            MessageBox.Show("Connection to Database has failed. Please resolve the issue then restart the application.")

        End Try

        If Cbox_User.Text = "" Then ' Confirms that the user has selected a user from the dropdown menu

            MessageBox.Show("Please select a user from the dropdown list")

        ElseIf (connection.State <> ConnectionState.Closed) And Cbox_User.Text <> "" Then ' Checks if the user has a valid connection to the database and has selected a user from the dropdown lost

            Form1.Cbox_Product.Items.AddRange(File.ReadAllLines(Form4.Txt_Products.Text)) ' Adds Products to "Product" dropdown on Form1 
            MessageBox.Show("User signed in as " + Cbox_User.Text) ' Prompts user that the user has signed in as the user they selected 
            Form1.Lbl_ActiveUser.Text = Cbox_User.Text '  Enables controls on Form1
            Form1.Btn_SignIn.Hide()
            Form1.Lbl_Client.Enabled = True
            Form1.Lbl_Product.Enabled = True
            Form1.Lbl_Total.Enabled = True
            Form1.Lbl_Date.Enabled = True
            Form1.Txt_Client.Enabled = True
            Form1.Cbox_Product.Enabled = True
            Form1.Txt_Total.Enabled = True
            Form1.Txt_Date.Enabled = True
            Form1.Btn_Submit.Enabled = True
            Form1.Btn_ViewSales.Enabled = True
            Form1.Btn_Today.Enabled = True
            Close()
            connection.Close()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
