Public Class RecipeList
    Private _items As RecipeItemData
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _items = New RecipeItemData
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub AddRecipeItemButton_Click(sender As Object, e As EventArgs) Handles AddRecipeItem.Click
        Dim message, title, itemName, item
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
            Save.Visible = value
            For Each item As RecipeItem In RecipeItemPanel.Controls
                item.Edit = value
            Next
        End Set
    End Property


    Public Sub Remove(item As RecipeItem)
        _items.Remove(item._name)
        RecipeItemPanel.Controls.Remove(item)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles Save.Click
        Fridge.RecipeButtonStatus(True)
        Fridge.SaveRecipe(_items)
        Me.Edit = False
    End Sub

    Public Sub Clear()
        _items = New RecipeItemData
        RecipeItemPanel.Controls.Clear()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Clear()
        Fridge.RecipeButtonStatus(True)
    End Sub

    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Import.Click
        ImportNames.Items.Clear()
        Dim importItems = New List(Of String)
        Dim currentRecipeName = Fridge.RecipeNames.SelectedItem
        If Fridge.RecipeNames.Items.Count > 0 Then
            For Each recipe In Fridge.RecipeNames.Items
                If recipe <> currentRecipeName Then
                    ImportNames.Items.Add(recipe)
                End If
            Next
        End If
    End Sub

    Private Sub ImportConfirm_Click(sender As Object, e As EventArgs) Handles ImportConfirm.Click
        For Each recipe In Fridge._recipes
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
