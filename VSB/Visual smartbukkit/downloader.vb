Public Class downloader

    Friend https As String
    Friend mes As String

    Private messa As String

    Private isdown As Boolean
    Private errormes As String = vbNullString

    Private Sub downloader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If thre.IsBusy = True Then
            If MsgBox("다운로드가 진행중입니다." & vbCrLf & "정말 취소하고 나가시겠습니까?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = vbYes Then
                Try
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath & "craftbukkit.jar.SBDOWN")
                Catch ex As Exception

                End Try

                thre.CancelAsync()

            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub downloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "버킷 " & mes & " 버전 다운로드를 시작합니다..."

        thre.RunWorkerAsync()
    End Sub

    Private Sub thre_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles thre.DoWork
        isdown = True

        Try
            My.Computer.FileSystem.DeleteFile("craftbukkit.jar.SBDOWN")
        Catch ex As Exception

        End Try

        Try
            My.Computer.Network.DownloadFile(https, Application.StartupPath & "\craftbukkit.jar.SBDOWN")
        Catch ex As Exception
            errormes = "다운로드중 오류가 발생했습니다." & vbCrLf & "인터넷에 연결되어있는지 확인하세요." & vbCrLf & vbCrLf & vbCrLf & "(ERROR CODE: " & ex.ToString & ")"

        End Try
        Threading.Thread.Sleep(500)
        isdown = False
        messa = "적용중..."

        Try
            My.Computer.FileSystem.DeleteFile("craftbukkit.jar")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.RenameFile("craftbukkit.jar.SBDOWN", "craftbukkit.jar")
        Catch ex As Exception
            errormes = "다운로드중 오류가 발생했습니다." & vbCrLf & vbCrLf & vbCrLf & "(ERROR CODE: " & ex.ToString & ")"

        End Try
        System.Threading.Thread.Sleep(500)
        errormes = "다운로드가 완료되었습니다!"


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        If Not errormes = vbNullString Then
            exitz(errormes)
        End If


        If isdown = True Then
            ProgressBar1.Style = ProgressBarStyle.Blocks
            Dim asdf As Long = My.Computer.FileSystem.GetFileInfo("craftbukkit.jar.SBDOWN").Length
            messa = "버킷 " & mes & " 버전 다운로드중... (" & CStr(Fix(asdf / 1000)) & " KB 완료)"

            ProgressBar1.Maximum = 13000
            ProgressBar1.Value = Fix(asdf / 1000)
        End If



        Label1.Text = messa
    End Sub


    Private Sub exitz(ByVal message As String)
        'thre.CancelAsync()
        Timer1.Enabled = False
        MsgBox(message)
        dlbukkit.Close()
        Me.Close()

    End Sub

End Class