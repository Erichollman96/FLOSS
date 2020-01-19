Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form3
    Dim connection As New MySqlConnection("server=localhost; user=root; password=; database=test;")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        connection.Open()
        Dim queryTable As New DataTable() ' Declares a data table and SQL command
        Dim myCmd As New MySqlCommand()
        myCmd.Connection = connection
        If String.IsNullOrEmpty(cboxClient2.Text) And String.IsNullOrEmpty(cboxSalesPerson2.Text) And String.IsNullOrEmpty(cboxProduct2.Text) Then ' Checks if specified fields have values inserted into them. If no values are present, the fields are not used as conditions in the SQL statement
            myCmd.CommandText = " SELECT * FROM test.orders"
        ElseIf String.IsNullOrEmpty(cboxClient2.Text) And String.IsNullOrEmpty(cboxSalesPerson2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE Product= '" & cboxProduct2.Text & "' "
        ElseIf String.IsNullOrEmpty(cboxProduct2.Text) And String.IsNullOrEmpty(cboxSalesPerson2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE Client= '" & cboxClient2.Text & "' "
        ElseIf String.IsNullOrEmpty(cboxProduct2.Text) And String.IsNullOrEmpty(cboxClient2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE SalesPerson= '" & cboxSalesPerson2.Text & "' "
        ElseIf String.IsNullOrEmpty(cboxProduct2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE SalesPerson= '" & cboxSalesPerson2.Text & "' AND Client= '" & cboxClient2.Text & "' "
        ElseIf String.IsNullOrEmpty(cboxClient2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE SalesPerson= '" & cboxSalesPerson2.Text & "' AND Product= '" & cboxProduct2.Text & "' "
        ElseIf String.IsNullOrEmpty(cboxSalesPerson2.Text) Then
            myCmd.CommandText = " SELECT * FROM test.orders WHERE Product= '" & cboxProduct2.Text & "' AND Client= '" & cboxClient2.Text & "' "
        Else
            myCmd.CommandText = " SELECT * FROM test.orders WHERE SalesPerson= '" & cboxSalesPerson2.Text & "' AND Product= '" & cboxProduct2.Text & "' AND Client= '" & cboxClient2.Text & "' "
        End If

        Dim myAdapater1 As New MySqlDataAdapter(myCmd) 'Fills the data grid with the results of one of the above SQL commands
        myAdapater1.Fill(queryTable)
        dgridSQL.DataSource = queryTable
        connection.Close()
    End Sub

End Class

