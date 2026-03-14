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
        pictureProfil = New PictureBox()
        LabelNama = New Label()
        LabelUmur = New Label()
        LabelTanggalLahir = New Label()
        LabelNoTelp = New Label()
        LabelAlamat = New Label()
        gbJK = New GroupBox()
        rbtnPerempuan = New RadioButton()
        rbtnLaki = New RadioButton()
        gbHobby = New GroupBox()
        cbMenari = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMembaca = New CheckBox()
        cbMemancing = New CheckBox()
        cbMenulis = New CheckBox()
        cbMenggambar = New CheckBox()
        cbTravel = New CheckBox()
        cbCoding = New CheckBox()
        cbGaming = New CheckBox()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelp = New TextBox()
        txtAlamat = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        btnBrowse = New Button()
        btnCetak = New Button()
        PictureBox1 = New PictureBox()
        CType(pictureProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbJK.SuspendLayout()
        gbHobby.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureProfil
        ' 
        pictureProfil.BackColor = Color.BurlyWood
        pictureProfil.Location = New Point(23, 21)
        pictureProfil.Name = "pictureProfil"
        pictureProfil.Size = New Size(232, 374)
        pictureProfil.TabIndex = 0
        pictureProfil.TabStop = False
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.Font = New Font("GeoSlab703 MdCn BT", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNama.Location = New Point(278, 21)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(40, 19)
        LabelNama.TabIndex = 1
        LabelNama.Text = "Nama"
        ' 
        ' LabelUmur
        ' 
        LabelUmur.AutoSize = True
        LabelUmur.Font = New Font("GeoSlab703 MdCn BT", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelUmur.Location = New Point(278, 53)
        LabelUmur.Name = "LabelUmur"
        LabelUmur.RightToLeft = RightToLeft.No
        LabelUmur.Size = New Size(40, 19)
        LabelUmur.TabIndex = 2
        LabelUmur.Text = "Umur"
        ' 
        ' LabelTanggalLahir
        ' 
        LabelTanggalLahir.AutoSize = True
        LabelTanggalLahir.Font = New Font("GeoSlab703 MdCn BT", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTanggalLahir.Location = New Point(278, 89)
        LabelTanggalLahir.Name = "LabelTanggalLahir"
        LabelTanggalLahir.RightToLeft = RightToLeft.No
        LabelTanggalLahir.Size = New Size(84, 19)
        LabelTanggalLahir.TabIndex = 3
        LabelTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' LabelNoTelp
        ' 
        LabelNoTelp.AutoSize = True
        LabelNoTelp.Font = New Font("GeoSlab703 MdCn BT", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNoTelp.Location = New Point(278, 126)
        LabelNoTelp.Name = "LabelNoTelp"
        LabelNoTelp.RightToLeft = RightToLeft.No
        LabelNoTelp.Size = New Size(67, 19)
        LabelNoTelp.TabIndex = 4
        LabelNoTelp.Text = "No Telepon"
        ' 
        ' LabelAlamat
        ' 
        LabelAlamat.AutoSize = True
        LabelAlamat.Font = New Font("GeoSlab703 MdCn BT", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelAlamat.Location = New Point(278, 162)
        LabelAlamat.Name = "LabelAlamat"
        LabelAlamat.RightToLeft = RightToLeft.No
        LabelAlamat.Size = New Size(47, 19)
        LabelAlamat.TabIndex = 5
        LabelAlamat.Text = "Alamat"
        ' 
        ' gbJK
        ' 
        gbJK.BackColor = Color.LightSteelBlue
        gbJK.Controls.Add(rbtnPerempuan)
        gbJK.Controls.Add(rbtnLaki)
        gbJK.Font = New Font("GeoSlab703 MdCn BT", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbJK.Location = New Point(278, 202)
        gbJK.Name = "gbJK"
        gbJK.Size = New Size(200, 111)
        gbJK.TabIndex = 6
        gbJK.TabStop = False
        gbJK.Text = "Jenis Kelamin"
        ' 
        ' rbtnPerempuan
        ' 
        rbtnPerempuan.AutoSize = True
        rbtnPerempuan.Location = New Point(14, 70)
        rbtnPerempuan.Name = "rbtnPerempuan"
        rbtnPerempuan.Size = New Size(86, 23)
        rbtnPerempuan.TabIndex = 1
        rbtnPerempuan.TabStop = True
        rbtnPerempuan.Text = "Perempuan"
        rbtnPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbtnLaki
        ' 
        rbtnLaki.AutoSize = True
        rbtnLaki.Location = New Point(14, 32)
        rbtnLaki.Name = "rbtnLaki"
        rbtnLaki.Size = New Size(82, 23)
        rbtnLaki.TabIndex = 0
        rbtnLaki.TabStop = True
        rbtnLaki.Text = "Laki-Laki"
        rbtnLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.BackColor = Color.LightSteelBlue
        gbHobby.Controls.Add(cbMenari)
        gbHobby.Controls.Add(cbMenyanyi)
        gbHobby.Controls.Add(cbOlahraga)
        gbHobby.Controls.Add(cbMembaca)
        gbHobby.Controls.Add(cbMemancing)
        gbHobby.Controls.Add(cbMenulis)
        gbHobby.Controls.Add(cbMenggambar)
        gbHobby.Controls.Add(cbTravel)
        gbHobby.Controls.Add(cbCoding)
        gbHobby.Controls.Add(cbGaming)
        gbHobby.Font = New Font("GeoSlab703 MdCn BT", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbHobby.Location = New Point(496, 202)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(292, 181)
        gbHobby.TabIndex = 7
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Location = New Point(192, 148)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(65, 23)
        cbMenari.TabIndex = 9
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Location = New Point(192, 119)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(79, 23)
        cbMenyanyi.TabIndex = 8
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(192, 88)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(74, 23)
        cbOlahraga.TabIndex = 7
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(192, 61)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(76, 23)
        cbMembaca.TabIndex = 6
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbMemancing
        ' 
        cbMemancing.AutoSize = True
        cbMemancing.Location = New Point(192, 33)
        cbMemancing.Name = "cbMemancing"
        cbMemancing.Size = New Size(88, 23)
        cbMemancing.TabIndex = 5
        cbMemancing.Text = "Memancing"
        cbMemancing.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(15, 148)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(69, 23)
        cbMenulis.TabIndex = 4
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Location = New Point(15, 119)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(95, 23)
        cbMenggambar.TabIndex = 3
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbTravel
        ' 
        cbTravel.AutoSize = True
        cbTravel.Location = New Point(15, 90)
        cbTravel.Name = "cbTravel"
        cbTravel.Size = New Size(78, 23)
        cbTravel.TabIndex = 2
        cbTravel.Text = "Traveling"
        cbTravel.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(15, 61)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(64, 23)
        cbCoding.TabIndex = 1
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(15, 32)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(68, 23)
        cbGaming.TabIndex = 0
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.LightSteelBlue
        txtNama.Font = New Font("GeoSlab703 MdCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(423, 21)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 25)
        txtNama.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.LightSteelBlue
        txtUmur.Font = New Font("GeoSlab703 MdCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUmur.Location = New Point(423, 50)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(200, 25)
        txtUmur.TabIndex = 9
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.BackColor = Color.LightSteelBlue
        txtNoTelp.Font = New Font("GeoSlab703 MdCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNoTelp.Location = New Point(423, 122)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(200, 25)
        txtNoTelp.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.LightSteelBlue
        txtAlamat.Font = New Font("GeoSlab703 MdCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(423, 158)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(200, 25)
        txtAlamat.TabIndex = 11
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.CalendarMonthBackground = Color.LightSteelBlue
        dtpTanggalLahir.CalendarTitleBackColor = Color.LightSteelBlue
        dtpTanggalLahir.Font = New Font("GeoSlab703 MdCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTanggalLahir.Location = New Point(423, 86)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(200, 25)
        dtpTanggalLahir.TabIndex = 12
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.LightCoral
        btnBrowse.Font = New Font("GeoSlab703 MdCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(97, 401)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 13
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.LightCoral
        btnCetak.Font = New Font("GeoSlab703 MdCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(278, 401)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(510, 23)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Teks_paragraf_Anda
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 434)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(800, 432)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowse)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(gbHobby)
        Controls.Add(gbJK)
        Controls.Add(LabelAlamat)
        Controls.Add(LabelNoTelp)
        Controls.Add(LabelTanggalLahir)
        Controls.Add(LabelUmur)
        Controls.Add(LabelNama)
        Controls.Add(pictureProfil)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form Cetak"
        CType(pictureProfil, ComponentModel.ISupportInitialize).EndInit()
        gbJK.ResumeLayout(False)
        gbJK.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pictureProfil As PictureBox
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelUmur As Label
    Friend WithEvents LabelTanggalLahir As Label
    Friend WithEvents LabelNoTelp As Label
    Friend WithEvents LabelAlamat As Label
    Friend WithEvents gbJK As GroupBox
    Friend WithEvents rbtnPerempuan As RadioButton
    Friend WithEvents rbtnLaki As RadioButton
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbTravel As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
