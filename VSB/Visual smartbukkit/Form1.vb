Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System
Imports System.Diagnostics
Imports System.ComponentModel



Public Class form1

    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Short

    Private worldz, chdl As String
    Private checkz As String
    Private thc As Boolean
    Private mymem As ULong

    Private Sub form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If thc = True Then
            If MsgBox("최신버킷 다운로드가 진행중입니다." & vbCrLf & "정말 종료하시겠습니까?", vbYesNo) = vbNo Then
                e.Cancel = True
            Else

            End If
        End If
    End Sub
    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = ""


        If My.Settings.OnOff = Nothing Then
            My.Settings.OnOff = True
        Else
            Seronoff.Checked = My.Settings.OnOff
        End If



        pluginload()

        If FileExists("craftbukkit.jar") = False Then
            'Dim dlth As New System.Threading.Thread(AddressOf budown)

            'inforpro.Style = ProgressBarStyle.Marquee
            'inforl.Text = "정보를 확인중입니다... "
            'inforpro.Visible = True
            'inforl.Visible = True
            'dlth.Start()

            'Timer1.Interval = 1000
            'Timer1.Enabled = True



            dlbukkit.StartPosition = FormStartPosition.CenterScreen

            dlbukkit.ShowDialog()

        End If

        If FileExists("스마트버킷실행기.bat") = False Then
            WriteAllBytes("스마트버킷실행기.bat", My.Resources.스마트버킷실행기, False)
        End If

        Timer2.Enabled = My.Settings.OnOff

        mymem = My.Computer.Info.TotalPhysicalMemory

    End Sub



    Private Sub 스마트버킷정보ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 스마트버킷정보ToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub


    Private Sub serverpro_over(ByVal sender As System.Object, ByVal e As System.EventArgs)
        inforbot.Text = "server.properties 의 정보를 수정합니다."
    End Sub

    Private Sub whitelist_over(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.MouseHover
        inforbot.Text = "화이트리스트의 정보를봅니다."
    End Sub

    Private Sub file_over(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 파일FToolStripMenuItem.MouseHover
        inforbot.Text = "파일"
    End Sub

    Private Sub bukkit_over(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 폴더ToolStripMenuItem.MouseHover
        inforbot.Text = "버킷"
    End Sub

    Private Sub infor_over(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 정보IToolStripMenuItem.MouseHover
        inforbot.Text = "정보"
    End Sub

    Private Sub menu_over(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menuitem.MouseHover
        inforbot.Text = ""
    End Sub

    Private Sub tabs_over(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.MouseHover
        inforbot.Text = ""
    End Sub







    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("""C:\program files\Windows NT\Accessories\wordpad.exe"" server.properties", vbNormalFocus)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FileExists("server.properties") = True Then
            DeleteFile("server.properties")

        End If
        MsgBox("초기화가 완료되었습니다!")
    End Sub







    




    Private Sub 끝내기ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 끝내기ToolStripMenuItem.Click
        End
    End Sub

    'Private Sub 최신버킷다운로드ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 최신버킷다운로드ToolStripMenuItem1.Click
    '    If MsgBox("최신버킷 다운로드를 시작하시겠습니까?", vbYesNo) = vbYes Then

    '        Dim dlth As New System.Threading.Thread(AddressOf budown)

    '        inforpro.Style = ProgressBarStyle.Marquee
    '        inforl.Text = "정보를 확인중입니다... "
    '        inforpro.Visible = True
    '        inforl.Visible = True
    '        dlth.Start()

    '        Timer1.Interval = 1000
    '        Timer1.Enabled = True

    '    End If
    '    'If MsgBox("최신버킷을 다운로드 하시겠습니까?", vbYesNo, "최신버킷 다운로드") = vbYes Then
    '    '    My.Computer.Network.DownloadFile("http://cbukk.it/craftbukkit.jar", Application.StartupPath & "\craftbukkit.jar", "", "", True, 100, True)
    '    '    MsgBox("다운로드 완료!")

    '    'End If





    'End Sub

    'Friend Sub budown()

    '    thc = True
    '    Try
    '        My.Computer.Network.DownloadFile("https://dl.dropbox.com/s/apda7awkhmdxjx8/B_version.txt?dl=1", Environ("appdata") & "\smartbukkit\bver.stg", "", "", False, 500000, True)
    '    Catch ex As Exception
    '        MsgBox("업데이트에 실패하였습니다." & vbCrLf & "(ERROR CODE: 404)", MsgBoxStyle.Critical)
    '    End Try

    '    Dim bv As String
    '    bv = ReadAllText(Environ("appdata") & "\smartbukkit\bver.stg")
    '    Dim bver() As String
    '    Dim tem As Single = 0


    '    bver = Split(bv, "@", , )


    '    inforl.Text = "버킷파일 다운로드중... " & bver(1)
    '    If FileExists(Environ("appdata") & "\smartbukkit\craftbukkit.jar") = True Then
    '        DeleteFile(Environ("appdata") & "\smartbukkit\craftbukkit.jar")
    '    End If
    '    My.Computer.Network.DownloadFile(bver(0), Environ("appdata") & "\smartbukkit\craftbukkit.jar")

    '    inforl.Text = "적용중..."

    '    If FileExists("craftbukit.jar") = True Then
    '        DeleteFile("craftbukkit.jar")
    '    End If
    '    MoveFile(Environ("appdata") & "\smartbukkit\craftbukkit.jar", Application.StartupPath & "\craftbukkit.jar", True)
    '    inforl.Visible = False
    '    MsgBox("다운로드가 완료되었습니다!", vbInformation)
    '    thc = False
    'End Sub

    Private Sub 실행기글자색변경CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 실행기글자색변경CToolStripMenuItem.Click
        Form2.ShowInTaskbar = False
        Form2.ShowDialog()
    End Sub

    Private Sub 버킷폴더BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 버킷폴더BToolStripMenuItem.Click
        Shell("cmd /c explorer.exe ""%cd%""", vbHide)
    End Sub

    Private Sub 플러그인폴더PToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 플러그인폴더PToolStripMenuItem.Click
        Shell("cmd /c explorer.exe ""%cd%\plugins""", vbHide)
    End Sub


    Private Sub ServerpropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerpropertiesToolStripMenuItem1.Click
        Shell(Environ("programfiles") & "\Windows NT\Accessories\wordpad.exe server.properties", vbNormalFocus)
    End Sub

    Private Sub BukkitymlToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BukkitymlToolStripMenuItem1.Click
        Shell("""C:\program files\Windows NT\Accessories\wordpad.exe"" white-list.txt", vbNormalFocus)
    End Sub

    Private Sub OpstxtToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpstxtToolStripMenuItem1.Click
        Shell("cmd /c notepad.exe ""%cd%\ops.txt""", vbHide)
    End Sub

    Private Sub BukkitymlToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BukkitymlToolStripMenuItem2.Click
        Shell(Environ("programfiles") & "\Windows NT\Accessories\wordpad.exe bukkit.yml", vbNormalFocus)
    End Sub

    Private Sub BannedplayerstxtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BannedplayerstxtToolStripMenuItem.Click
        Shell("cmd /c notepad.exe ""%cd%\banned-players.txt""", vbHide)
    End Sub

    Private Sub BannedipstxtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BannedipstxtToolStripMenuItem.Click
        Shell("cmd /c notepad.exe ""%cd%\banned-ips.txt""", vbHide)
    End Sub

    Private Sub ServerlogToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerlogToolStripMenuItem1.Click
        Shell("cmd /c notepad.exe ""%cd%\server.log""", vbHide)
    End Sub

    Private Sub 파란닌자sSPACEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 파란닌자sSPACEToolStripMenuItem.Click
        Shell("cmd /c start http://geon08.blog.me", vbHide)
    End Sub

    Private Sub 스마트버킷정보ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 스마트버킷정보ToolStripMenuItem1.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub 업데이트확인ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 업데이트확인ToolStripMenuItem1.Click
        updateth()

    End Sub

    Private Sub updateth()

        ToolStripStatusLabel1.Text = "업데이트 확인중입니다. 잠시만기다려주세요..."
        Dim upd As Integer
        Try
            DeleteFile(Environ("appdata") & "\smartbukkit\sbup.stg")

        Catch ex As Exception

        End Try
        
        Try
            '    My.Computer.Network.DownloadFile("https://dl.dropbox.com/s/7wo6cqhoeo1ji9h/sbversion.txt?dl=1", Environ("appdata") & "\smartbukkit\sbup.stg")

            upd = dlbukkit.HTMLGet("https://dl.dropbox.com/s/7wo6cqhoeo1ji9h/sbversion.txt?dl=1")

        Catch ex As Exception

            MsgBox("업데이트 확인중 오류가 발생했습니다." & vbCrLf & "인터넷에 연결되어있는지 확인하세요." & vbCrLf & vbCrLf & vbCrLf & "(ERROR CODE: " & ex.ToString & ")", vbInformation)
            ToolStripStatusLabel1.Visible = False

            Exit Sub
        End Try




        If CInt(upd) > 130 Then
            MsgBox("업데이트가 발견되었습니다." & vbCrLf & "파란닌자's SPACE 로 이동합니다.", vbOKOnly, "Update")
            Shell("cmd /c start http://geon08.blog.me", vbHide)
        Else
            MsgBox("최신버전을 사용하고계십니다. (1.3.0)", vbOKOnly, "Update")
        End If

        ToolStripStatusLabel1.Text = ""
    End Sub








    Private Sub pluginload()
        If DirectoryExists("plugins") = True Then
            plulist.Items.Clear()
            Dim files As Collections.ObjectModel.ReadOnlyCollection(Of String)
            files = GetFiles(Application.StartupPath & "\plugins")
            For i = 0 To files.Count - 1
                Dim a() As String
                a = Split(files.Item(i).ToString, "\plugins\", , )

                plulist.Items.Add(a(1))
            Next
        End If
    End Sub

    Private Sub plure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plure.Click
        pluginload()
    End Sub



    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.ShowInTaskbar = False
        Form3.ShowDialog()
    End Sub



    Private Sub Pludel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pludel.Click
        Dim wh As String
        wh = plulist.SelectedItem
        If FileExists(Application.StartupPath & "\plugins\" & wh) = True Then
            DeleteFile(Application.StartupPath & "\plugins\" & wh)
            plulist.Items.Remove(wh)
        End If
    End Sub


    Private Sub pluopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pluopen.Click
        OpenFileDialog1.Title = "불러올 플러그인파일을 선택해주세요."
        If OpenFileDialog1.ShowDialog() = vbCancel Then
            Exit Sub
        End If
        Dim fn(), fnu() As String
        fn = OpenFileDialog1.FileNames
        fnu = OpenFileDialog1.SafeFileNames
        Dim d As Integer
        d = fn.Length
        For a As Integer = 0 To d - 1
            CopyFile(fn(a), Application.StartupPath & "\plugins\" & fnu(a), FileIO.UIOption.AllDialogs)
        Next
        pluginload()
    End Sub


    Private Sub whiteopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles whiteopen.Click
        Shell("""C:\program files\Windows NT\Accessories\wordpad.exe"" white-list.txt", vbNormalFocus)
    End Sub

    Private Sub 서버실행RToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 서버실행RToolStripMenuItem.Click
        If FileExists("스마트버킷실행기.bat") = True Then
            Shell("cmd /c 스마트버킷실행기.bat", vbNormalFocus)
        Else
            MsgBox("버킷실행기를 찾을수 없습니다.")
        End If
    End Sub

    Private Sub pluhome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pluhome.Click
        Dim sp(1) As String
        sp = Split(plulist.SelectedItem, ".jar", , )
        Process.Start("http://plugins.bukkit.org/curseforge/#ti=" & sp(0) & "&ta=all&au=&pno=1")
    End Sub

    Private Sub plutxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub





    'Private Sub plufors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Process.Start("http://plugins.bukkit.org/curseforge/#ti=" & plufort.Text.ToString & "&ta=all&au=&pno=1")
    'End Sub


    Private Sub plumana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.ShowInTaskbar = False
        Form4.ShowDialog()
    End Sub



    Private Sub Seronoff_CheckedChanged(sender As Object, e As EventArgs) Handles Seronoff.CheckedChanged
        My.Settings.OnOff = Seronoff.Checked
        If Seronoff.Checked = True Then
            Panel1.Enabled = True
            Timer2.Enabled = True
        Else
            Panel1.Enabled = False
            Timer2.Enabled = False
        End If

    End Sub


    Private sermem As Process()



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'sermem = Process.GetProcessesByName("notepad")

        If FindWindow(vbNullString, "파란닌자 맞춤 실행기") Then
            sertxt.Text = "서버 : ON"

        Else
            sertxt.Text = "서버 : OFF"
        End If

        ' 프로세스감지
        'Dim m As Process()
        'Dim z As Long = 0
        'm = Process.GetProcesses
        'For Each i In m

        '    z += i.PeakWorkingSet64

        'Next

        'Dim l As Integer
        'l = z / mymem

        'serper.Text = l.ToString & "%"

        'serpro.Value = l


        'If sermem.Count = 0 Then
        '    sertxt.Text = "서버 : OFF"
        'Else
        '    sertxt.Text = "서버 : ON"
        '    Dim val As Integer = CInt(CULng(sermem(0).PrivateMemorySize64) / mymem * 100)
        '    serpro.Value = val
        '    serper.Text = val.ToString
        'End If
    End Sub

    Private Sub JButton1_Click(sender As Object, e As EventArgs) Handles JButton1.Click

        If FindWindow(vbNullString, "화이트리스트 편집") Then
            Exit Sub
        End If


        whitelistdia.Show()
    End Sub

    Private Sub whiteall_Click(sender As Object, e As EventArgs) Handles whiteall.Click
        If MsgBox("정말 화이트리스트를 초기화하시겠습니까?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Try
                DeleteFile("white-list.txt")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub JButton5_Click(sender As Object, e As EventArgs) Handles JButton5.Click
        Shell(Environ("programfiles") & "\Windows NT\Accessories\wordpad.exe server.properties", vbNormalFocus)
    End Sub





    Private Sub JButton3_Click(sender As Object, e As EventArgs) Handles JButton3.Click
        If MsgBox("정말 설정을 초기화하시겠습니까?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                DeleteFile("server.properties")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub JButton4_Click(sender As Object, e As EventArgs) Handles JButton4.Click
        Form3.Show()
    End Sub

    Private Sub JButton2_Click(sender As Object, e As EventArgs) Handles JButton2.Click
        findplug.Show()
    End Sub

    'Private Sub 버킷램할당량변경ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 버킷램할당량변경ToolStripMenuItem.Click
    '    bukkitram.ShowDialog()
    'End Sub

    Private Sub 버전별버킷다운로드VToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 버전별버킷다운로드VToolStripMenuItem.Click

        dlbukkit.Show()
    End Sub


    Private Sub 추가기능관리자SToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form4.ShowDialog()
    End Sub

    'Private Sub 버킷파일이동MToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 버킷파일이동MToolStripMenuItem.Click
    '    Dim asdf As New FolderBrowserDialog
    '    asdf.ShowNewFolderButton = False

    '    If asdf.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        Dim files As String() = New String() {"server.properties", "white-list.txt", "ops.txt", "banned-players.txt", "banned-ips.txt"}
    '        Dim folders As String() = New String() {"plugins", "world", "world-nether", "world-the-end"}

    '        For Each i In files
    '            CopyFile(asdf.SelectedPath & "\" & i, Application.StartupPath & "₩" & i)

    '        Next
    '        For Each i In folders
    '            CopyDirectory(asdf.SelectedPath & "₩" & i, Application.StartupPath & "₩" & i)

    '        Next
    '    End If





    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bukcom.Show()
    End Sub
End Class