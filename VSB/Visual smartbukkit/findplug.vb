Public Class findplug


    Private Sub JButton3_Click(sender As Object, e As EventArgs) Handles JButton3.Click
        'MsgBox(ListView1.SelectedItems.Item(0).SubItems.Item(1).Text)

        If ListView1.SelectedIndices.Count = 0 Then
            Exit Sub
        End If

        Dim it As String = ListView1.SelectedItems.Item(0).SubItems.Item(1).Text

        Process.Start("http://dev.bukkit.org/server-mods/" & it)

    End Sub


End Class