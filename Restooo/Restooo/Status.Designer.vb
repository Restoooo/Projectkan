<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Status))
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.ButtonStatus = New System.Windows.Forms.Button()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.ButtonReport = New System.Windows.Forms.Button()
        Me.ButtonStock = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.PanelTopLeft = New System.Windows.Forms.Panel()
        Me.ButtonMenuBurger = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelTimer = New System.Windows.Forms.Label()
        Me.LabelPesanan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerPanelReduce = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimerStatus = New System.Windows.Forms.Timer(Me.components)
        Me.RoundedRectangleControlPanel1 = New Restooo.RoundedRectangleControlPanel()
        Me.RoundedRectangleControlPanel2 = New Restooo.RoundedRectangleControlPanel()
        Me.RoundedRectangleControlPanel3 = New Restooo.RoundedRectangleControlPanel()
        Me.RoundedRectangleControlPanel4 = New Restooo.RoundedRectangleControlPanel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelLeft.SuspendLayout()
        Me.PanelTopLeft.SuspendLayout()
        Me.RoundedRectangleControlPanel1.SuspendLayout()
        Me.RoundedRectangleControlPanel2.SuspendLayout()
        Me.RoundedRectangleControlPanel3.SuspendLayout()
        Me.RoundedRectangleControlPanel4.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelLeft.TabIndex = 1
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
        Me.ButtonStatus.TabIndex = 11
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
        Me.ButtonLogout.TabIndex = 10
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
        Me.ButtonMenuBurger.TabIndex = 3
        Me.ButtonMenuBurger.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(147, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 42)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Waktu Daring:"
        '
        'labelTimer
        '
        Me.labelTimer.AutoSize = True
        Me.labelTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.labelTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.labelTimer.Location = New System.Drawing.Point(186, 135)
        Me.labelTimer.Name = "labelTimer"
        Me.labelTimer.Size = New System.Drawing.Size(164, 42)
        Me.labelTimer.TabIndex = 6
        Me.labelTimer.Text = "00:00:00"
        '
        'LabelPesanan
        '
        Me.LabelPesanan.AutoSize = True
        Me.LabelPesanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.LabelPesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPesanan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.LabelPesanan.Location = New System.Drawing.Point(163, 15)
        Me.LabelPesanan.Name = "LabelPesanan"
        Me.LabelPesanan.Size = New System.Drawing.Size(208, 42)
        Me.LabelPesanan.TabIndex = 3
        Me.LabelPesanan.Text = "Pesanan: 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(200, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 47)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Statistik"
        '
        'txtUsername
        '
        Me.txtUsername.AutoSize = True
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(64, 95)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(460, 42)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.Text = "Username: XXXXXXXXXX"
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(64, 43)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(337, 42)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "Name: XXXXXXXX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(226, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Profil"
        '
        'TimerPanelReduce
        '
        Me.TimerPanelReduce.Interval = 1
        '
        'TimerPanelIncrease
        '
        Me.TimerPanelIncrease.Interval = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(653, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 51)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Status"
        '
        'TimerStatus
        '
        Me.TimerStatus.Interval = 1000
        '
        'RoundedRectangleControlPanel1
        '
        Me.RoundedRectangleControlPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoundedRectangleControlPanel1.BackgroundColor = System.Drawing.Color.Transparent
        Me.RoundedRectangleControlPanel1.BorderColor = System.Drawing.Color.Black
        Me.RoundedRectangleControlPanel1.BorderWidth = 1
        Me.RoundedRectangleControlPanel1.Controls.Add(Me.Label1)
        Me.RoundedRectangleControlPanel1.CornerRadius = 20
        Me.RoundedRectangleControlPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.RoundedRectangleControlPanel1.Location = New System.Drawing.Point(465, 91)
        Me.RoundedRectangleControlPanel1.Name = "RoundedRectangleControlPanel1"
        Me.RoundedRectangleControlPanel1.Size = New System.Drawing.Size(546, 62)
        Me.RoundedRectangleControlPanel1.TabIndex = 6
        '
        'RoundedRectangleControlPanel2
        '
        Me.RoundedRectangleControlPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoundedRectangleControlPanel2.BackgroundColor = System.Drawing.Color.Transparent
        Me.RoundedRectangleControlPanel2.BorderColor = System.Drawing.Color.Black
        Me.RoundedRectangleControlPanel2.BorderWidth = 1
        Me.RoundedRectangleControlPanel2.Controls.Add(Me.txtName)
        Me.RoundedRectangleControlPanel2.Controls.Add(Me.txtUsername)
        Me.RoundedRectangleControlPanel2.CornerRadius = 20
        Me.RoundedRectangleControlPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RoundedRectangleControlPanel2.Location = New System.Drawing.Point(465, 159)
        Me.RoundedRectangleControlPanel2.Name = "RoundedRectangleControlPanel2"
        Me.RoundedRectangleControlPanel2.Size = New System.Drawing.Size(546, 185)
        Me.RoundedRectangleControlPanel2.TabIndex = 7
        '
        'RoundedRectangleControlPanel3
        '
        Me.RoundedRectangleControlPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoundedRectangleControlPanel3.BackgroundColor = System.Drawing.Color.Transparent
        Me.RoundedRectangleControlPanel3.BorderColor = System.Drawing.Color.Black
        Me.RoundedRectangleControlPanel3.BorderWidth = 1
        Me.RoundedRectangleControlPanel3.Controls.Add(Me.Label4)
        Me.RoundedRectangleControlPanel3.Controls.Add(Me.LabelPesanan)
        Me.RoundedRectangleControlPanel3.Controls.Add(Me.labelTimer)
        Me.RoundedRectangleControlPanel3.CornerRadius = 20
        Me.RoundedRectangleControlPanel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RoundedRectangleControlPanel3.Location = New System.Drawing.Point(465, 480)
        Me.RoundedRectangleControlPanel3.Name = "RoundedRectangleControlPanel3"
        Me.RoundedRectangleControlPanel3.Size = New System.Drawing.Size(546, 185)
        Me.RoundedRectangleControlPanel3.TabIndex = 9
        '
        'RoundedRectangleControlPanel4
        '
        Me.RoundedRectangleControlPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoundedRectangleControlPanel4.BackgroundColor = System.Drawing.Color.Transparent
        Me.RoundedRectangleControlPanel4.BorderColor = System.Drawing.Color.Black
        Me.RoundedRectangleControlPanel4.BorderWidth = 1
        Me.RoundedRectangleControlPanel4.Controls.Add(Me.Label2)
        Me.RoundedRectangleControlPanel4.CornerRadius = 20
        Me.RoundedRectangleControlPanel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.RoundedRectangleControlPanel4.Location = New System.Drawing.Point(465, 412)
        Me.RoundedRectangleControlPanel4.Name = "RoundedRectangleControlPanel4"
        Me.RoundedRectangleControlPanel4.Size = New System.Drawing.Size(546, 62)
        Me.RoundedRectangleControlPanel4.TabIndex = 8
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = Global.Restooo.My.Resources.Resources.RESTOOOO__5_
        Me.PictureBoxLogo.Location = New System.Drawing.Point(0, 304)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(200, 225)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 310
        Me.PictureBoxLogo.TabStop = False
        '
        'Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.RoundedRectangleControlPanel3)
        Me.Controls.Add(Me.RoundedRectangleControlPanel4)
        Me.Controls.Add(Me.RoundedRectangleControlPanel2)
        Me.Controls.Add(Me.RoundedRectangleControlPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelLeft)
        Me.Name = "Status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status"
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelTopLeft.ResumeLayout(False)
        Me.RoundedRectangleControlPanel1.ResumeLayout(False)
        Me.RoundedRectangleControlPanel1.PerformLayout()
        Me.RoundedRectangleControlPanel2.ResumeLayout(False)
        Me.RoundedRectangleControlPanel2.PerformLayout()
        Me.RoundedRectangleControlPanel3.ResumeLayout(False)
        Me.RoundedRectangleControlPanel3.PerformLayout()
        Me.RoundedRectangleControlPanel4.ResumeLayout(False)
        Me.RoundedRectangleControlPanel4.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelTopLeft As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TimerPanelReduce As Timer
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents txtUsername As Label
    Friend WithEvents txtName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelPesanan As Label
    Friend WithEvents labelTimer As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonMenuBurger As Button
    Friend WithEvents ButtonReport As Button
    Friend WithEvents ButtonStock As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents ButtonStatus As Button
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents TimerStatus As Timer
    Friend WithEvents RoundedRectangleControlPanel2 As RoundedRectangleControlPanel
    Friend WithEvents RoundedRectangleControlPanel1 As RoundedRectangleControlPanel
    Friend WithEvents RoundedRectangleControlPanel3 As RoundedRectangleControlPanel
    Friend WithEvents RoundedRectangleControlPanel4 As RoundedRectangleControlPanel
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
