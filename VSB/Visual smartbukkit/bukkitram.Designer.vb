<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bukkitram
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sMemory = New System.Windows.Forms.Label()
        Me.JButton1 = New JButton.JButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.maxRam = New System.Windows.Forms.Label()
        Me.JButton2 = New JButton.JButton()
        Me.rSlider = New System.Windows.Forms.TrackBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.rSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(419, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 70)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1000 MB / 1000 MB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(100%)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sMemory)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 53)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "시스템에 장착된 메모리"
        '
        'sMemory
        '
        Me.sMemory.AutoSize = True
        Me.sMemory.Location = New System.Drawing.Point(48, 22)
        Me.sMemory.Name = "sMemory"
        Me.sMemory.Size = New System.Drawing.Size(86, 15)
        Me.sMemory.TabIndex = 0
        Me.sMemory.Text = "약 1000 MB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'JButton1
        '
        Me.JButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JButton1.Brightness = 0
        Me.JButton1.ButtonColor = System.Drawing.Color.Aqua
        Me.JButton1.Checked = False
        Me.JButton1.CheckedColor = System.Drawing.Color.LightGreen
        Me.JButton1.CheckedTextColor = System.Drawing.Color.Black
        Me.JButton1.Image = Nothing
        Me.JButton1.Location = New System.Drawing.Point(595, 107)
        Me.JButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JButton1.Mode = JButton.JButton.ControlMode.[Default]
        Me.JButton1.Name = "JButton1"
        Me.JButton1.Size = New System.Drawing.Size(86, 32)
        Me.JButton1.Style = JButton.JButton.StyleMode.[Default]
        Me.JButton1.TabIndex = 3
        Me.JButton1.Text = "취소"
        Me.JButton1.TextColor = System.Drawing.Color.Black
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.maxRam)
        Me.GroupBox2.Location = New System.Drawing.Point(201, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 53)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "버킷 램할당 최대량"
        '
        'maxRam
        '
        Me.maxRam.AutoSize = True
        Me.maxRam.Location = New System.Drawing.Point(58, 22)
        Me.maxRam.Name = "maxRam"
        Me.maxRam.Size = New System.Drawing.Size(86, 15)
        Me.maxRam.TabIndex = 0
        Me.maxRam.Text = "약 1000 MB"
        '
        'JButton2
        '
        Me.JButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JButton2.Brightness = 0
        Me.JButton2.ButtonColor = System.Drawing.Color.Aqua
        Me.JButton2.Checked = False
        Me.JButton2.CheckedColor = System.Drawing.Color.LightGreen
        Me.JButton2.CheckedTextColor = System.Drawing.Color.Black
        Me.JButton2.Image = Nothing
        Me.JButton2.Location = New System.Drawing.Point(503, 107)
        Me.JButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JButton2.Mode = JButton.JButton.ControlMode.[Default]
        Me.JButton2.Name = "JButton2"
        Me.JButton2.Size = New System.Drawing.Size(86, 32)
        Me.JButton2.Style = JButton.JButton.StyleMode.[Default]
        Me.JButton2.TabIndex = 5
        Me.JButton2.Text = "저장"
        Me.JButton2.TextColor = System.Drawing.Color.Black
        '
        'rSlider
        '
        Me.rSlider.AutoSize = False
        Me.rSlider.LargeChange = 10
        Me.rSlider.Location = New System.Drawing.Point(12, 9)
        Me.rSlider.Margin = New System.Windows.Forms.Padding(0)
        Me.rSlider.Maximum = 1000
        Me.rSlider.Minimum = 100
        Me.rSlider.Name = "rSlider"
        Me.rSlider.Size = New System.Drawing.Size(391, 56)
        Me.rSlider.SmallChange = 10
        Me.rSlider.TabIndex = 7
        Me.rSlider.TickFrequency = 100
        Me.rSlider.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.rSlider.Value = 100
        '
        'bukkitram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 147)
        Me.Controls.Add(Me.rSlider)
        Me.Controls.Add(Me.JButton2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.JButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "bukkitram"
        Me.Text = "버킷 램 할당량 변경"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.rSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents sMemory As System.Windows.Forms.Label
    Friend WithEvents JButton1 As JButton.JButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents maxRam As System.Windows.Forms.Label
    Friend WithEvents JButton2 As JButton.JButton
    Friend WithEvents rSlider As System.Windows.Forms.TrackBar
End Class
