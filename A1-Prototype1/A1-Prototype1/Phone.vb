Public Class Phone
    Public _items As RecipeItemData
    Public _bought As RecipeItemData
    Public shoppingLists As New List(Of Dictionary(Of String, Integer))

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PhonePanel.Controls.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Visible = True Then
            ListBox1.Visible = False
        Else
            ListBox1.Visible = True
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.Visible = False
        'Load items in from lists
        Dim selectedListonPhone As Integer
        selectedListonPhone = ListBox1.SelectedIndex
        Dim items As Dictionary(Of String, Integer)
        items = shoppingLists.Item(selectedListonPhone)

        'Load list item
        Dim newItem As RecipeItem
        For Each item In items.Keys
            If _items.ContainsKey(item) Then
                For Each itemPanel As RecipeItem In PhonePanel.Controls
                    If itemPanel._name = item Then
                        itemPanel.IncreaseQuantity(items(item))
                        Exit For
                    End If
                Next
            Else
                newItem = New RecipeItem(item, items(item), "phone")
                PhonePanel.Controls.Add(newItem)
            End If
            _items.Add(item, items(item))
        Next

    End Sub
End Class