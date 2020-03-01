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
        Me.Btn_SelectProducts = New System.Windows.Forms.Button()
        Me.Btn_SelectCSV = New System.Windows.Forms.Button()
        Me.Btn_SelectUsers = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Btn_SelectClients = New System.Windows.Forms.Button()
        Me.Lbl_ProductFile = New System.Windows.Forms.Label()
        Me.Lbl_UserFile = New System.Windows.Forms.Label()
        Me.Lbl_CSVFile = New System.Windows.Forms.Label()
        Me.Lbl_ClientFile = New System.Windows.Forms.Label()
        Me.Btn_NextWizard = New System.Windows.Forms.Button()
        Me.Txt_Clients = New System.Windows.Forms.TextBox()
        Me.Txt_Users = New System.Windows.Forms.TextBox()
        Me.Txt_CSV = New System.Windows.Forms.TextBox()
        Me.Txt_Products = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_SelectProducts
        '
        Me.Btn_SelectProducts.Location = New System.Drawing.Point(191, 51)
        Me.Btn_SelectProducts.Name = "Btn_SelectProducts"
        Me.Btn_SelectProducts.Size = New System.Drawing.Size(26, 23)
        Me.Btn_SelectProducts.TabIndex = 19
        Me.Btn_SelectProducts.Text = "..."
        Me.Btn_SelectProducts.UseVisualStyleBackColor = True
        '
        'Btn_SelectCSV
        '
        Me.Btn_SelectCSV.Location = New System.Drawing.Point(191, 191)
        Me.Btn_SelectCSV.Name = "Btn_SelectCSV"
        Me.Btn_SelectCSV.Size = New System.Drawing.Size(26, 23)
        Me.Btn_SelectCSV.TabIndex = 22
        Me.Btn_SelectCSV.Text = "..."
        Me.Btn_SelectCSV.UseVisualStyleBackColor = True
        '
        'Btn_SelectUsers
        '
        Me.Btn_SelectUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SelectUsers.Location = New System.Drawing.Point(191, 94)
        Me.Btn_SelectUsers.Name = "Btn_SelectUsers"
        Me.Btn_SelectUsers.Size = New System.Drawing.Size(26, 23)
        Me.Btn_SelectUsers.TabIndex = 25
        Me.Btn_SelectUsers.Text = "..."
        Me.Btn_SelectUsers.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.Location = New System.Drawing.Point(62, 261)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(81, 23)
        Me.Btn_Close.TabIndex = 28
        Me.Btn_Close.Text = "Close"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Btn_SelectClients
        '
        Me.Btn_SelectClients.Location = New System.Drawing.Point(191, 142)
        Me.Btn_SelectClients.Name = "Btn_SelectClients"
        Me.Btn_SelectClients.Size = New System.Drawing.Size(26, 23)
        Me.Btn_SelectClients.TabIndex = 29
        Me.Btn_SelectClients.Text = "..."
        Me.Btn_SelectClients.UseVisualStyleBackColor = True
        '
        'Lbl_ProductFile
        '
        Me.Lbl_ProductFile.AutoSize = True
        Me.Lbl_ProductFile.Location = New System.Drawing.Point(22, 35)
        Me.Lbl_ProductFile.Name = "Lbl_ProductFile"
        Me.Lbl_ProductFile.Size = New System.Drawing.Size(119, 13)
        Me.Lbl_ProductFile.TabIndex = 31
        Me.Lbl_ProductFile.Text = "Full path to products file"
        '
        'Lbl_UserFile
        '
        Me.Lbl_UserFile.AutoSize = True
        Me.Lbl_UserFile.Location = New System.Drawing.Point(22, 78)
        Me.Lbl_UserFile.Name = "Lbl_UserFile"
        Me.Lbl_UserFile.Size = New System.Drawing.Size(103, 13)
        Me.Lbl_UserFile.TabIndex = 32
        Me.Lbl_UserFile.Text = "Full path to users file"
        '
        'Lbl_CSVFile
        '
        Me.Lbl_CSVFile.AutoSize = True
        Me.Lbl_CSVFile.Location = New System.Drawing.Point(22, 177)
        Me.Lbl_CSVFile.Name = "Lbl_CSVFile"
        Me.Lbl_CSVFile.Size = New System.Drawing.Size(131, 13)
        Me.Lbl_CSVFile.TabIndex = 33
        Me.Lbl_CSVFile.Text = "CSV record file destination"
        '
        'Lbl_ClientFile
        '
        Me.Lbl_ClientFile.AutoSize = True
        Me.Lbl_ClientFile.Location = New System.Drawing.Point(22, 127)
        Me.Lbl_ClientFile.Name = "Lbl_ClientFile"
        Me.Lbl_ClientFile.Size = New System.Drawing.Size(108, 13)
        Me.Lbl_ClientFile.TabIndex = 34
        Me.Lbl_ClientFile.Text = "Full path to clients file"
        '
        'Btn_NextWizard
        '
        Me.Btn_NextWizard.Location = New System.Drawing.Point(25, 232)
        Me.Btn_NextWizard.Name = "Btn_NextWizard"
        Me.Btn_NextWizard.Size = New System.Drawing.Size(160, 23)
        Me.Btn_NextWizard.TabIndex = 35
        Me.Btn_NextWizard.Text = "Save and Continue"
        Me.Btn_NextWizard.UseVisualStyleBackColor = True
        '
        'Txt_Clients
        '
        Me.Txt_Clients.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsAppTest.My.MySettings.Default, "Client", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Txt_Clients.Enabled = False
        Me.Txt_Clients.Location = New System.Drawing.Point(25, 143)
        Me.Txt_Clients.Name = "Txt_Clients"
        Me.Txt_Clients.Size = New System.Drawing.Size(160, 20)
        Me.Txt_Clients.TabIndex = 30
        Me.Txt_Clients.Text = Global.WindowsAppTest.My.MySettings.Default.Client
        '
        'Txt_Users
        '
        Me.Txt_Users.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsAppTest.My.MySettings.Default, "Salespeople", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Txt_Users.Enabled = False
        Me.Txt_Users.Location = New System.Drawing.Point(25, 94)
        Me.Txt_Users.Name = "Txt_Users"
        Me.Txt_Users.Size = New System.Drawing.Size(160, 20)
        Me.Txt_Users.TabIndex = 26
        Me.Txt_Users.Text = Global.WindowsAppTest.My.MySettings.Default.Salespeople
        '
        'Txt_CSV
        '
        Me.Txt_CSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsAppTest.My.MySettings.Default, "CSVFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Txt_CSV.Enabled = False
        Me.Txt_CSV.Location = New System.Drawing.Point(25, 193)
        Me.Txt_CSV.Name = "Txt_CSV"
        Me.Txt_CSV.Size = New System.Drawing.Size(160, 20)
        Me.Txt_CSV.TabIndex = 23
        Me.Txt_CSV.Text = Global.WindowsAppTest.My.MySettings.Default.CSVFile
        '
        'Txt_Products
        '
        Me.Txt_Products.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsAppTest.My.MySettings.Default, "Product", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Txt_Products.Enabled = False
        Me.Txt_Products.Location = New System.Drawing.Point(25, 51)
        Me.Txt_Products.Name = "Txt_Products"
        Me.Txt_Products.Size = New System.Drawing.Size(160, 20)
        Me.Txt_Products.TabIndex = 20
        Me.Txt_Products.Text = Global.WindowsAppTest.My.MySettings.Default.Product
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 291)
        Me.Controls.Add(Me.Btn_NextWizard)
        Me.Controls.Add(Me.Lbl_ClientFile)
        Me.Controls.Add(Me.Lbl_CSVFile)
        Me.Controls.Add(Me.Lbl_UserFile)
        Me.Controls.Add(Me.Lbl_ProductFile)
        Me.Controls.Add(Me.Txt_Clients)
        Me.Controls.Add(Me.Btn_SelectClients)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Txt_Users)
        Me.Controls.Add(Me.Btn_SelectUsers)
        Me.Controls.Add(Me.Txt_CSV)
        Me.Controls.Add(Me.Btn_SelectCSV)
        Me.Controls.Add(Me.Txt_Products)
        Me.Controls.Add(Me.Btn_SelectProducts)
        Me.Name = "Form4"
        Me.Text = "Initial Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Products As TextBox
    Friend WithEvents Btn_SelectProducts As Button
    Friend WithEvents Txt_CSV As TextBox
    Friend WithEvents Btn_SelectCSV As Button
    Friend WithEvents Txt_Users As TextBox
    Friend WithEvents Btn_SelectUsers As Button
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Txt_Clients As TextBox
    Friend WithEvents Btn_SelectClients As Button
    Friend WithEvents Lbl_ProductFile As Label
    Friend WithEvents Lbl_UserFile As Label
    Friend WithEvents Lbl_CSVFile As Label
    Friend WithEvents Lbl_ClientFile As Label
    Friend WithEvents Btn_NextWizard As Button
End Class
