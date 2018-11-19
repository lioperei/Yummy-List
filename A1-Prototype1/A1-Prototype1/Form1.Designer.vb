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
        Me.recipeBox = New System.Windows.Forms.PictureBox()
        Me.inventoryBox = New System.Windows.Forms.PictureBox()
        Me.cartBox = New System.Windows.Forms.PictureBox()
        Me.RecipeButton = New System.Windows.Forms.Button()
        Me.InventoryButton = New System.Windows.Forms.Button()
        Me.ShoppingListButton = New System.Windows.Forms.Button()
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
        CType(Me.recipeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cartBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShoppingLists.SuspendLayout()
        Me.Inventory.SuspendLayout()
        Me.RecipesTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'FridgeTabControl
        '
        Me.FridgeTabControl.Controls.Add(Me.Home)
        Me.FridgeTabControl.Controls.Add(Me.ShoppingLists)
        Me.FridgeTabControl.Controls.Add(Me.Inventory)
        Me.FridgeTabControl.Controls.Add(Me.RecipesTab)
        Me.FridgeTabControl.Location = New System.Drawing.Point(0, 0)
        Me.FridgeTabControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FridgeTabControl.Name = "FridgeTabControl"
        Me.FridgeTabControl.SelectedIndex = 0
        Me.FridgeTabControl.Size = New System.Drawing.Size(1198, 668)
        Me.FridgeTabControl.TabIndex = 0
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.SpringGreen
        Me.Home.Controls.Add(Me.recipeBox)
        Me.Home.Controls.Add(Me.inventoryBox)
        Me.Home.Controls.Add(Me.cartBox)
        Me.Home.Controls.Add(Me.RecipeButton)
        Me.Home.Controls.Add(Me.InventoryButton)
        Me.Home.Controls.Add(Me.ShoppingListButton)
        Me.Home.Location = New System.Drawing.Point(4, 29)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(1190, 635)
        Me.Home.TabIndex = 3
        Me.Home.Text = "Home"
        '
        'recipeBox
        '
        Me.recipeBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.recipeBox.Image = Global.A1_Prototype1.My.Resources.Resources.recepiepc2
        Me.recipeBox.Location = New System.Drawing.Point(920, 445)
        Me.recipeBox.Name = "recipeBox"
        Me.recipeBox.Size = New System.Drawing.Size(214, 151)
        Me.recipeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.recipeBox.TabIndex = 5
        Me.recipeBox.TabStop = False
        '
        'inventoryBox
        '
        Me.inventoryBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.inventoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inventoryBox.Image = Global.A1_Prototype1.My.Resources.Resources.recipepic
        Me.inventoryBox.Location = New System.Drawing.Point(920, 234)
        Me.inventoryBox.Name = "inventoryBox"
        Me.inventoryBox.Size = New System.Drawing.Size(214, 145)
        Me.inventoryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.inventoryBox.TabIndex = 4
        Me.inventoryBox.TabStop = False
        '
        'cartBox
        '
        Me.cartBox.BackColor = System.Drawing.Color.Navy
        Me.cartBox.Image = Global.A1_Prototype1.My.Resources.Resources.shoppingCart
        Me.cartBox.Location = New System.Drawing.Point(920, 34)
        Me.cartBox.Name = "cartBox"
        Me.cartBox.Size = New System.Drawing.Size(214, 146)
        Me.cartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cartBox.TabIndex = 3
        Me.cartBox.TabStop = False
        '
        'RecipeButton
        '
        Me.RecipeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RecipeButton.Font = New System.Drawing.Font("Comic Sans MS", 48.22641!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeButton.ForeColor = System.Drawing.Color.White
        Me.RecipeButton.Location = New System.Drawing.Point(33, 431)
        Me.RecipeButton.Name = "RecipeButton"
        Me.RecipeButton.Size = New System.Drawing.Size(1116, 178)
        Me.RecipeButton.TabIndex = 2
        Me.RecipeButton.Text = "     Recipes"
        Me.RecipeButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RecipeButton.UseVisualStyleBackColor = False
        '
        'InventoryButton
        '
        Me.InventoryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InventoryButton.Font = New System.Drawing.Font("Comic Sans MS", 48.22641!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryButton.ForeColor = System.Drawing.Color.White
        Me.InventoryButton.Location = New System.Drawing.Point(33, 220)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(1116, 178)
        Me.InventoryButton.TabIndex = 1
        Me.InventoryButton.Text = "    Inventory"
        Me.InventoryButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.InventoryButton.UseVisualStyleBackColor = False
        '
        'ShoppingListButton
        '
        Me.ShoppingListButton.BackColor = System.Drawing.Color.Navy
        Me.ShoppingListButton.Font = New System.Drawing.Font("Comic Sans MS", 48.22641!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShoppingListButton.ForeColor = System.Drawing.Color.White
        Me.ShoppingListButton.Location = New System.Drawing.Point(33, 17)
        Me.ShoppingListButton.Name = "ShoppingListButton"
        Me.ShoppingListButton.Size = New System.Drawing.Size(1116, 178)
        Me.ShoppingListButton.TabIndex = 0
        Me.ShoppingListButton.Text = "   Shopping List"
        Me.ShoppingListButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ShoppingListButton.UseVisualStyleBackColor = False
        '
        'ShoppingLists
        '
        Me.ShoppingLists.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ShoppingLists.Controls.Add(Me.ShoppingList1)
        Me.ShoppingLists.Location = New System.Drawing.Point(4, 29)
        Me.ShoppingLists.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ShoppingLists.Name = "ShoppingLists"
        Me.ShoppingLists.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ShoppingLists.Size = New System.Drawing.Size(1190, 635)
        Me.ShoppingLists.TabIndex = 0
        Me.ShoppingLists.Text = "Shopping Lists"
        '
        'ShoppingList1
        '
        Me.ShoppingList1.Location = New System.Drawing.Point(1, 17)
        Me.ShoppingList1.Name = "ShoppingList1"
        Me.ShoppingList1.Size = New System.Drawing.Size(1186, 582)
        Me.ShoppingList1.TabIndex = 0
        '
        'Inventory
        '
        Me.Inventory.Controls.Add(Me.InventoryList1)
        Me.Inventory.Location = New System.Drawing.Point(4, 29)
        Me.Inventory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Inventory.Size = New System.Drawing.Size(1190, 635)
        Me.Inventory.TabIndex = 1
        Me.Inventory.Text = "Inventory"
        Me.Inventory.UseVisualStyleBackColor = True
        '
        'InventoryList1
        '
        Me.InventoryList1.BackColor = System.Drawing.Color.Moccasin
        Me.InventoryList1.Location = New System.Drawing.Point(6, 6)
        Me.InventoryList1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.InventoryList1.Name = "InventoryList1"
        Me.InventoryList1.Size = New System.Drawing.Size(1186, 582)
        Me.InventoryList1.TabIndex = 0
        '
        'RecipesTab
        '
        Me.RecipesTab.Controls.Add(Me.RecipeList1)
        Me.RecipesTab.Location = New System.Drawing.Point(4, 29)
        Me.RecipesTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RecipesTab.Name = "RecipesTab"
        Me.RecipesTab.Size = New System.Drawing.Size(1190, 635)
        Me.RecipesTab.TabIndex = 2
        Me.RecipesTab.Text = "Recipes"
        Me.RecipesTab.UseVisualStyleBackColor = True
        '
        'RecipeList1
        '
        Me.RecipeList1.BackColor = System.Drawing.Color.LavenderBlush
        Me.RecipeList1.Location = New System.Drawing.Point(4, 5)
        Me.RecipeList1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.RecipeList1.Name = "RecipeList1"
        Me.RecipeList1.Size = New System.Drawing.Size(1172, 618)
        Me.RecipeList1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(136, 675)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Q"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(212, 675)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "W"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(362, 675)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 60)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "R"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(286, 675)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(66, 60)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "E"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(662, 675)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 60)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "I"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(586, 675)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 60)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "U"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(512, 675)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(66, 60)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Y"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(436, 675)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(66, 60)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "T"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Location = New System.Drawing.Point(807, 675)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(66, 60)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "P"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Location = New System.Drawing.Point(732, 675)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(66, 60)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "O"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Location = New System.Drawing.Point(774, 745)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(66, 60)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "L"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Location = New System.Drawing.Point(704, 745)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(66, 60)
        Me.Button12.TabIndex = 18
        Me.Button12.Text = "K"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Location = New System.Drawing.Point(628, 745)
        Me.Button13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(66, 60)
        Me.Button13.TabIndex = 17
        Me.Button13.Text = "J"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Location = New System.Drawing.Point(554, 745)
        Me.Button14.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(66, 60)
        Me.Button14.TabIndex = 16
        Me.Button14.Text = "H"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button15.Location = New System.Drawing.Point(478, 745)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(66, 60)
        Me.Button15.TabIndex = 15
        Me.Button15.Text = "G"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button16.Location = New System.Drawing.Point(404, 745)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(66, 60)
        Me.Button16.TabIndex = 14
        Me.Button16.Text = "F"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button17.Location = New System.Drawing.Point(328, 745)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(66, 60)
        Me.Button17.TabIndex = 13
        Me.Button17.Text = "D"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button18.Location = New System.Drawing.Point(254, 745)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(66, 60)
        Me.Button18.TabIndex = 12
        Me.Button18.Text = "S"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button19.Location = New System.Drawing.Point(178, 745)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(66, 60)
        Me.Button19.TabIndex = 11
        Me.Button19.Text = "A"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button20.Location = New System.Drawing.Point(657, 814)
        Me.Button20.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(66, 60)
        Me.Button20.TabIndex = 26
        Me.Button20.Text = "M"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button21.Location = New System.Drawing.Point(582, 814)
        Me.Button21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(66, 60)
        Me.Button21.TabIndex = 25
        Me.Button21.Text = "N"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button22.Location = New System.Drawing.Point(507, 814)
        Me.Button22.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(66, 60)
        Me.Button22.TabIndex = 24
        Me.Button22.Text = "B"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button23.Location = New System.Drawing.Point(432, 814)
        Me.Button23.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(66, 60)
        Me.Button23.TabIndex = 23
        Me.Button23.Text = "V"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button24.Location = New System.Drawing.Point(357, 814)
        Me.Button24.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(66, 60)
        Me.Button24.TabIndex = 22
        Me.Button24.Text = "C"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button25.Location = New System.Drawing.Point(282, 814)
        Me.Button25.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(66, 60)
        Me.Button25.TabIndex = 21
        Me.Button25.Text = "X"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button26.Location = New System.Drawing.Point(207, 814)
        Me.Button26.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(66, 60)
        Me.Button26.TabIndex = 20
        Me.Button26.Text = "Z"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button27.Location = New System.Drawing.Point(732, 814)
        Me.Button27.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(234, 60)
        Me.Button27.TabIndex = 27
        Me.Button27.Text = "CANCEL"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button28.Location = New System.Drawing.Point(849, 745)
        Me.Button28.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(117, 60)
        Me.Button28.TabIndex = 28
        Me.Button28.Text = "ENTER"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button29.Location = New System.Drawing.Point(882, 677)
        Me.Button29.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(84, 60)
        Me.Button29.TabIndex = 29
        Me.Button29.Text = "DEL"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HomeButton.Location = New System.Drawing.Point(1000, 702)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(166, 148)
        Me.HomeButton.TabIndex = 30
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Fridge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1200, 882)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Fridge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fridge"
        Me.FridgeTabControl.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        CType(Me.recipeBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cartBox, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
