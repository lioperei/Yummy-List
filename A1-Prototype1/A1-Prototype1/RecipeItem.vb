Public Class RecipeItem
    Public _name As String
    Private _quantity As Integer
    Private _context As String
    Public Sub New(name As String, Optional ByVal quantity As Integer = 1, Optional ByVal context As String = "list")
        InitializeComponent()
        _name = name
        _quantity = quantity
        _context = context

        Select Case _context
            Case "phone"
                DecrementButton.Visible = False
                IncrementButton.Visible = False
                Me.Width = 229
        End Select
        ItemName.Text = _name
        UpdateQuantity()
    End Sub

    Private Sub UpdateQuantity()
        ItemQuantity.Text = CStr(_quantity)
        If _quantity = 0 Then
            DecrementButton.Enabled = False
        Else
            DecrementButton.Enabled = True
        End If
    End Sub

    Public WriteOnly Property Edit As Boolean
        Set(value As Boolean)
            RemoveButton.Visible = value
            DecrementButton.Visible = value
            IncrementButton.Visible = value
        End Set
    End Property

    Private Sub DecrementButton_Click(sender As Object, e As EventArgs) Handles DecrementButton.Click
        If _quantity > 0 Then
            _quantity = _quantity - 1
        Else
            _quantity = 0
        End If
        UpdateQuantity()
    End Sub

    Private Sub IncrementButton_Click(sender As Object, e As EventArgs) Handles IncrementButton.Click
        _quantity = _quantity + 1
        UpdateQuantity()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Select Case _context
            Case "list"
                Fridge.ShoppingList1.Remove(Me)
            Case "phone"
                Phone.PhonePanel.Controls.Remove(Me)
                Dim item = New RecipeItemData()
                item.Add(_name, _quantity)
                Fridge.InventoryList1.LoadItems(item)

                Phone.BoughtList.Controls.Add(Me)
                RemoveButton.Text = "✔"
            Case "recipe"
                Fridge.RecipeList1.Remove(Me)
            Case "inventory"
                Fridge.InventoryList1.Remove(Me)
        End Select
    End Sub

    Public Sub IncreaseQuantity(value As Integer)
        _quantity += value
        UpdateQuantity()
    End Sub

End Class
