Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form1

    Dim connection As New MySqlConnection("server=localhost; user=root; password=; database=test;")  ' Connects to MySQL Database. Note the name of your database must match

    Private Sub btnSignIn1_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        Form2.cboxUser.Items.AddRange(File.ReadAllLines("C:\Users\erich\Desktop\Misc Data\Users.txt")) ' Generates a list of users to be inserted into dropdown box on Form2 from a text file in a specified file location
        Form2.ShowDialog()

    End Sub

    Public Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim command As New MySqlCommand("INSERT INTO `Orders`(Date, SalesPerson, Client, Product, Total) VALUES ('" & txtDate.Text & "','" & Form2.cboxUser.Text & "','" & txtClient.Text & "','" & cboxProduct.Text & "','" & txtTotal.Text & "')", connection) ' SQL statement to send a sale record to database with values from textboxes
        Dim dateString As String = txtDate.Text
        Dim findSlash As String = "/"
        Dim FirstSlash As Integer = dateString.IndexOf(findSlash) ' Finds the first forward slash in a string, used to cofirm date formatting

        connection.Open() ' Opens connection to MySQL database

        If String.IsNullOrEmpty(txtClient.Text) Or String.IsNullOrEmpty(txtTotal.Text) Or String.IsNullOrEmpty(txtDate.Text) Or String.IsNullOrEmpty(cboxProduct.Text) Then ' Checks to make sure each field has data in it

            MessageBox.Show("No data has been submitted. Please fill all fields before submitting.") ' This message is shown if any field is missing data values

        ElseIf IsDate(txtDate.Text) = 0 Or FirstSlash <= 3 Then ' Checks if the "Date" field is a valid date with true/false logic and also in year/month/day format. Prompts user if data is not a date or in incorrect format.

            MessageBox.Show("Incorrect date formatting. Please use YYYY/MM/DD formatting.")

        Else

            MessageBox.Show("Data Inserted into database. CSV file updated.") ' Confirms that the command has been executed and sends data to MySQL database, creates or updates a text file of a specified location
            My.Computer.FileSystem.WriteAllText("C:\Users\erich\Desktop\DataDump\test.txt", Environment.NewLine + txtDate.Text & "," & Form2.cboxUser.Text & "," & txtClient.Text & "," & cboxProduct.Text & "," & txtTotal.Text, True)
            command.ExecuteNonQuery()

        End If

        connection.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close() ' Closes the entire application
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Form2.Visible = False Then ' Checks the connection to MySQL database when Form2 is not visible (Form2 checks for connection upon attempting to sign in)

            Try

                connection.Open()

            Catch ex As Exception

                MessageBox.Show("Connection to Database has failed. Please resolve the issue.")

            End Try
            connection.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewSales.Click

        Form3.cboxSalesPerson2.Items.AddRange(File.ReadAllLines("C:\Users\erich\Desktop\Misc Data\Users.txt")) ' Generates a list of users from a specified file location
        Form3.cboxProduct2.Items.AddRange(File.ReadAllLines("C:\Users\erich\Desktop\Misc Data\Products.txt")) ' Generates a list of products from a specified file location
        Dim clientData As New MySqlDataAdapter("select distinct client from test.orders order by client asc", connection)  ' Generates a list of clients from using a SQL statement
        Dim clientSelect As New DataTable
        clientData.Fill(clientSelect)
        Form3.cboxClient2.DisplayMember = "client"
        Form3.cboxClient2.DataSource = clientSelect 'Inserts data from statement finding clients into dropdown box in Form3
        Form3.cboxClient2.SelectedIndex = -1 ' Changes Index of the specified field to -1; a null value
        Form3.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnToday.Click
        txtDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd") ' Inserts today's  date into the "Date" field
    End Sub

End Class
