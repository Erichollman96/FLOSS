<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblActiveUser = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnViewSales = New System.Windows.Forms.Button()
        Me.cboxProduct = New System.Windows.Forms.ComboBox()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtClient
        '
        Me.txtClient.Enabled = False
        Me.txtClient.Location = New System.Drawing.Point(87, 38)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(121, 20)
        Me.txtClient.TabIndex = 0
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(87, 90)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtTotal.TabIndex = 2
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDate.Location = New System.Drawing.Point(87, 116)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(121, 20)
        Me.txtDate.TabIndex = 3
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Enabled = False
        Me.lblClient.Location = New System.Drawing.Point(43, 41)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(33, 13)
        Me.lblClient.TabIndex = 4
        Me.lblClient.Text = "Client"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Enabled = False
        Me.lblProduct.Location = New System.Drawing.Point(43, 64)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(44, 13)
        Me.lblProduct.TabIndex = 5
        Me.lblProduct.Text = "Product"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Enabled = False
        Me.lblTotal.Location = New System.Drawing.Point(43, 90)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Enabled = False
        Me.lblDate.Location = New System.Drawing.Point(43, 116)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date"
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Location = New System.Drawing.Point(105, 142)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(287, 262)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSignIn
        '
        Me.btnSignIn.Location = New System.Drawing.Point(214, 9)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(80, 25)
        Me.btnSignIn.TabIndex = 10
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(12, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(65, 13)
        Me.lblUser.TabIndex = 11
        Me.lblUser.Text = "Active User:"
        '
        'lblActiveUser
        '
        Me.lblActiveUser.AutoSize = True
        Me.lblActiveUser.Location = New System.Drawing.Point(83, 9)
        Me.lblActiveUser.Name = "lblActiveUser"
        Me.lblActiveUser.Size = New System.Drawing.Size(115, 13)
        Me.lblActiveUser.TabIndex = 12
        Me.lblActiveUser.Text = "NO USER SELECTED"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'btnViewSales
        '
        Me.btnViewSales.Enabled = False
        Me.btnViewSales.Location = New System.Drawing.Point(160, 263)
        Me.btnViewSales.Name = "btnViewSales"
        Me.btnViewSales.Size = New System.Drawing.Size(106, 23)
        Me.btnViewSales.TabIndex = 13
        Me.btnViewSales.Text = "View Sales"
        Me.btnViewSales.UseVisualStyleBackColor = True
        '
        'cboxProduct
        '
        Me.cboxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxProduct.Enabled = False
        Me.cboxProduct.FormattingEnabled = True
        Me.cboxProduct.Location = New System.Drawing.Point(87, 63)
        Me.cboxProduct.Name = "cboxProduct"
        Me.cboxProduct.Size = New System.Drawing.Size(121, 21)
        Me.cboxProduct.Sorted = True
        Me.cboxProduct.TabIndex = 14
        '
        'btnToday
        '
        Me.btnToday.Enabled = False
        Me.btnToday.Location = New System.Drawing.Point(214, 116)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(80, 23)
        Me.btnToday.TabIndex = 15
        Me.btnToday.Text = "Today's Date"
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 317)
        Me.Controls.Add(Me.btnToday)
        Me.Controls.Add(Me.cboxProduct)
        Me.Controls.Add(Me.btnViewSales)
        Me.Controls.Add(Me.lblActiveUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtClient)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtClient As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblClient As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSignIn As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lblActiveUser As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnViewSales As Button
    Friend WithEvents cboxProduct As ComboBox
    Friend WithEvents btnToday As Button
End Class
