<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        MenuStrip1 = New MenuStrip()
        menuDataHIjab = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        lblJudul = New Label()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.AliceBlue
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuDataHIjab, menuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(711, 25)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' menuDataHIjab
        ' 
        menuDataHIjab.BackColor = Color.SteelBlue
        menuDataHIjab.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuDataHIjab.ForeColor = Color.White
        menuDataHIjab.Name = "menuDataHIjab"
        menuDataHIjab.Size = New Size(84, 21)
        menuDataHIjab.Text = "Data HIjab"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.BackColor = Color.SteelBlue
        menuKeluar.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuKeluar.ForeColor = Color.White
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(58, 21)
        menuKeluar.Text = "Keluar"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(219, -95)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(261, 435)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.SteelBlue
        lblJudul.Location = New Point(140, 295)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(438, 45)
        lblJudul.TabIndex = 2
        lblJudul.Text = "Manajemen Penjualan Hijab"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(0, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 25)
        Label1.TabIndex = 3
        Label1.Text = "Selamat Datang, Keysha!"
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(711, 385)
        Controls.Add(Label1)
        Controls.Add(lblJudul)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Penjualan Hijab"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuDataHIjab As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents Label1 As Label

End Class
