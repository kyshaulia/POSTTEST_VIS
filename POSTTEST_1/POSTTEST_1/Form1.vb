Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If IsNumeric(txtIPS.Text) Then
            Dim ips As Double = CDbl(txtIPS.Text)

            totalIP += ips
            jumlahSemester += 1

            Dim ipk As Double = totalIP / jumlahSemester
            txtIPK.Text = Format(ipk, "0.00")

			If ipk >= 2.0 And ipk <= 2.75 Then
				lblPredikat.Text = "Cukup"
			ElseIf ipk >= 2.76 And ipk <= 3.0 Then
				lblPredikat.Text = "Memuaskan"
			ElseIf ipk >= 3.01 Then
				lblPredikat.Text = "Sangat Memuaskan"
			Else
				lblPredikat.Text = "-"
			End If

			txtIPS.Text = ""
			txtIPS.Focus()

        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
		jumlahSemester = 0

		txtIPS.Text = ""
		txtIPK.Text = ""
		lblPredikat.Text = ""

    End Sub

End Class