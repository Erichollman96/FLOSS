<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgridSQL = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboxSalesPerson2 = New System.Windows.Forms.ComboBox()
        Me.cboxProduct2 = New System.Windows.Forms.ComboBox()
        Me.cboxClient2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgridSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgridSQL
        '
        Me.dgridSQL.AllowUserToOrderColumns = True
        Me.dgridSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridSQL.Location = New System.Drawing.Point(12, 187)
        Me.dgridSQL.Name = "dgridSQL"
        Me.dgridSQL.Size = New System.Drawing.Size(492, 161)
        Me.dgridSQL.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(176, 144)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboxSalesPerson2
        '
        Me.cboxSalesPerson2.FormattingEnabled = True
        Me.cboxSalesPerson2.Location = New System.Drawing.Point(155, 22)
        Me.cboxSalesPerson2.Name = "cboxSalesPerson2"
        Me.cboxSalesPerson2.Size = New System.Drawing.Size(121, 21)
        Me.cboxSalesPerson2.Sorted = True
        Me.cboxSalesPerson2.TabIndex = 4
        '
        'cboxProduct2
        '
        Me.cboxProduct2.FormattingEnabled = True
        Me.cboxProduct2.Location = New System.Drawing.Point(155, 96)
        Me.cboxProduct2.Name = "cboxProduct2"
        Me.cboxProduct2.Size = New System.Drawing.Size(121, 21)
        Me.cboxProduct2.Sorted = True
        Me.cboxProduct2.TabIndex = 5
        '
        'cboxClient2
        '
        Me.cboxClient2.FormattingEnabled = True
        Me.cboxClient2.Location = New System.Drawing.Point(155, 59)
        Me.cboxClient2.Name = "cboxClient2"
        Me.cboxClient2.Size = New System.Drawing.Size(121, 21)
        Me.cboxClient2.Sorted = True
        Me.cboxClient2.TabIndex = 6
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Leave field empty to search for ""All"""
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 381)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxClient2)
        Me.Controls.Add(Me.cboxProduct2)
        Me.Controls.Add(Me.cboxSalesPerson2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgridSQL)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgridSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgridSQL As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents cboxSalesPerson2 As ComboBox
    Friend WithEvents cboxProduct2 As ComboBox
    Friend WithEvents cboxClient2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
