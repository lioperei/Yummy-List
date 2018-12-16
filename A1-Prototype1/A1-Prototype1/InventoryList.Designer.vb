<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.InventoryItemPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 25.81132!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INVENTORY"
        '
        'InventoryItemPanel
        '
        Me.InventoryItemPanel.AutoScroll = True
        Me.InventoryItemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.InventoryItemPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryItemPanel.ForeColor = System.Drawing.Color.Chocolate
        Me.InventoryItemPanel.Location = New System.Drawing.Point(78, 70)
        Me.InventoryItemPanel.Name = "InventoryItemPanel"
        Me.InventoryItemPanel.Size = New System.Drawing.Size(570, 302)
        Me.InventoryItemPanel.TabIndex = 1
        Me.InventoryItemPanel.WrapContents = False
        '
        'InventoryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.InventoryItemPanel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InventoryList"
        Me.Size = New System.Drawing.Size(791, 378)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InventoryItemPanel As FlowLayoutPanel
End Class
