<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipeList
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sendToPhoneButton = New System.Windows.Forms.Button()
        Me.ImportPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RecipeItemPanel
        '
        Me.RecipeItemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.RecipeItemPanel.Location = New System.Drawing.Point(579, 58)
        Me.RecipeItemPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RecipeItemPanel.Name = "RecipeItemPanel"
        Me.RecipeItemPanel.Size = New System.Drawing.Size(450, 282)
        Me.RecipeItemPanel.TabIndex = 0
        '
        'AddRecipeItem
        '
        Me.AddRecipeItem.Location = New System.Drawing.Point(700, 346)
        Me.AddRecipeItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddRecipeItem.Name = "AddRecipeItem"
        Me.AddRecipeItem.Size = New System.Drawing.Size(46, 35)
        Me.AddRecipeItem.TabIndex = 1
        Me.AddRecipeItem.Text = "+"
        Me.AddRecipeItem.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(916, 346)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(112, 35)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Import
        '
        Me.Import.Location = New System.Drawing.Point(579, 346)
        Me.Import.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(112, 35)
        Me.Import.TabIndex = 2
        Me.Import.Text = "IMPORT"
        Me.Import.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(795, 346)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(112, 35)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(628, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITEM NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(842, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "QUANTITY"
        '
        'ImportPanel
        '
        Me.ImportPanel.Controls.Add(Me.ImportNames)
        Me.ImportPanel.Controls.Add(Me.ImportConfirm)
        Me.ImportPanel.Controls.Add(Me.Label3)
        Me.ImportPanel.Location = New System.Drawing.Point(579, 392)
        Me.ImportPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImportPanel.Name = "ImportPanel"
        Me.ImportPanel.Size = New System.Drawing.Size(450, 180)
        Me.ImportPanel.TabIndex = 5
        Me.ImportPanel.Visible = False
        '
        'ImportNames
        '
        Me.ImportNames.FormattingEnabled = True
        Me.ImportNames.ItemHeight = 20
        Me.ImportNames.Location = New System.Drawing.Point(69, 6)
        Me.ImportNames.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImportNames.Name = "ImportNames"
        Me.ImportNames.Size = New System.Drawing.Size(253, 144)
        Me.ImportNames.TabIndex = 4
        '
        'ImportConfirm
        '
        Me.ImportConfirm.BackColor = System.Drawing.Color.Lime
        Me.ImportConfirm.Location = New System.Drawing.Point(333, 0)
        Me.ImportConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImportConfirm.Name = "ImportConfirm"
        Me.ImportConfirm.Size = New System.Drawing.Size(112, 35)
        Me.ImportConfirm.TabIndex = 3
        Me.ImportConfirm.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Import"
        '
        'DeleteRecipe
        '
        Me.DeleteRecipe.BackColor = System.Drawing.Color.LavenderBlush
        Me.DeleteRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.DeleteRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteRecipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteRecipe.Location = New System.Drawing.Point(345, 420)
        Me.DeleteRecipe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteRecipe.Name = "DeleteRecipe"
        Me.DeleteRecipe.Size = New System.Drawing.Size(148, 135)
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
        Me.ModifyRecipeButton.Location = New System.Drawing.Point(345, 242)
        Me.ModifyRecipeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifyRecipeButton.Name = "ModifyRecipeButton"
        Me.ModifyRecipeButton.Size = New System.Drawing.Size(148, 138)
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
        Me.CreateRecipe.Location = New System.Drawing.Point(346, 58)
        Me.CreateRecipe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CreateRecipe.Name = "CreateRecipe"
        Me.CreateRecipe.Size = New System.Drawing.Size(147, 129)
        Me.CreateRecipe.TabIndex = 8
        Me.CreateRecipe.Text = "Create New Recipe"
        Me.CreateRecipe.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 21.73585!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 62)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Recipes"
        '
        'RecipeNames
        '
        Me.RecipeNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RecipeNames.FormattingEnabled = True
        Me.RecipeNames.ItemHeight = 29
        Me.RecipeNames.Location = New System.Drawing.Point(26, 85)
        Me.RecipeNames.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RecipeNames.Name = "RecipeNames"
        Me.RecipeNames.Size = New System.Drawing.Size(252, 468)
        Me.RecipeNames.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sendToPhoneButton
        '
        Me.sendToPhoneButton.Location = New System.Drawing.Point(1048, 108)
        Me.sendToPhoneButton.Name = "sendToPhoneButton"
        Me.sendToPhoneButton.Size = New System.Drawing.Size(114, 180)
        Me.sendToPhoneButton.TabIndex = 12
        Me.sendToPhoneButton.Text = "Send List to Phone"
        Me.sendToPhoneButton.UseVisualStyleBackColor = True
        '
        'RecipeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.sendToPhoneButton)
        Me.Controls.Add(Me.Button1)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RecipeList"
        Me.Size = New System.Drawing.Size(1186, 582)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents sendToPhoneButton As Button
End Class
