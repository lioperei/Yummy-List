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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.recipeBox = New System.Windows.Forms.PictureBox()
        Me.inventoryBox = New System.Windows.Forms.PictureBox()
        Me.cartBox = New System.Windows.Forms.PictureBox()
        Me.RecipeButton = New System.Windows.Forms.Button()
        Me.InventoryButton = New System.Windows.Forms.Button()
        Me.ShoppingListButton = New System.Windows.Forms.Button()
        Me.ShoppingLists = New System.Windows.Forms.TabPage()
        Me.deleteListButton = New System.Windows.Forms.Button()
        Me.modifyListButton = New System.Windows.Forms.Button()
        Me.createListButton = New System.Windows.Forms.Button()
        Me.Inventory = New System.Windows.Forms.TabPage()
        Me.Recipes = New System.Windows.Forms.TabPage()
        Me.DeleteRecipe = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.CreateRecipe = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RecipeList = New System.Windows.Forms.ListBox()
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
        Me.shoppingListView = New System.Windows.Forms.ListView()
        Me.TabControl1.SuspendLayout()
        Me.Home.SuspendLayout()
        CType(Me.recipeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cartBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShoppingLists.SuspendLayout()
        Me.Recipes.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Home)
        Me.TabControl1.Controls.Add(Me.ShoppingLists)
        Me.TabControl1.Controls.Add(Me.Inventory)
        Me.TabControl1.Controls.Add(Me.Recipes)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1198, 668)
        Me.TabControl1.TabIndex = 0
        '
        'Home
        '
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
        Me.Home.UseVisualStyleBackColor = True
        '
        'recipeBox
        '
        Me.recipeBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.recipeBox.Image = Global.A1_Prototype1.My.Resources.Resources.inventorypic
        Me.recipeBox.Location = New System.Drawing.Point(653, 450)
        Me.recipeBox.Name = "recipeBox"
        Me.recipeBox.Size = New System.Drawing.Size(166, 131)
        Me.recipeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.recipeBox.TabIndex = 5
        Me.recipeBox.TabStop = False
        '
        'inventoryBox
        '
        Me.inventoryBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.inventoryBox.Image = Global.A1_Prototype1.My.Resources.Resources.recipepic
        Me.inventoryBox.Location = New System.Drawing.Point(653, 247)
        Me.inventoryBox.Name = "inventoryBox"
        Me.inventoryBox.Size = New System.Drawing.Size(166, 131)
        Me.inventoryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.inventoryBox.TabIndex = 4
        Me.inventoryBox.TabStop = False
        '
        'cartBox
        '
        Me.cartBox.BackColor = System.Drawing.Color.Navy
        Me.cartBox.Image = Global.A1_Prototype1.My.Resources.Resources.shoppingCart
        Me.cartBox.Location = New System.Drawing.Point(662, 50)
        Me.cartBox.Name = "cartBox"
        Me.cartBox.Size = New System.Drawing.Size(141, 116)
        Me.cartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cartBox.TabIndex = 3
        Me.cartBox.TabStop = False
        '
        'RecipeButton
        '
        Me.RecipeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RecipeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeButton.ForeColor = System.Drawing.Color.White
        Me.RecipeButton.Location = New System.Drawing.Point(639, 431)
        Me.RecipeButton.Name = "RecipeButton"
        Me.RecipeButton.Size = New System.Drawing.Size(510, 179)
        Me.RecipeButton.TabIndex = 2
        Me.RecipeButton.Text = "Recipes"
        Me.RecipeButton.UseVisualStyleBackColor = False
        '
        'InventoryButton
        '
        Me.InventoryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InventoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryButton.ForeColor = System.Drawing.Color.White
        Me.InventoryButton.Location = New System.Drawing.Point(639, 222)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(510, 179)
        Me.InventoryButton.TabIndex = 1
        Me.InventoryButton.Text = "Inventory"
        Me.InventoryButton.UseVisualStyleBackColor = False
        '
        'ShoppingListButton
        '
        Me.ShoppingListButton.BackColor = System.Drawing.Color.Navy
        Me.ShoppingListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShoppingListButton.ForeColor = System.Drawing.Color.White
        Me.ShoppingListButton.Location = New System.Drawing.Point(639, 17)
        Me.ShoppingListButton.Name = "ShoppingListButton"
        Me.ShoppingListButton.Size = New System.Drawing.Size(510, 179)
        Me.ShoppingListButton.TabIndex = 0
        Me.ShoppingListButton.Text = "Shopping" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "List"
        Me.ShoppingListButton.UseVisualStyleBackColor = False
        '
        'ShoppingLists
        '
        Me.ShoppingLists.Controls.Add(Me.shoppingListView)
        Me.ShoppingLists.Controls.Add(Me.deleteListButton)
        Me.ShoppingLists.Controls.Add(Me.modifyListButton)
        Me.ShoppingLists.Controls.Add(Me.createListButton)
        Me.ShoppingLists.Location = New System.Drawing.Point(4, 29)
        Me.ShoppingLists.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ShoppingLists.Name = "ShoppingLists"
        Me.ShoppingLists.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ShoppingLists.Size = New System.Drawing.Size(1190, 635)
        Me.ShoppingLists.TabIndex = 0
        Me.ShoppingLists.Text = "Shopping Lists"
        Me.ShoppingLists.UseVisualStyleBackColor = True
        '
        'deleteListButton
        '
        Me.deleteListButton.Location = New System.Drawing.Point(148, 415)
        Me.deleteListButton.Name = "deleteListButton"
        Me.deleteListButton.Size = New System.Drawing.Size(350, 96)
        Me.deleteListButton.TabIndex = 3
        Me.deleteListButton.Text = "Delete List"
        Me.deleteListButton.UseVisualStyleBackColor = True
        '
        'modifyListButton
        '
        Me.modifyListButton.Location = New System.Drawing.Point(148, 260)
        Me.modifyListButton.Name = "modifyListButton"
        Me.modifyListButton.Size = New System.Drawing.Size(350, 96)
        Me.modifyListButton.TabIndex = 2
        Me.modifyListButton.Text = "Modify List"
        Me.modifyListButton.UseVisualStyleBackColor = True
        '
        'createListButton
        '
        Me.createListButton.Location = New System.Drawing.Point(148, 112)
        Me.createListButton.Name = "createListButton"
        Me.createListButton.Size = New System.Drawing.Size(350, 96)
        Me.createListButton.TabIndex = 1
        Me.createListButton.Text = "Create New List"
        Me.createListButton.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.Inventory.Location = New System.Drawing.Point(4, 29)
        Me.Inventory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Inventory.Size = New System.Drawing.Size(1190, 635)
        Me.Inventory.TabIndex = 1
        Me.Inventory.Text = "Inventory"
        Me.Inventory.UseVisualStyleBackColor = True
        '
        'Recipes
        '
        Me.Recipes.Controls.Add(Me.DeleteRecipe)
        Me.Recipes.Controls.Add(Me.Button31)
        Me.Recipes.Controls.Add(Me.CreateRecipe)
        Me.Recipes.Controls.Add(Me.Label1)
        Me.Recipes.Controls.Add(Me.RecipeList)
        Me.Recipes.Location = New System.Drawing.Point(4, 29)
        Me.Recipes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Recipes.Name = "Recipes"
        Me.Recipes.Size = New System.Drawing.Size(1190, 635)
        Me.Recipes.TabIndex = 2
        Me.Recipes.Text = "Recipes"
        Me.Recipes.UseVisualStyleBackColor = True
        '
        'DeleteRecipe
        '
        Me.DeleteRecipe.Location = New System.Drawing.Point(276, 218)
        Me.DeleteRecipe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteRecipe.Name = "DeleteRecipe"
        Me.DeleteRecipe.Size = New System.Drawing.Size(216, 35)
        Me.DeleteRecipe.TabIndex = 4
        Me.DeleteRecipe.Text = "Delete Recipe"
        Me.DeleteRecipe.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(276, 151)
        Me.Button31.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(216, 35)
        Me.Button31.TabIndex = 3
        Me.Button31.Text = "Modify Recipe"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'CreateRecipe
        '
        Me.CreateRecipe.Location = New System.Drawing.Point(276, 92)
        Me.CreateRecipe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CreateRecipe.Name = "CreateRecipe"
        Me.CreateRecipe.Size = New System.Drawing.Size(216, 35)
        Me.CreateRecipe.TabIndex = 2
        Me.CreateRecipe.Text = "Create New Recipe"
        Me.CreateRecipe.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(544, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Recipes"
        '
        'RecipeList
        '
        Me.RecipeList.FormattingEnabled = True
        Me.RecipeList.ItemHeight = 20
        Me.RecipeList.Location = New System.Drawing.Point(56, 68)
        Me.RecipeList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RecipeList.Name = "RecipeList"
        Me.RecipeList.Size = New System.Drawing.Size(122, 104)
        Me.RecipeList.TabIndex = 0
        '
        'Button1
        '
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
        Me.HomeButton.Location = New System.Drawing.Point(1001, 701)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(167, 148)
        Me.HomeButton.TabIndex = 30
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'shoppingListView
        '
        Me.shoppingListView.Location = New System.Drawing.Point(785, 46)
        Me.shoppingListView.Name = "shoppingListView"
        Me.shoppingListView.Size = New System.Drawing.Size(361, 484)
        Me.shoppingListView.TabIndex = 4
        Me.shoppingListView.UseCompatibleStateImageBehavior = False
        '
        'Fridge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
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
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Fridge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fridge"
        Me.TabControl1.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        CType(Me.recipeBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cartBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShoppingLists.ResumeLayout(False)
        Me.Recipes.ResumeLayout(False)
        Me.Recipes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ShoppingLists As TabPage
    Friend WithEvents Inventory As TabPage
    Friend WithEvents Recipes As TabPage
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
    Friend WithEvents Label1 As Label
    Friend WithEvents RecipeList As ListBox
    Friend WithEvents CreateRecipe As Button
    Friend WithEvents DeleteRecipe As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Home As TabPage
    Friend WithEvents HomeButton As Button
    Friend WithEvents RecipeButton As Button
    Friend WithEvents InventoryButton As Button
    Friend WithEvents ShoppingListButton As Button
    Friend WithEvents recipeBox As PictureBox
    Friend WithEvents inventoryBox As PictureBox
    Friend WithEvents cartBox As PictureBox
    Friend WithEvents deleteListButton As Button
    Friend WithEvents modifyListButton As Button
    Friend WithEvents createListButton As Button
    Friend WithEvents shoppingListView As ListView
End Class
