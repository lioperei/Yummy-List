Public Class RecipeList

    Private _recipes As Dictionary(Of String, Integer)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub AddRecipeButton_Click(sender As Object, e As EventArgs) Handles AddRecipeButton.Click
        Dim message, title, itemName, item
        message = "Enter a item Name"
        title = "New Recipe item"
        itemName = InputBox(message, title, "")
        item = New RecipeItem(itemName)
        RecipeItemPanel.Controls.Add(item)
    End Sub

    Public Sub Remove(item As RecipeItem)
        RecipeItemPanel.Controls.Remove(item)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'TODO: Save to file
        Me.Hide()
        Fridge.RecipeButtonStatus(True)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        'TODO

    End Sub
End Class
