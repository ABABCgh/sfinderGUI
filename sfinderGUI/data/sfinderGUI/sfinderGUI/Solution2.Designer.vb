﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Solution2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Solution2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcmode = New System.Windows.Forms.ComboBox()
        Me.dropmode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "パフェモード"
        '
        'pcmode
        '
        Me.pcmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pcmode.FormattingEnabled = True
        Me.pcmode.Items.AddRange(New Object() {"normal", "2l", "tetris", "tetris-end", "tss", "tsd", "tst", "btb"})
        Me.pcmode.Location = New System.Drawing.Point(12, 29)
        Me.pcmode.Name = "pcmode"
        Me.pcmode.Size = New System.Drawing.Size(109, 20)
        Me.pcmode.TabIndex = 2
        '
        'dropmode
        '
        Me.dropmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropmode.FormattingEnabled = True
        Me.dropmode.Items.AddRange(New Object() {"normal", "harddrop", "t-softdrop"})
        Me.dropmode.Location = New System.Drawing.Point(12, 84)
        Me.dropmode.Name = "dropmode"
        Me.dropmode.Size = New System.Drawing.Size(109, 20)
        Me.dropmode.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "設置方法"
        '
        'Solution2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(143, 163)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dropmode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcmode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Solution2"
        Me.Text = "PCmode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pcmode As ComboBox
    Friend WithEvents dropmode As ComboBox
    Friend WithEvents Label2 As Label
End Class
