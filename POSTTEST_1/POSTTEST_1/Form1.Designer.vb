<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		lblIPS = New Label()
		lblIPK = New Label()
		txtIPS = New TextBox()
		txtIPK = New TextBox()
		btnTambah = New Button()
		btnReset = New Button()
		lblPredikat = New Label()
		SuspendLayout()
		' 
		' lblIPS
		' 
		lblIPS.AutoSize = True
		lblIPS.Location = New Point(128, 89)
		lblIPS.Name = "lblIPS"
		lblIPS.Size = New Size(86, 20)
		lblIPS.TabIndex = 0
		lblIPS.Text = "IP Semester"
		' 
		' lblIPK
		' 
		lblIPK.AutoSize = True
		lblIPK.Location = New Point(128, 195)
		lblIPK.Name = "lblIPK"
		lblIPK.Size = New Size(89, 20)
		lblIPK.TabIndex = 1
		lblIPK.Text = "IP Kumulatif"
		' 
		' txtIPS
		' 
		txtIPS.Location = New Point(263, 89)
		txtIPS.Name = "txtIPS"
		txtIPS.Size = New Size(242, 27)
		txtIPS.TabIndex = 2
		' 
		' txtIPK
		' 
		txtIPK.Location = New Point(263, 188)
		txtIPK.Name = "txtIPK"
		txtIPK.Size = New Size(242, 27)
		txtIPK.TabIndex = 3
		' 
		' btnTambah
		' 
		btnTambah.Location = New Point(263, 132)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(94, 29)
		btnTambah.TabIndex = 4
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = True
		' 
		' btnReset
		' 
		btnReset.Location = New Point(411, 132)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(94, 29)
		btnReset.TabIndex = 5
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = True
		' 
		' lblPredikat
		' 
		lblPredikat.AutoSize = True
		lblPredikat.Location = New Point(263, 241)
		lblPredikat.Name = "lblPredikat"
		lblPredikat.Size = New Size(0, 20)
		lblPredikat.TabIndex = 6
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(lblPredikat)
		Controls.Add(btnReset)
		Controls.Add(btnTambah)
		Controls.Add(txtIPK)
		Controls.Add(txtIPS)
		Controls.Add(lblIPK)
		Controls.Add(lblIPS)
		Name = "Form1"
		Text = "Kalkulator IP"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblIPS As Label
	Friend WithEvents lblIPK As Label
	Friend WithEvents txtIPS As TextBox
	Friend WithEvents txtIPK As TextBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents lblPredikat As Label

End Class
