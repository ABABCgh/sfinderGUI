<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 理論パフェ率計算
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(理論パフェ率計算))
        Me.Data = New System.Windows.Forms.DataGridView()
        Me.tetfu = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tetfubutton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCbutton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPCbutton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.setup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.setupbutton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.usepc = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fumen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.deletefu = New System.Windows.Forms.Button()
        Me.pcsolution = New System.Windows.Forms.Label()
        Me.calc = New System.Windows.Forms.Button()
        Me.dpcsolution = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.frontmostbar = New System.Windows.Forms.TrackBar()
        Me.frontmost = New System.Windows.Forms.Label()
        Me.frontmostON = New System.Windows.Forms.Label()
        Me.error1 = New System.Windows.Forms.Label()
        Me.error2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frontmostbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Data
        '
        Me.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tetfu, Me.tetfubutton, Me.PC, Me.PCbutton, Me.DPC, Me.DPCbutton, Me.setup, Me.setupbutton, Me.usepc, Me.result, Me.fumen})
        Me.Data.Location = New System.Drawing.Point(110, 9)
        Me.Data.Name = "Data"
        Me.Data.RowTemplate.Height = 21
        Me.Data.Size = New System.Drawing.Size(379, 439)
        Me.Data.TabIndex = 0
        '
        'tetfu
        '
        Me.tetfu.HeaderText = "地形"
        Me.tetfu.Name = "tetfu"
        Me.tetfu.ReadOnly = True
        Me.tetfu.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tetfu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.tetfu.Width = 30
        '
        'tetfubutton
        '
        Me.tetfubutton.HeaderText = ""
        Me.tetfubutton.Name = "tetfubutton"
        Me.tetfubutton.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tetfubutton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.tetfubutton.Width = 10
        '
        'PC
        '
        Me.PC.HeaderText = "PC"
        Me.PC.Name = "PC"
        Me.PC.Width = 60
        '
        'PCbutton
        '
        Me.PCbutton.HeaderText = ""
        Me.PCbutton.Name = "PCbutton"
        Me.PCbutton.ReadOnly = True
        Me.PCbutton.Width = 10
        '
        'DPC
        '
        Me.DPC.HeaderText = "DPC"
        Me.DPC.Name = "DPC"
        Me.DPC.Width = 60
        '
        'DPCbutton
        '
        Me.DPCbutton.HeaderText = ""
        Me.DPCbutton.Name = "DPCbutton"
        Me.DPCbutton.ReadOnly = True
        Me.DPCbutton.Width = 10
        '
        'setup
        '
        Me.setup.HeaderText = "setup"
        Me.setup.Name = "setup"
        Me.setup.Width = 60
        '
        'setupbutton
        '
        Me.setupbutton.HeaderText = ""
        Me.setupbutton.Name = "setupbutton"
        Me.setupbutton.ReadOnly = True
        Me.setupbutton.Width = 10
        '
        'usepc
        '
        Me.usepc.HeaderText = ""
        Me.usepc.Name = "usepc"
        Me.usepc.Width = 25
        '
        'result
        '
        Me.result.HeaderText = ""
        Me.result.Name = "result"
        Me.result.ReadOnly = True
        Me.result.Width = 60
        '
        'fumen
        '
        Me.fumen.HeaderText = "テト譜"
        Me.fumen.Name = "fumen"
        Me.fumen.ReadOnly = True
        Me.fumen.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(9, 159)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(91, 76)
        Me.ListBox1.TabIndex = 1
        '
        'deletefu
        '
        Me.deletefu.Location = New System.Drawing.Point(40, 34)
        Me.deletefu.Name = "deletefu"
        Me.deletefu.Size = New System.Drawing.Size(64, 24)
        Me.deletefu.TabIndex = 3
        Me.deletefu.Text = "行削除"
        Me.deletefu.UseVisualStyleBackColor = True
        '
        'pcsolution
        '
        Me.pcsolution.AutoSize = True
        Me.pcsolution.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.pcsolution.Location = New System.Drawing.Point(14, 94)
        Me.pcsolution.Name = "pcsolution"
        Me.pcsolution.Size = New System.Drawing.Size(74, 15)
        Me.pcsolution.TabIndex = 4
        Me.pcsolution.Text = "PC : 0.00%"
        '
        'calc
        '
        Me.calc.Location = New System.Drawing.Point(40, 64)
        Me.calc.Name = "calc"
        Me.calc.Size = New System.Drawing.Size(64, 24)
        Me.calc.TabIndex = 5
        Me.calc.Text = "計算"
        Me.calc.UseVisualStyleBackColor = True
        '
        'dpcsolution
        '
        Me.dpcsolution.AutoSize = True
        Me.dpcsolution.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.dpcsolution.Location = New System.Drawing.Point(4, 111)
        Me.dpcsolution.Name = "dpcsolution"
        Me.dpcsolution.Size = New System.Drawing.Size(84, 15)
        Me.dpcsolution.TabIndex = 6
        Me.dpcsolution.Text = "DPC : 0.00%"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 24)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "上書き"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 301)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 24)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "記録"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "読み込み"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.txtname.Location = New System.Drawing.Point(10, 324)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(90, 21)
        Me.txtname.TabIndex = 11
        '
        'frontmostbar
        '
        Me.frontmostbar.Location = New System.Drawing.Point(60, 4)
        Me.frontmostbar.Maximum = 1
        Me.frontmostbar.Name = "frontmostbar"
        Me.frontmostbar.Size = New System.Drawing.Size(37, 45)
        Me.frontmostbar.TabIndex = 14
        Me.frontmostbar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'frontmost
        '
        Me.frontmost.AutoSize = True
        Me.frontmost.Location = New System.Drawing.Point(3, 9)
        Me.frontmost.Name = "frontmost"
        Me.frontmost.Size = New System.Drawing.Size(65, 12)
        Me.frontmost.TabIndex = 16
        Me.frontmost.Text = "最前面固定"
        '
        'frontmostON
        '
        Me.frontmostON.AutoSize = True
        Me.frontmostON.Location = New System.Drawing.Point(92, 8)
        Me.frontmostON.Name = "frontmostON"
        Me.frontmostON.Size = New System.Drawing.Size(17, 12)
        Me.frontmostON.TabIndex = 17
        Me.frontmostON.Text = "on"
        '
        'error1
        '
        Me.error1.AutoSize = True
        Me.error1.ForeColor = System.Drawing.Color.Red
        Me.error1.Location = New System.Drawing.Point(75, 247)
        Me.error1.Name = "error1"
        Me.error1.Size = New System.Drawing.Size(32, 12)
        Me.error1.TabIndex = 18
        Me.error1.Text = "エラー"
        '
        'error2
        '
        Me.error2.AutoSize = True
        Me.error2.ForeColor = System.Drawing.Color.Red
        Me.error2.Location = New System.Drawing.Point(75, 277)
        Me.error2.Name = "error2"
        Me.error2.Size = New System.Drawing.Size(32, 12)
        Me.error2.TabIndex = 19
        Me.error2.Text = "エラー"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(10, 356)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 24)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "直接見る"
        Me.Button4.UseVisualStyleBackColor = True
        '
        '理論パフェ率計算
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 457)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.error2)
        Me.Controls.Add(Me.error1)
        Me.Controls.Add(Me.frontmostON)
        Me.Controls.Add(Me.frontmost)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dpcsolution)
        Me.Controls.Add(Me.calc)
        Me.Controls.Add(Me.pcsolution)
        Me.Controls.Add(Me.deletefu)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Data)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.frontmostbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "理論パフェ率計算"
        Me.Text = "理論パフェ率計算"
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frontmostbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Data As DataGridView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents deletefu As Button
    Friend WithEvents pcsolution As Label
    Friend WithEvents calc As Button
    Friend WithEvents dpcsolution As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents frontmostbar As TrackBar
    Friend WithEvents frontmost As Label
    Friend WithEvents frontmostON As Label
    Friend WithEvents tetfu As DataGridViewImageColumn
    Friend WithEvents tetfubutton As DataGridViewButtonColumn
    Friend WithEvents PC As DataGridViewTextBoxColumn
    Friend WithEvents PCbutton As DataGridViewButtonColumn
    Friend WithEvents DPC As DataGridViewTextBoxColumn
    Friend WithEvents DPCbutton As DataGridViewButtonColumn
    Friend WithEvents setup As DataGridViewTextBoxColumn
    Friend WithEvents setupbutton As DataGridViewButtonColumn
    Friend WithEvents usepc As DataGridViewCheckBoxColumn
    Friend WithEvents result As DataGridViewTextBoxColumn
    Friend WithEvents fumen As DataGridViewTextBoxColumn
    Friend WithEvents error1 As Label
    Friend WithEvents error2 As Label
    Friend WithEvents Button4 As Button
End Class
