<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemsList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.InventoryItemPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InventoryItemPanel
        '
        Me.InventoryItemPanel.AutoScroll = True
        Me.InventoryItemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.InventoryItemPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryItemPanel.ForeColor = System.Drawing.Color.DarkViolet
        Me.InventoryItemPanel.Location = New System.Drawing.Point(140, 60)
        Me.InventoryItemPanel.Name = "InventoryItemPanel"
        Me.InventoryItemPanel.Size = New System.Drawing.Size(570, 302)
        Me.InventoryItemPanel.TabIndex = 5
        Me.InventoryItemPanel.WrapContents = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 25.81132!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label1.Location = New System.Drawing.Point(81, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ALL ITEMS"
        '
        'itemsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.InventoryItemPanel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "itemsList"
        Me.Size = New System.Drawing.Size(791, 378)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InventoryItemPanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
End Class
