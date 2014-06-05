Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        alne.Text = "가능"
        spmob.Text = "허용"
        spnpc.Text = "허용"
        spani.Text = "허용"
        white.Text = "사용안함"
        diffi.Text = "쉬움"
        gamemo.Text = "서바이벌"
        premi.Text = "복돌도 들어올수있음"
        pvp.Text = "허용"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        OK.Enabled = False
        Button1.Enabled = False

        If My.Computer.FileSystem.FileExists("server.properties") Then
            My.Computer.FileSystem.DeleteFile("server.properties")
        End If
        If alne.Text = "가능" Then
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "allow-nether=true", True)
        Else
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "allow-nether=false", True)
            Shell("cmd /c echo allow-nether=false>>server.properties", vbHide)
        End If

        My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "level-name=world" & vbCrLf & "enable-query=false" & vbCrLf & "allow-flight=false" & vbCrLf & "server-port=25565" & vbCrLf & "level-type=DEFAULT" & vbCrLf & "enable-rcon=false" & vbCrLf & "level-seed=" & vbCrLf & "server-ip=" & vbCrLf & "max-build-height=" & hblock.Value.ToString, True)

        If spnpc.Text = "허용" Then
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "spawn-npcs=true", True)
        Else
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "spawn-npcs=false", True)
        End If

        If white.Text = "사용" Then
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "white-list=true", True)
        Else
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "white-list=false", True)
        End If

        If spani.Text = "허용" Then
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "spawn-animals=true", True)
        Else
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "spawn-animals=false", True)
        End If

        My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "snooper-enabled=true" & vbCrLf & "texture-pack=", True)



        If premi.Text = "정품만 들어올수있음" Then
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "online-mode=true", True)
        Else
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "online-mode=false", True)
        End If

        If pvp.Text = "허용" Then
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "pvp=true", True)
        Else
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "pvp=false", True)
        End If

        Dim dif As String

        If diffi.Text = "쉬움" Then
            dif = "1"
        ElseIf diffi.Text = "보통" Then
            dif = "2"
        ElseIf diffi.Text = "어려움" Then
            dif = "3"
        Else
            dif = "0"
        End If
        My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "difficulty=" & dif & vbCrLf & "server-Name=Unknown Server", True)

        If gamemo.Text = "서바이벌" Then
            dif = "0"
        ElseIf gamemo.Text = "크리에이티브" Then
            dif = "1"
        Else
            dif = "2"
        End If
        My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "gamemode=" & dif, True)
        Dim num As Integer
        num = member.Value

        My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "max-players=" & num, True)

        If spmob.Text = "허용" Then
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "spawn-monsters=true", True)

        Else
            My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "spawn-monsters=false", True)

        End If
        My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "generate-structures=true" & vbCrLf & "view-distance=10", True)

        My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "spawn-protection=" & prota.Value.ToString, True)

        dif = motd.Text
        My.Computer.FileSystem.WriteAllText("server.properties", vbCrLf & "motd=" & dif, True)
        Me.Close()




    End Sub

    Private Sub protac_CheckedChanged(sender As Object, e As EventArgs) Handles protac.CheckedChanged
        If protac.Checked = True Then
            prota.Enabled = False
            prota.Text = 0
        Else
            prota.Enabled = True

        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles hblock.Scroll
        hblockh.Text = hblock.Value.ToString & "칸"
    End Sub
End Class