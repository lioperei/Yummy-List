Imports System.Web.Script.Serialization
Public Class RecipeList
    Private _items As RecipeItemData
    Public _recipes As List(Of RecipeData)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.Edit = False
        _items = New RecipeItemData
        ' Add any initialization after the InitializeComponent() call.
        Dim recipeJson = System.Text.Encoding.UTF8.GetString(My.Resources.Data.test)
        _recipes = New JavaScriptSerializer().Deserialize(Of List(Of RecipeData))(recipeJson)

        For Each recipe As RecipeData In _recipes
            RecipeNames.Items.Add(recipe.Name)
        Next
    End Sub

    Private Sub CreateRecipe_Click(sender As Object, e As EventArgs) Handles CreateRecipe.Click
        Dim message, title, recipeName
        message = "Enter a Recipe Name"
        title = "New Recipe"
        recipeName = InputBox(message, title, "")
        If Len(recipeName) > 0 Then
            RecipeNames.Items.Add(recipeName)
            RecipeNames.SelectedItem = recipeName
            Edit = True
            Clear()
            RecipeButtonStatus(False)
        End If
    End Sub

    Private Sub ModifyRecipeButton_Click(sender As Object, e As EventArgs) Handles ModifyRecipeButton.Click
        If RecipeNames.SelectedItems.Count = 1 Then
            Edit = True
            RecipeButtonStatus(False)
        End If
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

    Private Sub RecipeNames_SelectionIndexChanged(ByVal sender As Object,
                                              ByVal e As System.EventArgs) Handles RecipeNames.SelectedIndexChanged
        Dim selectedItem = RecipeNames.SelectedItem
        Clear()
        For Each item In _recipes
            If item.Name = selectedItem Then
                LoadItems(item.Items)
                Exit For
            End If
        Next
    End Sub

    Private Sub DeleteRecipe_Click(sender As Object, e As EventArgs) Handles DeleteRecipe.Click
        Dim selected = RecipeNames.SelectedItem
        Console.WriteLine(selected)
        If selected <> "" Then
            RecipeNames.Items.Remove(selected)
            MessageBox.Show("Recipe: " + selected + " deleted")
        End If
    End Sub

    Public Sub RecipeButtonStatus(value As Boolean)
        CreateRecipe.Enabled = value
        ModifyRecipeButton.Enabled = value
        DeleteRecipe.Enabled = value
        RecipeNames.Enabled = value
    End Sub
    Private Sub AddRecipeItemButton_Click(sender As Object, e As EventArgs) Handles AddRecipeItem.Click
        Dim message, title, itemName
        message = "Enter a item Name"
        title = "New Recipe item"
        itemName = InputBox(message, title, "")
        If itemName.length > 0 Then
            Dim newItem = New RecipeItemData
            newItem.Add(itemName, 1)
            LoadItems(newItem)
        End If
    End Sub

    Public Sub LoadItems(items As Dictionary(Of String, Integer))
        Dim newItem As RecipeItem
        For Each item In items.Keys
            If _items.ContainsKey(item) Then
                For Each itemPanel As RecipeItem In RecipeItemPanel.Controls
                    If itemPanel._name = item Then
                        itemPanel.IncreaseQuantity(items(item))
                        Exit For
                    End If
                Next
            Else
                newItem = New RecipeItem(item, items(item))
                RecipeItemPanel.Controls.Add(newItem)
            End If
            _items.Add(item, items(item))
        Next
    End Sub

    Public WriteOnly Property Edit As Boolean
        Set(value As Boolean)
            Import.Visible = value
            AddRecipeItem.Visible = value
            Cancel.Visible = value
            SaveButton.Visible = value
            For Each item As RecipeItem In RecipeItemPanel.Controls
                item.Edit = value
            Next
        End Set
    End Property


    Public Sub Remove(item As RecipeItem)
        _items.Remove(item._name)
        RecipeItemPanel.Controls.Remove(item)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        RecipeButtonStatus(True)
        SaveRecipe(_items)
        Me.Edit = False
    End Sub

    Public Sub Clear()
        _items = New RecipeItemData
        RecipeItemPanel.Controls.Clear()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Clear()
        RecipeButtonStatus(True)
    End Sub

    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Import.Click
        ImportPanel.Visible = True
        ImportNames.Items.Clear()
        Dim importItems = New List(Of String)
        Dim currentRecipeName = RecipeNames.SelectedItem
        If RecipeNames.Items.Count > 0 Then
            For Each recipe In RecipeNames.Items
                If recipe <> currentRecipeName Then
                    ImportNames.Items.Add(recipe)
                End If
            Next
        End If
    End Sub

    Private Sub ImportConfirm_Click(sender As Object, e As EventArgs) Handles ImportConfirm.Click
        ImportPanel.Visible = False
        For Each recipe In _recipes
            If recipe.Name = ImportNames.SelectedItem Then
                LoadItems(recipe.Items)
                Exit For
            End If
        Next
    End Sub

    'Private Sub ImportNames_SelectedChanges(sender As Object, e As EventArgs) Handles ImportNames.SelectedIndexChanged
    'If ImportNames.SelectedItems.Count > 1 Then
    '       ImportConfirm.Enabled = True
    'Else
    '       ImportConfirm.Enabled = False
    'End If
    'End Sub
End Class
