Imports System.IO
Imports System.Text

Module DataModule
    Public Function BuatIsiFile(
        nama As String,
        id As String,
        tglLahir As String,
        jk As String,
        jabatan As String,
        noHp As String,
        email As String,
        alamat As String,
        hobi As String
    ) As String

        Dim sb As New StringBuilder()
        sb.AppendLine("Nama=" & nama)
        sb.AppendLine("ID=" & id)
        sb.AppendLine("TanggalLahir=" & tglLahir)
        sb.AppendLine("JenisKelamin=" & jk)
        sb.AppendLine("Jabatan=" & jabatan)
        sb.AppendLine("NoHP=" & noHp)
        sb.AppendLine("Email=" & email)
        sb.AppendLine("Alamat=" & alamat)
        sb.Append("Hobi=" & hobi)
        Return sb.ToString()
    End Function

    Public Function SimpanDataKeFile(
        sfd As SaveFileDialog,
        isi As String,
        namaDefault As String
    ) As Boolean

        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.FileName = namaDefault
        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi)
            Return True
        End If
        Return False
    End Function

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"
        If ofd.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        End If

        Dim hasil As New Dictionary(Of String, String)
        Dim baris() As String = File.ReadAllLines(ofd.FileName)
        For Each b As String In baris
            If b.Trim() = "" Then Continue For

            Dim bagian() As String = b.Split("="c)
            If bagian.Length = 2 Then
                hasil(bagian(0)) = bagian(1)
            End If
        Next
        Return hasil
    End Function

    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data.ContainsKey(key) Then
            Return data(key)
        End If
        Return ""
    End Function

End Module
