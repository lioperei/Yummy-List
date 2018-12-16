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
        Me.RecipeItemPanel.ForeColor = System.Drawing.Color.FloralWhite
        Me.RecipeItemPanel.Location = New System.Drawing.Point(437, 38)
        Me.RecipeItemPanel.Name = "RecipeItemPanel"
        Me.RecipeItemPanel.Size = New System.Drawing.Size(338, 165)
        Me.RecipeItemPanel.TabIndex = 0
        Me.RecipeItemPanel.WrapContents = False
        '
        'AddRecipeItem
        '
        Me.AddRecipeItem.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.AddRecipeItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddRecipeItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRecipeItem.ForeColor = System.Drawing.Color.FloralWhite
        Me.AddRecipeItem.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AddRecipeItem.Location = New System.Drawing.Point(514, 208)
        Me.AddRecipeItem.Name = "AddRecipeItem"
        Me.AddRecipeItem.Size = New System.Drawing.Size(82, 40)
        Me.AddRecipeItem.TabIndex = 1
        Me.AddRecipeItem.Text = "+ Add"
        Me.AddRecipeItem.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.FloralWhite
        Me.SaveButton.Location = New System.Drawing.Point(696, 208)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 40)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'Import
        '
        Me.Import.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Import.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Import.ForeColor = System.Drawing.Color.FloralWhite
        Me.Import.Location = New System.Drawing.Point(415, 208)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(95, 40)
        Me.Import.TabIndex = 2
        Me.Import.Text = "IMPORT"
        Me.Import.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.FloralWhite
        Me.Cancel.Location = New System.Drawing.Point(600, 208)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(90, 40)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.2!)
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(481, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITEM NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.2!)
        Me.Label2.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label2.Location = New System.Drawing.Point(624, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "QUANTITY"
        '
        'ImportPanel
        '
        Me.ImportPanel.Controls.Add(Me.ImportNames)
        Me.ImportPanel.Controls.Add(Me.ImportConfirm)
        Me.ImportPanel.Controls.Add(Me.Label3)
        Me.ImportPanel.ForeColor = System.Drawing.Color.FloralWhite
        Me.ImportPanel.Location = New System.Drawing.Point(437, 255)
        Me.ImportPanel.Name = "ImportPanel"
        Me.ImportPanel.Size = New System.Drawing.Size(337, 117)
        Me.ImportPanel.TabIndex = 5
        Me.ImportPanel.Visible = False
        '
        'ImportNames
        '
        Me.ImportNames.FormattingEnabled = True
        Me.ImportNames.Location = New System.Drawing.Point(61, 4)
        Me.ImportNames.Name = "ImportNames"
        Me.ImportNames.Size = New System.Drawing.Size(170, 95)
        Me.ImportNames.TabIndex = 4
        '
        'ImportConfirm
        '
        Me.ImportConfirm.BackColor = System.Drawing.Color.Lime
        Me.ImportConfirm.ForeColor = System.Drawing.Color.Black
        Me.ImportConfirm.Location = New System.Drawing.Point(240, 4)
        Me.ImportConfirm.Name = "ImportConfirm"
        Me.ImportConfirm.Size = New System.Drawing.Size(75, 95)
        Me.ImportConfirm.TabIndex = 3
        Me.ImportConfirm.Text = "IMPORT"
        Me.ImportConfirm.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Select >"
        '
        'DeleteRecipe
        '
        Me.DeleteRecipe.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.DeleteRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.DeleteRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DeleteRecipe.ForeColor = System.Drawing.Color.FloralWhite
        Me.DeleteRecipe.Location = New System.Drawing.Point(188, 258)
        Me.DeleteRecipe.Name = "DeleteRecipe"
        Me.DeleteRecipe.Size = New System.Drawing.Size(220, 49)
        Me.DeleteRecipe.TabIndex = 10
        Me.DeleteRecipe.Text = "Delete Recipe"
        Me.DeleteRecipe.UseVisualStyleBackColor = False
        '
        'ModifyRecipeButton
        '
        Me.ModifyRecipeButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ModifyRecipeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.ModifyRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ModifyRecipeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ModifyRecipeButton.ForeColor = System.Drawing.Color.FloralWhite
        Me.ModifyRecipeButton.Location = New System.Drawing.Point(188, 153)
        Me.ModifyRecipeButton.Name = "ModifyRecipeButton"
        Me.ModifyRecipeButton.Size = New System.Drawing.Size(220, 49)
        Me.ModifyRecipeButton.TabIndex = 9
        Me.ModifyRecipeButton.Text = "Modify Recipe"
        Me.ModifyRecipeButton.UseVisualStyleBackColor = False
        '
        'CreateRecipe
        '
        Me.CreateRecipe.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.CreateRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.CreateRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CreateRecipe.ForeColor = System.Drawing.Color.FloralWhite
        Me.CreateRecipe.Location = New System.Drawing.Point(188, 55)
        Me.CreateRecipe.Name = "CreateRecipe"
        Me.CreateRecipe.Size = New System.Drawing.Size(220, 49)
        Me.CreateRecipe.TabIndex = 8
        Me.CreateRecipe.Text = "Create New Recipe"
        Me.CreateRecipe.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 21.73585!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label4.Location = New System.Drawing.Point(9, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 41)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Recipes"
        '
        'RecipeNames
        '
        Me.RecipeNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RecipeNames.ForeColor = System.Drawing.Color.SaddleBrown
        Me.RecipeNames.FormattingEnabled = True
        Me.RecipeNames.ItemHeight = 20
        Me.RecipeNames.Location = New System.Drawing.Point(17, 55)
        Me.RecipeNames.Name = "RecipeNames"
        Me.RecipeNames.Size = New System.Drawing.Size(169, 284)
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
