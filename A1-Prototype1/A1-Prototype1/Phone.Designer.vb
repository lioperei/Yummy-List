<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Phone
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PhonePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(52, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MOBILE SHOPPING LIST"
        '
        'PhonePanel
        '
        Me.PhonePanel.Location = New System.Drawing.Point(23, 42)
        Me.PhonePanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PhonePanel.Name = "PhonePanel"
        Me.PhonePanel.Size = New System.Drawing.Size(233, 376)
        Me.PhonePanel.TabIndex = 1
        '
        'Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(278, 450)
        Me.Controls.Add(Me.PhonePanel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Phone"
        Me.Text = "Phone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PhonePanel As FlowLayoutPanel
End Class
