<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlbukkit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlbukkit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ref = New JButton.JButton()
        Me.JButton1 = New JButton.JButton()
        Me.VerList = New System.Windows.Forms.ListView()
        Me.bver = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btxt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bsize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ref)
        Me.GroupBox1.Controls.Add(Me.JButton1)
        Me.GroupBox1.Controls.Add(Me.VerList)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 289)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "원하는 버킷버전 선택"
        '
        'ref
        '
        Me.ref.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ref.Brightness = 0
        Me.ref.ButtonColor = System.Drawing.Color.Gainsboro
        Me.ref.Checked = False
        Me.ref.CheckedColor = System.Drawing.Color.LightGreen
        Me.ref.CheckedTextColor = System.Drawing.Color.Black
        Me.ref.Image = Nothing
        Me.ref.Location = New System.Drawing.Point(6, 245)
        Me.ref.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ref.Mode = JButton.JButton.ControlMode.[Default]
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(107, 36)
        Me.ref.Style = JButton.JButton.StyleMode.[Default]
        Me.ref.TabIndex = 2
        Me.ref.Text = "새로고침"
        Me.ref.TextColor = System.Drawing.Color.Black
        '
        'JButton1
        '
        Me.JButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JButton1.Brightness = 0
        Me.JButton1.ButtonColor = System.Drawing.Color.Gainsboro
        Me.JButton1.Checked = False
        Me.JButton1.CheckedColor = System.Drawing.Color.LightGreen
        Me.JButton1.CheckedTextColor = System.Drawing.Color.Black
        Me.JButton1.Image = Nothing
        Me.JButton1.Location = New System.Drawing.Point(499, 245)
        Me.JButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JButton1.Mode = JButton.JButton.ControlMode.[Default]
        Me.JButton1.Name = "JButton1"
        Me.JButton1.Size = New System.Drawing.Size(107, 36)
        Me.JButton1.Style = JButton.JButton.StyleMode.[Default]
        Me.JButton1.TabIndex = 1
        Me.JButton1.Text = "다운로드"
        Me.JButton1.TextColor = System.Drawing.Color.Black
        '
        'VerList
        '
        Me.VerList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.VerList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.bver, Me.btxt, Me.bsize})
        Me.VerList.FullRowSelect = True
        Me.VerList.GridLines = True
        Me.VerList.Location = New System.Drawing.Point(3, 21)
        Me.VerList.MultiSelect = False
        Me.VerList.Name = "VerList"
        Me.VerList.Size = New System.Drawing.Size(606, 217)
        Me.VerList.TabIndex = 0
        Me.VerList.UseCompatibleStateImageBehavior = False
        Me.VerList.View = System.Windows.Forms.View.Details
        '
        'bver
        '
        Me.bver.Text = "버전"
        Me.bver.Width = 140
        '
        'btxt
        '
        Me.btxt.Text = "설명"
        Me.btxt.Width = 300
        '
        'bsize
        '
        Me.bsize.Text = "크기"
        Me.bsize.Width = 120
        '
        'dlbukkit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 294)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlbukkit"
        Me.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Text = "다운로드받을 버킷버전을 선택해주세요."
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents JButton1 As JButton.JButton
    Friend WithEvents VerList As System.Windows.Forms.ListView
    Friend WithEvents bver As System.Windows.Forms.ColumnHeader
    Friend WithEvents btxt As System.Windows.Forms.ColumnHeader
    Friend WithEvents bsize As System.Windows.Forms.ColumnHeader
    Friend WithEvents ref As JButton.JButton
End Class
