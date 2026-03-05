Public Module ModulePerpustakaan
    Public daftarBuku(99) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku) = judul & " (" & genre & ")"
            jumlahBuku += 1
        End If
    End Sub

    Public Sub HapusBuku(ByVal judul As String, ByRef ditemukan As Boolean)
        ditemukan = False
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i) = judul Then
                For j As Integer = i To jumlahBuku - 2
                    daftarBuku(j) = daftarBuku(j + 1)
                Next

                jumlahBuku -= 1
                ditemukan = True
                Exit For
            End If
        Next
    End Sub

    Public Function HitungJumlahBuku() As Integer
        Return jumlahBuku
    End Function

End Module
