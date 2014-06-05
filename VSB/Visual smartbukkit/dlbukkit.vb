Imports System.Net
Imports System.IO

Public Class dlbukkit


    Private https() As String
    Private kbs() As String
    Private mes() As String


    Private Sub dlbukkit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        vload()
    End Sub


    Private Sub JButton1_Click(sender As Object, e As EventArgs) Handles JButton1.Click
        'MsgBox(VerList.SelectedItems(0).ToString & vbCrLf & VerList.SelectedIndices(0).ToString)



        If VerList.SelectedIndices.Count = 0 Then
            MsgBox("버전을 선택해주세요.")
            Exit Sub
        End If



        downloader.https = https(VerList.SelectedIndices(0))
        downloader.mes = mes(VerList.SelectedIndices(0))
        downloader.Show()
        Me.Hide()
    End Sub




    Private Sub vload()

        'If My.Computer.FileSystem.FileExists(Environ("appdata") & "₩smartbukkit₩bukkitv.stg") = True Then
        '    My.Computer.Network.DownloadFile("https://dl.dropbox.com/s/6uf4gcggghf1u3m/bukkitv.stg?dl=1", Environ("appdata") & "₩smartbukkit₩bukkitv.stg")
        'End If




        'Dim re As Net.WebRequest
        'Dim res As Net.WebResponse

        're = Net.WebRequest.Create("https://dl.dropbox.com/s/6uf4gcggghf1u3m/bukkitv.stg?dl=1")
        'res = re.GetResponse



        '    Dim far() As String = Split(My.Computer.FileSystem.ReadAllText(Environ("appdata") & "\smartbukkit\bukkitv.stg", System.Text.Encoding.UTF8), Chr(13))
        'Try

        VerList.Items.Clear()
        Try
            Dim far() As String = Split(HTMLGet("https://dl.dropbox.com/s/6uf4gcggghf1u3m/bukkitv.stg?dl=1"), vbCrLf)

            ReDim https(far.Count - 1)
            ReDim kbs(far.Count - 1)
            ReDim mes(far.Count - 1)

            For i = 0 To far.Count - 1
                Dim ff() As String = Split(far(i), "|")
                Dim asdf As ListViewItem = New ListViewItem(New String() {ff(0), ff(1), ff(2) & "MB"}, -1)
                https(i) = ff(3)
                kbs(i) = ff(2)
                mes(i) = ff(0)
                VerList.Items.AddRange(New ListViewItem() {asdf})

            Next
        Catch ex As Exception
            MsgBox("정보를 불러오는데 실패했습니다." & vbCrLf & "인터넷에 연결되어있는지 확인하시고," & vbCrLf & "계속 실패할경우 다음의 메세지를 파란닌자에게 알려주십시오." & vbCrLf & vbCrLf & ex.Message & ", " & ex.TargetSite.ToString)
        End Try
       

        'Catch ex As Exception
        '    MsgBox("알수없는 오류가 발생하였습니다." & vbCrLf & vbCrLf & ex.ToString)
        'End Try



    End Sub
    Friend Function HTMLGet(Address As String) As String
        Dim rt As String = ""
        Dim wRequest As WebRequest
        Dim wResponse As WebResponse
        Dim sr As StreamReader
        wRequest = WebRequest.Create(Address)
        wResponse = wRequest.GetResponse
        sr = New StreamReader(wResponse.GetResponseStream)
        rt = sr.ReadToEnd
        sr.Close()
        Return rt
    End Function


    Private Sub ref_click(sender As Object, e As EventArgs) Handles ref.Click
        ref.Enabled = False
        vload()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class