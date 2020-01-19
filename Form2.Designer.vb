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
        Me.cboxUser = New System.Windows.Forms.ComboBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
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
        'cboxUser
        '
        Me.cboxUser.AllowDrop = True
        Me.cboxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxUser.FormattingEnabled = True
        Me.cboxUser.Location = New System.Drawing.Point(72, 23)
        Me.cboxUser.Name = "cboxUser"
        Me.cboxUser.Size = New System.Drawing.Size(121, 21)
        Me.cboxUser.Sorted = True
        Me.cboxUser.TabIndex = 1
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(72, 78)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(188, 78)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 124)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.cboxUser)
        Me.Controls.Add(Me.lblUser)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents cboxUser As ComboBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnClose As Button
End Class
