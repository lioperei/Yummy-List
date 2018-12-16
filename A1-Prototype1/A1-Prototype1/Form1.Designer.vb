<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fridge
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.FridgeTabControl = New System.Windows.Forms.TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.cartBox = New System.Windows.Forms.PictureBox()
        Me.ShoppingListButton = New System.Windows.Forms.Button()
        Me.ShoppingList90 = New System.Windows.Forms.Button()
        Me.inventoryBox = New System.Windows.Forms.PictureBox()
        Me.InventoryButton = New System.Windows.Forms.Button()
        Me.InventoryButton90 = New System.Windows.Forms.Button()
        Me.recipeBox = New System.Windows.Forms.PictureBox()
        Me.RecipeButton = New System.Windows.Forms.Button()
        Me.ShoppingLists = New System.Windows.Forms.TabPage()
        Me.ShoppingList1 = New A1_Prototype1.ShoppingList()
        Me.Inventory = New System.Windows.Forms.TabPage()
        Me.InventoryList1 = New A1_Prototype1.InventoryList()
        Me.RecipesTab = New System.Windows.Forms.TabPage()
        Me.RecipeList1 = New A1_Prototype1.RecipeList()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.FridgeTabControl.SuspendLayout()
        Me.Home.SuspendLayout()
        CType(Me.cartBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.recipeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShoppingLists.SuspendLayout()
        Me.Inventory.SuspendLayout()
        Me.RecipesTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'FridgeTabControl
        '
        Me.FridgeTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.FridgeTabControl.Controls.Add(Me.Home)
        Me.FridgeTabControl.Controls.Add(Me.ShoppingLists)
        Me.FridgeTabControl.Controls.Add(Me.Inventory)
        Me.FridgeTabControl.Controls.Add(Me.RecipesTab)
        Me.FridgeTabControl.Location = New System.Drawing.Point(0, 0)
        Me.FridgeTabControl.Name = "FridgeTabControl"
        Me.FridgeTabControl.Padding = New System.Drawing.Point(0, 0)
        Me.FridgeTabControl.SelectedIndex = 0
        Me.FridgeTabControl.Size = New System.Drawing.Size(795, 434)
        Me.FridgeTabControl.TabIndex = 0
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Home.Controls.Add(Me.cartBox)
        Me.Home.Controls.Add(Me.ShoppingListButton)
        Me.Home.Controls.Add(Me.ShoppingList90)
        Me.Home.Controls.Add(Me.inventoryBox)
        Me.Home.Controls.Add(Me.InventoryButton)
        Me.Home.Controls.Add(Me.InventoryButton90)
        Me.Home.Controls.Add(Me.recipeBox)
        Me.Home.Controls.Add(Me.RecipeButton)
        Me.Home.Location = New System.Drawing.Point(4, 25)
        Me.Home.Margin = New System.Windows.Forms.Padding(2)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(787, 405)
        Me.Home.TabIndex = 3
        Me.Home.Text = "Home"
        '
        'cartBox
        '
        Me.cartBox.BackColor = System.Drawing.Color.Navy
        Me.cartBox.Image = Global.A1_Prototype1.My.Resources.Resources.shoppingCart
        Me.cartBox.Location = New System.Drawing.Point(623, 289)
        Me.cartBox.Margin = New System.Windows.Forms.Padding(2)
        Me.cartBox.Name = "cartBox"
        Me.cartBox.Size = New System.Drawing.Size(143, 95)
        Me.cartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cartBox.TabIndex = 3
        Me.cartBox.TabStop = False
        '
        'ShoppingListButton
        '
        Me.ShoppingListButton.BackColor = System.Drawing.Color.Navy
        Me.ShoppingListButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShoppingListButton.Font = New System.Drawing.Font("Comic Sans MS", 40.07547!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShoppingListButton.ForeColor = System.Drawing.Color.Gold
        Me.ShoppingListButton.Location = New System.Drawing.Point(22, 11)
        Me.ShoppingListButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ShoppingListButton.Name = "ShoppingListButton"
        Me.ShoppingListButton.Size = New System.Drawing.Size(744, 116)
        Me.ShoppingListButton.TabIndex = 0
        Me.ShoppingListButton.Text = "Shopping List"
        Me.ShoppingListButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ShoppingListButton.UseVisualStyleBackColor = False
        '
        'ShoppingList90
        '
        Me.ShoppingList90.BackColor = System.Drawing.Color.Navy
        Me.ShoppingList90.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShoppingList90.Font = New System.Drawing.Font("Comic Sans MS", 40.07547!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShoppingList90.ForeColor = System.Drawing.Color.Gold
        Me.ShoppingList90.Location = New System.Drawing.Point(623, 123)
        Me.ShoppingList90.Margin = New System.Windows.Forms.Padding(2)
        Me.ShoppingList90.Name = "ShoppingList90"
        Me.ShoppingList90.Size = New System.Drawing.Size(143, 273)
        Me.ShoppingList90.TabIndex = 7
        Me.ShoppingList90.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ShoppingList90.UseVisualStyleBackColor = False
        '
        'inventoryBox
        '
        Me.inventoryBox.BackColor = System.Drawing.Color.Navy
        Me.inventoryBox.Image = Global.A1_Prototype1.My.Resources.Resources.recipepic
        Me.inventoryBox.Location = New System.Drawing.Point(446, 289)
        Me.inventoryBox.Margin = New System.Windows.Forms.Padding(2)
        Me.inventoryBox.Name = "inventoryBox"
        Me.inventoryBox.Size = New System.Drawing.Size(143, 98)
        Me.inventoryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.inventoryBox.TabIndex = 4
        Me.inventoryBox.TabStop = False
        '
        'InventoryButton
        '
        Me.InventoryButton.BackColor = System.Drawing.Color.Navy
        Me.InventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.InventoryButton.Font = New System.Drawing.Font("Comic Sans MS", 40.07547!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryButton.ForeColor = System.Drawing.Color.Gold
        Me.InventoryButton.Location = New System.Drawing.Point(22, 143)
        Me.InventoryButton.Margin = New System.Windows.Forms.Padding(2)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(567, 116)
        Me.InventoryButton.TabIndex = 1
        Me.InventoryButton.Text = "Inventory"
        Me.InventoryButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.InventoryButton.UseVisualStyleBackColor = False
        '
        'InventoryButton90
        '
        Me.InventoryButton90.BackColor = System.Drawing.Color.Navy
        Me.InventoryButton90.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.InventoryButton90.Font = New System.Drawing.Font("Comic Sans MS", 40.07547!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryButton90.ForeColor = System.Drawing.Color.Gold
        Me.InventoryButton90.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.InventoryButton90.Location = New System.Drawing.Point(446, 143)
        Me.InventoryButton90.Margin = New System.Windows.Forms.Padding(2)
        Me.InventoryButton90.Name = "InventoryButton90"
        Me.InventoryButton90.Size = New System.Drawing.Size(143, 253)
        Me.InventoryButton90.TabIndex = 6
        Me.InventoryButton90.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.InventoryButton90.UseVisualStyleBackColor = False
        '
        'recipeBox
        '
        Me.recipeBox.BackColor = System.Drawing.Color.Navy
        Me.recipeBox.Image = Global.A1_Prototype1.My.Resources.Resources.recepiepc2
        Me.recipeBox.Location = New System.Drawing.Point(265, 289)
        Me.recipeBox.Margin = New System.Windows.Forms.Padding(2)
        Me.recipeBox.Name = "recipeBox"
        Me.recipeBox.Size = New System.Drawing.Size(143, 98)
        Me.recipeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.recipeBox.TabIndex = 5
        Me.recipeBox.TabStop = False
        '
        'RecipeButton
        '
        Me.RecipeButton.BackColor = System.Drawing.Color.Navy
        Me.RecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RecipeButton.Font = New System.Drawing.Font("Comic Sans MS", 40.07547!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeButton.ForeColor = System.Drawing.Color.Gold
        Me.RecipeButton.Location = New System.Drawing.Point(22, 280)
        Me.RecipeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeButton.Name = "RecipeButton"
        Me.RecipeButton.Size = New System.Drawing.Size(396, 116)
        Me.RecipeButton.TabIndex = 2
        Me.RecipeButton.Text = "Recipes"
        Me.RecipeButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RecipeButton.UseVisualStyleBackColor = False
        '
        'ShoppingLists
        '
        Me.ShoppingLists.BackColor = System.Drawing.Color.Yellow
        Me.ShoppingLists.Controls.Add(Me.ShoppingList1)
        Me.ShoppingLists.Location = New System.Drawing.Point(4, 25)
        Me.ShoppingLists.Name = "ShoppingLists"
        Me.ShoppingLists.Padding = New System.Windows.Forms.Padding(3)
        Me.ShoppingLists.Size = New System.Drawing.Size(787, 405)
        Me.ShoppingLists.TabIndex = 0
        Me.ShoppingLists.Text = "Shopping Lists"
        '
        'ShoppingList1
        '
        Me.ShoppingList1.Location = New System.Drawing.Point(1, 11)
        Me.ShoppingList1.Margin = New System.Windows.Forms.Padding(1)
        Me.ShoppingList1.Name = "ShoppingList1"
        Me.ShoppingList1.Size = New System.Drawing.Size(791, 378)
        Me.ShoppingList1.TabIndex = 0
        '
        'Inventory
        '
        Me.Inventory.Controls.Add(Me.InventoryList1)
        Me.Inventory.Location = New System.Drawing.Point(4, 25)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Padding = New System.Windows.Forms.Padding(3)
        Me.Inventory.Size = New System.Drawing.Size(787, 405)
        Me.Inventory.TabIndex = 1
        Me.Inventory.Text = "Inventory"
        Me.Inventory.UseVisualStyleBackColor = True
        '
        'InventoryList1
        '
        Me.InventoryList1.BackColor = System.Drawing.Color.Moccasin
        Me.InventoryList1.Location = New System.Drawing.Point(4, 4)
        Me.InventoryList1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InventoryList1.Name = "InventoryList1"
        Me.InventoryList1.Size = New System.Drawing.Size(791, 403)
        Me.InventoryList1.TabIndex = 0
        '
        'RecipesTab
        '
        Me.RecipesTab.Controls.Add(Me.RecipeList1)
        Me.RecipesTab.Location = New System.Drawing.Point(4, 25)
        Me.RecipesTab.Name = "RecipesTab"
        Me.RecipesTab.Size = New System.Drawing.Size(787, 405)
        Me.RecipesTab.TabIndex = 2
        Me.RecipesTab.Text = "Recipes"
        Me.RecipesTab.UseVisualStyleBackColor = True
        '
        'RecipeList1
        '
        Me.RecipeList1.BackColor = System.Drawing.Color.Teal
        Me.RecipeList1.Location = New System.Drawing.Point(3, 3)
        Me.RecipeList1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RecipeList1.Name = "RecipeList1"
        Me.RecipeList1.Size = New System.Drawing.Size(781, 402)
        Me.RecipeList1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(31, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Q"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(81, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "W"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(181, 439)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 39)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "R"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(131, 439)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 39)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "E"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(381, 439)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(44, 39)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "I"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(331, 439)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(44, 39)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "U"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.Location = New System.Drawing.Point(281, 439)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(44, 39)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Y"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button8.Location = New System.Drawing.Point(231, 439)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(44, 39)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "T"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button9.Location = New System.Drawing.Point(478, 439)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(44, 39)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "P"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.Location = New System.Drawing.Point(428, 439)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(44, 39)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "O"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button11.Location = New System.Drawing.Point(456, 484)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(44, 39)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "L"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button12.Location = New System.Drawing.Point(409, 484)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(44, 39)
        Me.Button12.TabIndex = 18
        Me.Button12.Text = "K"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button13.Location = New System.Drawing.Point(359, 484)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(44, 39)
        Me.Button13.TabIndex = 17
        Me.Button13.Text = "J"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button14.Location = New System.Drawing.Point(309, 484)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(44, 39)
        Me.Button14.TabIndex = 16
        Me.Button14.Text = "H"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button15.Location = New System.Drawing.Point(259, 484)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(44, 39)
        Me.Button15.TabIndex = 15
        Me.Button15.Text = "G"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button16.Location = New System.Drawing.Point(209, 484)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(44, 39)
        Me.Button16.TabIndex = 14
        Me.Button16.Text = "F"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button17.Location = New System.Drawing.Point(159, 484)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(44, 39)
        Me.Button17.TabIndex = 13
        Me.Button17.Text = "D"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button18.Location = New System.Drawing.Point(109, 484)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(44, 39)
        Me.Button18.TabIndex = 12
        Me.Button18.Text = "S"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button19.Location = New System.Drawing.Point(59, 484)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(44, 39)
        Me.Button19.TabIndex = 11
        Me.Button19.Text = "A"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button20.Location = New System.Drawing.Point(378, 529)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(44, 39)
        Me.Button20.TabIndex = 26
        Me.Button20.Text = "M"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button21.Location = New System.Drawing.Point(328, 529)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(44, 39)
        Me.Button21.TabIndex = 25
        Me.Button21.Text = "N"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button22.Location = New System.Drawing.Point(278, 529)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(44, 39)
        Me.Button22.TabIndex = 24
        Me.Button22.Text = "B"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button23.Location = New System.Drawing.Point(228, 529)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(44, 39)
        Me.Button23.TabIndex = 23
        Me.Button23.Text = "V"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button24.Location = New System.Drawing.Point(178, 529)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(44, 39)
        Me.Button24.TabIndex = 22
        Me.Button24.Text = "C"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button25.Location = New System.Drawing.Point(128, 529)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(44, 39)
        Me.Button25.TabIndex = 21
        Me.Button25.Text = "X"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button26.Location = New System.Drawing.Point(78, 529)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(44, 39)
        Me.Button26.TabIndex = 20
        Me.Button26.Text = "Z"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button27.Location = New System.Drawing.Point(428, 529)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(156, 39)
        Me.Button27.TabIndex = 27
        Me.Button27.Text = "CANCEL"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button28.Location = New System.Drawing.Point(506, 484)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(78, 39)
        Me.Button28.TabIndex = 28
        Me.Button28.Text = "ENTER"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button29.Location = New System.Drawing.Point(528, 440)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(56, 39)
        Me.Button29.TabIndex = 29
        Me.Button29.Text = "DEL"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.Navy
        Me.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HomeButton.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.ForeColor = System.Drawing.Color.Gold
        Me.HomeButton.Location = New System.Drawing.Point(604, 440)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(191, 128)
        Me.HomeButton.TabIndex = 30
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'Fridge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 573)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FridgeTabControl)
        Me.Name = "Fridge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fridge"
        Me.FridgeTabControl.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        CType(Me.cartBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.recipeBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShoppingLists.ResumeLayout(False)
        Me.Inventory.ResumeLayout(False)
        Me.RecipesTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FridgeTabControl As TabControl
    Friend WithEvents ShoppingLists As TabPage
    Friend WithEvents Inventory As TabPage
    Friend WithEvents RecipesTab As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Home As TabPage
    Friend WithEvents HomeButton As Button
    Friend WithEvents RecipeButton As Button
    Friend WithEvents InventoryButton As Button
    Friend WithEvents ShoppingListButton As Button
    Friend WithEvents recipeBox As PictureBox
    Friend WithEvents inventoryBox As PictureBox
    Friend WithEvents cartBox As PictureBox
    Friend WithEvents RecipeList1 As RecipeList
    Friend WithEvents InventoryList1 As InventoryList
    Friend WithEvents ShoppingList1 As ShoppingList
    Friend WithEvents InventoryButton90 As Button
    Friend WithEvents ShoppingList90 As Button
End Class
