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
        Me.ItemName.Location = New System.Drawing.Point(44, 7)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(45, 15)
        Me.ItemName.TabIndex = 0
        Me.ItemName.Text = "Label1"
        '
        'RemoveButton
        '
        Me.RemoveButton.BackColor = System.Drawing.Color.PeachPuff
        Me.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RemoveButton.Location = New System.Drawing.Point(8, 2)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(30, 23)
        Me.RemoveButton.TabIndex = 1
        Me.RemoveButton.Text = "X"
        Me.RemoveButton.UseVisualStyleBackColor = False
        '
        'IncrementButton
        '
        Me.IncrementButton.BackColor = System.Drawing.Color.PeachPuff
        Me.IncrementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.IncrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IncrementButton.Location = New System.Drawing.Point(265, 2)
        Me.IncrementButton.Name = "IncrementButton"
        Me.IncrementButton.Size = New System.Drawing.Size(30, 23)
        Me.IncrementButton.TabIndex = 2
        Me.IncrementButton.Text = "+"
        Me.IncrementButton.UseVisualStyleBackColor = False
        '
        'DecrementButton
        '
        Me.DecrementButton.BackColor = System.Drawing.Color.PeachPuff
        Me.DecrementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.DecrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DecrementButton.Location = New System.Drawing.Point(229, 2)
        Me.DecrementButton.Name = "DecrementButton"
        Me.DecrementButton.Size = New System.Drawing.Size(30, 23)
        Me.DecrementButton.TabIndex = 3
        Me.DecrementButton.Text = "-"
        Me.DecrementButton.UseVisualStyleBackColor = False
        '
        'ItemQuantity
        '
        Me.ItemQuantity.AutoSize = True
        Me.ItemQuantity.Location = New System.Drawing.Point(184, 7)
        Me.ItemQuantity.Name = "ItemQuantity"
        Me.ItemQuantity.Size = New System.Drawing.Size(45, 15)
        Me.ItemQuantity.TabIndex = 4
        Me.ItemQuantity.Text = "Label1"
        '
        'RecipeItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ItemQuantity)
        Me.Controls.Add(Me.DecrementButton)
        Me.Controls.Add(Me.IncrementButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ItemName)
        Me.Name = "RecipeItem"
        Me.Size = New System.Drawing.Size(300, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ItemName As Label
    Friend WithEvents RemoveButton As Button
    Friend WithEvents IncrementButton As Button
    Friend WithEvents DecrementButton As Button
    Friend WithEvents ItemQuantity As Label
End Class
