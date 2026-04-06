Imports System.Security.Cryptography

Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.Text.Trim() = "" Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiRadio(grp As GroupBox, ep As ErrorProvider, pesan As String) As Boolean
        For Each c As Control In grp.Controls
            If TypeOf c Is RadioButton AndAlso DirectCast(c, RadioButton).Checked Then
                ep.SetError(grp, "")
                Return True
            End If
        Next
        ep.SetError(grp, pesan)
        Return False
    End Function

    Public Function ValidasiCheck(grp As GroupBox, ep As ErrorProvider, pesan As String) As Boolean
        For Each c As Control In grp.Controls
            If TypeOf c Is CheckBox AndAlso DirectCast(c, CheckBox).Checked Then
                ep.SetError(grp, "")
                Return True
            End If
        Next
        ep.SetError(grp, pesan)
        Return False
    End Function

    Public Function ValidasiPictureBox(ep As ErrorProvider, pb As PictureBox, pesan As String) As Boolean
        If pb.Image Is Nothing Then
            ep.SetError(pb, pesan)
            Return False
        Else
            ep.SetError(pb, "")
            Return True
        End If
    End Function

    Public Function ValidasiSemuaInput(
        ep As ErrorProvider,
        txtNama As TextBox,
        txtID As TextBox,
        mtbNoHP As MaskedTextBox,
        txtEmail As TextBox,
        txtAlamat As TextBox,
        grpJabatan As GroupBox,
        grpJK As GroupBox,
        grpHobi As GroupBox,
        pb As PictureBox
    ) As Boolean

        Dim namaValid = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        Dim idValid = ValidasiTextBox(ep, txtID, "ID tidak boleh kosong")
        Dim hpValid = ValidasiMaskedTextBox(ep, mtbNoHP, "Nomor HP belum lengkap")
        Dim emailValid = ValidasiTextBox(ep, txtEmail, "Email tidak boleh kosong")
        Dim alamatValid = ValidasiTextBox(ep, txtAlamat, "Alamat tidak boleh kosong")
        Dim jabatanValid = ValidasiRadio(grpJabatan, ep, "Pilih Jabatan ")
        Dim jkValid = ValidasiRadio(grpJK, ep, "Pilih jenis kelamin")
        Dim hobiValid = ValidasiCheck(grpHobi, ep, "Pilih minimal 1 hobi")
        Dim fotoValid = ValidasiPictureBox(ep, pb, "Pilih foto profil")

        Return namaValid And idValid And hpValid And emailValid And alamatValid And jabatanValid And jkValid And hobiValid And fotoValid
    End Function

End Module
