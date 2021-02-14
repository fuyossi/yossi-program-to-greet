<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新規あいさつNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.オンラインヘルプOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ウェブサイト関係WToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YossiあいさつするプログラムのウェブサイトWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TankHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.アップデートを確認UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.YossiあいさつするプログラムについてAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.アプリケーションを開くToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.オプションToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(100, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 70)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "前のウィンドウに戻る"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(500, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 70)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "閉じる"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Location = New System.Drawing.Point(50, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 100)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "おはようございます"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "あいさつをしてみましょう(今の時間帯は無視されます)"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button4.AutoSize = True
        Me.Button4.Location = New System.Drawing.Point(300, 125)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 100)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "こんにちは"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.AutoSize = True
        Me.Button5.Location = New System.Drawing.Point(550, 125)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(200, 100)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "こんばんは"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 38)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新規あいさつNToolStripMenuItem, Me.ToolStripMenuItem1, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(112, 34)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '新規あいさつNToolStripMenuItem
        '
        Me.新規あいさつNToolStripMenuItem.Name = "新規あいさつNToolStripMenuItem"
        Me.新規あいさつNToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.新規あいさつNToolStripMenuItem.Size = New System.Drawing.Size(355, 40)
        Me.新規あいさつNToolStripMenuItem.Text = "新規あいさつ(&N)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(352, 6)
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(355, 40)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ヘルプHToolStripMenuItem1, Me.オンラインヘルプOToolStripMenuItem, Me.ToolStripMenuItem2, Me.ウェブサイト関係WToolStripMenuItem, Me.ToolStripMenuItem3, Me.アップデートを確認UToolStripMenuItem, Me.ToolStripMenuItem4, Me.YossiあいさつするプログラムについてAToolStripMenuItem})
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(108, 34)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'ヘルプHToolStripMenuItem1
        '
        Me.ヘルプHToolStripMenuItem1.Name = "ヘルプHToolStripMenuItem1"
        Me.ヘルプHToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ヘルプHToolStripMenuItem1.Size = New System.Drawing.Size(457, 40)
        Me.ヘルプHToolStripMenuItem1.Text = "ヘルプ(&H)..."
        '
        'オンラインヘルプOToolStripMenuItem
        '
        Me.オンラインヘルプOToolStripMenuItem.Name = "オンラインヘルプOToolStripMenuItem"
        Me.オンラインヘルプOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.オンラインヘルプOToolStripMenuItem.Size = New System.Drawing.Size(457, 40)
        Me.オンラインヘルプOToolStripMenuItem.Text = "オンラインヘルプ(&O)..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(454, 6)
        '
        'ウェブサイト関係WToolStripMenuItem
        '
        Me.ウェブサイト関係WToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YossiあいさつするプログラムのウェブサイトWToolStripMenuItem, Me.TankHToolStripMenuItem})
        Me.ウェブサイト関係WToolStripMenuItem.Name = "ウェブサイト関係WToolStripMenuItem"
        Me.ウェブサイト関係WToolStripMenuItem.Size = New System.Drawing.Size(457, 40)
        Me.ウェブサイト関係WToolStripMenuItem.Text = "ウェブサイト関係(&W)"
        '
        'YossiあいさつするプログラムのウェブサイトWToolStripMenuItem
        '
        Me.YossiあいさつするプログラムのウェブサイトWToolStripMenuItem.Name = "YossiあいさつするプログラムのウェブサイトWToolStripMenuItem"
        Me.YossiあいさつするプログラムのウェブサイトWToolStripMenuItem.Size = New System.Drawing.Size(506, 40)
        Me.YossiあいさつするプログラムのウェブサイトWToolStripMenuItem.Text = "yossiあいさつするプログラムのウェブサイト(&W)..."
        '
        'TankHToolStripMenuItem
        '
        Me.TankHToolStripMenuItem.Name = "TankHToolStripMenuItem"
        Me.TankHToolStripMenuItem.Size = New System.Drawing.Size(506, 40)
        Me.TankHToolStripMenuItem.Text = "tank(&H)..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(454, 6)
        '
        'アップデートを確認UToolStripMenuItem
        '
        Me.アップデートを確認UToolStripMenuItem.Name = "アップデートを確認UToolStripMenuItem"
        Me.アップデートを確認UToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F9), System.Windows.Forms.Keys)
        Me.アップデートを確認UToolStripMenuItem.Size = New System.Drawing.Size(457, 40)
        Me.アップデートを確認UToolStripMenuItem.Text = "アップデートを確認(&U)..."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(454, 6)
        '
        'YossiあいさつするプログラムについてAToolStripMenuItem
        '
        Me.YossiあいさつするプログラムについてAToolStripMenuItem.Name = "YossiあいさつするプログラムについてAToolStripMenuItem"
        Me.YossiあいさつするプログラムについてAToolStripMenuItem.Size = New System.Drawing.Size(457, 40)
        Me.YossiあいさつするプログラムについてAToolStripMenuItem.Text = "yossiあいさつするプログラムについて(&A)..."
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "yossiあいさつするプログラム"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.アプリケーションを開くToolStripMenuItem, Me.ToolStripMenuItem5, Me.オプションToolStripMenuItem, Me.ToolStripMenuItem6, Me.終了ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(260, 124)
        '
        'アプリケーションを開くToolStripMenuItem
        '
        Me.アプリケーションを開くToolStripMenuItem.Name = "アプリケーションを開くToolStripMenuItem"
        Me.アプリケーションを開くToolStripMenuItem.Size = New System.Drawing.Size(259, 36)
        Me.アプリケーションを開くToolStripMenuItem.Text = "アプリケーションを開く"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(256, 6)
        '
        'オプションToolStripMenuItem
        '
        Me.オプションToolStripMenuItem.Name = "オプションToolStripMenuItem"
        Me.オプションToolStripMenuItem.Size = New System.Drawing.Size(259, 36)
        Me.オプションToolStripMenuItem.Text = "オプション"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(256, 6)
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(259, 36)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "yossiあいさつするプログラム(ウィンドウ2)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新規あいさつNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents オンラインヘルプOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ウェブサイト関係WToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YossiあいさつするプログラムのウェブサイトWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TankHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents アップデートを確認UToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents YossiあいさつするプログラムについてAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents アプリケーションを開くToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents オプションToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
End Class
