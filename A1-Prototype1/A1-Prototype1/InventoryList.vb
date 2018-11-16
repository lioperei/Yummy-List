Imports System.Web.Script.Serialization
Public Class InventoryList
    Private _items As RecipeItemData

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _items = New RecipeItemData
        Dim iventoryJson = System.Text.Encoding.UTF8.GetString(My.Resources.Data.inventory)
        _items = New JavaScriptSerializer().Deserialize(Of RecipeItemData)(iventoryJson)
        Dim newItem
        For Each item In _items.Keys
            newItem = New RecipeItem(item, _items(item))
            InventoryItemPanel.Controls.Add(newItem)
        Next

    End Sub

    Public Sub LoadItems(items As Dictionary(Of String, Integer))
        Dim newItem As RecipeItem
        For Each item In items.Keys
            If _items.ContainsKey(item) Then
                For Each itemPanel As RecipeItem In InventoryItemPanel.Controls
                    If itemPanel._name = item Then
                        itemPanel.IncreaseQuantity(items(item))
                        Exit For
                    End If
                Next
            Else
                newItem = New RecipeItem(item, items(item))
                InventoryItemPanel.Controls.Add(newItem)
            End If
            _items.Add(item, items(item))
        Next
    End Sub

End Class
