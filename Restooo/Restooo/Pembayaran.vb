﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Pembayaran

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub ButtonStatus_Click(sender As Object, e As EventArgs) Handles ButtonStatus.Click
        Status.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click
        Report.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonStock_Click(sender As Object, e As EventArgs) Handles ButtonStock.Click
        Stock.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        MenuDuduk.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonBurgerMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenuBurger.Click
        If PanelLeft.Width > 50 Then
            TimerPanelReduce.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
        End If
    End Sub

    Private Sub TimerPanelReduce_Tick(sender As Object, e As EventArgs) Handles TimerPanelReduce.Tick
        If PanelLeft.Width > 50 Then
            ButtonDashboard.Width -= 5
            ButtonMenu.Width -= 5
            ButtonStock.Width -= 5
            ButtonReport.Width -= 5
            PanelLeft.Width -= 5
            ButtonDashboard.Text = ""
            ButtonMenu.Text = ""
            ButtonStock.Text = ""
            ButtonReport.Text = ""
        Else
            TimerPanelReduce.Enabled = False
        End If
    End Sub
    Private Sub TimerPanelIncrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelIncrease.Tick
        If PanelLeft.Width < 200 Then
            ButtonDashboard.Width += 5
            ButtonMenu.Width += 5
            ButtonStock.Width += 5
            ButtonReport.Width += 5
            PanelLeft.Width += 5
            ButtonDashboard.Text = "Dashboard"
            ButtonMenu.Text = "Menu"
            ButtonStock.Text = "Stock"
            ButtonReport.Text = "Report"
        Else
            TimerPanelIncrease.Enabled = False
        End If
    End Sub

    Dim orderedItems As List(Of String)
        Dim totalharga As Integer

    Public Sub New(ByVal pesanan As List(Of String), ByVal totalharga As Integer)
        InitializeComponent()
        orderedItems = pesanan
        Me.totalharga = totalharga
    End Sub

    Private Sub PembayaranForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatePanelPembayaran()
    End Sub

    Private Sub UpdatePanelPembayaran()
        PanelPembayaran.Controls.Clear()
        Dim posYpesanan As Integer = 0

        For Each item As String In orderedItems
            Dim label As New Label()
            label.Text = item
            label.Size = New Size(300, 30)
            label.AutoSize = False
            label.TextAlign = ContentAlignment.MiddleLeft
            label.Padding = New Padding(0, 0, 10, 0)
            label.Location = New Point(0, posYpesanan)

            ' Extract menu name and price
            Dim parts() As String = item.Split("|"c)
            If parts.Length = 3 Then
                label.Text = $"{parts(1).Trim()} - Rp. {parts(2).Trim()}"
            End If

            PanelPembayaran.Controls.Add(label)
            posYpesanan += 40
        Next

        ' Add label for total payment
        Dim labelTotalHarga As New Label()
        labelTotalHarga.Text = $"Total Harga: Rp. {totalharga.ToString()}"
        labelTotalHarga.Size = New Size(300, 30)
        labelTotalHarga.AutoSize = False
        labelTotalHarga.Font = New Font(labelTotalHarga.Font.FontFamily, 12, FontStyle.Bold)
        labelTotalHarga.TextAlign = ContentAlignment.MiddleLeft
        labelTotalHarga.Location = New Point(0, posYpesanan + 20)
        PanelPembayaran.Controls.Add(labelTotalHarga)
    End Sub


End Class