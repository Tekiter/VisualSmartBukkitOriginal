<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JButton2 = New JButton.JButton()
        Me.JButton1 = New JButton.JButton()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(659, 339)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "이름"
        Me.ColumnHeader1.Width = 140
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "설명"
        Me.ColumnHeader4.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "버전"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "만든이"
        Me.ColumnHeader2.Width = 130
        '
        'JButton2
        '
        Me.JButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JButton2.BackColor = System.Drawing.Color.White
        Me.JButton2.Brightness = 0
        Me.JButton2.ButtonColor = System.Drawing.Color.Gray
        Me.JButton2.Checked = False
        Me.JButton2.CheckedColor = System.Drawing.Color.LightGreen
        Me.JButton2.CheckedTextColor = System.Drawing.Color.Black
        Me.JButton2.Image = Nothing
        Me.JButton2.Location = New System.Drawing.Point(677, 59)
        Me.JButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JButton2.Mode = JButton.JButton.ControlMode.[Default]
        Me.JButton2.Name = "JButton2"
        Me.JButton2.Size = New System.Drawing.Size(79, 25)
        Me.JButton2.Style = JButton.JButton.StyleMode.[Default]
        Me.JButton2.TabIndex = 4
        Me.JButton2.Text = "실행"
        Me.JButton2.TextColor = System.Drawing.Color.White
        '
        'JButton1
        '
        Me.JButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JButton1.BackColor = System.Drawing.Color.White
        Me.JButton1.Brightness = 0
        Me.JButton1.ButtonColor = System.Drawing.Color.Gray
        Me.JButton1.Checked = False
        Me.JButton1.CheckedColor = System.Drawing.Color.LightGreen
        Me.JButton1.CheckedTextColor = System.Drawing.Color.Black
        Me.JButton1.Image = Nothing
        Me.JButton1.Location = New System.Drawing.Point(677, 326)
        Me.JButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JButton1.Mode = JButton.JButton.ControlMode.[Default]
        Me.JButton1.Name = "JButton1"
        Me.JButton1.Size = New System.Drawing.Size(79, 25)
        Me.JButton1.Style = JButton.JButton.StyleMode.[Default]
        Me.JButton1.TabIndex = 5
        Me.JButton1.Text = "닫기"
        Me.JButton1.TextColor = System.Drawing.Color.White
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 365)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.JButton2)
        Me.Controls.Add(Me.JButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Text = "추가기능 관리"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents JButton2 As JButton.JButton
    Friend WithEvents JButton1 As JButton.JButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
