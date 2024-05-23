<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMakan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LabelReport As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuMakan))
        Me.PanelTopLeft = New System.Windows.Forms.Panel()
        Me.ButtonMenuBurger = New System.Windows.Forms.Button()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.ButtonStatus = New System.Windows.Forms.Button()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.ButtonReport = New System.Windows.Forms.Button()
        Me.ButtonStock = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelReduce = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonBayar = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.btnResetList = New System.Windows.Forms.Button()
        Me.PanelMakanan = New System.Windows.Forms.Panel()
        Me.PanelMinuman = New System.Windows.Forms.Panel()
        Me.PanelList = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        LabelReport = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.PanelTopLeft.SuspendLayout()
        Me.PanelLeft.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelReport
        '
        LabelReport.Anchor = System.Windows.Forms.AnchorStyles.None
        LabelReport.AutoSize = True
        LabelReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        LabelReport.Location = New System.Drawing.Point(563, 34)
        LabelReport.Name = "LabelReport"
        LabelReport.Size = New System.Drawing.Size(130, 51)
        LabelReport.TabIndex = 9
        LabelReport.Text = "Menu"
        '
        'Label1
        '
        Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Label1.Location = New System.Drawing.Point(346, 120)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(200, 51)
        Label1.TabIndex = 10
        Label1.Text = "Makanan"
        '
        'Label2
        '
        Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Label2.Location = New System.Drawing.Point(688, 120)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(200, 51)
        Label2.TabIndex = 11
        Label2.Text = "Minuman"
        '
        'Label3
        '
        Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Label3.Location = New System.Drawing.Point(1033, 50)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(90, 51)
        Label3.TabIndex = 12
        Label3.Text = "List"
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
        Me.PanelLeft.TabIndex = 6
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
        'TimerPanelIncrease
        '
        Me.TimerPanelIncrease.Interval = 1
        '
        'TimerPanelReduce
        '
        Me.TimerPanelReduce.Interval = 1
        '
        'ButtonBayar
        '
        Me.ButtonBayar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ButtonBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ButtonBayar.Location = New System.Drawing.Point(1087, 688)
        Me.ButtonBayar.Name = "ButtonBayar"
        Me.ButtonBayar.Size = New System.Drawing.Size(135, 61)
        Me.ButtonBayar.TabIndex = 10
        Me.ButtonBayar.Text = "Bayar"
        Me.ButtonBayar.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1072, 610)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total:"
        '
        'tbHarga
        '
        Me.tbHarga.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbHarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.tbHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.tbHarga.Location = New System.Drawing.Point(961, 635)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.ReadOnly = True
        Me.tbHarga.Size = New System.Drawing.Size(267, 38)
        Me.tbHarga.TabIndex = 18
        Me.tbHarga.Text = "0"
        '
        'btnResetList
        '
        Me.btnResetList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnResetList.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnResetList.Image = CType(resources.GetObject("btnResetList.Image"), System.Drawing.Image)
        Me.btnResetList.Location = New System.Drawing.Point(1129, 54)
        Me.btnResetList.Name = "btnResetList"
        Me.btnResetList.Size = New System.Drawing.Size(44, 47)
        Me.btnResetList.TabIndex = 13
        Me.btnResetList.UseVisualStyleBackColor = False
        '
        'PanelMakanan
        '
        Me.PanelMakanan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMakanan.AutoScroll = True
        Me.PanelMakanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PanelMakanan.Location = New System.Drawing.Point(292, 174)
        Me.PanelMakanan.Name = "PanelMakanan"
        Me.PanelMakanan.Size = New System.Drawing.Size(300, 546)
        Me.PanelMakanan.TabIndex = 22
        '
        'PanelMinuman
        '
        Me.PanelMinuman.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMinuman.AutoScroll = True
        Me.PanelMinuman.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PanelMinuman.Location = New System.Drawing.Point(640, 174)
        Me.PanelMinuman.Name = "PanelMinuman"
        Me.PanelMinuman.Size = New System.Drawing.Size(300, 546)
        Me.PanelMinuman.TabIndex = 23
        '
        'PanelList
        '
        Me.PanelList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelList.AutoScroll = True
        Me.PanelList.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PanelList.Location = New System.Drawing.Point(961, 120)
        Me.PanelList.Name = "PanelList"
        Me.PanelList.Size = New System.Drawing.Size(267, 476)
        Me.PanelList.TabIndex = 23
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = Global.Restooo.My.Resources.Resources.RESTOOOO__5_
        Me.PictureBoxLogo.Location = New System.Drawing.Point(0, 304)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(200, 225)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 307
        Me.PictureBoxLogo.TabStop = False
        '
        'MenuMakan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.PanelList)
        Me.Controls.Add(Me.PanelMinuman)
        Me.Controls.Add(Me.PanelMakanan)
        Me.Controls.Add(Me.tbHarga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnResetList)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ButtonBayar)
        Me.Controls.Add(LabelReport)
        Me.Controls.Add(Me.PanelLeft)
        Me.Name = "MenuMakan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.PanelTopLeft.ResumeLayout(False)
        Me.PanelLeft.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelTopLeft As Panel
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents TimerPanelReduce As Timer
    Friend WithEvents ButtonBayar As Button
    Friend WithEvents btnResetList As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label4 As Label
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents ButtonMenuBurger As Button
    Friend WithEvents ButtonReport As Button
    Friend WithEvents ButtonStock As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents ButtonStatus As Button
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents PanelMakanan As Panel
    Friend WithEvents PanelMinuman As Panel
    Friend WithEvents PanelList As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
