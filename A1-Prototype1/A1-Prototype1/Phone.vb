Public Class Phone
    Private _items As RecipeItemData
    Public Sub LoadShoppingList(shoppingList As Object)
        _items = shoppingList.items
    End Sub
End Class