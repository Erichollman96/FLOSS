<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.LblDatabase = New System.Windows.Forms.Label()
        Me.LblDatabaseUsername = New System.Windows.Forms.Label()
        Me.LblDatabasePassword = New System.Windows.Forms.Label()
        Me.BtnSaveAndExit = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblServerName = New System.Windows.Forms.Label()
        Me.Txt_ServerName = New System.Windows.Forms.TextBox()
        Me.Txt_DBPassword = New System.Windows.Forms.TextBox()
        Me.Txt_DBUsername = New System.Windows.Forms.TextBox()
        Me.Txt_DBName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblDatabase
        '
        Me.LblDatabase.AutoSize = True
        Me.LblDatabase.Location = New System.Drawing.Point(23, 61)
        Me.LblDatabase.Name = "LblDatabase"
        Me.LblDatabase.Size = New System.Drawing.Size(84, 13)
        Me.LblDatabase.TabIndex = 1
        Me.LblDatabase.Text = "Database Name"
        '
        'LblDatabaseUsername
        '
        Me.LblDatabaseUsername.AutoSize = True
        Me.LblDatabaseUsername.Location = New System.Drawing.Point(23, 98)
        Me.LblDatabaseUsername.Name = "LblDatabaseUsername"
        Me.LblDatabaseUsername.Size = New System.Drawing.Size(104, 13)
        Me.LblDatabaseUsername.TabIndex = 2
        Me.LblDatabaseUsername.Text = "Database Username"
        '
        'LblDatabasePassword
        '
        Me.LblDatabasePassword.AutoSize = True
        Me.LblDatabasePassword.Location = New System.Drawing.Point(23, 141)
        Me.LblDatabasePassword.Name = "LblDatabasePassword"
        Me.LblDatabasePassword.Size = New System.Drawing.Size(102, 13)
        Me.LblDatabasePassword.TabIndex = 2
        Me.LblDatabasePassword.Text = "Database Password"
        '
        'BtnSaveAndExit
        '
        Me.BtnSaveAndExit.Location = New System.Drawing.Point(28, 180)
        Me.BtnSaveAndExit.Name = "BtnSaveAndExit"
        Me.BtnSaveAndExit.Size = New System.Drawing.Size(100, 23)
        Me.BtnSaveAndExit.TabIndex = 3
        Me.BtnSaveAndExit.Text = "Save and Exit"
        Me.BtnSaveAndExit.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(157, 180)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblServerName
        '
        Me.LblServerName.AutoSize = True
        Me.LblServerName.Location = New System.Drawing.Point(23, 25)
        Me.LblServerName.Name = "LblServerName"
        Me.LblServerName.Size = New System.Drawing.Size(69, 13)
        Me.LblServerName.TabIndex = 6
        Me.LblServerName.Text = "Server Name"
        '
        'Txt_ServerName
        '
        Me.Txt_ServerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsAppTest.My.MySettings.Default, "ServerName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Txt_ServerName.Location = New System.Drawing.Point(143, 22)
        Me.Txt_ServerName.Name = "Txt_ServerName"
        Me.Txt_ServerName.Size = New System.Drawing.Size(100, 20)
        Me.Txt_ServerName.TabIndex = 5
        Me.Txt_ServerName.Text = Global.WindowsAppTest.My.MySettings.Default.ServerName
        '
        'Txt_DBPassword
        '
        Me.Txt_DBPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsAppTest.My.MySettings.Default, "DBPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Txt_DBPassword.Location = New System.Drawing.Point(143, 141)
        Me.Txt_DBPassword.Name = "Txt_DBPassword"
        Me.Txt_DBPassword.Size = New System.Drawing.Size(100, 20)
        Me.Txt_DBPassword.TabIndex = 2
        Me.Txt_DBPassword.Text = Global.WindowsAppTest.My.MySettings.Default.DBPassword
        '
        'Txt_DBUsername
        '
        Me.Txt_DBUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsAppTest.My.MySettings.Default, "DBUsername", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Txt_DBUsername.Location = New System.Drawing.Point(143, 98)
        Me.Txt_DBUsername.Name = "Txt_DBUsername"
        Me.Txt_DBUsername.Size = New System.Drawing.Size(100, 20)
        Me.Txt_DBUsername.TabIndex = 1
        Me.Txt_DBUsername.Text = Global.WindowsAppTest.My.MySettings.Default.DBUsername
        '
        'Txt_DBName
        '
        Me.Txt_DBName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsAppTest.My.MySettings.Default, "DBName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Txt_DBName.Location = New System.Drawing.Point(143, 58)
        Me.Txt_DBName.Name = "Txt_DBName"
        Me.Txt_DBName.Size = New System.Drawing.Size(100, 20)
        Me.Txt_DBName.TabIndex = 0
        Me.Txt_DBName.Text = Global.WindowsAppTest.My.MySettings.Default.DBName
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 252)
        Me.Controls.Add(Me.LblServerName)
        Me.Controls.Add(Me.Txt_ServerName)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSaveAndExit)
        Me.Controls.Add(Me.LblDatabasePassword)
        Me.Controls.Add(Me.LblDatabaseUsername)
        Me.Controls.Add(Me.LblDatabase)
        Me.Controls.Add(Me.Txt_DBPassword)
        Me.Controls.Add(Me.Txt_DBUsername)
        Me.Controls.Add(Me.Txt_DBName)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_DBName As TextBox
    Friend WithEvents Txt_DBUsername As TextBox
    Friend WithEvents Txt_DBPassword As TextBox
    Friend WithEvents LblDatabase As Label
    Friend WithEvents LblDatabaseUsername As Label
    Friend WithEvents LblDatabasePassword As Label
    Friend WithEvents BtnSaveAndExit As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblServerName As Label
    Friend WithEvents Txt_ServerName As TextBox
End Class
