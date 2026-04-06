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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        menuInputData = New ToolStripMenuItem()
        GfhjToolStripMenuItem = New ToolStripMenuItem()
        menuLihatKartu = New ToolStripMenuItem()
        menuSimpanData = New ToolStripMenuItem()
        menuBukaData = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        pbLogo = New PictureBox()
        lbJudul = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        TabControl1 = New TabControl()
        tpDataUtama = New TabPage()
        cbDivisi = New ComboBox()
        dtpTanggalLahir = New DateTimePicker()
        txtIDAnggota = New TextBox()
        txtNama = New TextBox()
        lblDivisi = New Label()
        lblJK = New Label()
        lblTanggalLahir = New Label()
        lblIDAnggota = New Label()
        lblNama = New Label()
        gbJK = New GroupBox()
        rbtnPerempuan = New RadioButton()
        rbtnLaki = New RadioButton()
        tpKontak = New TabPage()
        txtAlamat = New TextBox()
        mtxtNoTelp = New MaskedTextBox()
        txtEmail = New TextBox()
        lblAlamat = New Label()
        lblEmail = New Label()
        lblNoTelp = New Label()
        tpProfil = New TabPage()
        btnCetak = New Button()
        btnBrowse = New Button()
        gbHobby = New GroupBox()
        cbFotografi = New CheckBox()
        cbDiving = New CheckBox()
        cbHiking = New CheckBox()
        cbTravel = New CheckBox()
        cbRenang = New CheckBox()
        cbCoding = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbMenari = New CheckBox()
        cbMancing = New CheckBox()
        gbJabatan = New GroupBox()
        rbAnggota = New RadioButton()
        rbBendiv = New RadioButton()
        rbSekdiv = New RadioButton()
        rbBendum = New RadioButton()
        rbSekum = New RadioButton()
        rbWaketum = New RadioButton()
        rbKetum = New RadioButton()
        rbKediv = New RadioButton()
        pbProfil = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TabControl1.SuspendLayout()
        tpDataUtama.SuspendLayout()
        gbJK.SuspendLayout()
        tpKontak.SuspendLayout()
        tpProfil.SuspendLayout()
        gbHobby.SuspendLayout()
        gbJabatan.SuspendLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuInputData, menuLihatKartu, menuSimpanData, menuBukaData, menuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(593, 25)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' menuInputData
        ' 
        menuInputData.DropDownItems.AddRange(New ToolStripItem() {GfhjToolStripMenuItem})
        menuInputData.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuInputData.Name = "menuInputData"
        menuInputData.Size = New Size(85, 21)
        menuInputData.Text = "Input Data"
        ' 
        ' GfhjToolStripMenuItem
        ' 
        GfhjToolStripMenuItem.Name = "GfhjToolStripMenuItem"
        GfhjToolStripMenuItem.Size = New Size(68, 22)
        ' 
        ' menuLihatKartu
        ' 
        menuLihatKartu.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuLihatKartu.Name = "menuLihatKartu"
        menuLihatKartu.Size = New Size(86, 21)
        menuLihatKartu.Text = "Lihat Kartu"
        ' 
        ' menuSimpanData
        ' 
        menuSimpanData.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuSimpanData.Name = "menuSimpanData"
        menuSimpanData.Size = New Size(97, 21)
        menuSimpanData.Text = "Simpan Data"
        ' 
        ' menuBukaData
        ' 
        menuBukaData.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuBukaData.Name = "menuBukaData"
        menuBukaData.Size = New Size(82, 21)
        menuBukaData.Text = "Buka Data"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(58, 21)
        menuKeluar.Text = "Keluar"
        ' 
        ' pbLogo
        ' 
        pbLogo.Image = My.Resources.Resources.lykn
        pbLogo.Location = New Point(12, 13)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(92, 64)
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage
        pbLogo.TabIndex = 1
        pbLogo.TabStop = False
        ' 
        ' lbJudul
        ' 
        lbJudul.AutoSize = True
        lbJudul.BackColor = Color.DimGray
        lbJudul.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbJudul.ForeColor = SystemColors.ButtonHighlight
        lbJudul.Location = New Point(146, 28)
        lbJudul.Name = "lbJudul"
        lbJudul.Size = New Size(337, 24)
        lbJudul.TabIndex = 2
        lbJudul.Text = "SISTEM KARTU ANGGOTA LYKN"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(lbJudul)
        Panel1.Controls.Add(pbLogo)
        Panel1.Location = New Point(0, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(593, 92)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Controls.Add(TabControl1)
        Panel2.Location = New Point(0, 28)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(593, 456)
        Panel2.TabIndex = 4
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpDataUtama)
        TabControl1.Controls.Add(tpKontak)
        TabControl1.Controls.Add(tpProfil)
        TabControl1.Location = New Point(32, 121)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(533, 297)
        TabControl1.TabIndex = 0
        ' 
        ' tpDataUtama
        ' 
        tpDataUtama.BackColor = Color.LightGray
        tpDataUtama.Controls.Add(cbDivisi)
        tpDataUtama.Controls.Add(dtpTanggalLahir)
        tpDataUtama.Controls.Add(txtIDAnggota)
        tpDataUtama.Controls.Add(txtNama)
        tpDataUtama.Controls.Add(lblDivisi)
        tpDataUtama.Controls.Add(lblJK)
        tpDataUtama.Controls.Add(lblTanggalLahir)
        tpDataUtama.Controls.Add(lblIDAnggota)
        tpDataUtama.Controls.Add(lblNama)
        tpDataUtama.Controls.Add(gbJK)
        tpDataUtama.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tpDataUtama.Location = New Point(4, 24)
        tpDataUtama.Name = "tpDataUtama"
        tpDataUtama.Padding = New Padding(3)
        tpDataUtama.Size = New Size(525, 269)
        tpDataUtama.TabIndex = 0
        tpDataUtama.Text = "Data Utama"
        ' 
        ' cbDivisi
        ' 
        cbDivisi.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbDivisi.FormattingEnabled = True
        cbDivisi.Items.AddRange(New Object() {"Ketua Umum", "Wakil Ketua Umum", "Sekretaris Umum", "Bendahara Umum", "Humas", "Medikraf", "Keanggotaan", "Pengembangan", "Kewirausahaan", "IT/Teknologi"})
        cbDivisi.Location = New Point(220, 208)
        cbDivisi.Name = "cbDivisi"
        cbDivisi.Size = New Size(227, 26)
        cbDivisi.TabIndex = 8
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Anchor = AnchorStyles.None
        dtpTanggalLahir.CustomFormat = "dddd, dd MMMM yyyy"
        dtpTanggalLahir.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTanggalLahir.Format = DateTimePickerFormat.Custom
        dtpTanggalLahir.Location = New Point(220, 114)
        dtpTanggalLahir.MaxDate = New Date(2026, 12, 31, 0, 0, 0, 0)
        dtpTanggalLahir.MinDate = New Date(1945, 1, 1, 0, 0, 0, 0)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(227, 26)
        dtpTanggalLahir.TabIndex = 7
        ' 
        ' txtIDAnggota
        ' 
        txtIDAnggota.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIDAnggota.Location = New Point(220, 74)
        txtIDAnggota.Name = "txtIDAnggota"
        txtIDAnggota.Size = New Size(227, 26)
        txtIDAnggota.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(220, 36)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(227, 26)
        txtNama.TabIndex = 5
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDivisi.Location = New Point(70, 210)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(42, 19)
        lblDivisi.TabIndex = 4
        lblDivisi.Text = "Divisi"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJK.Location = New Point(68, 167)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(95, 19)
        lblJK.TabIndex = 3
        lblJK.Text = "Jenis Kelamin"
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTanggalLahir.Location = New Point(68, 114)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(95, 19)
        lblTanggalLahir.TabIndex = 2
        lblTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' lblIDAnggota
        ' 
        lblIDAnggota.AutoSize = True
        lblIDAnggota.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIDAnggota.Location = New Point(68, 74)
        lblIDAnggota.Name = "lblIDAnggota"
        lblIDAnggota.Size = New Size(82, 19)
        lblIDAnggota.TabIndex = 1
        lblIDAnggota.Text = "ID Anggota"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(68, 36)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(44, 19)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' gbJK
        ' 
        gbJK.Controls.Add(rbtnPerempuan)
        gbJK.Controls.Add(rbtnLaki)
        gbJK.Location = New Point(220, 146)
        gbJK.Name = "gbJK"
        gbJK.Size = New Size(227, 44)
        gbJK.TabIndex = 11
        gbJK.TabStop = False
        ' 
        ' rbtnPerempuan
        ' 
        rbtnPerempuan.AutoSize = True
        rbtnPerempuan.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbtnPerempuan.Location = New Point(120, 21)
        rbtnPerempuan.Name = "rbtnPerempuan"
        rbtnPerempuan.Size = New Size(90, 22)
        rbtnPerempuan.TabIndex = 10
        rbtnPerempuan.TabStop = True
        rbtnPerempuan.Text = "Perempuan"
        rbtnPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbtnLaki
        ' 
        rbtnLaki.AutoSize = True
        rbtnLaki.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbtnLaki.Location = New Point(6, 21)
        rbtnLaki.Name = "rbtnLaki"
        rbtnLaki.Size = New Size(81, 22)
        rbtnLaki.TabIndex = 9
        rbtnLaki.TabStop = True
        rbtnLaki.Text = "Laki-Laki"
        rbtnLaki.UseVisualStyleBackColor = True
        ' 
        ' tpKontak
        ' 
        tpKontak.BackColor = Color.LightGray
        tpKontak.Controls.Add(txtAlamat)
        tpKontak.Controls.Add(mtxtNoTelp)
        tpKontak.Controls.Add(txtEmail)
        tpKontak.Controls.Add(lblAlamat)
        tpKontak.Controls.Add(lblEmail)
        tpKontak.Controls.Add(lblNoTelp)
        tpKontak.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tpKontak.Location = New Point(4, 24)
        tpKontak.Name = "tpKontak"
        tpKontak.Padding = New Padding(3)
        tpKontak.Size = New Size(525, 269)
        tpKontak.TabIndex = 1
        tpKontak.Text = "Kontak & Info"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(224, 176)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(214, 23)
        txtAlamat.TabIndex = 5
        ' 
        ' mtxtNoTelp
        ' 
        mtxtNoTelp.Location = New Point(222, 70)
        mtxtNoTelp.Mask = "0000-0000-0000"
        mtxtNoTelp.Name = "mtxtNoTelp"
        mtxtNoTelp.Size = New Size(216, 23)
        mtxtNoTelp.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(224, 120)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(214, 23)
        txtEmail.TabIndex = 3
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlamat.Location = New Point(88, 180)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(53, 19)
        lblAlamat.TabIndex = 2
        lblAlamat.Text = "Alamat"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(88, 120)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(42, 19)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNoTelp.Location = New Point(88, 70)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(81, 19)
        lblNoTelp.TabIndex = 0
        lblNoTelp.Text = "No Telepon"
        ' 
        ' tpProfil
        ' 
        tpProfil.BackColor = Color.LightGray
        tpProfil.Controls.Add(btnCetak)
        tpProfil.Controls.Add(btnBrowse)
        tpProfil.Controls.Add(gbHobby)
        tpProfil.Controls.Add(gbJabatan)
        tpProfil.Controls.Add(pbProfil)
        tpProfil.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tpProfil.Location = New Point(4, 24)
        tpProfil.Name = "tpProfil"
        tpProfil.Padding = New Padding(3)
        tpProfil.Size = New Size(525, 269)
        tpProfil.TabIndex = 2
        tpProfil.Text = "Profil & Aktivitas"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.DimGray
        btnCetak.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.ForeColor = SystemColors.ActiveCaptionText
        btnCetak.Location = New Point(197, 240)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(322, 26)
        btnCetak.TabIndex = 5
        btnCetak.Text = "Simpan dan Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DimGray
        btnBrowse.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.ForeColor = SystemColors.ActiveCaptionText
        btnBrowse.Location = New Point(48, 240)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 26)
        btnBrowse.TabIndex = 4
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(cbFotografi)
        gbHobby.Controls.Add(cbDiving)
        gbHobby.Controls.Add(cbHiking)
        gbHobby.Controls.Add(cbTravel)
        gbHobby.Controls.Add(cbRenang)
        gbHobby.Controls.Add(cbCoding)
        gbHobby.Controls.Add(cbMenyanyi)
        gbHobby.Controls.Add(cbMenari)
        gbHobby.Controls.Add(cbMancing)
        gbHobby.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbHobby.Location = New Point(197, 128)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(311, 106)
        gbHobby.TabIndex = 3
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Font = New Font("Comic Sans MS", 9.75F)
        cbFotografi.Location = New Point(196, 68)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(85, 22)
        cbFotografi.TabIndex = 8
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbDiving
        ' 
        cbDiving.AutoSize = True
        cbDiving.Font = New Font("Comic Sans MS", 9.75F)
        cbDiving.Location = New Point(196, 43)
        cbDiving.Name = "cbDiving"
        cbDiving.Size = New Size(64, 22)
        cbDiving.TabIndex = 7
        cbDiving.Text = "Diving"
        cbDiving.UseVisualStyleBackColor = True
        ' 
        ' cbHiking
        ' 
        cbHiking.AutoSize = True
        cbHiking.Font = New Font("Comic Sans MS", 9.75F)
        cbHiking.Location = New Point(196, 18)
        cbHiking.Name = "cbHiking"
        cbHiking.Size = New Size(66, 22)
        cbHiking.TabIndex = 6
        cbHiking.Text = "Hiking"
        cbHiking.UseVisualStyleBackColor = True
        ' 
        ' cbTravel
        ' 
        cbTravel.AutoSize = True
        cbTravel.Font = New Font("Comic Sans MS", 9.75F)
        cbTravel.Location = New Point(108, 68)
        cbTravel.Name = "cbTravel"
        cbTravel.Size = New Size(84, 22)
        cbTravel.TabIndex = 5
        cbTravel.Text = "Traveling"
        cbTravel.UseVisualStyleBackColor = True
        ' 
        ' cbRenang
        ' 
        cbRenang.AutoSize = True
        cbRenang.Font = New Font("Comic Sans MS", 9.75F)
        cbRenang.Location = New Point(108, 43)
        cbRenang.Name = "cbRenang"
        cbRenang.Size = New Size(70, 22)
        cbRenang.TabIndex = 4
        cbRenang.Text = "Renang"
        cbRenang.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Font = New Font("Comic Sans MS", 9.75F)
        cbCoding.Location = New Point(108, 18)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(68, 22)
        cbCoding.TabIndex = 3
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Font = New Font("Comic Sans MS", 9.75F)
        cbMenyanyi.Location = New Point(9, 68)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(84, 22)
        cbMenyanyi.TabIndex = 2
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Font = New Font("Comic Sans MS", 9.75F)
        cbMenari.Location = New Point(9, 43)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(69, 22)
        cbMenari.TabIndex = 1
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.Font = New Font("Comic Sans MS", 9.75F)
        cbMancing.Location = New Point(9, 18)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(77, 22)
        cbMancing.TabIndex = 0
        cbMancing.Text = "Mancing"
        cbMancing.UseVisualStyleBackColor = True
        ' 
        ' gbJabatan
        ' 
        gbJabatan.BackColor = Color.LightGray
        gbJabatan.Controls.Add(rbAnggota)
        gbJabatan.Controls.Add(rbBendiv)
        gbJabatan.Controls.Add(rbSekdiv)
        gbJabatan.Controls.Add(rbBendum)
        gbJabatan.Controls.Add(rbSekum)
        gbJabatan.Controls.Add(rbWaketum)
        gbJabatan.Controls.Add(rbKetum)
        gbJabatan.Controls.Add(rbKediv)
        gbJabatan.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbJabatan.Location = New Point(197, 6)
        gbJabatan.Name = "gbJabatan"
        gbJabatan.Size = New Size(311, 116)
        gbJabatan.TabIndex = 2
        gbJabatan.TabStop = False
        gbJabatan.Text = "Jabatan"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Font = New Font("Comic Sans MS", 9.75F)
        rbAnggota.Location = New Point(178, 97)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(112, 22)
        rbAnggota.TabIndex = 7
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota Divisi"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbBendiv
        ' 
        rbBendiv.AutoSize = True
        rbBendiv.Font = New Font("Comic Sans MS", 9.75F)
        rbBendiv.Location = New Point(178, 72)
        rbBendiv.Name = "rbBendiv"
        rbBendiv.Size = New Size(127, 22)
        rbBendiv.TabIndex = 6
        rbBendiv.TabStop = True
        rbBendiv.Text = "Bendahara Divisi"
        rbBendiv.UseVisualStyleBackColor = True
        ' 
        ' rbSekdiv
        ' 
        rbSekdiv.AutoSize = True
        rbSekdiv.Font = New Font("Comic Sans MS", 9.75F)
        rbSekdiv.Location = New Point(178, 47)
        rbSekdiv.Name = "rbSekdiv"
        rbSekdiv.Size = New Size(127, 22)
        rbSekdiv.TabIndex = 5
        rbSekdiv.TabStop = True
        rbSekdiv.Text = "Sekertaris Divisi"
        rbSekdiv.UseVisualStyleBackColor = True
        ' 
        ' rbBendum
        ' 
        rbBendum.AutoSize = True
        rbBendum.Font = New Font("Comic Sans MS", 9.75F)
        rbBendum.Location = New Point(6, 97)
        rbBendum.Name = "rbBendum"
        rbBendum.Size = New Size(129, 22)
        rbBendum.TabIndex = 4
        rbBendum.TabStop = True
        rbBendum.Text = "Bendahara Umum"
        rbBendum.UseVisualStyleBackColor = True
        ' 
        ' rbSekum
        ' 
        rbSekum.AutoSize = True
        rbSekum.Font = New Font("Comic Sans MS", 9.75F)
        rbSekum.Location = New Point(6, 72)
        rbSekum.Name = "rbSekum"
        rbSekum.Size = New Size(129, 22)
        rbSekum.TabIndex = 3
        rbSekum.TabStop = True
        rbSekum.Text = "Sekertaris Umum"
        rbSekum.UseVisualStyleBackColor = True
        ' 
        ' rbWaketum
        ' 
        rbWaketum.AutoSize = True
        rbWaketum.Font = New Font("Comic Sans MS", 9.75F)
        rbWaketum.Location = New Point(6, 47)
        rbWaketum.Name = "rbWaketum"
        rbWaketum.Size = New Size(138, 22)
        rbWaketum.TabIndex = 2
        rbWaketum.TabStop = True
        rbWaketum.Text = "Wakil Ketua Umum"
        rbWaketum.UseVisualStyleBackColor = True
        ' 
        ' rbKetum
        ' 
        rbKetum.AutoSize = True
        rbKetum.Font = New Font("Comic Sans MS", 9.75F)
        rbKetum.Location = New Point(6, 22)
        rbKetum.Name = "rbKetum"
        rbKetum.Size = New Size(99, 22)
        rbKetum.TabIndex = 1
        rbKetum.TabStop = True
        rbKetum.Text = "Ketua Umum"
        rbKetum.UseVisualStyleBackColor = True
        ' 
        ' rbKediv
        ' 
        rbKediv.AutoSize = True
        rbKediv.Font = New Font("Comic Sans MS", 9.75F)
        rbKediv.Location = New Point(178, 22)
        rbKediv.Name = "rbKediv"
        rbKediv.Size = New Size(103, 22)
        rbKediv.TabIndex = 0
        rbKediv.TabStop = True
        rbKediv.Text = "Kepala Divisi"
        rbKediv.UseVisualStyleBackColor = True
        ' 
        ' pbProfil
        ' 
        pbProfil.BackColor = Color.DarkGray
        pbProfil.Location = New Point(6, 6)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(160, 228)
        pbProfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(593, 483)
        Controls.Add(MenuStrip1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        tpDataUtama.ResumeLayout(False)
        tpDataUtama.PerformLayout()
        gbJK.ResumeLayout(False)
        gbJK.PerformLayout()
        tpKontak.ResumeLayout(False)
        tpKontak.PerformLayout()
        tpProfil.ResumeLayout(False)
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        gbJabatan.ResumeLayout(False)
        gbJabatan.PerformLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuInputData As ToolStripMenuItem
    Friend WithEvents menuLihatKartu As ToolStripMenuItem
    Friend WithEvents menuSimpanData As ToolStripMenuItem
    Friend WithEvents menuBukaData As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lbJudul As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpDataUtama As TabPage
    Friend WithEvents tpKontak As TabPage
    Friend WithEvents tpProfil As TabPage
    Friend WithEvents lblJK As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblIDAnggota As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents txtIDAnggota As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblDivisi As Label
    Friend WithEvents cbDivisi As ComboBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents rbtnPerempuan As RadioButton
    Friend WithEvents rbtnLaki As RadioButton
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents mtxtNoTelp As MaskedTextBox
    Friend WithEvents pbProfil As PictureBox
    Friend WithEvents gbJabatan As GroupBox
    Friend WithEvents rbKediv As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbBendiv As RadioButton
    Friend WithEvents rbSekdiv As RadioButton
    Friend WithEvents rbBendum As RadioButton
    Friend WithEvents rbSekum As RadioButton
    Friend WithEvents rbWaketum As RadioButton
    Friend WithEvents rbKetum As RadioButton
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents cbRenang As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbDiving As CheckBox
    Friend WithEvents cbHiking As CheckBox
    Friend WithEvents cbTravel As CheckBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GfhjToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbJK As GroupBox

End Class
