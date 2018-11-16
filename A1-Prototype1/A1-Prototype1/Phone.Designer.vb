<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Phone
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WaitingForListLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MOBILE SHOPPING LIST"
        '
        'WaitingForListLabel
        '
        Me.WaitingForListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!)
        Me.WaitingForListLabel.Location = New System.Drawing.Point(12, 59)
        Me.WaitingForListLabel.Name = "WaitingForListLabel"
        Me.WaitingForListLabel.Size = New System.Drawing.Size(254, 344)
        Me.WaitingForListLabel.TabIndex = 1
        Me.WaitingForListLabel.Text = "WAITING FOR A SHOPPING LIST"
        Me.WaitingForListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 450)
        Me.Controls.Add(Me.WaitingForListLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Phone"
        Me.Text = "Phone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents WaitingForListLabel As Label
End Class
