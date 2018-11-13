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
        Console.WriteLine(recipeName)
        RecipeList.Items.Add(recipeName)
    End Sub

    Private Sub DeleteRecipe_Click(sender As Object, e As EventArgs) Handles DeleteRecipe.Click
        Dim selected = RecipeList.SelectedItem
        Console.WriteLine(selected)
        If selected Then
            RecipeList.Items.Remove(selected)
            MessageBox.Show("Recipe {0} deleted", selected)
        End If
    End Sub

    Private Sub ShoppingList_Click(sender As Object, e As EventArgs) Handles ShoppingList.Click
        TabControl1.SelectedTab = ShoppingLists
    End Sub

    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        TabControl1.SelectedTab = Inventory
    End Sub

    Private Sub RecipeButton_Click(sender As Object, e As EventArgs) Handles RecipeButton.Click
        TabControl1.SelectedTab = Recipes
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        TabControl1.SelectedTab = Home
        ' Need to figure out how to hide home button 
    End Sub
End Class
