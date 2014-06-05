<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class whitelistdia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(whitelistdia))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancle = New JButton.JButton()
        Me.OK = New JButton.JButton()
        Me.whrefresh = New JButton.JButton()
        Me.whaddtxt = New System.Windows.Forms.TextBox()
        Me.whadd = New System.Windows.Forms.Button()
        Me.whdel = New System.Windows.Forms.Button()
        Me.ser = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sertxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.whitelist = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancle, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(265, 390)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 33)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancle
        '
        Me.Cancle.Brightness = 0
        Me.Cancle.ButtonColor = System.Drawing.Color.Gainsboro
        Me.Cancle.Checked = False
        Me.Cancle.CheckedColor = System.Drawing.Color.LightGreen
        Me.Cancle.CheckedTextColor = System.Drawing.Color.Black
        Me.Cancle.Image = Nothing
        Me.Cancle.Location = New System.Drawing.Point(100, 4)
        Me.Cancle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancle.Mode = JButton.JButton.ControlMode.[Default]
        Me.Cancle.Name = "Cancle"
        Me.Cancle.Size = New System.Drawing.Size(89, 25)
        Me.Cancle.Style = JButton.JButton.StyleMode.[Default]
        Me.Cancle.TabIndex = 2
        Me.Cancle.Text = "취소"
        Me.Cancle.TextColor = System.Drawing.Color.Black
        '
        'OK
        '
        Me.OK.Brightness = 0
        Me.OK.ButtonColor = System.Drawing.Color.Gainsboro
        Me.OK.Checked = False
        Me.OK.CheckedColor = System.Drawing.Color.LightGreen
        Me.OK.CheckedTextColor = System.Drawing.Color.Black
        Me.OK.Image = Nothing
        Me.OK.Location = New System.Drawing.Point(3, 4)
        Me.OK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK.Mode = JButton.JButton.ControlMode.[Default]
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(89, 25)
        Me.OK.Style = JButton.JButton.StyleMode.[Default]
        Me.OK.TabIndex = 2
        Me.OK.Text = "저장"
        Me.OK.TextColor = System.Drawing.Color.Black
        '
        'whrefresh
        '
        Me.whrefresh.Brightness = 0
        Me.whrefresh.ButtonColor = System.Drawing.Color.Gainsboro
        Me.whrefresh.Checked = False
        Me.whrefresh.CheckedColor = System.Drawing.Color.LightGreen
        Me.whrefresh.CheckedTextColor = System.Drawing.Color.Black
        Me.whrefresh.Image = Nothing
        Me.whrefresh.Location = New System.Drawing.Point(131, 33)
        Me.whrefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.whrefresh.Mode = JButton.JButton.ControlMode.[Default]
        Me.whrefresh.Name = "whrefresh"
        Me.whrefresh.Size = New System.Drawing.Size(99, 41)
        Me.whrefresh.Style = JButton.JButton.StyleMode.[Default]
        Me.whrefresh.TabIndex = 2
        Me.whrefresh.Text = "새로고침"
        Me.whrefresh.TextColor = System.Drawing.Color.Black
        '
        'whaddtxt
        '
        Me.whaddtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.whaddtxt.Location = New System.Drawing.Point(10, 356)
        Me.whaddtxt.Name = "whaddtxt"
        Me.whaddtxt.Size = New System.Drawing.Size(127, 25)
        Me.whaddtxt.TabIndex = 5
        '
        'whadd
        '
        Me.whadd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.whadd.Location = New System.Drawing.Point(143, 356)
        Me.whadd.Name = "whadd"
        Me.whadd.Size = New System.Drawing.Size(81, 25)
        Me.whadd.TabIndex = 6
        Me.whadd.Text = "추가 >"
        Me.whadd.UseVisualStyleBackColor = True
        '
        'whdel
        '
        Me.whdel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.whdel.Location = New System.Drawing.Point(128, 243)
        Me.whdel.Name = "whdel"
        Me.whdel.Size = New System.Drawing.Size(99, 41)
        Me.whdel.TabIndex = 7
        Me.whdel.Text = "삭제"
        Me.whdel.UseVisualStyleBackColor = True
        '
        'ser
        '
        Me.ser.Location = New System.Drawing.Point(132, 22)
        Me.ser.Name = "ser"
        Me.ser.Size = New System.Drawing.Size(75, 25)
        Me.ser.TabIndex = 8
        Me.ser.Text = "찾기"
        Me.ser.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.sertxt)
        Me.GroupBox2.Controls.Add(Me.ser)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 56)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "찾기"
        '
        'sertxt
        '
        Me.sertxt.Location = New System.Drawing.Point(8, 22)
        Me.sertxt.Name = "sertxt"
        Me.sertxt.Size = New System.Drawing.Size(118, 25)
        Me.sertxt.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.whitelist)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 380)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "화이트리스트 목록"
        '
        'whitelist
        '
        Me.whitelist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.whitelist.FormattingEnabled = True
        Me.whitelist.ItemHeight = 15
        Me.whitelist.Location = New System.Drawing.Point(3, 21)
        Me.whitelist.Name = "whitelist"
        Me.whitelist.Size = New System.Drawing.Size(221, 356)
        Me.whitelist.TabIndex = 1
        '
        'whitelistdia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.whdel)
        Me.Controls.Add(Me.whadd)
        Me.Controls.Add(Me.whaddtxt)
        Me.Controls.Add(Me.whrefresh)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(487, 1000)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(487, 478)
        Me.Name = "whitelistdia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "화이트리스트 편집"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancle As JButton.JButton
    Friend WithEvents OK As JButton.JButton
    Friend WithEvents whrefresh As JButton.JButton
    Friend WithEvents whaddtxt As System.Windows.Forms.TextBox
    Friend WithEvents whadd As System.Windows.Forms.Button
    Friend WithEvents whdel As System.Windows.Forms.Button
    Friend WithEvents ser As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents sertxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents whitelist As System.Windows.Forms.ListBox

End Class
