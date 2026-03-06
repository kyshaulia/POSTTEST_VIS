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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lstBuku = New ListBox()
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudulTambah = New TextBox()
        lblGenre = New Label()
        lblJudulTambah = New Label()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        txtJudulHapus = New TextBox()
        lblJudulHapus = New Label()
        lblnama = New Label()
        lblDaftar = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        lblTotal = New Label()
        PictureBox3 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstBuku
        ' 
        lstBuku.BackColor = Color.Lavender
        lstBuku.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstBuku.FormattingEnabled = True
        lstBuku.ItemHeight = 18
        lstBuku.Location = New Point(532, 93)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(239, 310)
        lstBuku.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Lavender
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Controls.Add(lblGenre)
        GroupBox1.Controls.Add(lblJudulTambah)
        GroupBox1.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(49, 57)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(296, 171)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.SteelBlue
        btnTambah.Font = New Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.MistyRose
        btnTambah.Location = New Point(201, 135)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(89, 30)
        btnTambah.TabIndex = 6
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtGenre
        ' 
        txtGenre.BackColor = Color.MistyRose
        txtGenre.Location = New Point(118, 80)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(172, 26)
        txtGenre.TabIndex = 3
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.BackColor = Color.MistyRose
        txtJudulTambah.Location = New Point(118, 35)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(172, 26)
        txtJudulTambah.TabIndex = 2
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGenre.Location = New Point(15, 82)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(50, 20)
        lblGenre.TabIndex = 1
        lblGenre.Text = "Genre"
        ' 
        ' lblJudulTambah
        ' 
        lblJudulTambah.AutoSize = True
        lblJudulTambah.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJudulTambah.Location = New Point(15, 35)
        lblJudulTambah.Name = "lblJudulTambah"
        lblJudulTambah.Size = New Size(86, 20)
        lblJudulTambah.TabIndex = 0
        lblJudulTambah.Text = "Judul Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Lavender
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtJudulHapus)
        GroupBox2.Controls.Add(lblJudulHapus)
        GroupBox2.Location = New Point(49, 258)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(296, 171)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.SteelBlue
        btnHapus.Font = New Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.MistyRose
        btnHapus.Location = New Point(199, 135)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(91, 30)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.BackColor = Color.MistyRose
        txtJudulHapus.Location = New Point(132, 33)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(158, 23)
        txtJudulHapus.TabIndex = 4
        ' 
        ' lblJudulHapus
        ' 
        lblJudulHapus.AutoSize = True
        lblJudulHapus.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJudulHapus.Location = New Point(26, 35)
        lblJudulHapus.Name = "lblJudulHapus"
        lblJudulHapus.Size = New Size(86, 20)
        lblJudulHapus.TabIndex = 2
        lblJudulHapus.Text = "Judul Buku"
        ' 
        ' lblnama
        ' 
        lblnama.AutoSize = True
        lblnama.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblnama.ForeColor = Color.Peru
        lblnama.Location = New Point(39, 18)
        lblnama.Name = "lblnama"
        lblnama.Size = New Size(203, 27)
        lblnama.TabIndex = 7
        lblnama.Text = "Wesley Book Library"
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDaftar.ForeColor = Color.Peru
        lblDaftar.Location = New Point(616, 57)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(81, 23)
        lblDaftar.TabIndex = 8
        lblDaftar.Text = "Book List"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(367, 57)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(136, 138)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(367, 240)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(136, 183)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(659, 375)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(0, 18)
        lblTotal.TabIndex = 11
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(717, 57)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(54, 69)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox3)
        Controls.Add(lblTotal)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(lblDaftar)
        Controls.Add(lblnama)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(lstBuku)
        Name = "Form1"
        Text = "Posttest 2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstBuku As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblJudulTambah As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblJudulHapus As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lblnama As Label
    Friend WithEvents lblDaftar As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents PictureBox3 As PictureBox

End Class
