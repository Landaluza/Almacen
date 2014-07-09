

Class spPaletsProducidos2
    inherits sp

    Public Shared scc As String
    Public Shared message As String

    Public Sub New()
        MyBase.New("[dbo].[PaletsProducidos5Select]", "[dbo].[PaletsProducidos5Insert]", "[dbo].[PaletsProducidos5Update]", _
                   String.Empty, "PaletsProducidos5SelectDgv", "PaletsProducidos3SelectByFormatoEnvasadoID")
    End Sub
End Class
