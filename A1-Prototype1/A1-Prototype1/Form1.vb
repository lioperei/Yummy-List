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

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        TabControl1.SelectedTab = Home
        ' Need to figure out how to hide home button 
    End Sub

    Private Sub Fridge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShoppingListButton_Click(sender As Object, e As EventArgs) Handles ShoppingListButton.Click
        TabControl1.SelectedTab = ShoppingLists
    End Sub

    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        TabControl1.SelectedTab = Inventory
    End Sub

    Private Sub RecipeButton_Click(sender As Object, e As EventArgs) Handles RecipeButton.Click
        TabControl1.SelectedTab = Recipes
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles recipeBox.Click
        TabControl1.SelectedTab = Recipes
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles cartBox.Click
        TabControl1.SelectedTab = ShoppingLists
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles inventoryBox.Click
        TabControl1.SelectedTab = Inventory
    End Sub

    Private Sub createListButton_Click(sender As Object, e As EventArgs) Handles createListButton.Click
        Dim listName = InputBox("Enter a list name", "New Shopping List", "")
        Console.WriteLine(listName)
        shoppingListView.Items.Add(listName)
        'create and hide new form with all the required items, with the information being pulled from an excel or notepad file 
    End Sub

    Private Sub modifyListButton_Click(sender As Object, e As EventArgs) Handles modifyListButton.Click
        ' Need to show that was hidden new form that handles a specific shopping list 
    End Sub

    Private Sub deleteListButton_Click(sender As Object, e As EventArgs) Handles deleteListButton.Click
        For Each item As ListViewItem In shoppingListView.SelectedItems
            item.Remove()
        Next
    End Sub
End Class
