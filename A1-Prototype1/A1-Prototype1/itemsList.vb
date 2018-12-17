Imports System.Web.Script.Serialization
Public Class itemsList
    Private _items As RecipeItemData
    Private itemPurchaseCount As List(Of Integer)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim iventoryJson = System.Text.Encoding.UTF8.GetString(My.Resources.Data.inventory)
        _items = New JavaScriptSerializer().Deserialize(Of RecipeItemData)(iventoryJson)
        Dim newItem
        For Each item In _items.Keys
            newItem = New RecipeItem(item, _items(item))
            InventoryItemPanel.Controls.Add(newItem)
        Next
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub LoadItems(items As RecipeItemData)
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
                newItem = New RecipeItem(item, items(item), "inventory")
                InventoryItemPanel.Controls.Add(newItem)
            End If
            _items.Add(item, items(item))
        Next
    End Sub

    Public Sub Remove(item As RecipeItem)
        _items.Remove(item._name)
        InventoryItemPanel.Controls.Remove(item)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim store = InputBox("Enter a store name", "New List Item", "")
        If Len(store) > 0 Then
            ListBox1.Items.Add(store)
        End If
    End Sub
End Class
