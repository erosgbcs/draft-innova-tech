Public Class Models

End Class

Public Class Product
    Public Property Code As String
    Public Property Name As String
    Public Property Category As String
    Public Property Price As Decimal
    Public Property Stock As Integer
End Class

Public Class CartItem
    Public Property ProductCode As String
    Public Property ProductName As String
    Public Property Price As Decimal
    Public Property Quantity As Integer
    Public ReadOnly Property Subtotal As Decimal
        Get
            Return Price * Quantity
        End Get
    End Property
End Class
