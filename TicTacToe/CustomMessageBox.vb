﻿Public Class CustomMessageBox
    Public Sub New(ByVal message As String, ByVal numB As Integer, ByVal button1Name As String, ByVal button2name As String, ByVal button3name As String, ByVal header As String)
        InitializeComponent()
        Label1.Text = message
        If Form1.CheckBox1.Checked = True Then
            Me.BackColor = SystemColors.ControlText
            Me.ForeColor = SystemColors.Control
            Label1.ForeColor = SystemColors.Control
            Button1.BackColor = SystemColors.ControlText
            Button1.ForeColor = SystemColors.Control
            Button2.BackColor = SystemColors.ControlText
            Button2.ForeColor = SystemColors.Control
            Button3.BackColor = SystemColors.ControlText
            Button3.ForeColor = SystemColors.Control
            PictureBox1.BackColor = Color.FromArgb(15, 15, 15)
        End If
        If numB = 0 Then
            numB = 1
        End If
        If numB = 1 Then
            Button1.Text = button1Name
            Button1.Location = New Point(104, 80)
            Button2.Hide()
            Button3.Hide()
        ElseIf numB = 2 Then
            Button1.Text = button1Name
            Button2.Text = button2name
            Button1.Location = New Point(37, 80)
            Button2.Location = New Point(163, 80)
            Button3.Hide()
        ElseIf numB = 3 Then
            Button1.Text = button1Name
            Button2.Text = button2name
            Button3.Text = button3name
            Button1.Location = New Point(10, 80)
            Button2.Location = New Point(104, 80)
            Button3.Location = New Point(197, 80)
        End If
        Me.Text = header
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DialogResult = Windows.Forms.DialogResult.No
        Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub
End Class