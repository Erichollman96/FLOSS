<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Datagrid_SQL = New System.Windows.Forms.DataGridView()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Cbox_SalesPerson2 = New System.Windows.Forms.ComboBox()
        Me.Cbox_Product2 = New System.Windows.Forms.ComboBox()
        Me.Cbox_Client2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_FormInstructions = New System.Windows.Forms.Label()
        CType(Me.Datagrid_SQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Datagrid_SQL
        '
        Me.Datagrid_SQL.AllowUserToOrderColumns = True
        Me.Datagrid_SQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagrid_SQL.Location = New System.Drawing.Point(12, 187)
        Me.Datagrid_SQL.Name = "Datagrid_SQL"
        Me.Datagrid_SQL.Size = New System.Drawing.Size(492, 161)
        Me.Datagrid_SQL.TabIndex = 0
        '
        'Btn_Search
        '
        Me.Btn_Search.Location = New System.Drawing.Point(176, 144)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Search.TabIndex = 1
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Cbox_SalesPerson2
        '
        Me.Cbox_SalesPerson2.FormattingEnabled = True
        Me.Cbox_SalesPerson2.Location = New System.Drawing.Point(155, 22)
        Me.Cbox_SalesPerson2.Name = "Cbox_SalesPerson2"
        Me.Cbox_SalesPerson2.Size = New System.Drawing.Size(121, 21)
        Me.Cbox_SalesPerson2.Sorted = True
        Me.Cbox_SalesPerson2.TabIndex = 4
        '
        'Cbox_Product2
        '
        Me.Cbox_Product2.FormattingEnabled = True
        Me.Cbox_Product2.Location = New System.Drawing.Point(155, 96)
        Me.Cbox_Product2.Name = "Cbox_Product2"
        Me.Cbox_Product2.Size = New System.Drawing.Size(121, 21)
        Me.Cbox_Product2.Sorted = True
        Me.Cbox_Product2.TabIndex = 5
        '
        'Cbox_Client2
        '
        Me.Cbox_Client2.FormattingEnabled = True
        Me.Cbox_Client2.Location = New System.Drawing.Point(155, 59)
        Me.Cbox_Client2.Name = "Cbox_Client2"
        Me.Cbox_Client2.Size = New System.Drawing.Size(121, 21)
        Me.Cbox_Client2.Sorted = True
        Me.Cbox_Client2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sales Person"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Client"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product"
        '
        'Lbl_FormInstructions
        '
        Me.Lbl_FormInstructions.AutoSize = True
        Me.Lbl_FormInstructions.Location = New System.Drawing.Point(134, 128)
        Me.Lbl_FormInstructions.Name = "Lbl_FormInstructions"
        Me.Lbl_FormInstructions.Size = New System.Drawing.Size(176, 13)
        Me.Lbl_FormInstructions.TabIndex = 8
        Me.Lbl_FormInstructions.Text = "Leave field empty to search for ""All"""
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 381)
        Me.Controls.Add(Me.Lbl_FormInstructions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbox_Client2)
        Me.Controls.Add(Me.Cbox_Product2)
        Me.Controls.Add(Me.Cbox_SalesPerson2)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Datagrid_SQL)
        Me.Name = "Form3"
        Me.Text = "Search For Records"
        CType(Me.Datagrid_SQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Datagrid_SQL As DataGridView
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Cbox_SalesPerson2 As ComboBox
    Friend WithEvents Cbox_Product2 As ComboBox
    Friend WithEvents Cbox_Client2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_FormInstructions As Label
End Class
