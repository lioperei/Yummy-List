<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fridge
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ShoppingLists = New System.Windows.Forms.TabPage()
        Me.Inventory = New System.Windows.Forms.TabPage()
        Me.Recipes = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ShoppingLists)
        Me.TabControl1.Controls.Add(Me.Inventory)
        Me.TabControl1.Controls.Add(Me.Recipes)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(799, 454)
        Me.TabControl1.TabIndex = 0
        '
        'ShoppingLists
        '
        Me.ShoppingLists.Location = New System.Drawing.Point(4, 22)
        Me.ShoppingLists.Name = "ShoppingLists"
        Me.ShoppingLists.Padding = New System.Windows.Forms.Padding(3)
        Me.ShoppingLists.Size = New System.Drawing.Size(791, 428)
        Me.ShoppingLists.TabIndex = 0
        Me.ShoppingLists.Text = "Shopping Lists"
        Me.ShoppingLists.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.Inventory.Location = New System.Drawing.Point(4, 22)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Padding = New System.Windows.Forms.Padding(3)
        Me.Inventory.Size = New System.Drawing.Size(791, 428)
        Me.Inventory.TabIndex = 1
        Me.Inventory.Text = "Inventory"
        Me.Inventory.UseVisualStyleBackColor = True
        '
        'Recipes
        '
        Me.Recipes.Location = New System.Drawing.Point(4, 22)
        Me.Recipes.Name = "Recipes"
        Me.Recipes.Size = New System.Drawing.Size(791, 428)
        Me.Recipes.TabIndex = 2
        Me.Recipes.Text = "Recipes"
        Me.Recipes.UseVisualStyleBackColor = True
        '
        'Fridge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Fridge"
        Me.Text = "Fridge"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ShoppingLists As TabPage
    Friend WithEvents Inventory As TabPage
    Friend WithEvents Recipes As TabPage
End Class
