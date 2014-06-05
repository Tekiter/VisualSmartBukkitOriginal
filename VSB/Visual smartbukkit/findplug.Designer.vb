<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class findplug
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
        Dim ListViewGroup7 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("관리도구", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup8 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("경제", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup9 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("보호", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup10 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("재미", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup11 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("이동", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup12 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("라이브러리", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"에센셜", "Essentials"}, -1)
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"펄미션EX", "PermissionsEX"}, -1)
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"히어로즈", "Heroes"}, -1)
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"온블럭", "OwnBlock"}, -1)
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"이코노미", "iConomy"}, -1)
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"월드에딧", "WorldEdit"}, -1)
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"지옥문포탈", "StarGate"}, -1)
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"지역보호", "Residence"}, -1)
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Vault", "Vault"}, -1)
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"마이홈", "MyHome"}, -1)
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"로그인", "xAuth"}, -1)
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"체스트샵", "Chestshop"}, -1)
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"오토세이브", "simple-autosave"}, -1)
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"국경", "worldborder"}, -1)
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"다이아게이트", "creativegates"}, -1)
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"모자", "simplehat"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(findplug))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.plname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.plenname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.JButton2 = New JButton.JButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JButton3 = New JButton.JButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.plname, Me.plenname})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListView1.FullRowSelect = True
        ListViewGroup7.Header = "관리도구"
        ListViewGroup7.Name = "ListViewGroup1"
        ListViewGroup8.Header = "경제"
        ListViewGroup8.Name = "ListViewGroup2"
        ListViewGroup9.Header = "보호"
        ListViewGroup9.Name = "ListViewGroup3"
        ListViewGroup10.Header = "재미"
        ListViewGroup10.Name = "ListViewGroup4"
        ListViewGroup11.Header = "이동"
        ListViewGroup11.Name = "ListViewGroup5"
        ListViewGroup12.Header = "라이브러리"
        ListViewGroup12.Name = "ListViewGroup6"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup7, ListViewGroup8, ListViewGroup9, ListViewGroup10, ListViewGroup11, ListViewGroup12})
        ListViewItem17.Group = ListViewGroup7
        ListViewItem18.Group = ListViewGroup7
        ListViewItem19.Group = ListViewGroup10
        ListViewItem20.Group = ListViewGroup9
        ListViewItem21.Group = ListViewGroup8
        ListViewItem22.Group = ListViewGroup7
        ListViewItem23.Group = ListViewGroup11
        ListViewItem24.Group = ListViewGroup9
        ListViewItem25.Group = ListViewGroup12
        ListViewItem26.Group = ListViewGroup11
        ListViewItem27.Group = ListViewGroup9
        ListViewItem28.Group = ListViewGroup8
        ListViewItem29.Group = ListViewGroup7
        ListViewItem30.Group = ListViewGroup9
        ListViewItem31.Group = ListViewGroup11
        ListViewItem32.Group = ListViewGroup10
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30, ListViewItem31, ListViewItem32})
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(311, 446)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'plname
        '
        Me.plname.Text = "이름"
        Me.plname.Width = 140
        '
        'plenname
        '
        Me.plenname.Text = "영어이름"
        Me.plenname.Width = 140
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.JButton2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(326, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 114)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "직접탐색"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 25)
        Me.TextBox1.TabIndex = 4
        '
        'JButton2
        '
        Me.JButton2.Brightness = 0
        Me.JButton2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.JButton2.Checked = False
        Me.JButton2.CheckedColor = System.Drawing.Color.LightGreen
        Me.JButton2.CheckedTextColor = System.Drawing.Color.Black
        Me.JButton2.Image = Nothing
        Me.JButton2.Location = New System.Drawing.Point(135, 55)
        Me.JButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JButton2.Mode = JButton.JButton.ControlMode.[Default]
        Me.JButton2.Name = "JButton2"
        Me.JButton2.Size = New System.Drawing.Size(167, 44)
        Me.JButton2.Style = JButton.JButton.StyleMode.[Default]
        Me.JButton2.TabIndex = 3
        Me.JButton2.Text = "다운로드 페이지 >"
        Me.JButton2.TextColor = System.Drawing.Color.Black
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "플러그인 영어이름을 입력하시면" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "버킷포럼에서 검색됩니다."
        '
        'JButton3
        '
        Me.JButton3.Brightness = 0
        Me.JButton3.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.JButton3.Checked = False
        Me.JButton3.CheckedColor = System.Drawing.Color.LightGreen
        Me.JButton3.CheckedTextColor = System.Drawing.Color.Black
        Me.JButton3.Image = Nothing
        Me.JButton3.Location = New System.Drawing.Point(347, 90)
        Me.JButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JButton3.Mode = JButton.JButton.ControlMode.[Default]
        Me.JButton3.Name = "JButton3"
        Me.JButton3.Size = New System.Drawing.Size(241, 120)
        Me.JButton3.Style = JButton.JButton.StyleMode.[Default]
        Me.JButton3.TabIndex = 3
        Me.JButton3.Text = "플러그인 홈페이지 & 다운로드 >"
        Me.JButton3.TextColor = System.Drawing.Color.Black
        '
        'findplug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 446)
        Me.Controls.Add(Me.JButton3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "findplug"
        Me.Text = "플러그인 찾기 & 다운로드"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents plname As System.Windows.Forms.ColumnHeader
    Friend WithEvents plenname As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents JButton2 As JButton.JButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents JButton3 As JButton.JButton
End Class
