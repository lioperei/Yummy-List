Imports System.Web.Script.Serialization
Public Class ShoppingList
    Private _items As RecipeItemData
    Public _lists As List(Of RecipeData)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.Edit = False
        _items = New RecipeItemData
        ' Add any initialization after the InitializeComponent() call.
        Dim listJson = System.Text.Encoding.UTF8.GetString(My.Resources.listTest)
        _lists = New JavaScriptSerializer().Deserialize(Of List(Of RecipeData))(listJson)

        For Each list As RecipeData In _lists
            ShoppingListsBox.Items.Add(list.Name)
        Next
    End Sub

    Private Sub CreateList_Click(sender As Object, e As EventArgs) Handles CreateList.Click
        Dim listName = InputBox("Enter a shopping list name", "New Shopping List", "")
        If Len(listName) > 0 Then
            ShoppingListsBox.Items.Add(listName)
            ShoppingListsBox.SelectedItem = listName
            Edit = True
            Clear()
            ListButtonStatus(False)
        End If
    End Sub

    Private Sub ModifyListButton_Click(sender As Object, e As EventArgs) Handles ModifyListButton.Click
        If ShoppingListsBox.SelectedItems.Count = 1 Then
            Edit = True
            ListButtonStatus(False)
        End If
    End Sub

    Public Sub SaveList(items As Dictionary(Of String, Integer))
        Dim selectedList = ShoppingListsBox.SelectedItem
        Dim found = False
        For Each item As RecipeData In _lists
            If item.Name = selectedList Then
                item.Items = items
                found = True
                Exit For
            End If
        Next
        If Not found Then
            Dim newList = New RecipeData
            newList.Name = ShoppingListsBox.SelectedItem
            newList.Items = items
            _lists.Add(newList)
        End If
    End Sub

    Private Sub ShoppingListsBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShoppingListsBox.SelectedIndexChanged
        Dim selecteditem = ShoppingListsBox.SelectedItem
        Clear()
        For Each item In _lists
            If item.Name = selecteditem Then
                LoadItems(item.Items)
                Exit For
            End If
        Next
    End Sub

    Private Sub DeleteList_Click(sender As Object, e As EventArgs) Handles DeleteList.Click
        Dim selected = ShoppingListsBox.SelectedItem
        Console.WriteLine(selected)
        If selected <> "" Then
            ShoppingListsBox.Items.Remove(selected)
            MessageBox.Show("Recipe: " + selected + " deleted")
        End If
    End Sub

    Public Sub ListButtonStatus(value As Boolean)
        CreateList.Enabled = value
        ModifyListButton.Enabled = value
        DeleteList.Enabled = value
        ShoppingListsBox.Enabled = value
    End Sub

    Private Sub AddListItem_Click(sender As Object, e As EventArgs) Handles AddListItem.Click
        Dim itemName = InputBox("Enter an item name", "New List Item", "")
        If Len(itemName) > 0 Then
            Dim newItem = New RecipeItemData
            newItem.Add(itemName, 1)
            LoadItems(newItem)
        End If
    End Sub

    Public Sub LoadItems(items As Dictionary(Of String, Integer))
        Dim newItem As RecipeItem
        For Each item In items.Keys
            If _items.ContainsKey(item) Then
                For Each itemPanel As RecipeItem In ListItemPanel.Controls
                    If itemPanel._name = item Then
                        itemPanel.IncreaseQuantity(items(item))
                        Exit For
                    End If
                Next
            Else
                newItem = New RecipeItem(item, items(item))
                ListItemPanel.Controls.Add(newItem)
            End If
            _items.Add(item, items(item))
        Next
        Edit = Not ModifyListButton.Enabled
    End Sub

    Public WriteOnly Property Edit As Boolean
        Set(value As Boolean)
            Import.Visible = value
            AddListItem.Visible = value
            Cancel.Visible = value
            SaveButton.Visible = value
            For Each item As RecipeItem In ListItemPanel.Controls
                item.Edit = value
            Next
        End Set
    End Property

    Public Sub Remove(item As RecipeItem)
        _items.Remove(item._name)
        ListItemPanel.Controls.Remove(item)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ListButtonStatus(True)
        SaveList(_items)
        Me.Edit = False
    End Sub

    Public Sub Clear()
        _items = New RecipeItemData
        ListItemPanel.Controls.Clear()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Clear()
        ListButtonStatus(True)
    End Sub

    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Import.Click
        ImportPanel.Visible = True
        ImportNames.Items.Clear()
        Dim importItems = New List(Of String)
        Dim currentlistName = ShoppingListsBox.SelectedItem
        If ShoppingListsBox.Items.Count > 0 Then
            For Each item In ShoppingListsBox.Items
                If item <> currentlistName Then
                    ImportNames.Items.Add(item)
                End If
            Next
        End If
    End Sub

    Public Sub LoadItemsToPhone(items As Dictionary(Of String, Integer))
        Dim newItem As RecipeItem
        For Each item In items.Keys
            If _items.ContainsKey(item) Then
                For Each itemPanel As RecipeItem In Phone.PhonePanel.Controls
                    If itemPanel._name = item Then
                        itemPanel.IncreaseQuantity(items(item))
                        Exit For
                    End If
                Next
            Else
                newItem = New RecipeItem(item, items(item))
                Phone.PhonePanel.Controls.Add(newItem)
            End If
            _items.Add(item, items(item))
        Next
        Edit = Not ModifyListButton.Enabled
    End Sub

    Private Sub sendToPhoneButton_Click(sender As Object, e As EventArgs) Handles sendToPhoneButton.Click
        Dim selectedItem = ShoppingListsBox.SelectedItem
        Clear()
        For Each item In _lists
            If item.Name = selectedItem Then
                LoadItemsToPhone(item.Items)
                Exit For
            End If
        Next
        Phone.Show()
    End Sub
End Class
