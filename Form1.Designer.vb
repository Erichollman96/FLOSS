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
        Me.Txt_Client = New System.Windows.Forms.TextBox()
        Me.Txt_Total = New System.Windows.Forms.TextBox()
        Me.Txt_Date = New System.Windows.Forms.TextBox()
        Me.Lbl_Client = New System.Windows.Forms.Label()
        Me.Lbl_Product = New System.Windows.Forms.Label()
        Me.Lbl_Total = New System.Windows.Forms.Label()
        Me.Lbl_Date = New System.Windows.Forms.Label()
        Me.Btn_Submit = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Btn_SignIn = New System.Windows.Forms.Button()
        Me.Lbl_User = New System.Windows.Forms.Label()
        Me.Lbl_ActiveUser = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_ViewSales = New System.Windows.Forms.Button()
        Me.Cbox_Product = New System.Windows.Forms.ComboBox()
        Me.Btn_Today = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_SetupWizard = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Client
        '
        Me.Txt_Client.Enabled = False
        Me.Txt_Client.Location = New System.Drawing.Point(81, 66)
        Me.Txt_Client.Name = "Txt_Client"
        Me.Txt_Client.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Client.TabIndex = 0
        '
        'Txt_Total
        '
        Me.Txt_Total.Enabled = False
        Me.Txt_Total.Location = New System.Drawing.Point(81, 118)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Total.TabIndex = 2
        '
        'Txt_Date
        '
        Me.Txt_Date.Enabled = False
        Me.Txt_Date.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Txt_Date.Location = New System.Drawing.Point(81, 144)
        Me.Txt_Date.Name = "Txt_Date"
        Me.Txt_Date.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Date.TabIndex = 3
        '
        'Lbl_Client
        '
        Me.Lbl_Client.AutoSize = True
        Me.Lbl_Client.Enabled = False
        Me.Lbl_Client.Location = New System.Drawing.Point(37, 69)
        Me.Lbl_Client.Name = "Lbl_Client"
        Me.Lbl_Client.Size = New System.Drawing.Size(33, 13)
        Me.Lbl_Client.TabIndex = 4
        Me.Lbl_Client.Text = "Client"
        '
        'Lbl_Product
        '
        Me.Lbl_Product.AutoSize = True
        Me.Lbl_Product.Enabled = False
        Me.Lbl_Product.Location = New System.Drawing.Point(37, 92)
        Me.Lbl_Product.Name = "Lbl_Product"
        Me.Lbl_Product.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Product.TabIndex = 5
        Me.Lbl_Product.Text = "Product"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.AutoSize = True
        Me.Lbl_Total.Enabled = False
        Me.Lbl_Total.Location = New System.Drawing.Point(37, 118)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_Total.TabIndex = 6
        Me.Lbl_Total.Text = "Total"
        '
        'Lbl_Date
        '
        Me.Lbl_Date.AutoSize = True
        Me.Lbl_Date.Enabled = False
        Me.Lbl_Date.Location = New System.Drawing.Point(37, 144)
        Me.Lbl_Date.Name = "Lbl_Date"
        Me.Lbl_Date.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Date.TabIndex = 7
        Me.Lbl_Date.Text = "Date"
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Enabled = False
        Me.Btn_Submit.Location = New System.Drawing.Point(99, 170)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Submit.TabIndex = 8
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.Location = New System.Drawing.Point(287, 262)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Close.TabIndex = 9
        Me.Btn_Close.Text = "Close"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Btn_SignIn
        '
        Me.Btn_SignIn.Location = New System.Drawing.Point(208, 37)
        Me.Btn_SignIn.Name = "Btn_SignIn"
        Me.Btn_SignIn.Size = New System.Drawing.Size(80, 25)
        Me.Btn_SignIn.TabIndex = 10
        Me.Btn_SignIn.Text = "Sign In"
        Me.Btn_SignIn.UseVisualStyleBackColor = True
        '
        'Lbl_User
        '
        Me.Lbl_User.AutoSize = True
        Me.Lbl_User.Location = New System.Drawing.Point(6, 37)
        Me.Lbl_User.Name = "Lbl_User"
        Me.Lbl_User.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_User.TabIndex = 11
        Me.Lbl_User.Text = "Active User:"
        '
        'Lbl_ActiveUser
        '
        Me.Lbl_ActiveUser.AutoSize = True
        Me.Lbl_ActiveUser.Location = New System.Drawing.Point(77, 37)
        Me.Lbl_ActiveUser.Name = "Lbl_ActiveUser"
        Me.Lbl_ActiveUser.Size = New System.Drawing.Size(115, 13)
        Me.Lbl_ActiveUser.TabIndex = 12
        Me.Lbl_ActiveUser.Text = "NO USER SELECTED"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300000
        '
        'Btn_ViewSales
        '
        Me.Btn_ViewSales.Enabled = False
        Me.Btn_ViewSales.Location = New System.Drawing.Point(160, 263)
        Me.Btn_ViewSales.Name = "Btn_ViewSales"
        Me.Btn_ViewSales.Size = New System.Drawing.Size(106, 23)
        Me.Btn_ViewSales.TabIndex = 13
        Me.Btn_ViewSales.Text = "View Sales"
        Me.Btn_ViewSales.UseVisualStyleBackColor = True
        '
        'Cbox_Product
        '
        Me.Cbox_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_Product.Enabled = False
        Me.Cbox_Product.FormattingEnabled = True
        Me.Cbox_Product.Location = New System.Drawing.Point(81, 91)
        Me.Cbox_Product.Name = "Cbox_Product"
        Me.Cbox_Product.Size = New System.Drawing.Size(121, 21)
        Me.Cbox_Product.Sorted = True
        Me.Cbox_Product.TabIndex = 14
        '
        'Btn_Today
        '
        Me.Btn_Today.Enabled = False
        Me.Btn_Today.Location = New System.Drawing.Point(208, 144)
        Me.Btn_Today.Name = "Btn_Today"
        Me.Btn_Today.Size = New System.Drawing.Size(80, 23)
        Me.Btn_Today.TabIndex = 15
        Me.Btn_Today.Text = "Today's Date"
        Me.Btn_Today.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SetupToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(405, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_About})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Menu_About
        '
        Me.Menu_About.Name = "Menu_About"
        Me.Menu_About.Size = New System.Drawing.Size(107, 22)
        Me.Menu_About.Text = "About"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_SetupWizard})
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'Menu_SetupWizard
        '
        Me.Menu_SetupWizard.Name = "Menu_SetupWizard"
        Me.Menu_SetupWizard.Size = New System.Drawing.Size(143, 22)
        Me.Menu_SetupWizard.Text = "Setup Wizard"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 317)
        Me.Controls.Add(Me.Btn_Today)
        Me.Controls.Add(Me.Cbox_Product)
        Me.Controls.Add(Me.Btn_ViewSales)
        Me.Controls.Add(Me.Lbl_ActiveUser)
        Me.Controls.Add(Me.Lbl_User)
        Me.Controls.Add(Me.Btn_SignIn)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Lbl_Date)
        Me.Controls.Add(Me.Lbl_Total)
        Me.Controls.Add(Me.Lbl_Product)
        Me.Controls.Add(Me.Lbl_Client)
        Me.Controls.Add(Me.Txt_Date)
        Me.Controls.Add(Me.Txt_Total)
        Me.Controls.Add(Me.Txt_Client)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Submit Records"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Client As TextBox
    Friend WithEvents Txt_Total As TextBox
    Friend WithEvents Txt_Date As TextBox
    Friend WithEvents Lbl_Client As Label
    Friend WithEvents Lbl_Product As Label
    Friend WithEvents Lbl_Total As Label
    Friend WithEvents Lbl_Date As Label
    Friend WithEvents Btn_Submit As Button
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Btn_SignIn As Button
    Friend WithEvents Lbl_User As Label
    Friend WithEvents Lbl_ActiveUser As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Btn_ViewSales As Button
    Friend WithEvents Cbox_Product As ComboBox
    Friend WithEvents Btn_Today As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_About As ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_SetupWizard As ToolStripMenuItem
End Class
