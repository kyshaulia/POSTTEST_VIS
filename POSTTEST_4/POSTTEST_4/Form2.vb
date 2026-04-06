Public Class FormHasil
    Public Sub SetData(
    nama As String,
    id As String,
    jabatan As String,
    kontak As String,
    hobi As String,
    foto As Image
    )
        lblNama.Text = nama
        lblID.Text = id
        lblJabatan.Text = jabatan
        lblKontak.Text = kontak
        lblHobby.Text = hobi
        pbProfil.Image = foto
    End Sub

End Class