Public Class Form4

    Private Sub JButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        Dim files As Collections.ObjectModel.ReadOnlyCollection(Of String)
        files = My.Computer.FileSystem.GetFiles(Environ("appdata") & "\Smartbukkit\VSBplugins\info")

        For i = 0 To files.Count - 1
            Try
                Dim ss() As String = Split(Split(My.Computer.FileSystem.ReadAllText(files.Item(i), System.Text.Encoding.Default), Chr(13))(0), "::")
                If ss(0) <> "VSBplinfo-1.0.0" Then
                    ss(4) = "실행불가"
                End If
                Dim asdf As ListViewItem = New ListViewItem(New String() {ss(1), ss(2), ss(3), ss(4)}, -1)
                ListView1.Items.AddRange(New ListViewItem() {asdf})
            Catch ex As Exception

            End Try
            
        Next

    End Sub
End Class