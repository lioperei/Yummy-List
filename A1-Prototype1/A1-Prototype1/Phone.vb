Public Class Phone
    Private _items As RecipeItemData
    Private _bought As RecipeItemData

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.BackgroundImage = My.Resources.Data.phonesmall
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub LoadShoppingList(shoppingList As Object)
        _items = shoppingList.items
    End Sub

    Public Sub LoadBoughtList(shoppingList As Object)
        _items = shoppingList.items
    End Sub
    Public Sub Remove(item As RecipeItem)
        '_items.Remove(item._name)
        item.Enabled = False
        'PhonePanel.Controls.Remove(item)
    End Sub
End Class