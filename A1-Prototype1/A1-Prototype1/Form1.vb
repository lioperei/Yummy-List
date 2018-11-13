Public Class Fridge
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Phone.Show()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CreateRecipe_Click(sender As Object, e As EventArgs) Handles CreateRecipe.Click
        Dim message, title, recipeName
        message = "Enter a Recipe Name"
        title = "New Recipe"
        recipeName = InputBox(message, title, "")
        RecipeNames.Items.Add(recipeName)
        RecipeList1.Show()
        RecipeButtonStatus(False)
    End Sub

    Public Sub RecipeButtonStatus(value As Boolean)
        RecipeNames.Enabled = False
        CreateRecipe.Enabled = value
        ModifyRecipeButton.Enabled = value
        DeleteRecipe.Enabled = value
    End Sub

    Private Sub DeleteRecipe_Click(sender As Object, e As EventArgs) Handles DeleteRecipe.Click
        Dim selected = RecipeNames.SelectedItem
        Console.WriteLine(selected)
        If selected <> "" Then
            RecipeNames.Items.Remove(selected)
            MessageBox.Show("Recipe {0} deleted", selected)
        End If
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        FridgeTabControl.SelectedTab = Home
        ' Need to figure out how to hide home button 
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

    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        FridgeTabControl.SelectedTab = Inventory
    End Sub

    Private Sub RecipeButton_Click(sender As Object, e As EventArgs) Handles RecipeButton.Click
        FridgeTabControl.SelectedTab = Recipes
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles recipeBox.Click
        FridgeTabControl.SelectedTab = Recipes
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles cartBox.Click
        FridgeTabControl.SelectedTab = ShoppingLists
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles inventoryBox.Click
        FridgeTabControl.SelectedTab = Inventory
    End Sub
End Class
