Public Class Fridge

    Public Sub New()

        InitializeComponent()
        HomeButton.Visible = True
        HomeButton.Enabled = True
        Phone.Show()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        FridgeTabControl.SelectedTab = Home
    End Sub

    Private Sub FridgeTabControl_SelectedIndexChanged(ByVal sender As Object,
                                              ByVal e As System.EventArgs) _
            Handles FridgeTabControl.SelectedIndexChanged
        If FridgeTabControl.SelectedTab.Name = "Home" Then
            HomeButton.Enabled = False
        Else
            HomeButton.Enabled = True
        End If
    End Sub

    Private Sub Fridge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShoppingListButton_Click(sender As Object, e As EventArgs) Handles ShoppingListButton.Click
        FridgeTabControl.SelectedTab = ShoppingLists
    End Sub
    Private Sub ShoppingList90_Click(sender As Object, e As EventArgs) 
        FridgeTabControl.SelectedTab = ShoppingLists
    End Sub


    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        FridgeTabControl.SelectedTab = Inventory
    End Sub

    Private Sub RecipeButton_Click(sender As Object, e As EventArgs) Handles RecipeButton.Click
        FridgeTabControl.SelectedTab = RecipesTab
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles recipeBox.Click
        FridgeTabControl.SelectedTab = RecipesTab
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles cartBox.Click
        FridgeTabControl.SelectedTab = ShoppingLists
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles inventoryBox.Click
        FridgeTabControl.SelectedTab = Inventory
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub InventoryButton90_Click(sender As Object, e As EventArgs) 
        FridgeTabControl.SelectedTab = Inventory
    End Sub

    Private Sub InventoryButton90_MouseHover(sender As Object, e As EventArgs) Handles  InventoryButton.MouseHover, inventoryBox.MouseEnter
        InventoryButton.ForeColor = Color.WhiteSmoke
    End Sub
    Private Sub InventoryButton90_MouseLeave(sender As Object, e As EventArgs) Handles  InventoryButton.MouseLeave, inventoryBox.MouseLeave
        InventoryButton.ForeColor = Color.Gold
    End Sub
    Private Sub ShoppingList90_MouseHover(sender As Object, e As EventArgs) Handles ShoppingListButton.MouseHover, cartBox.MouseEnter
        ShoppingListButton.ForeColor = Color.WhiteSmoke
    End Sub
    Private Sub ShoppingList90_MouseLeave(sender As Object, e As EventArgs) Handles ShoppingListButton.MouseLeave, cartBox.MouseLeave
        ShoppingListButton.ForeColor = Color.Gold
    End Sub
    Private Sub RecipeButton_MouseHover(sender As Object, e As EventArgs) Handles RecipeButton.MouseHover, recipeBox.MouseEnter
        RecipeButton.ForeColor = Color.WhiteSmoke
    End Sub
    Private Sub RecipeButton_MouseLeave(sender As Object, e As EventArgs) Handles RecipeButton.MouseLeave, recipeBox.MouseLeave
        RecipeButton.ForeColor = Color.Gold
    End Sub
    Private Sub HomeButton_MouseHover(sender As Object, e As EventArgs) Handles HomeButton.MouseHover
        HomeButton.ForeColor = Color.WhiteSmoke
    End Sub
    Private Sub HomeButton_MouseLeave(sender As Object, e As EventArgs) Handles HomeButton.MouseLeave
        HomeButton.ForeColor = Color.Gold
    End Sub

    Private Sub FridgeTabControl_PaddingChanged(sender As Object, e As EventArgs) Handles FridgeTabControl.PaddingChanged

    End Sub

    Private Sub FridgeTabControl_Selected(sender As Object, e As TabControlEventArgs) Handles FridgeTabControl.Selected

    End Sub

    Private Sub FridgeTabControl_TabIndexChanged(sender As Object, e As EventArgs) Handles FridgeTabControl.TabIndexChanged
        If (FridgeTabControl.TabIndex = 1 Or FridgeTabControl.TabIndex = 2 Or FridgeTabControl.TabIndex = 3) Then
            HomeButton.Visible = True
            HomeButton.Enabled = True
        Else
            HomeButton.Visible = False
            HomeButton.Enabled = False
        End If
    End Sub

    Private Sub ShoppingList1_Load(sender As Object, e As EventArgs) Handles ShoppingList1.Load

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
