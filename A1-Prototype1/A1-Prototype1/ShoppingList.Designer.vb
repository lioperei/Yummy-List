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
        Me.ListItemPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sendToPhoneButton = New System.Windows.Forms.Button()
        Me.splitList = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImportPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DeleteList
        '
        Me.DeleteList.BackColor = System.Drawing.Color.LavenderBlush
        Me.DeleteList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.DeleteList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteList.Location = New System.Drawing.Point(232, 274)
        Me.DeleteList.Name = "DeleteList"
        Me.DeleteList.Size = New System.Drawing.Size(99, 88)
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
        Me.ModifyListButton.Location = New System.Drawing.Point(232, 158)
        Me.ModifyListButton.Name = "ModifyListButton"
        Me.ModifyListButton.Size = New System.Drawing.Size(99, 90)
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
        Me.CreateList.Location = New System.Drawing.Point(233, 38)
        Me.CreateList.Name = "CreateList"
        Me.CreateList.Size = New System.Drawing.Size(98, 84)
        Me.CreateList.TabIndex = 19
        Me.CreateList.Text = "Create New List"
        Me.CreateList.UseVisualStyleBackColor = False
        '
        'ShoppingListLabel
        '
        Me.ShoppingListLabel.AutoSize = True
        Me.ShoppingListLabel.Font = New System.Drawing.Font("Comic Sans MS", 21.73585!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShoppingListLabel.Location = New System.Drawing.Point(11, 6)
        Me.ShoppingListLabel.Name = "ShoppingListLabel"
        Me.ShoppingListLabel.Size = New System.Drawing.Size(219, 41)
        Me.ShoppingListLabel.TabIndex = 18
        Me.ShoppingListLabel.Text = "Shopping Lists"
        '
        'ShoppingListsBox
        '
        Me.ShoppingListsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ShoppingListsBox.FormattingEnabled = True
        Me.ShoppingListsBox.ItemHeight = 20
        Me.ShoppingListsBox.Location = New System.Drawing.Point(19, 56)
        Me.ShoppingListsBox.Name = "ShoppingListsBox"
        Me.ShoppingListsBox.Size = New System.Drawing.Size(169, 304)
        Me.ShoppingListsBox.TabIndex = 17
        '
        'ImportPanel
        '
        Me.ImportPanel.Controls.Add(Me.ImportNames)
        Me.ImportPanel.Controls.Add(Me.ImportConfirm)
        Me.ImportPanel.Controls.Add(Me.Label3)
        Me.ImportPanel.Location = New System.Drawing.Point(365, 255)
        Me.ImportPanel.Name = "ImportPanel"
        Me.ImportPanel.Size = New System.Drawing.Size(323, 117)
        Me.ImportPanel.TabIndex = 16
        Me.ImportPanel.Visible = False
        '
        'ImportNames
        '
        Me.ImportNames.FormattingEnabled = True
        Me.ImportNames.Location = New System.Drawing.Point(56, 4)
        Me.ImportNames.Name = "ImportNames"
        Me.ImportNames.Size = New System.Drawing.Size(170, 95)
        Me.ImportNames.TabIndex = 4
        '
        'ImportConfirm
        '
        Me.ImportConfirm.BackColor = System.Drawing.Color.Lime
        Me.ImportConfirm.Location = New System.Drawing.Point(232, 0)
        Me.ImportConfirm.Name = "ImportConfirm"
        Me.ImportConfirm.Size = New System.Drawing.Size(75, 23)
        Me.ImportConfirm.TabIndex = 3
        Me.ImportConfirm.Text = "Import"
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
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(532, 226)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 15
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Import
        '
        Me.Import.Location = New System.Drawing.Point(372, 227)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(75, 23)
        Me.Import.TabIndex = 14
        Me.Import.Text = "IMPORT"
        Me.Import.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(613, 226)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'AddListItem
        '
        Me.AddListItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddListItem.Location = New System.Drawing.Point(453, 227)
        Me.AddListItem.Name = "AddListItem"
        Me.AddListItem.Size = New System.Drawing.Size(60, 23)
        Me.AddListItem.TabIndex = 13
        Me.AddListItem.Text = "+ ADD"
        Me.AddListItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddListItem.UseVisualStyleBackColor = True
        '
        'ListItemPanel
        '
        Me.ListItemPanel.AutoScroll = True
        Me.ListItemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ListItemPanel.Location = New System.Drawing.Point(365, 38)
        Me.ListItemPanel.Name = "ListItemPanel"
        Me.ListItemPanel.Size = New System.Drawing.Size(323, 183)
        Me.ListItemPanel.TabIndex = 12
        Me.ListItemPanel.WrapContents = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(420, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ITEM NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(574, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "QUANTITY"
        '
        'sendToPhoneButton
        '
        Me.sendToPhoneButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.sendToPhoneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.sendToPhoneButton.Location = New System.Drawing.Point(700, 37)
        Me.sendToPhoneButton.Margin = New System.Windows.Forms.Padding(2)
        Me.sendToPhoneButton.Name = "sendToPhoneButton"
        Me.sendToPhoneButton.Size = New System.Drawing.Size(76, 85)
        Me.sendToPhoneButton.TabIndex = 13
        Me.sendToPhoneButton.Text = "GO SHOPPING!"
        Me.sendToPhoneButton.UseVisualStyleBackColor = False
        '
        'splitList
        '
        Me.splitList.BackColor = System.Drawing.Color.PaleTurquoise
        Me.splitList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.26415!)
        Me.splitList.Location = New System.Drawing.Point(700, 158)
        Me.splitList.Margin = New System.Windows.Forms.Padding(2)
        Me.splitList.Name = "splitList"
        Me.splitList.Size = New System.Drawing.Size(76, 90)
        Me.splitList.TabIndex = 24
        Me.splitList.Text = "Split List"
        Me.splitList.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LavenderBlush
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(700, 274)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 86)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Set Reminder"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ShoppingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.splitList)
        Me.Controls.Add(Me.sendToPhoneButton)
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
        Me.Controls.Add(Me.ListItemPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ShoppingList"
        Me.Size = New System.Drawing.Size(791, 378)
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
    Friend WithEvents ListItemPanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sendToPhoneButton As Button
    Friend WithEvents splitList As Button
    Friend WithEvents Button1 As Button
End Class
