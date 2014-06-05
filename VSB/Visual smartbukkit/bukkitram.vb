Public Class bukkitram

    'Private tfm As String = ""

    Private Sub bukkitram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim ram As ULong = My.Computer.Info.TotalPhysicalMemory
        'Dim sram(ram.ToString.Length - 1 - 4) As Char
        'For i = 0 To ram.ToString.Length - 4 - 1
        '    sram(i) = ram.ToString.Substring(i, 1)

        'Next


        'For Each i In sram
        '    tfm &= i
        'Next

        'Dim tm As UShort = CUShort(tfm)

        'sMemory.Text = tfm

        'If tm < 1000 Then
        '    MsgBox("시스템에 장착된 메모리가 너무 작아" & vbCrLf & "서버할당 메모리를 조정할수 없습니다.", MsgBoxStyle.Information)
        '    Me.Close()
        'End If



        Dim ram As ULong = My.Computer.Info.TotalPhysicalMemory

        ram = ram / 100000000

        If ram < 10 Then
            MsgBox("시스템에 장착된 메모리가 너무 작아" & vbCrLf & "서버할당 메모리를 조정할수 없습니다.", MsgBoxStyle.Information)
            Me.Close()
        End If

        rSlider.Maximum = Int(ram * 10 - 100)
        rSlider.TickFrequency = Int((ram * 10 - 100) / 10)
        sMemory.Text = "약 " & ram.ToString & "00 MB"

        maxRam.Text = "약 " & CStr(ram - 10) & "00 MB"
    End Sub





    Private Sub JButton1_Click(sender As Object, e As EventArgs) Handles JButton1.Click
        Me.Close()
    End Sub

    Private Sub JButton2_Click(sender As Object, e As EventArgs) Handles JButton2.Click

    End Sub

    Private Sub rSlider_Scroll(sender As Object, e As EventArgs) Handles rSlider.Scroll
        Dim ram As ULong = My.Computer.Info.TotalPhysicalMemory

        ram = ram / 10000000

        Label1.Text = rSlider.Value.ToString & "0 MB / " & CStr(ram - 100) & "0 MB" & vbCrLf & "(" & rSlider.Value / CULng(rSlider.Value) * 100 & "%)"
    End Sub
End Class