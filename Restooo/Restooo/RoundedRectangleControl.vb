Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

<DesignerCategory("Code")>
Public Class RoundedRectangleControlPanel
    Inherits Panel

    Public Property CornerRadius As Integer
    Public Property FillColor As Color
    Public Property BorderColor As Color
    Public Property BorderWidth As Integer
    Public Property BackgroundColor As Color ' Tambahkan properti warna latar belakang

    Public Sub New()
        CornerRadius = 20 ' Atur radius untuk seluruh sudut
        FillColor = Color.LightGray
        BorderColor = Color.Black
        BorderWidth = 1
        BackgroundColor = Color.Transparent ' Atur warna latar belakang menjadi transparan
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim rect As New Rectangle(BorderWidth, BorderWidth, Me.Width - (2 * BorderWidth), Me.Height - (2 * BorderWidth))
        Using path As GraphicsPath = GetRoundedRect(rect, CornerRadius)
            ' Fill the rectangle
            Using brush As New SolidBrush(FillColor)
                e.Graphics.FillPath(brush, path)
            End Using
            ' Draw the border
            Using pen As New Pen(BorderColor, BorderWidth)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using

        ' Fill the background with the specified color
        Using backgroundBrush As New SolidBrush(BackgroundColor)
            e.Graphics.FillRectangle(backgroundBrush, ClientRectangle)
        End Using
    End Sub

    Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        Dim diameter As Integer = radius * 2

        ' Buat seluruh bagian menjadi sudut yang dibulatkan
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90) ' Kiri atas
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90) ' Kanan atas
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90) ' Kanan bawah
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90) ' Kiri bawah
        path.CloseFigure()

        Return path
    End Function
End Class
