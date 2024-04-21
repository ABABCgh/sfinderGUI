<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Solution1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Solution1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TrackBar()
        Me.unique = New System.Windows.Forms.Button()
        Me.minimal = New System.Windows.Forms.Button()
        Me.open = New System.Windows.Forms.Label()
        Me.marginO = New System.Windows.Forms.CheckBox()
        CType(Me.mode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Path"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(134, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Setup"
        '
        'mode
        '
        Me.mode.Cursor = System.Windows.Forms.Cursors.Default
        Me.mode.Location = New System.Drawing.Point(68, 27)
        Me.mode.Maximum = 1
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(60, 45)
        Me.mode.TabIndex = 3
        Me.mode.TickFrequency = 0
        Me.mode.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'unique
        '
        Me.unique.Font = New System.Drawing.Font("MS UI Gothic", 8.0!)
        Me.unique.Location = New System.Drawing.Point(121, 62)
        Me.unique.Name = "unique"
        Me.unique.Size = New System.Drawing.Size(74, 18)
        Me.unique.TabIndex = 5
        Me.unique.Text = "path_unique"
        Me.unique.UseVisualStyleBackColor = True
        '
        'minimal
        '
        Me.minimal.Font = New System.Drawing.Font("MS UI Gothic", 8.0!)
        Me.minimal.Location = New System.Drawing.Point(43, 62)
        Me.minimal.Name = "minimal"
        Me.minimal.Size = New System.Drawing.Size(74, 18)
        Me.minimal.TabIndex = 4
        Me.minimal.Text = "path_minimal"
        Me.minimal.UseVisualStyleBackColor = True
        '
        'open
        '
        Me.open.AutoSize = True
        Me.open.Location = New System.Drawing.Point(12, 64)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(29, 12)
        Me.open.TabIndex = 6
        Me.open.Text = "open"
        '
        'marginO
        '
        Me.marginO.AutoSize = True
        Me.marginO.Location = New System.Drawing.Point(110, 56)
        Me.marginO.Name = "marginO"
        Me.marginO.Size = New System.Drawing.Size(76, 16)
        Me.marginO.TabIndex = 7
        Me.marginO.Text = "-margin O"
        Me.marginO.UseVisualStyleBackColor = True
        '
        'Solution1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 89)
        Me.Controls.Add(Me.marginO)
        Me.Controls.Add(Me.open)
        Me.Controls.Add(Me.unique)
        Me.Controls.Add(Me.minimal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Solution1"
        Me.Text = "PCmode"
        CType(Me.mode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mode As TrackBar
    Friend WithEvents unique As Button
    Friend WithEvents minimal As Button
    Friend WithEvents open As Label
    Friend WithEvents marginO As CheckBox
End Class
