<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addtetfu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addtetfu))
        Me.preview = New System.Windows.Forms.PictureBox()
        Me.open = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tetfu = New System.Windows.Forms.TextBox()
        Me.paste = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.error1 = New System.Windows.Forms.Label()
        Me.error2 = New System.Windows.Forms.Label()
        Me.error3 = New System.Windows.Forms.Label()
        Me.error4 = New System.Windows.Forms.Label()
        Me.autoadd = New System.Windows.Forms.CheckBox()
        CType(Me.preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'preview
        '
        Me.preview.Location = New System.Drawing.Point(13, 80)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(150, 150)
        Me.preview.TabIndex = 22
        Me.preview.TabStop = False
        '
        'open
        '
        Me.open.Location = New System.Drawing.Point(91, 49)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(73, 21)
        Me.open.TabIndex = 21
        Me.open.Text = "開く"
        Me.open.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 12)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "テト譜"
        '
        'tetfu
        '
        Me.tetfu.Location = New System.Drawing.Point(12, 24)
        Me.tetfu.Name = "tetfu"
        Me.tetfu.Size = New System.Drawing.Size(152, 19)
        Me.tetfu.TabIndex = 19
        '
        'paste
        '
        Me.paste.Location = New System.Drawing.Point(12, 49)
        Me.paste.Name = "paste"
        Me.paste.Size = New System.Drawing.Size(73, 21)
        Me.paste.TabIndex = 18
        Me.paste.Text = "貼り付け"
        Me.paste.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(53, 242)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 25
        Me.Add.Text = "追加"
        Me.Add.UseVisualStyleBackColor = True
        '
        'error1
        '
        Me.error1.AutoSize = True
        Me.error1.ForeColor = System.Drawing.Color.Red
        Me.error1.Location = New System.Drawing.Point(131, 9)
        Me.error1.Name = "error1"
        Me.error1.Size = New System.Drawing.Size(32, 12)
        Me.error1.TabIndex = 28
        Me.error1.Text = "エラー"
        '
        'error2
        '
        Me.error2.AutoSize = True
        Me.error2.ForeColor = System.Drawing.Color.Red
        Me.error2.Location = New System.Drawing.Point(96, 9)
        Me.error2.Name = "error2"
        Me.error2.Size = New System.Drawing.Size(32, 12)
        Me.error2.TabIndex = 29
        Me.error2.Text = "エラー"
        '
        'error3
        '
        Me.error3.AutoSize = True
        Me.error3.ForeColor = System.Drawing.Color.Red
        Me.error3.Location = New System.Drawing.Point(131, 247)
        Me.error3.Name = "error3"
        Me.error3.Size = New System.Drawing.Size(32, 12)
        Me.error3.TabIndex = 30
        Me.error3.Text = "エラー"
        '
        'error4
        '
        Me.error4.AutoSize = True
        Me.error4.ForeColor = System.Drawing.Color.Red
        Me.error4.Location = New System.Drawing.Point(131, 9)
        Me.error4.Name = "error4"
        Me.error4.Size = New System.Drawing.Size(29, 12)
        Me.error4.TabIndex = 31
        Me.error4.Text = "警告"
        '
        'autoadd
        '
        Me.autoadd.AutoSize = True
        Me.autoadd.Checked = True
        Me.autoadd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autoadd.Location = New System.Drawing.Point(57, 267)
        Me.autoadd.Name = "autoadd"
        Me.autoadd.Size = New System.Drawing.Size(72, 16)
        Me.autoadd.TabIndex = 32
        Me.autoadd.Text = "自動追加"
        Me.autoadd.UseVisualStyleBackColor = True
        '
        'Addtetfu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 285)
        Me.Controls.Add(Me.autoadd)
        Me.Controls.Add(Me.error4)
        Me.Controls.Add(Me.error3)
        Me.Controls.Add(Me.error2)
        Me.Controls.Add(Me.error1)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.preview)
        Me.Controls.Add(Me.open)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tetfu)
        Me.Controls.Add(Me.paste)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Addtetfu"
        Me.Text = "Addtetfu"
        CType(Me.preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents preview As PictureBox
    Friend WithEvents open As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tetfu As TextBox
    Friend WithEvents paste As Button
    Friend WithEvents Add As Button
    Friend WithEvents error1 As Label
    Friend WithEvents error2 As Label
    Friend WithEvents error3 As Label
    Friend WithEvents error4 As Label
    Friend WithEvents autoadd As CheckBox
End Class
