<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecipeItem
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
        Me.ItemName = New System.Windows.Forms.Label()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.IncrementButton = New System.Windows.Forms.Button()
        Me.DecrementButton = New System.Windows.Forms.Button()
        Me.ItemQuantity = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ItemName
        '
        Me.ItemName.AutoSize = True
        Me.ItemName.Location = New System.Drawing.Point(66, 11)
        Me.ItemName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(57, 20)
        Me.ItemName.TabIndex = 0
        Me.ItemName.Text = "Label1"
        '
        'RemoveButton
        '
        Me.RemoveButton.BackColor = System.Drawing.Color.PeachPuff
        Me.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RemoveButton.Location = New System.Drawing.Point(12, 3)
        Me.RemoveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(45, 35)
        Me.RemoveButton.TabIndex = 1
        Me.RemoveButton.Text = "X"
        Me.RemoveButton.UseVisualStyleBackColor = False
        '
        'IncrementButton
        '
        Me.IncrementButton.BackColor = System.Drawing.Color.PeachPuff
        Me.IncrementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.IncrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IncrementButton.Location = New System.Drawing.Point(398, 3)
        Me.IncrementButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IncrementButton.Name = "IncrementButton"
        Me.IncrementButton.Size = New System.Drawing.Size(45, 35)
        Me.IncrementButton.TabIndex = 2
        Me.IncrementButton.Text = "+"
        Me.IncrementButton.UseVisualStyleBackColor = False
        '
        'DecrementButton
        '
        Me.DecrementButton.BackColor = System.Drawing.Color.PeachPuff
        Me.DecrementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.DecrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DecrementButton.Location = New System.Drawing.Point(344, 3)
        Me.DecrementButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DecrementButton.Name = "DecrementButton"
        Me.DecrementButton.Size = New System.Drawing.Size(45, 35)
        Me.DecrementButton.TabIndex = 3
        Me.DecrementButton.Text = "-"
        Me.DecrementButton.UseVisualStyleBackColor = False
        '
        'ItemQuantity
        '
        Me.ItemQuantity.AutoSize = True
        Me.ItemQuantity.Location = New System.Drawing.Point(276, 11)
        Me.ItemQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemQuantity.Name = "ItemQuantity"
        Me.ItemQuantity.Size = New System.Drawing.Size(57, 20)
        Me.ItemQuantity.TabIndex = 4
        Me.ItemQuantity.Text = "Label1"
        '
        'RecipeItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ItemQuantity)
        Me.Controls.Add(Me.DecrementButton)
        Me.Controls.Add(Me.IncrementButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ItemName)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RecipeItem"
        Me.Size = New System.Drawing.Size(451, 46)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ItemName As Label
    Friend WithEvents RemoveButton As Button
    Friend WithEvents IncrementButton As Button
    Friend WithEvents DecrementButton As Button
    Friend WithEvents ItemQuantity As Label
End Class
