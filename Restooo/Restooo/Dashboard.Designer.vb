﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelLeft.SuspendLayout()
        Me.PanelTopLeft.SuspendLayout()
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
        Me.PanelLeft.TabIndex = 0
        '
        'ButtonStatus
        '
        Me.ButtonStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStatus.Image = Global.Restooo.My.Resources.Resources.Iconsmind_Outline_Profile_32
        Me.ButtonStatus.Location = New System.Drawing.Point(150, 711)
        Me.ButtonStatus.Name = "ButtonStatus"
        Me.ButtonStatus.Size = New System.Drawing.Size(50, 50)
        Me.ButtonStatus.TabIndex = 5
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
        Me.ButtonLogout.TabIndex = 4
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
        Me.ButtonReport.TabIndex = 3
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
        Me.ButtonStock.TabIndex = 2
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
        Me.ButtonMenu.TabIndex = 1
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
        Me.ButtonDashboard.TabIndex = 0
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
        Me.ButtonMenuBurger.TabIndex = 0
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
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1064, 761)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selamat datang, XXXX!!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelLeft)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelTopLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelTopLeft As Panel
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents ButtonStatus As Button
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents ButtonReport As Button
    Friend WithEvents ButtonStock As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents TimerPanelReduce As Timer
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents ButtonMenuBurger As Button
    Friend WithEvents Label1 As Label
End Class
