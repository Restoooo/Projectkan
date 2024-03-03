<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonStatus = New System.Windows.Forms.Button()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.ButtonReport = New System.Windows.Forms.Button()
        Me.ButtonStock = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.DataGridViewStock = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelReduce = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTopLeft = New System.Windows.Forms.Panel()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTopLeft.SuspendLayout()
        Me.PanelLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(151, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ButtonStatus
        '
        Me.ButtonStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStatus.Image = Global.Restooo.My.Resources.Resources.Iconsmind_Outline_Profile_32
        Me.ButtonStatus.Location = New System.Drawing.Point(147, 708)
        Me.ButtonStatus.Name = "ButtonStatus"
        Me.ButtonStatus.Size = New System.Drawing.Size(50, 50)
        Me.ButtonStatus.TabIndex = 5
        Me.ButtonStatus.UseVisualStyleBackColor = True
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogout.Image = Global.Restooo.My.Resources.Resources.Icons8_Windows_8_User_Interface_Logout_32
        Me.ButtonLogout.Location = New System.Drawing.Point(0, 707)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(50, 50)
        Me.ButtonLogout.TabIndex = 4
        Me.ButtonLogout.UseVisualStyleBackColor = True
        '
        'ButtonReport
        '
        Me.ButtonReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReport.Image = Global.Restooo.My.Resources.Resources.Icons8_Windows_8_Food_List_Ingredients_32
        Me.ButtonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonReport.Location = New System.Drawing.Point(0, 220)
        Me.ButtonReport.Name = "ButtonReport"
        Me.ButtonReport.Size = New System.Drawing.Size(200, 54)
        Me.ButtonReport.TabIndex = 3
        Me.ButtonReport.Text = "Report"
        Me.ButtonReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonReport.UseVisualStyleBackColor = True
        '
        'ButtonStock
        '
        Me.ButtonStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStock.Image = Global.Restooo.My.Resources.Resources.Iconoir_Team_Iconoir_Packages_32
        Me.ButtonStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStock.Location = New System.Drawing.Point(0, 166)
        Me.ButtonStock.Name = "ButtonStock"
        Me.ButtonStock.Size = New System.Drawing.Size(200, 54)
        Me.ButtonStock.TabIndex = 2
        Me.ButtonStock.Text = "Stock"
        Me.ButtonStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonStock.UseVisualStyleBackColor = True
        '
        'ButtonMenu
        '
        Me.ButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenu.Image = Global.Restooo.My.Resources.Resources.Aniket_Suvarna_Box_Regular_Bx_food_menu_32
        Me.ButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu.Location = New System.Drawing.Point(0, 112)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(200, 54)
        Me.ButtonMenu.TabIndex = 1
        Me.ButtonMenu.Text = "Menu"
        Me.ButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDashboard.Image = Global.Restooo.My.Resources.Resources.Amitjakhu_Drip_Home_32
        Me.ButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDashboard.Location = New System.Drawing.Point(0, 58)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(200, 54)
        Me.ButtonDashboard.TabIndex = 0
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStock.Location = New System.Drawing.Point(639, 37)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(131, 51)
        Me.LabelStock.TabIndex = 7
        Me.LabelStock.Text = "Stock"
        '
        'DataGridViewStock
        '
        Me.DataGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridViewStock.Location = New System.Drawing.Point(469, 112)
        Me.DataGridViewStock.Name = "DataGridViewStock"
        Me.DataGridViewStock.Size = New System.Drawing.Size(458, 313)
        Me.DataGridViewStock.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Nama Menu"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Jumlah Stok"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'TimerPanelIncrease
        '
        Me.TimerPanelIncrease.Interval = 1
        '
        'TimerPanelReduce
        '
        Me.TimerPanelReduce.Interval = 1
        '
        'PanelTopLeft
        '
        Me.PanelTopLeft.Controls.Add(Me.PictureBox1)
        Me.PanelTopLeft.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTopLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelTopLeft.Name = "PanelTopLeft"
        Me.PanelTopLeft.Size = New System.Drawing.Size(200, 58)
        Me.PanelTopLeft.TabIndex = 0
        '
        'PanelLeft
        '
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
        Me.PanelLeft.TabIndex = 5
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.LabelStock)
        Me.Controls.Add(Me.DataGridViewStock)
        Me.Controls.Add(Me.PanelLeft)
        Me.Name = "Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTopLeft.ResumeLayout(False)
        Me.PanelLeft.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonStatus As Button
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents ButtonReport As Button
    Friend WithEvents ButtonStock As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelStock As Label
    Friend WithEvents DataGridViewStock As DataGridView
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents TimerPanelReduce As Timer
    Friend WithEvents PanelTopLeft As Panel
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
