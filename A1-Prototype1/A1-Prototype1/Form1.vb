Public Class Fridge

    Public Sub New()

        InitializeComponent()
        Phone.Show()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        FridgeTabControl.SelectedTab = Home
        ' Need to figure out how to hide home button 
    End Sub

    Private Sub FridgeTabControl_SelectedIndexChanged(ByVal sender As Object,
                                              ByVal e As System.EventArgs) _
            Handles FridgeTabControl.SelectedIndexChanged
        If FridgeTabControl.SelectedTab.Name = "Home" Then
            HomeButton.Enabled = False
        Else
            HomeButton.Enabled = True
        End If
    End Sub

    Private Sub Fridge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShoppingListButton_Click(sender As Object, e As EventArgs) Handles ShoppingListButton.Click
        FridgeTabControl.SelectedTab = ShoppingLists
    End Sub

    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        FridgeTabControl.SelectedTab = Inventory
    End Sub

    Private Sub RecipeButton_Click(sender As Object, e As EventArgs) Handles RecipeButton.Click
        FridgeTabControl.SelectedTab = RecipesTab
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles recipeBox.Click
        FridgeTabControl.SelectedTab = RecipesTab
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles cartBox.Click
        FridgeTabControl.SelectedTab = ShoppingLists
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles inventoryBox.Click
        FridgeTabControl.SelectedTab = Inventory
    End Sub

    Private Sub createListButton_Click(sender As Object, e As EventArgs) Handles createListButton.Click
        Dim listName = InputBox("Enter a list name", "New Shopping List", "")
        Console.WriteLine(listName)
        shoppingListView.Items.Add(listName)
        'create and hide new form with all the required items, with the information being pulled from an excel or notepad file 
    End Sub

    Private Sub modifyListButton_Click(sender As Object, e As EventArgs) Handles modifyListButton.Click
        ' Need to show that was hidden new form that handles a specific shopping list 
    End Sub

    Private Sub deleteListButton_Click(sender As Object, e As EventArgs) Handles deleteListButton.Click
        For Each item As ListViewItem In shoppingListView.SelectedItems
            item.Remove()
        Next
    End Sub

End Class
