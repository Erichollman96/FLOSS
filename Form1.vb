Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form1

    Dim connection As New MySqlConnection("server=localhost; user=root; password=; database=test;")  ' Connects to MySQL Database. ! USER NOTE: YOUR DATABASE NAME MUST MATCH !

    Private Sub BtnSignIn1_Click(sender As Object, e As EventArgs) Handles Btn_SignIn.Click

        Form2.Cbox_User.Items.AddRange(File.ReadAllLines(Form4.Txt_Salespeople.Text)) ' Generates a list of users to be inserted into dropdown box on Form2 from a text file in a specified file location
        Form2.ShowDialog()

    End Sub

    Public Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click

        Dim command As New MySqlCommand("INSERT INTO `Orders`(Date, SalesPerson, Client, Product, Total) VALUES ('" & Txt_Date.Text & "','" & Form2.Cbox_User.Text & "','" & Txt_Client.Text & "','" & Cbox_Product.Text & "','" & Txt_Total.Text & "')", connection) ' SQL statement to send a sale record to database with values from textboxes
        Dim dateString As String = Txt_Date.Text
        Dim findSlash As String = "/"
        Dim FirstSlash As Integer = dateString.IndexOf(findSlash) ' Finds the first forward slash in a string, used to cofirm date formatting

        connection.Open() ' Opens connection to MySQL database

        If String.IsNullOrEmpty(Txt_Client.Text) Or String.IsNullOrEmpty(Txt_Total.Text) Or String.IsNullOrEmpty(Txt_Date.Text) Or String.IsNullOrEmpty(Cbox_Product.Text) Then ' Checks to make sure each field has data in it

            MessageBox.Show("No data has been submitted. Please fill all fields before submitting.") ' This message is shown if any field is missing data values

        ElseIf IsDate(Txt_Date.Text) = 0 Or FirstSlash <= 3 Then ' Checks if the "Date" field is a valid date with true/false logic and also in year/month/day format. Prompts user if data is not a date or in incorrect format.

            MessageBox.Show("Incorrect date formatting. Please use YYYY/MM/DD formatting.")

        Else

            MessageBox.Show("Data Inserted into database. CSV file updated.") ' Confirms that the command has been executed and sends data to MySQL database, creates or updates a text file of a specified location 
            My.Computer.FileSystem.WriteAllText("C:\Users\erich\Desktop\DataDump\test.txt", Environment.NewLine + Txt_Date.Text & "," & Form2.Cbox_User.Text & "," & Txt_Client.Text & "," & Cbox_Product.Text & "," & Txt_Total.Text, True) '! USER NOTE: MUST SPECIFY FILE LOCATION MANUALLY !
            command.ExecuteNonQuery()

        End If

        connection.Close()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
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

    Private Sub Btn_ViewSales_Click(sender As Object, e As EventArgs) Handles Btn_ViewSales.Click

        Form3.Cbox_SalesPerson2.Items.AddRange(File.ReadAllLines(Form4.Txt_Salespeople.Text)) ' Generates a list of users from a specified file location 
        Form3.Cbox_Product2.Items.AddRange(File.ReadAllLines(Form4.Txt_Products.Text)) ' Generates a list of products from a specified file location 
        Dim clientData As New MySqlDataAdapter("select distinct client from test.orders order by client asc", connection)  ' Generates a list of clients using a SQL statement
        Dim clientSelect As New DataTable
        clientData.Fill(clientSelect)
        Form3.Cbox_Client2.DisplayMember = "client"
        Form3.Cbox_Client2.DataSource = clientSelect 'Inserts data from statement finding clients into dropdown box in Form3
        Form3.Cbox_Client2.SelectedIndex = -1 ' Changes Index of the specified field to -1; a null value
        Form3.ShowDialog()
    End Sub

    Private Sub Menu_SetupWizard_Click(sender As Object, e As EventArgs) Handles Menu_SetupWizard.Click
        Form4.ShowDialog()

    End Sub

    Private Sub Btn1_Click_1(sender As Object, e As EventArgs) Handles Btn_Today.Click
        Txt_Date.Text = DateTime.Now.Date.ToString("yyyy/MM/dd") ' Inserts today's  date into the "Date" field
    End Sub

    Private Sub Menu_About_Click(sender As Object, e As EventArgs) Handles Menu_About.Click

        Process.Start("https://github.com/Erichollman96/FOSS-sales/blob/master/README.md")

    End Sub
End Class
