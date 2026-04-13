Module ValidationModule

    Public Function Validasi(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Sub HanyaAngka(e As KeyPressEventArgs, ep As ErrorProvider, ctrl As Control, pesan As String)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            ep.SetError(ctrl, pesan)
        Else
            ep.SetError(ctrl, "")
        End If
    End Sub

    Public Sub HanyaHuruf(e As KeyPressEventArgs, ep As ErrorProvider, ctrl As Control, pesan As String)
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            ep.SetError(ctrl, pesan)
        Else
            ep.SetError(ctrl, "")
        End If
    End Sub

    Public Sub WajibIsiKeyPress(ctrl As Control, ep As ErrorProvider, pesan As String)
        If ctrl.Text.Trim = "" Then
            ep.SetError(ctrl, pesan)
        Else
            ep.SetError(ctrl, "")
        End If
    End Sub

End Module
