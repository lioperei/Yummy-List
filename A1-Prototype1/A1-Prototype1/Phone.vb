Public Class Phone
    Private _items As RecipeItemData
    Public Sub LoadShoppingList(shoppingList As Object)
        WaitingForListLabel.Visible = False
        _items = shoppingList.items
    End Sub
End Class