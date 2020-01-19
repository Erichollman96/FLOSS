<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Cbox_User = New System.Windows.Forms.ComboBox()
        Me.Btn_Confirm = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(34, 31)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(32, 13)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "User:"
        '
        'Cbox_User
        '
        Me.Cbox_User.AllowDrop = True
        Me.Cbox_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_User.FormattingEnabled = True
        Me.Cbox_User.Location = New System.Drawing.Point(72, 23)
        Me.Cbox_User.Name = "Cbox_User"
        Me.Cbox_User.Size = New System.Drawing.Size(121, 21)
        Me.Cbox_User.Sorted = True
        Me.Cbox_User.TabIndex = 1
        '
        'Btn_Confirm
        '
        Me.Btn_Confirm.Location = New System.Drawing.Point(72, 78)
        Me.Btn_Confirm.Name = "Btn_Confirm"
        Me.Btn_Confirm.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Confirm.TabIndex = 2
        Me.Btn_Confirm.Text = "Confirm"
        Me.Btn_Confirm.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.Location = New System.Drawing.Point(188, 78)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Close.TabIndex = 3
        Me.Btn_Close.Text = "Close"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 124)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Btn_Confirm)
        Me.Controls.Add(Me.Cbox_User)
        Me.Controls.Add(Me.lblUser)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents Cbox_User As ComboBox
    Friend WithEvents Btn_Confirm As Button
    Friend WithEvents Btn_Close As Button
End Class
