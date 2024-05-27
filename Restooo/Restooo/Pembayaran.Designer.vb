<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pembayaran
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembayaran))
        Me.PanelTopLeft = New System.Windows.Forms.Panel()
        Me.ButtonMenuBurger = New System.Windows.Forms.Button()
        Me.ButtonReport = New System.Windows.Forms.Button()
        Me.ButtonStock = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.ButtonStatus = New System.Windows.Forms.Button()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.TimerPanelReduce = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.PanelPembayaran = New System.Windows.Forms.Panel()
        Me.PanelNota = New System.Windows.Forms.Panel()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.lblUang = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTanggal = New System.Windows.Forms.Label()
        Me.LabelNamaPelayan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.PanelTopLeft.SuspendLayout()
        Me.PanelLeft.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNota.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTopLeft
        '
        Me.PanelTopLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PanelTopLeft.Controls.Add(Me.ButtonMenuBurger)
        Me.PanelTopLeft.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTopLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelTopLeft.Name = "PanelTopLeft"
        Me.PanelTopLeft.Size = New System.Drawing.Size(200, 58)
        Me.PanelTopLeft.TabIndex = 0
        '
        'ButtonMenuBurger
        '
        Me.ButtonMenuBurger.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ButtonMenuBurger.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMenuBurger.Image = CType(resources.GetObject("ButtonMenuBurger.Image"), System.Drawing.Image)
        Me.ButtonMenuBurger.Location = New System.Drawing.Point(147, 0)
        Me.ButtonMenuBurger.Name = "ButtonMenuBurger"
        Me.ButtonMenuBurger.Size = New System.Drawing.Size(53, 58)
        Me.ButtonMenuBurger.TabIndex = 1
        Me.ButtonMenuBurger.UseVisualStyleBackColor = False
        '
        'ButtonReport
        '
        Me.ButtonReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ButtonReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ButtonReport.Image = Global.Restooo.My.Resources.Resources.Icons8_Windows_8_Food_List_Ingredients_32
        Me.ButtonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonReport.Location = New System.Drawing.Point(0, 244)
        Me.ButtonReport.Name = "ButtonReport"
        Me.ButtonReport.Size = New System.Drawing.Size(200, 54)
        Me.ButtonReport.TabIndex = 9
        Me.ButtonReport.Text = "Report"
        Me.ButtonReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonReport.UseVisualStyleBackColor = False
        '
        'ButtonStock
        '
        Me.ButtonStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ButtonStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ButtonStock.Image = Global.Restooo.My.Resources.Resources.Iconoir_Team_Iconoir_Packages_32
        Me.ButtonStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStock.Location = New System.Drawing.Point(0, 184)
        Me.ButtonStock.Name = "ButtonStock"
        Me.ButtonStock.Size = New System.Drawing.Size(200, 54)
        Me.ButtonStock.TabIndex = 8
        Me.ButtonStock.Text = "Stock"
        Me.ButtonStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonStock.UseVisualStyleBackColor = False
        '
        'ButtonMenu
        '
        Me.ButtonMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ButtonMenu.Image = Global.Restooo.My.Resources.Resources.Aniket_Suvarna_Box_Regular_Bx_food_menu_32
        Me.ButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu.Location = New System.Drawing.Point(0, 124)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(200, 54)
        Me.ButtonMenu.TabIndex = 7
        Me.ButtonMenu.Text = "Menu"
        Me.ButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonMenu.UseVisualStyleBackColor = False
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ButtonDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ButtonDashboard.Image = Global.Restooo.My.Resources.Resources.Amitjakhu_Drip_Home_32
        Me.ButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDashboard.Location = New System.Drawing.Point(0, 64)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(200, 54)
        Me.ButtonDashboard.TabIndex = 6
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDashboard.UseVisualStyleBackColor = False
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PanelLeft.Controls.Add(Me.PictureBoxLogo)
        Me.PanelLeft.Controls.Add(Me.ButtonStatus)
        Me.PanelLeft.Controls.Add(Me.ButtonLogout)
        Me.PanelLeft.Controls.Add(Me.ButtonReport)
        Me.PanelLeft.Controls.Add(Me.ButtonStock)
        Me.PanelLeft.Controls.Add(Me.ButtonMenu)
        Me.PanelLeft.Controls.Add(Me.ButtonDashboard)
        Me.PanelLeft.Controls.Add(Me.PanelTopLeft)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(200, 761)
        Me.PanelLeft.TabIndex = 7
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = Global.Restooo.My.Resources.Resources.RESTOOOO__5_
        Me.PictureBoxLogo.Location = New System.Drawing.Point(0, 304)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(200, 225)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 308
        Me.PictureBoxLogo.TabStop = False
        '
        'ButtonStatus
        '
        Me.ButtonStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ButtonStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStatus.Image = Global.Restooo.My.Resources.Resources.Iconsmind_Outline_Profile_32
        Me.ButtonStatus.Location = New System.Drawing.Point(150, 711)
        Me.ButtonStatus.Name = "ButtonStatus"
        Me.ButtonStatus.Size = New System.Drawing.Size(50, 50)
        Me.ButtonStatus.TabIndex = 13
        Me.ButtonStatus.UseVisualStyleBackColor = False
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogout.Image = Global.Restooo.My.Resources.Resources.Icons8_Windows_8_User_Interface_Logout_32
        Me.ButtonLogout.Location = New System.Drawing.Point(0, 711)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(50, 50)
        Me.ButtonLogout.TabIndex = 12
        Me.ButtonLogout.UseVisualStyleBackColor = False
        '
        'TimerPanelReduce
        '
        Me.TimerPanelReduce.Interval = 1
        '
        'TimerPanelIncrease
        '
        Me.TimerPanelIncrease.Interval = 1
        '
        'LabelStock
        '
        Me.LabelStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.LabelStock.Location = New System.Drawing.Point(591, 9)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(267, 51)
        Me.LabelStock.TabIndex = 9
        Me.LabelStock.Text = "Pembayaran"
        '
        'PanelPembayaran
        '
        Me.PanelPembayaran.AutoScroll = True
        Me.PanelPembayaran.AutoSize = True
        Me.PanelPembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PanelPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPembayaran.Location = New System.Drawing.Point(63, 111)
        Me.PanelPembayaran.Name = "PanelPembayaran"
        Me.PanelPembayaran.Size = New System.Drawing.Size(258, 348)
        Me.PanelPembayaran.TabIndex = 20
        '
        'PanelNota
        '
        Me.PanelNota.AllowDrop = True
        Me.PanelNota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelNota.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PanelNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelNota.Controls.Add(Me.lblKembalian)
        Me.PanelNota.Controls.Add(Me.lblUang)
        Me.PanelNota.Controls.Add(Me.lblTotal)
        Me.PanelNota.Controls.Add(Me.Label3)
        Me.PanelNota.Controls.Add(Me.Label5)
        Me.PanelNota.Controls.Add(Me.Label4)
        Me.PanelNota.Controls.Add(Me.Label2)
        Me.PanelNota.Controls.Add(Me.LabelTanggal)
        Me.PanelNota.Controls.Add(Me.LabelNamaPelayan)
        Me.PanelNota.Controls.Add(Me.Label1)
        Me.PanelNota.Controls.Add(Me.PanelPembayaran)
        Me.PanelNota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.PanelNota.Location = New System.Drawing.Point(536, 91)
        Me.PanelNota.Name = "PanelNota"
        Me.PanelNota.Size = New System.Drawing.Size(373, 658)
        Me.PanelNota.TabIndex = 21
        '
        'lblKembalian
        '
        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Enabled = False
        Me.lblKembalian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblKembalian.Location = New System.Drawing.Point(63, 528)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(93, 13)
        Me.lblKembalian.TabIndex = 32
        Me.lblKembalian.Text = "Kembalian : XXXX"
        '
        'lblUang
        '
        Me.lblUang.AutoSize = True
        Me.lblUang.Enabled = False
        Me.lblUang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblUang.Location = New System.Drawing.Point(63, 506)
        Me.lblUang.Name = "lblUang"
        Me.lblUang.Size = New System.Drawing.Size(71, 13)
        Me.lblUang.TabIndex = 31
        Me.lblUang.Text = "Bayar : XXXX"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(61, 483)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(68, 13)
        Me.lblTotal.TabIndex = 30
        Me.lblTotal.Text = "Total : XXXX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(60, 578)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Telp : 018324654891"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(151, 630)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Terima Kasih :)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(60, 605)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Email : rest4o@gmail.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(61, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nomor Meja :"
        '
        'LabelTanggal
        '
        Me.LabelTanggal.AutoSize = True
        Me.LabelTanggal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.LabelTanggal.Location = New System.Drawing.Point(236, 47)
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(49, 13)
        Me.LabelTanggal.TabIndex = 22
        Me.LabelTanggal.Text = "Tanggal "
        '
        'LabelNamaPelayan
        '
        Me.LabelNamaPelayan.AutoSize = True
        Me.LabelNamaPelayan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.LabelNamaPelayan.Location = New System.Drawing.Point(61, 47)
        Me.LabelNamaPelayan.Name = "LabelNamaPelayan"
        Me.LabelNamaPelayan.Size = New System.Drawing.Size(41, 13)
        Me.LabelNamaPelayan.TabIndex = 23
        Me.LabelNamaPelayan.Text = "Nama :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(151, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Restoooo"
        '
        'btnDone
        '
        Me.btnDone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDone.Location = New System.Drawing.Point(952, 90)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(126, 38)
        Me.btnDone.TabIndex = 22
        Me.btnDone.Text = "Selesai"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'Pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.PanelNota)
        Me.Controls.Add(Me.LabelStock)
        Me.Controls.Add(Me.PanelLeft)
        Me.Name = "Pembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran"
        Me.PanelTopLeft.ResumeLayout(False)
        Me.PanelLeft.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNota.ResumeLayout(False)
        Me.PanelNota.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTopLeft As Panel
    Friend WithEvents ButtonMenuBurger As Button
    Friend WithEvents ButtonReport As Button
    Friend WithEvents ButtonStock As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents ButtonStatus As Button
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents TimerPanelReduce As Timer
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents LabelStock As Label
    Friend WithEvents PanelPembayaran As Panel
    Friend WithEvents PanelNota As Panel
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents LabelNamaPelayan As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents lblUang As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblKembalian As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
