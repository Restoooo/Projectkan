﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.LabelLoadingMessage = New System.Windows.Forms.Label()
        Me.ProgressBarLoading = New System.Windows.Forms.ProgressBar()
        Me.TimerLoading = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelLoadingMessage
        '
        Me.LabelLoadingMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelLoadingMessage.AutoSize = True
        Me.LabelLoadingMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoadingMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.LabelLoadingMessage.Location = New System.Drawing.Point(433, 354)
        Me.LabelLoadingMessage.Name = "LabelLoadingMessage"
        Me.LabelLoadingMessage.Size = New System.Drawing.Size(391, 108)
        Me.LabelLoadingMessage.TabIndex = 0
        Me.LabelLoadingMessage.Text = "Loading"
        '
        'ProgressBarLoading
        '
        Me.ProgressBarLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBarLoading.Location = New System.Drawing.Point(411, 465)
        Me.ProgressBarLoading.MarqueeAnimationSpeed = 120
        Me.ProgressBarLoading.Maximum = 120
        Me.ProgressBarLoading.Name = "ProgressBarLoading"
        Me.ProgressBarLoading.Size = New System.Drawing.Size(435, 41)
        Me.ProgressBarLoading.TabIndex = 1
        '
        'TimerLoading
        '
        Me.TimerLoading.Interval = 1000
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(438, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(379, 321)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ProgressBarLoading)
        Me.Controls.Add(Me.LabelLoadingMessage)
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelLoadingMessage As Label
    Friend WithEvents ProgressBarLoading As ProgressBar
    Friend WithEvents TimerLoading As Timer
    Friend WithEvents PictureBox3 As PictureBox
End Class
