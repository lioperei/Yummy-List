Imports System.Web.Script.Serialization
Public Class Fridge
    Public _recipes As List(Of RecipeData)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Phone.Show()
        'Recipe
        Recipelist1.Edit = False
        Dim recipeJson = System.Text.Encoding.UTF8.GetString(My.Resources.Data.test)
        _recipes = New JavaScriptSerializer().Deserialize(Of List(Of RecipeData))(recipeJson)

        For Each recipe As RecipeData In _recipes
            RecipeNames.Items.Add(recipe.Name)
        Next


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CreateRecipe_Click(sender As Object, e As EventArgs) Handles CreateRecipe.Click
        Dim message, title, recipeName
        message = "Enter a Recipe Name"
        title = "New Recipe"
        recipeName = InputBox(message, title, "")
        RecipeNames.Items.Add(recipeName)
        RecipeNames.SelectedItem = recipeName
        RecipeList1.Edit = True
        RecipeList1.Clear()
        RecipeButtonStatus(False)
    End Sub

    Public Sub RecipeButtonStatus(value As Boolean)
        CreateRecipe.Enabled = value
        ModifyRecipeButton.Enabled = value
        DeleteRecipe.Enabled = value
        RecipeNames.Enabled = value
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

    Private Sub ModifyRecipeButton_Click(sender As Object, e As EventArgs) Handles ModifyRecipeButton.Click
        RecipeList1.Edit = True
        RecipeButtonStatus(False)
    End Sub

    Private Sub RecipeNames_SelectionIndexChanged(ByVal sender As Object,
                                              ByVal e As System.EventArgs) _
            Handles RecipeNames.SelectedValueChanged
        Dim selectedItem = RecipeNames.SelectedItem
        RecipeList1.Clear()
        For Each item In _recipes
            If item.Name = selectedItem Then
                RecipeList1.LoadItems(item.Items)
                Exit For
            End If
        Next
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

    Public Sub SaveRecipe(items As Dictionary(Of String, Integer))
        Dim selectedRecipe = RecipeNames.SelectedItem
        Dim found = False
        For Each recipe As RecipeData In _recipes
            If recipe.Name = selectedRecipe Then
                recipe.Items = items
                found = True
                Exit For
            End If
        Next
        If Not found Then
            Dim newRecipe = New RecipeData
            newRecipe.Name = RecipeNames.SelectedItem
            newRecipe.Items = items
            _recipes.Add(newRecipe)
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs)
        RecipeList1.Clear()
    End Sub
End Class
