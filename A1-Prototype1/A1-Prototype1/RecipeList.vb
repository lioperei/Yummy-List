

Public Class RecipeList
    Private _items
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub AddRecipeButton_Click(sender As Object, e As EventArgs) Handles AddRecipeItem.Click
        Dim message, title, itemName, item
        message = "Enter a item Name"
        title = "New Recipe item"
        itemName = InputBox(message, title, "")
        If itemName.length > 0 Then
            item = New RecipeItem(itemName)
            RecipeItemPanel.Controls.Add(item)
        End If
    End Sub

    Public Sub LoadItems(items As Array)
        'Clear()
        Dim newItem As RecipeItem
        For Each item In items
            newItem = New RecipeItem(item("name"), item("quantity"))
            RecipeItemPanel.Controls.Add(newItem)
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
        RecipeItemPanel.Controls.Remove(item)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles Save.Click
        'TODO: Save to file
        Fridge.RecipeButtonStatus(True)
        Me.Edit = False
    End Sub

    Public Sub Clear()
        For Each item As Control In RecipeItemPanel.Controls
            RecipeItemPanel.Controls.Remove(item)
        Next
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Clear()
        Fridge.RecipeButtonStatus(True)
    End Sub
End Class
