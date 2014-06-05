Option Explicit On


Public Class bukcom
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Friend Declare Function SetForegroundWindow Lib "user32" (ByVal hwnd As Integer) As Integer







    Private Sub cc(ByVal prompt As String)
        Dim fw As Integer = FindWindow(vbNullString, "파란닌자 맞춤 실행기")

        If fw = 0 Then
            MsgBox("버킷이 켜져있지 않습니다.", MsgBoxStyle.Information)
            Exit Sub
        End If


        SetForegroundWindow(fw)
        SendKeys.Send(prompt & "{ENTER}")
        una.Clear()
    End Sub


    Private Function es() As Boolean
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\plugins\essentials.jar") = True Then
            Return True
            Exit Function
        End If



        Return False

    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cc("stop")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("로그인 플러그인이 설치되어있는경우 리로드시 현재 접속해있는 유저의 아이템이 날아갈수도 있습니다." & vbCrLf & "계속하시겠습니까?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cc("reload")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cc("save-all")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cc("ping")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cc("time set 0")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cc("toggledownfall")
    End Sub

    Private Sub Ban_Click(sender As Object, e As EventArgs) Handles Ban.Click
        cc("ban " & una.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        cc("pardon " & una.Text)
    End Sub



    Private Sub ipBan_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If es() = True Then
            cc("mute " & una.Text)
        Else
            MsgBox("본기능은 에센셜플러그인이 설치되어있어야 작동합니다.")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        cc("op " & una.Text)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        cc("deop " & una.Text)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button18.Click
        cc("gamemode 0 " & una.Text)
    End Sub






    Private Sub Button18_Click(sender As Object, e As EventArgs)
        cc("god " & una.Text)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        cc("fly " & una.Text)
    End Sub

 


    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        cc("lightning " & una.Text)
    End Sub



    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        cc("gamemode 1 " & una.Text)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        cc("gamemode 2 " & una.Text)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        cc("kill " & una.Text)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        cc("heal " & una.Text)
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        cc("god " & una.Text)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        cc("fly " & una.Text)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        cc("clearinventory " & una.Text)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click

        cc("spawn " & una.Text)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        cc("list")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        cc("Kick " & una.Text)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim fa As New Form

        '"148, 256
        fa.Size = New Point(740, 1287)
        Dim gg As New PictureBox
        gg.Image = My.Resources.코드
        gg.Dock = DockStyle.Fill
        gg.SizeMode = PictureBoxSizeMode.Zoom
        fa.Controls.Add(gg)
        fa.Show()


    End Sub

 
    Private Sub igive_Click(sender As Object, e As EventArgs) Handles igive.Click

        If iuser.Text = "" Then
            MsgBox("빈칸을 모두 입력해주세요", vbInformation)
            Exit Sub
        End If
        If icode.Text = "" Then
            MsgBox("빈칸을 모두 입력해주세요", vbInformation)
            Exit Sub
        End If

        cc("give " & iuser.Text & " " & icode.Text & " " & iamount.Value.ToString)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cc("time night")
    End Sub
End Class