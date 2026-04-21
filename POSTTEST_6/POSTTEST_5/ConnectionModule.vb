Imports MySqlConnector

Module ConnectionModule
    Public ReadOnly ConnectionString As String =
        "Server=localhost;Port=3306;Database=db_hijab;User ID=root;Password=;ConvertZeroDateTime=True;"

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(ConnectionString)
        Return conn
    End Function
End Module
