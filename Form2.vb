Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form2

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close() ' Closes the window
    End Sub

    Public Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim connection As New MySqlConnection("server=localhost; user=root; password=; database=test;")

        Try ' Checks the conenction to the database upon user attempting to sign in

            connection.Open()

        Catch ex As Exception

            MessageBox.Show("Connection to Database has failed. Please resolve the issue then restart the application.")

        End Try

        If cboxUser.Text = "" Then ' Confirms that the user has selected a user from the dropdown menu

            MessageBox.Show("Please select a user from the dropdown list")

        ElseIf (connection.State <> ConnectionState.Closed) And cboxUser.Text <> "" Then ' Checks if the user has a valid connection to the database and has selected a user from the dropdown lost

            Form1.cboxProduct.Items.AddRange(File.ReadAllLines("C:\Users\erich\Desktop\Misc Data\Products.txt")) ' Adds Products to "Product" dropdown on Form1
            MessageBox.Show("User signed in as " + cboxUser.Text) ' Confirms that the user has signed in as the user they selected
            Form1.lblActiveUser.Text = cboxUser.Text '  Enables controls on Form1
            Form1.btnSignIn.Hide()
            Form1.lblClient.Enabled = True
            Form1.lblProduct.Enabled = True
            Form1.lblTotal.Enabled = True
            Form1.lblDate.Enabled = True
            Form1.txtClient.Enabled = True
            Form1.cboxProduct.Enabled = True
            Form1.txtTotal.Enabled = True
            Form1.txtDate.Enabled = True
            Form1.btnSubmit.Enabled = True
            Form1.btnViewSales.Enabled = True
            Form1.btnToday.Enabled = True
            Close()
            connection.Close()
        End If
    End Sub
End Class
