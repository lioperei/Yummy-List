<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecipeList
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
        Me.RecipeItemPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddRecipeItem = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Import = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImportPanel = New System.Windows.Forms.Panel()
        Me.ImportNames = New System.Windows.Forms.ListBox()
        Me.ImportConfirm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DeleteRecipe = New System.Windows.Forms.Button()
        Me.ModifyRecipeButton = New System.Windows.Forms.Button()
        Me.CreateRecipe = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RecipeNames = New System.Windows.Forms.ListBox()
        Me.ImportPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RecipeItemPanel
        '
        Me.RecipeItemPanel.AutoScroll = True
        Me.RecipeItemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.RecipeItemPanel.Location = New System.Drawing.Point(386, 38)
        Me.RecipeItemPanel.Name = "RecipeItemPanel"
        Me.RecipeItemPanel.Size = New System.Drawing.Size(388, 183)
        Me.RecipeItemPanel.TabIndex = 0
        Me.RecipeItemPanel.WrapContents = False
        '
        'AddRecipeItem
        '
        Me.AddRecipeItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddRecipeItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AddRecipeItem.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AddRecipeItem.Location = New System.Drawing.Point(467, 225)
        Me.AddRecipeItem.Name = "AddRecipeItem"
        Me.AddRecipeItem.Size = New System.Drawing.Size(52, 23)
        Me.AddRecipeItem.TabIndex = 1
        Me.AddRecipeItem.Text = "+ Add"
        Me.AddRecipeItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddRecipeItem.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(611, 225)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Import
        '
        Me.Import.Location = New System.Drawing.Point(386, 225)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(75, 23)
        Me.Import.TabIndex = 2
        Me.Import.Text = "IMPORT"
        Me.Import.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(530, 225)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(452, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITEM NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(662, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "QUANTITY"
        '
        'ImportPanel
        '
        Me.ImportPanel.Controls.Add(Me.ImportNames)
        Me.ImportPanel.Controls.Add(Me.ImportConfirm)
        Me.ImportPanel.Controls.Add(Me.Label3)
        Me.ImportPanel.Location = New System.Drawing.Point(386, 255)
        Me.ImportPanel.Name = "ImportPanel"
        Me.ImportPanel.Size = New System.Drawing.Size(388, 117)
        Me.ImportPanel.TabIndex = 5
        Me.ImportPanel.Visible = False
        '
        'ImportNames
        '
        Me.ImportNames.FormattingEnabled = True
        Me.ImportNames.Location = New System.Drawing.Point(50, 4)
        Me.ImportNames.Name = "ImportNames"
        Me.ImportNames.Size = New System.Drawing.Size(254, 95)
        Me.ImportNames.TabIndex = 4
        '
        'ImportConfirm
        '
        Me.ImportConfirm.BackColor = System.Drawing.Color.Lime
        Me.ImportConfirm.Location = New System.Drawing.Point(310, 0)
        Me.ImportConfirm.Name = "ImportConfirm"
        Me.ImportConfirm.Size = New System.Drawing.Size(75, 23)
        Me.ImportConfirm.TabIndex = 3
        Me.ImportConfirm.Text = "IMPORT"
        Me.ImportConfirm.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Select >"
        '
        'DeleteRecipe
        '
        Me.DeleteRecipe.BackColor = System.Drawing.Color.LavenderBlush
        Me.DeleteRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.DeleteRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteRecipe.Location = New System.Drawing.Point(230, 273)
        Me.DeleteRecipe.Name = "DeleteRecipe"
        Me.DeleteRecipe.Size = New System.Drawing.Size(99, 88)
        Me.DeleteRecipe.TabIndex = 10
        Me.DeleteRecipe.Text = "Delete Recipe"
        Me.DeleteRecipe.UseVisualStyleBackColor = False
        '
        'ModifyRecipeButton
        '
        Me.ModifyRecipeButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.ModifyRecipeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.ModifyRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ModifyRecipeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifyRecipeButton.Location = New System.Drawing.Point(230, 157)
        Me.ModifyRecipeButton.Name = "ModifyRecipeButton"
        Me.ModifyRecipeButton.Size = New System.Drawing.Size(99, 90)
        Me.ModifyRecipeButton.TabIndex = 9
        Me.ModifyRecipeButton.Text = "Modify Recipe"
        Me.ModifyRecipeButton.UseVisualStyleBackColor = False
        '
        'CreateRecipe
        '
        Me.CreateRecipe.BackColor = System.Drawing.Color.LavenderBlush
        Me.CreateRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.CreateRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateRecipe.Location = New System.Drawing.Point(231, 38)
        Me.CreateRecipe.Name = "CreateRecipe"
        Me.CreateRecipe.Size = New System.Drawing.Size(98, 84)
        Me.CreateRecipe.TabIndex = 8
        Me.CreateRecipe.Text = "Create New Recipe"
        Me.CreateRecipe.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 21.73585!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 41)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Recipes"
        '
        'RecipeNames
        '
        Me.RecipeNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RecipeNames.FormattingEnabled = True
        Me.RecipeNames.ItemHeight = 20
        Me.RecipeNames.Location = New System.Drawing.Point(17, 55)
        Me.RecipeNames.Name = "RecipeNames"
        Me.RecipeNames.Size = New System.Drawing.Size(169, 304)
        Me.RecipeNames.TabIndex = 6
        '
        'RecipeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DeleteRecipe)
        Me.Controls.Add(Me.ModifyRecipeButton)
        Me.Controls.Add(Me.CreateRecipe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RecipeNames)
        Me.Controls.Add(Me.ImportPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Import)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.AddRecipeItem)
        Me.Controls.Add(Me.RecipeItemPanel)
        Me.Name = "RecipeList"
        Me.Size = New System.Drawing.Size(791, 378)
        Me.ImportPanel.ResumeLayout(False)
        Me.ImportPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecipeItemPanel As FlowLayoutPanel
    Friend WithEvents AddRecipeItem As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Import As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ImportPanel As Panel
    Friend WithEvents ImportNames As ListBox
    Friend WithEvents ImportConfirm As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DeleteRecipe As Button
    Friend WithEvents ModifyRecipeButton As Button
    Friend WithEvents CreateRecipe As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents RecipeNames As ListBox
End Class
