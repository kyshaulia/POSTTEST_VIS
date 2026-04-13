Imports MySqlConnector

Module DataModule

    Public Function GetAllHijab() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbhijab ORDER BY kodeHijab ASC"


        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim da As New MySqlDataAdapter(query, conn)
        da.Fill(dt)

        conn.Close()

        Return dt
    End Function

    Public Function SearchHijab(keyword As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String =
            "SELECT * FROM tbhijab WHERE " &
            "kodeHijab LIKE @key OR " &
            "namaHijab LIKE @key OR " &
            "kategori LIKE @key OR " &
            "warna LIKE @key OR " &
            "CAST(harga as CHAR) LIKE @key OR " &
            "CAST(stok as CHAR) LIKE @key"

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim da As New MySqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
        da.Fill(dt)


        Return dt
    End Function

    Public Function SimpanHijab(kode As String, nama As String, kategori As String, warna As String, harga As Integer, stok As Integer) As Boolean

        Dim query As String =
        "INSERT INTO tbhijab VALUES (@kode,@nama,@kategori,@warna,@harga,@stok)"

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@kode", kode)
        cmd.Parameters.AddWithValue("@nama", nama)
        cmd.Parameters.AddWithValue("@kategori", kategori)
        cmd.Parameters.AddWithValue("@warna", warna)
        cmd.Parameters.AddWithValue("@harga", harga)
        cmd.Parameters.AddWithValue("@stok", stok)

        cmd.ExecuteNonQuery()
        conn.Close()

        Return True

    End Function

    Public Function UbahHijab(kode As String, nama As String, kategori As String, warna As String, harga As Integer, stok As Integer) As Boolean

        Dim query As String =
            "UPDATE tbhijab SET namaHijab=@nama, kategori=@kategori,
             warna=@warna, harga=@harga, stok=@stok WHERE kodeHijab=@kode"

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@kode", kode)
        cmd.Parameters.AddWithValue("@nama", nama)
        cmd.Parameters.AddWithValue("@kategori", kategori)
        cmd.Parameters.AddWithValue("@warna", warna)
        cmd.Parameters.AddWithValue("@harga", harga)
        cmd.Parameters.AddWithValue("@stok", stok)

        Dim hasil As Integer = cmd.ExecuteNonQuery()
        conn.Close()

        If hasil > 0 Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function HapusHijab(kode As String) As Boolean
        Dim query As String = "DELETE FROM tbhijab WHERE kodeHijab=@kode"

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@kode", kode)
        Return cmd.ExecuteNonQuery() > 0
        conn.Close()

    End Function

    Public Function CekKodeHijab(kode As String) As Boolean
        Dim query As String = "SELECT * FROM tbhijab WHERE kodeHijab=@kode"
        Dim dt As New DataTable()

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim da As New MySqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@kode", kode)
        da.Fill(dt)

        conn.Close()

        Return dt.Rows.Count > 0
    End Function

End Module
