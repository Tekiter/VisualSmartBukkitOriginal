Public Class Form2
    Public bc, tc As String
    Public che As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vbutton1.Click, VButton1.Click
        If co0.Checked = True Then
            tc = "0"
        ElseIf co1.Checked = True Then
            tc = "1"
        ElseIf co2.Checked = True Then
            tc = "2"
        ElseIf co3.Checked = True Then
            tc = "3"
        ElseIf co4.Checked = True Then
            tc = "4"
        ElseIf co5.Checked = True Then
            tc = "5"
        ElseIf co6.Checked = True Then
            tc = "6"
        ElseIf co7.Checked = True Then
            tc = "7"
        ElseIf co8.Checked = True Then
            tc = "8"
        ElseIf co9.Checked = True Then
            tc = "9"
        ElseIf coA.Checked = True Then
            tc = "A"
        ElseIf coB.Checked = True Then
            tc = "B"
        ElseIf coC.Checked = True Then
            tc = "C"
        ElseIf coD.Checked = True Then
            tc = "D"
        ElseIf coE.Checked = True Then
            tc = "E"
        ElseIf coF.Checked = True Then
            tc = "F"
        End If



        If cb0.Checked = True Then
            bc = "0"
        ElseIf cb1.Checked = True Then
            bc = "1"
        ElseIf cb2.Checked = True Then
            bc = "2"
        ElseIf cb3.Checked = True Then
            bc = "3"
        ElseIf cb4.Checked = True Then
            bc = "4"
        ElseIf cb5.Checked = True Then
            bc = "5"
        ElseIf cb6.Checked = True Then
            bc = "6"
        ElseIf cb7.Checked = True Then
            bc = "7"
        ElseIf cb8.Checked = True Then
            bc = "8"
        ElseIf cb9.Checked = True Then
            bc = "9"
        ElseIf cbA.Checked = True Then
            bc = "A"
        ElseIf cbB.Checked = True Then
            bc = "B"
        ElseIf cbC.Checked = True Then
            bc = "C"
        ElseIf cbD.Checked = True Then
            bc = "D"
        ElseIf cbE.Checked = True Then
            bc = "E"
        ElseIf cbF.Checked = True Then
            bc = "F"
        End If

       

        If tc = bc Then
            MsgBox("배경색과 글자색을 같게지정할수 없습니다.", vbOKOnly, "ERROR")
        Else

            Shell("cmd /c echo " & bc & tc & ">%appdata%\smartbukkit\color.stg", vbHide)




            Me.Close()
        End If


    End Sub

    Private Sub RadioButton17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
   

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bc = "0"
        tc = "7"



    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub



    Private Sub co7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co7.CheckedChanged
        p_view.ForeColor = Color.LightGray
    End Sub

    Private Sub coB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coB.CheckedChanged
        p_view.ForeColor = Color.Aqua
    End Sub

    Private Sub co0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co0.CheckedChanged
        p_view.ForeColor = Color.Black

    End Sub

    Private Sub co8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co8.CheckedChanged
        p_view.ForeColor = Color.Gray

    End Sub

    Private Sub co1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co1.CheckedChanged
        p_view.ForeColor = Color.Blue
    End Sub

    Private Sub co2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co2.CheckedChanged
        p_view.ForeColor = Color.Green
    End Sub

    Private Sub co3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co3.CheckedChanged
        p_view.ForeColor = Color.Teal
    End Sub

    Private Sub co4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co4.CheckedChanged
        p_view.ForeColor = Color.DarkRed
    End Sub

    Private Sub co6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co6.CheckedChanged
        p_view.ForeColor = Color.DarkGoldenrod


    End Sub

    Private Sub co9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co9.CheckedChanged
        p_view.ForeColor = Color.LightBlue

    End Sub

    Private Sub coA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coA.CheckedChanged
        p_view.ForeColor = Color.LightGreen
    End Sub

    Private Sub coC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coC.CheckedChanged
        p_view.ForeColor = Color.Red

    End Sub

    Private Sub co5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co5.CheckedChanged
        p_view.ForeColor = Color.Purple

    End Sub

    Private Sub coE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coE.CheckedChanged
        p_view.ForeColor = Color.Yellow

    End Sub

    Private Sub coF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coF.CheckedChanged
        p_view.ForeColor = Color.White
    End Sub

    Private Sub coD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coD.CheckedChanged
        p_view.ForeColor = Color.HotPink

    End Sub

    Private Sub cb0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb0.CheckedChanged
        p_view.BackColor = Color.Black
    End Sub

    Private Sub cb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.CheckedChanged
        p_view.BackColor = Color.Blue
    End Sub

    Private Sub cb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb2.CheckedChanged
        p_view.BackColor = Color.Green
    End Sub

    Private Sub cb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb3.CheckedChanged
        p_view.BackColor = Color.Teal
    End Sub

    Private Sub cb4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb4.CheckedChanged
        p_view.BackColor = Color.DarkRed
    End Sub

    Private Sub cb5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb5.CheckedChanged
        p_view.BackColor = Color.Purple

    End Sub

    Private Sub cb6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb6.CheckedChanged
        p_view.BackColor = Color.DarkGoldenrod

    End Sub

    Private Sub cb7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb7.CheckedChanged
        p_view.BackColor = Color.LightGray
    End Sub

    Private Sub cb8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb8.CheckedChanged
        p_view.BackColor = Color.Gray

    End Sub

    Private Sub cb9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb9.CheckedChanged
        p_view.BackColor = Color.LightBlue

    End Sub

    Private Sub cbA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbA.CheckedChanged
        p_view.BackColor = Color.LightGreen

    End Sub

    Private Sub cbB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbB.CheckedChanged
        p_view.BackColor = Color.Aqua

    End Sub

    Private Sub cbC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbC.CheckedChanged
        p_view.BackColor = Color.Red

    End Sub

    Private Sub cbD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbD.CheckedChanged
        p_view.BackColor = Color.HotPink

    End Sub

    Private Sub cbE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbE.CheckedChanged
        p_view.BackColor = Color.Yellow

    End Sub

    Private Sub cbF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbF.CheckedChanged
        p_view.BackColor = Color.White

    End Sub
End Class