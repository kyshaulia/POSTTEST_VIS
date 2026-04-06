<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        lbJudul = New Label()
        Panel1 = New Panel()
        pbLogo = New PictureBox()
        Panel2 = New Panel()
        lblHobby = New Label()
        lblKontak = New Label()
        lblJabatan = New Label()
        lblID = New Label()
        lblNama = New Label()
        lbl5 = New Label()
        lbl4 = New Label()
        lbl3 = New Label()
        lbl2 = New Label()
        lbl1 = New Label()
        pbProfil = New PictureBox()
        Panel1.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbJudul
        ' 
        lbJudul.AutoSize = True
        lbJudul.BackColor = Color.DimGray
        lbJudul.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbJudul.ForeColor = SystemColors.ButtonHighlight
        lbJudul.Location = New Point(146, 32)
        lbJudul.Name = "lbJudul"
        lbJudul.Size = New Size(255, 24)
        lbJudul.TabIndex = 5
        lbJudul.Text = "KARTU ANGGOTA LYKN"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(lbJudul)
        Panel1.Controls.Add(pbLogo)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(634, 92)
        Panel1.TabIndex = 6
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
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Controls.Add(lblHobby)
        Panel2.Controls.Add(lblKontak)
        Panel2.Controls.Add(lblJabatan)
        Panel2.Controls.Add(lblID)
        Panel2.Controls.Add(lblNama)
        Panel2.Controls.Add(lbl5)
        Panel2.Controls.Add(lbl4)
        Panel2.Controls.Add(lbl3)
        Panel2.Controls.Add(lbl2)
        Panel2.Controls.Add(lbl1)
        Panel2.Controls.Add(pbProfil)
        Panel2.Location = New Point(0, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(634, 382)
        Panel2.TabIndex = 7
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHobby.ForeColor = SystemColors.ButtonHighlight
        lblHobby.Location = New Point(370, 285)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(0, 20)
        lblHobby.TabIndex = 10
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKontak.ForeColor = SystemColors.ButtonHighlight
        lblKontak.Location = New Point(370, 245)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(0, 20)
        lblKontak.TabIndex = 9
        ' 
        ' lblJabatan
        ' 
        lblJabatan.AutoSize = True
        lblJabatan.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJabatan.ForeColor = SystemColors.ButtonHighlight
        lblJabatan.Location = New Point(370, 203)
        lblJabatan.Name = "lblJabatan"
        lblJabatan.Size = New Size(0, 20)
        lblJabatan.TabIndex = 8
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblID.ForeColor = SystemColors.ButtonHighlight
        lblID.Location = New Point(370, 163)
        lblID.Name = "lblID"
        lblID.Size = New Size(0, 20)
        lblID.TabIndex = 7
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = SystemColors.ButtonHighlight
        lblNama.Location = New Point(370, 124)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(0, 20)
        lblNama.TabIndex = 6
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl5.ForeColor = SystemColors.ButtonHighlight
        lbl5.Location = New Point(218, 285)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(127, 21)
        lbl5.TabIndex = 5
        lbl5.Text = "Hobby/Aktivitas"
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl4.ForeColor = SystemColors.ButtonHighlight
        lbl4.Location = New Point(218, 245)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(58, 21)
        lbl4.TabIndex = 4
        lbl4.Text = "Kontak"
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl3.ForeColor = SystemColors.ButtonHighlight
        lbl3.Location = New Point(218, 202)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(68, 21)
        lbl3.TabIndex = 3
        lbl3.Text = "Jabatan"
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl2.ForeColor = SystemColors.ButtonHighlight
        lbl2.Location = New Point(218, 162)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(29, 21)
        lbl2.TabIndex = 2
        lbl2.Text = "ID"
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl1.ForeColor = SystemColors.ButtonHighlight
        lbl1.Location = New Point(218, 124)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(50, 21)
        lbl1.TabIndex = 1
        lbl1.Text = "Nama"
        ' 
        ' pbProfil
        ' 
        pbProfil.BackColor = Color.DimGray
        pbProfil.Location = New Point(23, 115)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(159, 220)
        pbProfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 381)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "FormHasil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Hasil"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbJudul As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbProfil As PictureBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblJabatan As Label
End Class
