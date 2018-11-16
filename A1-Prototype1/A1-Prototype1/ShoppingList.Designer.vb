<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShoppingList
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
        Me.DeleteList = New System.Windows.Forms.Button()
        Me.ModifyListButton = New System.Windows.Forms.Button()
        Me.CreateList = New System.Windows.Forms.Button()
        Me.ShoppingListLabel = New System.Windows.Forms.Label()
        Me.ShoppingListsBox = New System.Windows.Forms.ListBox()
        Me.ImportPanel = New System.Windows.Forms.Panel()
        Me.ImportNames = New System.Windows.Forms.ListBox()
        Me.ImportConfirm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Import = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.AddListItem = New System.Windows.Forms.Button()
        Me.RecipeItemPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImportPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DeleteList
        '
        Me.DeleteList.BackColor = System.Drawing.Color.LavenderBlush
        Me.DeleteList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.DeleteList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteList.Location = New System.Drawing.Point(348, 421)
        Me.DeleteList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteList.Name = "DeleteList"
        Me.DeleteList.Size = New System.Drawing.Size(148, 135)
        Me.DeleteList.TabIndex = 21
        Me.DeleteList.Text = "Delete List"
        Me.DeleteList.UseVisualStyleBackColor = False
        '
        'ModifyListButton
        '
        Me.ModifyListButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.ModifyListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.ModifyListButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ModifyListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifyListButton.Location = New System.Drawing.Point(348, 243)
        Me.ModifyListButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifyListButton.Name = "ModifyListButton"
        Me.ModifyListButton.Size = New System.Drawing.Size(148, 138)
        Me.ModifyListButton.TabIndex = 20
        Me.ModifyListButton.Text = "Modify List"
        Me.ModifyListButton.UseVisualStyleBackColor = False
        '
        'CreateList
        '
        Me.CreateList.BackColor = System.Drawing.Color.LavenderBlush
        Me.CreateList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.CreateList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateList.Location = New System.Drawing.Point(349, 59)
        Me.CreateList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CreateList.Name = "CreateList"
        Me.CreateList.Size = New System.Drawing.Size(147, 129)
        Me.CreateList.TabIndex = 19
        Me.CreateList.Text = "Create New List"
        Me.CreateList.UseVisualStyleBackColor = False
        '
        'ShoppingListLabel
        '
        Me.ShoppingListLabel.AutoSize = True
        Me.ShoppingListLabel.Font = New System.Drawing.Font("Comic Sans MS", 21.73585!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShoppingListLabel.Location = New System.Drawing.Point(17, 9)
        Me.ShoppingListLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ShoppingListLabel.Name = "ShoppingListLabel"
        Me.ShoppingListLabel.Size = New System.Drawing.Size(330, 62)
        Me.ShoppingListLabel.TabIndex = 18
        Me.ShoppingListLabel.Text = "Shopping Lists"
        '
        'ShoppingListsBox
        '
        Me.ShoppingListsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ShoppingListsBox.FormattingEnabled = True
        Me.ShoppingListsBox.ItemHeight = 29
        Me.ShoppingListsBox.Location = New System.Drawing.Point(29, 86)
        Me.ShoppingListsBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ShoppingListsBox.Name = "ShoppingListsBox"
        Me.ShoppingListsBox.Size = New System.Drawing.Size(252, 468)
        Me.ShoppingListsBox.TabIndex = 17
        '
        'ImportPanel
        '
        Me.ImportPanel.Controls.Add(Me.ImportNames)
        Me.ImportPanel.Controls.Add(Me.ImportConfirm)
        Me.ImportPanel.Controls.Add(Me.Label3)
        Me.ImportPanel.Location = New System.Drawing.Point(582, 393)
        Me.ImportPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImportPanel.Name = "ImportPanel"
        Me.ImportPanel.Size = New System.Drawing.Size(450, 180)
        Me.ImportPanel.TabIndex = 16
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
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(798, 347)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(112, 35)
        Me.Cancel.TabIndex = 15
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Import
        '
        Me.Import.Location = New System.Drawing.Point(582, 347)
        Me.Import.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(112, 35)
        Me.Import.TabIndex = 14
        Me.Import.Text = "IMPORT"
        Me.Import.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(919, 347)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(112, 35)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'AddListItem
        '
        Me.AddListItem.Location = New System.Drawing.Point(703, 347)
        Me.AddListItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddListItem.Name = "AddListItem"
        Me.AddListItem.Size = New System.Drawing.Size(46, 35)
        Me.AddListItem.TabIndex = 13
        Me.AddListItem.Text = "+"
        Me.AddListItem.UseVisualStyleBackColor = True
        '
        'RecipeItemPanel
        '
        Me.RecipeItemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.RecipeItemPanel.Location = New System.Drawing.Point(582, 59)
        Me.RecipeItemPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RecipeItemPanel.Name = "RecipeItemPanel"
        Me.RecipeItemPanel.Size = New System.Drawing.Size(450, 282)
        Me.RecipeItemPanel.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(647, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ITEM NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(861, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "QUANTITY"
        '
        'ShoppingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DeleteList)
        Me.Controls.Add(Me.ModifyListButton)
        Me.Controls.Add(Me.CreateList)
        Me.Controls.Add(Me.ShoppingListLabel)
        Me.Controls.Add(Me.ShoppingListsBox)
        Me.Controls.Add(Me.ImportPanel)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Import)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.AddListItem)
        Me.Controls.Add(Me.RecipeItemPanel)
        Me.Name = "ShoppingList"
        Me.Size = New System.Drawing.Size(1186, 582)
        Me.ImportPanel.ResumeLayout(False)
        Me.ImportPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DeleteList As Button
    Friend WithEvents ModifyListButton As Button
    Friend WithEvents CreateList As Button
    Friend WithEvents ShoppingListLabel As Label
    Friend WithEvents ShoppingListsBox As ListBox
    Friend WithEvents ImportPanel As Panel
    Friend WithEvents ImportNames As ListBox
    Friend WithEvents ImportConfirm As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents Import As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents AddListItem As Button
    Friend WithEvents RecipeItemPanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
