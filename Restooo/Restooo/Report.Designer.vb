﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.ButtonStatus = New System.Windows.Forms.Button()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.ButtonReport = New System.Windows.Forms.Button()
        Me.ButtonStock = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.PanelTopLeft = New System.Windows.Forms.Panel()
        Me.ButtonMenuBurger = New System.Windows.Forms.Button()
        Me.TimerPanelReduce = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewReport = New System.Windows.Forms.DataGridView()
        Me.LabelReport = New System.Windows.Forms.Label()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.DataGridViewReportDetail = New System.Windows.Forms.DataGridView()
        Me.PanelLeft.SuspendLayout()
        Me.PanelTopLeft.SuspendLayout()
        CType(Me.DataGridViewReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewReportDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelLeft.TabIndex = 2
        '
        'ButtonStatus
        '
        Me.ButtonStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStatus.Image = Global.Restooo.My.Resources.Resources.Iconsmind_Outline_Profile_32
        Me.ButtonStatus.Location = New System.Drawing.Point(150, 711)
        Me.ButtonStatus.Name = "ButtonStatus"
        Me.ButtonStatus.Size = New System.Drawing.Size(50, 50)
        Me.ButtonStatus.TabIndex = 11
        Me.ButtonStatus.UseVisualStyleBackColor = True
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogout.Image = Global.Restooo.My.Resources.Resources.Icons8_Windows_8_User_Interface_Logout_32
        Me.ButtonLogout.Location = New System.Drawing.Point(0, 711)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(50, 50)
        Me.ButtonLogout.TabIndex = 10
        Me.ButtonLogout.UseVisualStyleBackColor = True
        '
        'ButtonReport
        '
        Me.ButtonReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReport.Image = Global.Restooo.My.Resources.Resources.Icons8_Windows_8_Food_List_Ingredients_32
        Me.ButtonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonReport.Location = New System.Drawing.Point(0, 244)
        Me.ButtonReport.Name = "ButtonReport"
        Me.ButtonReport.Size = New System.Drawing.Size(200, 54)
        Me.ButtonReport.TabIndex = 9
        Me.ButtonReport.Text = "Report"
        Me.ButtonReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonReport.UseVisualStyleBackColor = True
        '
        'ButtonStock
        '
        Me.ButtonStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStock.Image = Global.Restooo.My.Resources.Resources.Iconoir_Team_Iconoir_Packages_32
        Me.ButtonStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStock.Location = New System.Drawing.Point(0, 184)
        Me.ButtonStock.Name = "ButtonStock"
        Me.ButtonStock.Size = New System.Drawing.Size(200, 54)
        Me.ButtonStock.TabIndex = 8
        Me.ButtonStock.Text = "Stock"
        Me.ButtonStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonStock.UseVisualStyleBackColor = True
        '
        'ButtonMenu
        '
        Me.ButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenu.Image = Global.Restooo.My.Resources.Resources.Aniket_Suvarna_Box_Regular_Bx_food_menu_32
        Me.ButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMenu.Location = New System.Drawing.Point(0, 124)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(200, 54)
        Me.ButtonMenu.TabIndex = 7
        Me.ButtonMenu.Text = "Menu"
        Me.ButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDashboard.Image = Global.Restooo.My.Resources.Resources.Amitjakhu_Drip_Home_32
        Me.ButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDashboard.Location = New System.Drawing.Point(0, 64)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(200, 54)
        Me.ButtonDashboard.TabIndex = 6
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'PanelTopLeft
        '
        Me.PanelTopLeft.Controls.Add(Me.ButtonMenuBurger)
        Me.PanelTopLeft.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTopLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelTopLeft.Name = "PanelTopLeft"
        Me.PanelTopLeft.Size = New System.Drawing.Size(200, 58)
        Me.PanelTopLeft.TabIndex = 0
        '
        'ButtonMenuBurger
        '
        Me.ButtonMenuBurger.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMenuBurger.Image = CType(resources.GetObject("ButtonMenuBurger.Image"), System.Drawing.Image)
        Me.ButtonMenuBurger.Location = New System.Drawing.Point(147, 0)
        Me.ButtonMenuBurger.Name = "ButtonMenuBurger"
        Me.ButtonMenuBurger.Size = New System.Drawing.Size(53, 58)
        Me.ButtonMenuBurger.TabIndex = 1
        Me.ButtonMenuBurger.UseVisualStyleBackColor = True
        '
        'TimerPanelReduce
        '
        Me.TimerPanelReduce.Interval = 1
        '
        'TimerPanelIncrease
        '
        Me.TimerPanelIncrease.Interval = 1
        '
        'DataGridViewReport
        '
        Me.DataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewReport.Location = New System.Drawing.Point(321, 112)
        Me.DataGridViewReport.Name = "DataGridViewReport"
        Me.DataGridViewReport.Size = New System.Drawing.Size(796, 362)
        Me.DataGridViewReport.TabIndex = 3
        '
        'LabelReport
        '
        Me.LabelReport.AutoSize = True
        Me.LabelReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReport.Location = New System.Drawing.Point(639, 37)
        Me.LabelReport.Name = "LabelReport"
        Me.LabelReport.Size = New System.Drawing.Size(151, 51)
        Me.LabelReport.TabIndex = 4
        Me.LabelReport.Text = "Report"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Image = CType(resources.GetObject("ButtonRefresh.Image"), System.Drawing.Image)
        Me.ButtonRefresh.Location = New System.Drawing.Point(796, 50)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(49, 38)
        Me.ButtonRefresh.TabIndex = 10
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'DataGridViewReportDetail
        '
        Me.DataGridViewReportDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewReportDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewReportDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewReportDetail.Location = New System.Drawing.Point(321, 494)
        Me.DataGridViewReportDetail.Name = "DataGridViewReportDetail"
        Me.DataGridViewReportDetail.Size = New System.Drawing.Size(796, 139)
        Me.DataGridViewReportDetail.TabIndex = 11
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.DataGridViewReportDetail)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.LabelReport)
        Me.Controls.Add(Me.DataGridViewReport)
        Me.Controls.Add(Me.PanelLeft)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelTopLeft.ResumeLayout(False)
        CType(Me.DataGridViewReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewReportDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelTopLeft As Panel
    Friend WithEvents TimerPanelReduce As Timer
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents DataGridViewReport As DataGridView
    Friend WithEvents LabelReport As Label
    Friend WithEvents ButtonMenuBurger As Button
    Friend WithEvents ButtonReport As Button
    Friend WithEvents ButtonStock As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents ButtonStatus As Button
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents DataGridViewReportDetail As DataGridView
End Class
