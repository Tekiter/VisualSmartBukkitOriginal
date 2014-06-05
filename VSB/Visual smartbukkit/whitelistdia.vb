Imports System.Windows.Forms

Public Class whitelistdia


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub whitelistdia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        whiteload()
    End Sub

    Private Sub JButton2_Click(sender As Object, e As EventArgs) Handles Cancle.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim asdf As Windows.Forms.ListBox.ObjectCollection
        asdf = whitelist.Items

        Try
            My.Computer.FileSystem.DeleteFile("white-list.txt")
        Catch ex As Exception

        End Try
        My.Computer.FileSystem.WriteAllText("white-list.txt", asdf(0), True, System.Text.Encoding.Default)

        For i = 1 To asdf.Count - 1
            My.Computer.FileSystem.WriteAllText("white-list.txt", Chr(13) & asdf(i), True, System.Text.Encoding.Default)
        Next



        Me.Close()

    End Sub









    Private Sub whiteload()
        Try
            Dim wh() As String
            wh = Split(My.Computer.FileSystem.ReadAllText("white-list.txt", System.Text.Encoding.Default), Chr(13))
            For Each i In wh
                whitelist.Items.Add(i)

            Next
        Catch ex As Exception

        End Try
        


    End Sub


    Private Sub sertxt_TextChanged(sender As Object, e As EventArgs) Handles sertxt.TextChanged
        AcceptButton = ser
    End Sub

    Private Sub ser_Click(sender As Object, e As EventArgs) Handles ser.Click


        Dim i As Integer = whitelist.FindString(sertxt.Text)

        If i = -1 Then
            MsgBox("해당 닉네임이 없습니다.")
            Exit Sub
        End If


        whitelist.SelectedIndex = i
        sertxt.Clear()
        sertxt.Focus()

    End Sub

    Private Sub whadd_Click(sender As Object, e As EventArgs) Handles whadd.Click
        If whaddtxt.Text = vbNullString Then
            Exit Sub
        End If

        If Not whitelist.FindString(whaddtxt.Text) = -1 Then

        Else
            whitelist.Items.Add(whaddtxt.Text)
        End If



        whaddtxt.Clear()
        whaddtxt.Focus()

    End Sub

    Private Sub whaddtxt_TextChanged(sender As Object, e As EventArgs) Handles whaddtxt.TextChanged
        AcceptButton = whadd
    End Sub

    Private Sub whdel_Click(sender As Object, e As EventArgs) Handles whdel.Click
        If whitelist.SelectedIndex = -1 Then
            MsgBox("선택된 항목이 없습니다.")
            Exit Sub
        End If

        whitelist.Items.RemoveAt(whitelist.SelectedIndex)


    End Sub




    'Private Sub whiteload()
    '    Dim tx() As String = Split(My.Computer.FileSystem.ReadAllText("white-list.txt"), Chr(13))

    '    For Each i In tx
    '        whitelist.Items.Add(i)
    '    Next
    'End Sub

    Private Sub whrefresh_Click(sender As Object, e As EventArgs) Handles whrefresh.Click
        whitelist.Items.Clear()
        whiteload()
    End Sub
End Class
