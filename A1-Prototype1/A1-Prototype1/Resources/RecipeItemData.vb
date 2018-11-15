Public Class RecipeItemData
    Inherits Dictionary(Of String, Integer)

    Public Overloads Sub Add(ByRef key As String, ByVal value As Integer)
        If Me.ContainsKey(key) Then
            Dim old = Me(key)
            Me(key) = old + value
        Else
            Me(key) = value
        End If
    End Sub
End Class
