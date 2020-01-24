<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Txt_Products = New System.Windows.Forms.TextBox()
        Me.Btn_SelectProducts = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Btn_SelectProds = New System.Windows.Forms.Button()
        Me.Txt_Salespeople = New System.Windows.Forms.TextBox()
        Me.Btn_SelectSalespeople = New System.Windows.Forms.Button()
        Me.Btn_SaveAndClose = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_Products
        '
        Me.Txt_Products.Location = New System.Drawing.Point(32, 28)
        Me.Txt_Products.Name = "Txt_Products"
        Me.Txt_Products.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Products.TabIndex = 20
        '
        'Btn_SelectProducts
        '
        Me.Btn_SelectProducts.Location = New System.Drawing.Point(151, 26)
        Me.Btn_SelectProducts.Name = "Btn_SelectProducts"
        Me.Btn_SelectProducts.Size = New System.Drawing.Size(98, 23)
        Me.Btn_SelectProducts.TabIndex = 19
        Me.Btn_SelectProducts.Text = "Select Products"
        Me.Btn_SelectProducts.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(31, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 23
        '
        'Btn_SelectProds
        '
        Me.Btn_SelectProds.Location = New System.Drawing.Point(150, 106)
        Me.Btn_SelectProds.Name = "Btn_SelectProds"
        Me.Btn_SelectProds.Size = New System.Drawing.Size(120, 23)
        Me.Btn_SelectProds.TabIndex = 22
        Me.Btn_SelectProds.Text = "Select CSV Location"
        Me.Btn_SelectProds.UseVisualStyleBackColor = True
        '
        'Txt_Salespeople
        '
        Me.Txt_Salespeople.Location = New System.Drawing.Point(31, 68)
        Me.Txt_Salespeople.Name = "Txt_Salespeople"
        Me.Txt_Salespeople.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Salespeople.TabIndex = 26
        '
        'Btn_SelectSalespeople
        '
        Me.Btn_SelectSalespeople.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SelectSalespeople.Location = New System.Drawing.Point(144, 68)
        Me.Btn_SelectSalespeople.Name = "Btn_SelectSalespeople"
        Me.Btn_SelectSalespeople.Size = New System.Drawing.Size(112, 23)
        Me.Btn_SelectSalespeople.TabIndex = 25
        Me.Btn_SelectSalespeople.Text = "Select Salespeople"
        Me.Btn_SelectSalespeople.UseVisualStyleBackColor = True
        '
        'Btn_SaveAndClose
        '
        Me.Btn_SaveAndClose.Location = New System.Drawing.Point(39, 166)
        Me.Btn_SaveAndClose.Name = "Btn_SaveAndClose"
        Me.Btn_SaveAndClose.Size = New System.Drawing.Size(93, 23)
        Me.Btn_SaveAndClose.TabIndex = 27
        Me.Btn_SaveAndClose.Text = "Save and Close"
        Me.Btn_SaveAndClose.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.Location = New System.Drawing.Point(175, 166)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(81, 23)
        Me.Btn_Close.TabIndex = 28
        Me.Btn_Close.Text = "Close"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 219)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Btn_SaveAndClose)
        Me.Controls.Add(Me.Txt_Salespeople)
        Me.Controls.Add(Me.Btn_SelectSalespeople)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Btn_SelectProds)
        Me.Controls.Add(Me.Txt_Products)
        Me.Controls.Add(Me.Btn_SelectProducts)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Products As TextBox
    Friend WithEvents Btn_SelectProducts As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Btn_SelectProds As Button
    Friend WithEvents Txt_Salespeople As TextBox
    Friend WithEvents Btn_SelectSalespeople As Button
    Friend WithEvents Btn_SaveAndClose As Button
    Friend WithEvents Btn_Close As Button
End Class
