Public Class Phone
    Public _items As RecipeItemData
    Public _bought As RecipeItemData
    Public shoppingLists As New List(Of RecipeData)

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
        PhonePanel.Controls.Clear()
        BoughtList.Controls.Clear()
        Dim selectedListonPhone As String = ListBox1.SelectedItem
        For Each list In shoppingLists
            If list.Name = selectedListonPhone Then
                For Each item In list.Items.Keys
                    PhonePanel.Controls.Add(New RecipeItem(item, list.Items(item), "phone"))
                Next
                Exit For
            End If
        Next
    End Sub

    Public Sub loadLists(lists As List(Of RecipeData))
        shoppingLists = lists
        ListBox1.Items.Clear()
        For Each list In shoppingLists
            ListBox1.Items.Add(list.Name)
        Next
    End Sub

End Class