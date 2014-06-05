Imports Microsoft.VisualBasic.FileIO.FileSystem
Public NotInheritable Class SplashScreen1
    Private check As Boolean
    Private Sub SplashScreen1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated


        Try
            My.Computer.FileSystem.CreateDirectory(Environ("appdata") & "\Smartbukkit")
        Catch ex As Exception

        End Try


        Try
            CreateDirectory(Environ("appdata") & "\Smartbukkit\VSBplugins")
        Catch ex As Exception

        End Try

        Try
            CreateDirectory(Environ("appdata") & "\Smartbukkit\VSBplugins\info")
        Catch ex As Exception

        End Try

     

        My.Computer.FileSystem.CreateDirectory("plugins")
    End Sub

  


    'TODO: 프로젝트 디자이너에서 "프로젝트" 메뉴의 "속성"을 선택하여 표시된 "응용 프로그램" 탭에서
    '  이 폼을 응용 프로그램의 시작 화면으로 쉽게 설정할 수 있습니다.




End Class
