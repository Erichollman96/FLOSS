Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form3
    Dim connection As New MySqlConnection("server=localhost; user=root; password=; database=test;")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        connection.Open()
        Dim queryTable As New DataTable() ' Declares a data table and SQL command
        Dim myCmd As New MySqlCommand()
        Dim Command As String
        myCmd.Connection = connection
        If String.IsNullOrEmpty(Cbox_Client2.Text) And String.IsNullOrEmpty(Cbox_SalesPerson2.Text) And String.IsNullOrEmpty(Cbox_Product2.Text) Then ' Checks if specified fields have values inserted into them. If no values are present, the fields are not used as conditions in the SQL statement
            Command = " SELECT * FROM test.orders"
        ElseIf String.IsNullOrEmpty(Cbox_Client2.Text) And String.IsNullOrEmpty(Cbox_SalesPerson2.Text) Then
            Command = " SELECT * FROM test.orders WHERE Product= '" & Cbox_Product2.Text & "' "
        ElseIf String.IsNullOrEmpty(Cbox_Product2.Text) And String.IsNullOrEmpty(Cbox_SalesPerson2.Text) Then
            Command = " SELECT * FROM test.orders WHERE Client= '" & Cbox_Client2.Text & "' "
        ElseIf String.IsNullOrEmpty(Cbox_Product2.Text) And String.IsNullOrEmpty(Cbox_Client2.Text) Then
            Command = " SELECT * FROM test.orders WHERE SalesPerson= '" & Cbox_SalesPerson2.Text & "' "
        ElseIf String.IsNullOrEmpty(Cbox_Product2.Text) Then
            Command = " SELECT * FROM test.orders WHERE SalesPerson= '" & Cbox_SalesPerson2.Text & "' AND Client= '" & Cbox_Client2.Text & "' "
        ElseIf String.IsNullOrEmpty(Cbox_Client2.Text) Then
            Command = " SELECT * FROM test.orders WHERE SalesPerson= '" & Cbox_SalesPerson2.Text & "' AND Product= '" & Cbox_Product2.Text & "' "
        ElseIf String.IsNullOrEmpty(Cbox_SalesPerson2.Text) Then
            Command = " SELECT * FROM test.orders WHERE Product= '" & Cbox_Product2.Text & "' AND Client= '" & Cbox_Client2.Text & "' "
        Else
            Command = " SELECT * FROM test.orders WHERE SalesPerson= '" & Cbox_SalesPerson2.Text & "' AND Product= '" & Cbox_Product2.Text & "' AND Client= '" & Cbox_Client2.Text & "' "
        End If

        myCmd.CommandText = Command
        Dim myAdapater1 As New MySqlDataAdapter(myCmd) 'Fills the data grid with the results of one of the above SQL commands
        myAdapater1.Fill(queryTable)
        Datagrid_SQL.DataSource = queryTable
        connection.Close()



        connection.Open()
        Dim command2 As String = Command.Replace("*", "COUNT(ID)")
        Dim cmd3 = New MySqlCommand(command2, connection)
        Dim totalcount As Int16 = cmd3.ExecuteScalar
        Dim command3 As String = "select count(ID) from test.orders"
        Dim cmd4 = New MySqlCommand(command3, connection)
        Dim matchingrecords As Int16 = cmd4.ExecuteScalar
        LblSqlResults.Text = totalcount & " out of " & matchingrecords & " records showing"
        connection.Close()


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

