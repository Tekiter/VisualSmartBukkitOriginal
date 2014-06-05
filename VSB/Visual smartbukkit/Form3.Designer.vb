<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.alne = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.white = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.spnpc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.spani = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.spmob = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pvp = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.diffi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.premi = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.gamemo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.member = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.motd = New System.Windows.Forms.TextBox()
        Me.Button1 = New JButton.JButton()
        Me.OK = New JButton.JButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.prota = New System.Windows.Forms.NumericUpDown()
        Me.protac = New System.Windows.Forms.CheckBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.hblock = New System.Windows.Forms.TrackBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.hblockh = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.prota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        CType(Me.hblock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "지옥입장"
        '
        'alne
        '
        Me.alne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.alne.FormattingEnabled = True
        Me.alne.Items.AddRange(New Object() {"가능", "불가능"})
        Me.alne.Location = New System.Drawing.Point(103, 18)
        Me.alne.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.alne.Name = "alne"
        Me.alne.Size = New System.Drawing.Size(138, 23)
        Me.alne.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.alne)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(267, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(254, 51)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "화이트리스트"
        '
        'white
        '
        Me.white.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.white.FormattingEnabled = True
        Me.white.Items.AddRange(New Object() {"사용", "사용안함"})
        Me.white.Location = New System.Drawing.Point(103, 18)
        Me.white.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.white.Name = "white"
        Me.white.Size = New System.Drawing.Size(138, 23)
        Me.white.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.white)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(267, 72)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(254, 51)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.spnpc)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.spani)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.spmob)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(235, 129)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "스폰관련"
        '
        'spnpc
        '
        Me.spnpc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.spnpc.FormattingEnabled = True
        Me.spnpc.Items.AddRange(New Object() {"허용", "비허용"})
        Me.spnpc.Location = New System.Drawing.Point(88, 90)
        Me.spnpc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.spnpc.Name = "spnpc"
        Me.spnpc.Size = New System.Drawing.Size(138, 23)
        Me.spnpc.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "NPC 스폰"
        '
        'spani
        '
        Me.spani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.spani.FormattingEnabled = True
        Me.spani.Items.AddRange(New Object() {"허용", "비허용"})
        Me.spani.Location = New System.Drawing.Point(88, 58)
        Me.spani.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.spani.Name = "spani"
        Me.spani.Size = New System.Drawing.Size(138, 23)
        Me.spani.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "동물스폰"
        '
        'spmob
        '
        Me.spmob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.spmob.FormattingEnabled = True
        Me.spmob.Items.AddRange(New Object() {"허용", "비허용"})
        Me.spmob.Location = New System.Drawing.Point(88, 25)
        Me.spmob.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.spmob.Name = "spmob"
        Me.spmob.Size = New System.Drawing.Size(138, 23)
        Me.spmob.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "몬스터스폰"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pvp)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 151)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(235, 55)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'pvp
        '
        Me.pvp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pvp.FormattingEnabled = True
        Me.pvp.Items.AddRange(New Object() {"허용", "허용안함"})
        Me.pvp.Location = New System.Drawing.Point(88, 19)
        Me.pvp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pvp.Name = "pvp"
        Me.pvp.Size = New System.Drawing.Size(138, 23)
        Me.pvp.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "PVP"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.diffi)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(267, 151)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(254, 55)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'diffi
        '
        Me.diffi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.diffi.FormattingEnabled = True
        Me.diffi.Items.AddRange(New Object() {"쉬움", "보통", "어려움", "평화로움"})
        Me.diffi.Location = New System.Drawing.Point(103, 19)
        Me.diffi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.diffi.Name = "diffi"
        Me.diffi.Size = New System.Drawing.Size(138, 23)
        Me.diffi.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "난이도"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.premi)
        Me.GroupBox6.Location = New System.Drawing.Point(14, 214)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(235, 55)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        '
        'premi
        '
        Me.premi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.premi.FormattingEnabled = True
        Me.premi.Items.AddRange(New Object() {"정품만 들어올수있음", "복돌도 들어올수있음"})
        Me.premi.Location = New System.Drawing.Point(9, 19)
        Me.premi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.premi.Name = "premi"
        Me.premi.Size = New System.Drawing.Size(217, 23)
        Me.premi.TabIndex = 1
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.gamemo)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Location = New System.Drawing.Point(267, 214)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox7.Size = New System.Drawing.Size(254, 55)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        '
        'gamemo
        '
        Me.gamemo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gamemo.FormattingEnabled = True
        Me.gamemo.Items.AddRange(New Object() {"서바이벌", "크리에이티브", "어드벤쳐"})
        Me.gamemo.Location = New System.Drawing.Point(103, 19)
        Me.gamemo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gamemo.Name = "gamemo"
        Me.gamemo.Size = New System.Drawing.Size(138, 23)
        Me.gamemo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "기본 게임모드"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.member)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Location = New System.Drawing.Point(14, 276)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox8.Size = New System.Drawing.Size(235, 50)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        '
        'member
        '
        Me.member.Location = New System.Drawing.Point(88, 16)
        Me.member.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.member.Name = "member"
        Me.member.Size = New System.Drawing.Size(137, 25)
        Me.member.TabIndex = 4
        Me.member.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "최대인원"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.motd)
        Me.GroupBox9.Location = New System.Drawing.Point(267, 276)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox9.Size = New System.Drawing.Size(254, 50)
        Me.GroupBox9.TabIndex = 7
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "서버소개 (영어만)"
        '
        'motd
        '
        Me.motd.Location = New System.Drawing.Point(10, 18)
        Me.motd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.motd.Name = "motd"
        Me.motd.Size = New System.Drawing.Size(227, 25)
        Me.motd.TabIndex = 0
        Me.motd.Text = "A Minecraft Server"
        '
        'Button1
        '
        Me.Button1.Brightness = 0
        Me.Button1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Checked = False
        Me.Button1.CheckedColor = System.Drawing.Color.LightGreen
        Me.Button1.CheckedTextColor = System.Drawing.Color.Black
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(707, 315)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button1.Mode = JButton.JButton.ControlMode.[Default]
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 29)
        Me.Button1.Style = JButton.JButton.StyleMode.[Default]
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "취소"
        Me.Button1.TextColor = System.Drawing.Color.Black
        '
        'OK
        '
        Me.OK.Brightness = 0
        Me.OK.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.OK.Checked = False
        Me.OK.CheckedColor = System.Drawing.Color.LightGreen
        Me.OK.CheckedTextColor = System.Drawing.Color.Black
        Me.OK.Image = Nothing
        Me.OK.Location = New System.Drawing.Point(613, 315)
        Me.OK.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.OK.Mode = JButton.JButton.ControlMode.[Default]
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(86, 29)
        Me.OK.Style = JButton.JButton.StyleMode.[Default]
        Me.OK.TabIndex = 15
        Me.OK.Text = "확인"
        Me.OK.TextColor = System.Drawing.Color.Black
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label11)
        Me.GroupBox12.Controls.Add(Me.prota)
        Me.GroupBox12.Controls.Add(Me.protac)
        Me.GroupBox12.Location = New System.Drawing.Point(527, 15)
        Me.GroupBox12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox12.Size = New System.Drawing.Size(261, 84)
        Me.GroupBox12.TabIndex = 17
        Me.GroupBox12.TabStop = False
        '
        'prota
        '
        Me.prota.Location = New System.Drawing.Point(145, 19)
        Me.prota.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prota.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.prota.Name = "prota"
        Me.prota.Size = New System.Drawing.Size(109, 25)
        Me.prota.TabIndex = 12
        Me.prota.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'protac
        '
        Me.protac.AutoSize = True
        Me.protac.Location = New System.Drawing.Point(86, 52)
        Me.protac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.protac.Name = "protac"
        Me.protac.Size = New System.Drawing.Size(169, 19)
        Me.protac.TabIndex = 3
        Me.protac.Text = "스폰지역보호 없애기"
        Me.protac.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label13)
        Me.GroupBox10.Controls.Add(Me.hblockh)
        Me.GroupBox10.Controls.Add(Me.Label12)
        Me.GroupBox10.Controls.Add(Me.Label10)
        Me.GroupBox10.Controls.Add(Me.hblock)
        Me.GroupBox10.Location = New System.Drawing.Point(527, 105)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(261, 202)
        Me.GroupBox10.TabIndex = 18
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "최대건축 가능높이"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 15)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "서버스폰보호 범위"
        '
        'hblock
        '
        Me.hblock.AutoSize = False
        Me.hblock.LargeChange = 20
        Me.hblock.Location = New System.Drawing.Point(198, 12)
        Me.hblock.Margin = New System.Windows.Forms.Padding(0)
        Me.hblock.Maximum = 256
        Me.hblock.Minimum = 128
        Me.hblock.Name = "hblock"
        Me.hblock.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.hblock.Size = New System.Drawing.Size(41, 187)
        Me.hblock.SmallChange = 10
        Me.hblock.TabIndex = 0
        Me.hblock.TickFrequency = 16
        Me.hblock.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.hblock.Value = 256
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(167, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "256"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(166, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "128"
        '
        'hblockh
        '
        Me.hblockh.AutoSize = True
        Me.hblockh.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.hblockh.Location = New System.Drawing.Point(43, 77)
        Me.hblockh.Name = "hblockh"
        Me.hblockh.Size = New System.Drawing.Size(99, 41)
        Me.hblockh.TabIndex = 3
        Me.hblockh.Text = "256칸"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(166, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "192"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 352)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(552, 399)
        Me.Name = "Form3"
        Me.Text = "server.properties 수정"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.member, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.prota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.hblock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents alne As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents white As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents spnpc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents spani As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents spmob As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pvp As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents diffi As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents premi As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents gamemo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents member As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents motd As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As JButton.JButton
    Friend WithEvents OK As JButton.JButton
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents prota As System.Windows.Forms.NumericUpDown
    Friend WithEvents protac As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents hblock As System.Windows.Forms.TrackBar
    Friend WithEvents hblockh As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
