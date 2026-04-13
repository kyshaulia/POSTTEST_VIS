Imports MySqlConnector

Module ConnectionModule
    Public ReadOnly ConnectionString As String =
        "Server=localhost;Port=3306;Database=db_hijab;User ID=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=db_hijab")
        Return conn
    End Function
End Module
