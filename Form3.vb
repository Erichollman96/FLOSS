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
        myCmd.Connection = connection
        If String.IsNullOrEmpty(Cbox_Client2.Text) And String.IsNullOrEmpty(Cbox_SalesPerson2.Text) And String.IsNullOrEmpty(Cbox_Product2.Text) Then ' Checks if specified fields have values inserted into them. If no values are present, the fields are not used as conditions in the SQL statement
            myCmd.CommandText = " SELECT * FROM test.orders"
        ElseIf String.IsNullOrEmpty(Cbox_Client2.Text) And String.IsNullOrEmpty(Cbox_SalesPerson2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE Product= '" & Cbox_Product2.Text & "' "
        ElseIf String.IsNullOrEmpty(Cbox_Product2.Text) And String.IsNullOrEmpty(Cbox_SalesPerson2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE Client= '" & Cbox_Client2.Text & "' "
        ElseIf String.IsNullOrEmpty(Cbox_Product2.Text) And String.IsNullOrEmpty(Cbox_Client2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE SalesPerson= '" & Cbox_SalesPerson2.Text & "' "
        ElseIf String.IsNullOrEmpty(Cbox_Product2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE SalesPerson= '" & Cbox_SalesPerson2.Text & "' AND Client= '" & Cbox_Client2.Text & "' "
        ElseIf String.IsNullOrEmpty(Cbox_Client2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE SalesPerson= '" & Cbox_SalesPerson2.Text & "' AND Product= '" & Cbox_Product2.Text & "' "
        ElseIf String.IsNullOrEmpty(Cbox_SalesPerson2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE Product= '" & Cbox_Product2.Text & "' AND Client= '" & Cbox_Client2.Text & "' "
        Else
            myCmd.CommandText = " SELECT * FROM test.orders WHERE SalesPerson= '" & Cbox_SalesPerson2.Text & "' AND Product= '" & Cbox_Product2.Text & "' AND Client= '" & Cbox_Client2.Text & "' "
        End If

        Dim myAdapater1 As New MySqlDataAdapter(myCmd) 'Fills the data grid with the results of one of the above SQL commands
        myAdapater1.Fill(queryTable)
        Datagrid_SQL.DataSource = queryTable
        connection.Close()
    End Sub

End Class

