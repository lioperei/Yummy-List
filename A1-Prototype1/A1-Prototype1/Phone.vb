﻿Public Class Phone
    Private _items As RecipeItemData
    Public Sub LoadShoppingList(shoppingList As Object)
        _items = shoppingList.items
    End Sub

    Public Sub Remove(item As RecipeItem)
        '_items.Remove(item._name)
        item.Enabled = False
        'PhonePanel.Controls.Remove(item)
    End Sub
End Class