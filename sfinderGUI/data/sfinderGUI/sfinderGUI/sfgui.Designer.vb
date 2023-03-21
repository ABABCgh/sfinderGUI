<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sfgui
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sfgui))
        Me.paste = New System.Windows.Forms.Button()
        Me.tetfu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.open = New System.Windows.Forms.Button()
        Me.Setup = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.preview1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.p2 = New System.Windows.Forms.TextBox()
        Me.Cover = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.page = New System.Windows.Forms.TextBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.loadtxt = New System.Windows.Forms.Button()
        Me.Path = New System.Windows.Forms.CheckedListBox()
        Me.loadsuccess = New System.Windows.Forms.Button()
        Me.success = New System.Windows.Forms.Label()
        Me.lastoutput = New System.Windows.Forms.Button()
        Me.preview2 = New System.Windows.Forms.PictureBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.copy = New System.Windows.Forms.Button()
        Me.error1 = New System.Windows.Forms.Label()
        Me.error2 = New System.Windows.Forms.Label()
        Me.error3 = New System.Windows.Forms.Label()
        Me.clear2 = New System.Windows.Forms.Button()
        CType(Me.preview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.preview2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paste
        '
        Me.paste.Location = New System.Drawing.Point(12, 49)
        Me.paste.Name = "paste"
        Me.paste.Size = New System.Drawing.Size(73, 21)
        Me.paste.TabIndex = 0
        Me.paste.Text = "貼り付け"
        Me.paste.UseVisualStyleBackColor = True
        '
        'tetfu
        '
        Me.tetfu.Location = New System.Drawing.Point(12, 24)
        Me.tetfu.Name = "tetfu"
        Me.tetfu.Size = New System.Drawing.Size(152, 19)
        Me.tetfu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "テト譜"
        '
        'open
        '
        Me.open.Location = New System.Drawing.Point(91, 49)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(73, 21)
        Me.open.TabIndex = 4
        Me.open.Text = "開く"
        Me.open.UseVisualStyleBackColor = True
        '
        'Setup
        '
        Me.Setup.Location = New System.Drawing.Point(163, 265)
        Me.Setup.Name = "Setup"
        Me.Setup.Size = New System.Drawing.Size(102, 38)
        Me.Setup.TabIndex = 5
        Me.Setup.Text = "実行"
        Me.Setup.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(199, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "⇒"
        '
        'preview1
        '
        Me.preview1.Location = New System.Drawing.Point(13, 100)
        Me.preview1.Name = "preview1"
        Me.preview1.Size = New System.Drawing.Size(150, 150)
        Me.preview1.TabIndex = 8
        Me.preview1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 22)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "⇒"
        '
        'p1
        '
        Me.p1.Location = New System.Drawing.Point(184, 127)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(57, 19)
        Me.p1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 12)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ミノパターン"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(433, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 12)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ミノパターン"
        '
        'p2
        '
        Me.p2.Location = New System.Drawing.Point(433, 127)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(57, 19)
        Me.p2.TabIndex = 12
        '
        'Cover
        '
        Me.Cover.Location = New System.Drawing.Point(414, 265)
        Me.Cover.Name = "Cover"
        Me.Cover.Size = New System.Drawing.Size(102, 38)
        Me.Cover.TabIndex = 15
        Me.Cover.Text = "実行"
        Me.Cover.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ページ"
        '
        'page
        '
        Me.page.Location = New System.Drawing.Point(53, 75)
        Me.page.Name = "page"
        Me.page.Size = New System.Drawing.Size(32, 19)
        Me.page.TabIndex = 17
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(374, 255)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(39, 21)
        Me.clear.TabIndex = 18
        Me.clear.Text = "クリア"
        Me.clear.UseVisualStyleBackColor = True
        '
        'loadtxt
        '
        Me.loadtxt.Location = New System.Drawing.Point(311, 255)
        Me.loadtxt.Name = "loadtxt"
        Me.loadtxt.Size = New System.Drawing.Size(59, 21)
        Me.loadtxt.TabIndex = 19
        Me.loadtxt.Text = "読み込み"
        Me.loadtxt.UseVisualStyleBackColor = True
        '
        'Path
        '
        Me.Path.FormattingEnabled = True
        Me.Path.Location = New System.Drawing.Point(263, 24)
        Me.Path.Name = "Path"
        Me.Path.Size = New System.Drawing.Size(152, 228)
        Me.Path.TabIndex = 20
        '
        'loadsuccess
        '
        Me.loadsuccess.Location = New System.Drawing.Point(517, 159)
        Me.loadsuccess.Name = "loadsuccess"
        Me.loadsuccess.Size = New System.Drawing.Size(59, 21)
        Me.loadsuccess.TabIndex = 21
        Me.loadsuccess.Text = "読み込み"
        Me.loadsuccess.UseVisualStyleBackColor = True
        '
        'success
        '
        Me.success.AutoSize = True
        Me.success.BackColor = System.Drawing.Color.Transparent
        Me.success.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.success.ForeColor = System.Drawing.SystemColors.ControlText
        Me.success.Location = New System.Drawing.Point(512, 127)
        Me.success.Name = "success"
        Me.success.Size = New System.Drawing.Size(87, 27)
        Me.success.TabIndex = 22
        Me.success.Text = "00.00%"
        '
        'lastoutput
        '
        Me.lastoutput.Location = New System.Drawing.Point(517, 186)
        Me.lastoutput.Name = "lastoutput"
        Me.lastoutput.Size = New System.Drawing.Size(59, 21)
        Me.lastoutput.TabIndex = 23
        Me.lastoutput.Text = "開く"
        Me.lastoutput.UseVisualStyleBackColor = True
        '
        'preview2
        '
        Me.preview2.Location = New System.Drawing.Point(421, 24)
        Me.preview2.Name = "preview2"
        Me.preview2.Size = New System.Drawing.Size(70, 70)
        Me.preview2.TabIndex = 24
        Me.preview2.TabStop = False
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(265, 255)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(42, 21)
        Me.Add.TabIndex = 25
        Me.Add.Text = "追加"
        Me.Add.UseVisualStyleBackColor = True
        '
        'copy
        '
        Me.copy.Cursor = System.Windows.Forms.Cursors.Default
        Me.copy.Location = New System.Drawing.Point(497, 24)
        Me.copy.Name = "copy"
        Me.copy.Size = New System.Drawing.Size(42, 21)
        Me.copy.TabIndex = 26
        Me.copy.Text = "コピー"
        Me.copy.UseVisualStyleBackColor = True
        '
        'error1
        '
        Me.error1.AutoSize = True
        Me.error1.ForeColor = System.Drawing.Color.Red
        Me.error1.Location = New System.Drawing.Point(170, 28)
        Me.error1.Name = "error1"
        Me.error1.Size = New System.Drawing.Size(32, 12)
        Me.error1.TabIndex = 27
        Me.error1.Text = "エラー"
        '
        'error2
        '
        Me.error2.AutoSize = True
        Me.error2.ForeColor = System.Drawing.Color.Red
        Me.error2.Location = New System.Drawing.Point(170, 53)
        Me.error2.Name = "error2"
        Me.error2.Size = New System.Drawing.Size(32, 12)
        Me.error2.TabIndex = 28
        Me.error2.Text = "エラー"
        '
        'error3
        '
        Me.error3.AutoSize = True
        Me.error3.ForeColor = System.Drawing.Color.Red
        Me.error3.Location = New System.Drawing.Point(91, 78)
        Me.error3.Name = "error3"
        Me.error3.Size = New System.Drawing.Size(32, 12)
        Me.error3.TabIndex = 29
        Me.error3.Text = "エラー"
        '
        'clear2
        '
        Me.clear2.Location = New System.Drawing.Point(267, 278)
        Me.clear2.Name = "clear2"
        Me.clear2.Size = New System.Drawing.Size(145, 21)
        Me.clear2.TabIndex = 30
        Me.clear2.Text = "チェックしていないものをクリア"
        Me.clear2.UseVisualStyleBackColor = True
        '
        'Sfgui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 315)
        Me.Controls.Add(Me.clear2)
        Me.Controls.Add(Me.error3)
        Me.Controls.Add(Me.error2)
        Me.Controls.Add(Me.error1)
        Me.Controls.Add(Me.copy)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.preview2)
        Me.Controls.Add(Me.lastoutput)
        Me.Controls.Add(Me.success)
        Me.Controls.Add(Me.loadsuccess)
        Me.Controls.Add(Me.Path)
        Me.Controls.Add(Me.loadtxt)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.page)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cover)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.preview1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Setup)
        Me.Controls.Add(Me.open)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tetfu)
        Me.Controls.Add(Me.paste)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sfgui"
        Me.Text = "solution finder"
        CType(Me.preview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.preview2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents paste As Button
    Friend WithEvents tetfu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents open As Button
    Friend WithEvents Setup As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents preview1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents p1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents p2 As TextBox
    Friend WithEvents Cover As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents page As TextBox
    Friend WithEvents clear As Button
    Friend WithEvents loadtxt As Button
    Friend WithEvents Path As CheckedListBox
    Friend WithEvents loadsuccess As Button
    Friend WithEvents success As Label
    Friend WithEvents lastoutput As Button
    Friend WithEvents preview2 As PictureBox
    Friend WithEvents Add As Button
    Friend WithEvents copy As Button
    Friend WithEvents error1 As Label
    Friend WithEvents error2 As Label
    Friend WithEvents error3 As Label
    Friend WithEvents clear2 As Button
End Class
