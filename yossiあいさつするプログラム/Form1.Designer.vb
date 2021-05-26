<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新規あいさつNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.オプションOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.オプションOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.オンラインヘルプOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ウェブサイト関係EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YossiあいさつするプログラムのウェブサイトEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TankHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.アップデートを確認AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.YossiあいさつするプログラムについてAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.アプリケーションを開くToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.オプションToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(118, 400)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 80)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "閉じる"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(591, 400)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(236, 80)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "実行"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(285, 314)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(367, 28)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "朝でも夜でもこんにちはで応答する"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(822, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "「実行」をクリックすると時間帯に合わせて「おはようございます」「こんにちは」「こんばんは」"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(347, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "のどちらかで応答します。"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.オプションOToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(945, 40)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新規あいさつNToolStripMenuItem, Me.ToolStripMenuItem1, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(129, 36)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '新規あいさつNToolStripMenuItem
        '
        Me.新規あいさつNToolStripMenuItem.Name = "新規あいさつNToolStripMenuItem"
        Me.新規あいさつNToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.新規あいさつNToolStripMenuItem.Size = New System.Drawing.Size(405, 44)
        Me.新規あいさつNToolStripMenuItem.Text = "新規あいさつ(&N)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(402, 6)
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(405, 44)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        'オプションOToolStripMenuItem
        '
        Me.オプションOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.オプションOToolStripMenuItem1})
        Me.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem"
        Me.オプションOToolStripMenuItem.Size = New System.Drawing.Size(155, 36)
        Me.オプションOToolStripMenuItem.Text = "オプション(&O)"
        '
        'オプションOToolStripMenuItem1
        '
        Me.オプションOToolStripMenuItem1.Name = "オプションOToolStripMenuItem1"
        Me.オプションOToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.オプションOToolStripMenuItem1.Size = New System.Drawing.Size(324, 44)
        Me.オプションOToolStripMenuItem1.Text = "オプション(&O)..."
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.オンラインヘルプOToolStripMenuItem, Me.ToolStripMenuItem3, Me.ウェブサイト関係EToolStripMenuItem, Me.ToolStripMenuItem2, Me.アップデートを確認AToolStripMenuItem, Me.ToolStripMenuItem4, Me.YossiあいさつするプログラムについてAToolStripMenuItem})
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(124, 36)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'オンラインヘルプOToolStripMenuItem
        '
        Me.オンラインヘルプOToolStripMenuItem.Name = "オンラインヘルプOToolStripMenuItem"
        Me.オンラインヘルプOToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.オンラインヘルプOToolStripMenuItem.Size = New System.Drawing.Size(524, 44)
        Me.オンラインヘルプOToolStripMenuItem.Text = "オンラインヘルプ(&O)..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(521, 6)
        '
        'ウェブサイト関係EToolStripMenuItem
        '
        Me.ウェブサイト関係EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YossiあいさつするプログラムのウェブサイトEToolStripMenuItem, Me.TankHToolStripMenuItem})
        Me.ウェブサイト関係EToolStripMenuItem.Name = "ウェブサイト関係EToolStripMenuItem"
        Me.ウェブサイト関係EToolStripMenuItem.Size = New System.Drawing.Size(524, 44)
        Me.ウェブサイト関係EToolStripMenuItem.Text = "ウェブサイト関係(&W)"
        '
        'YossiあいさつするプログラムのウェブサイトEToolStripMenuItem
        '
        Me.YossiあいさつするプログラムのウェブサイトEToolStripMenuItem.Name = "YossiあいさつするプログラムのウェブサイトEToolStripMenuItem"
        Me.YossiあいさつするプログラムのウェブサイトEToolStripMenuItem.Size = New System.Drawing.Size(579, 44)
        Me.YossiあいさつするプログラムのウェブサイトEToolStripMenuItem.Text = "yossiあいさつするプログラムのウェブサイト(&W)..."
        '
        'TankHToolStripMenuItem
        '
        Me.TankHToolStripMenuItem.Name = "TankHToolStripMenuItem"
        Me.TankHToolStripMenuItem.Size = New System.Drawing.Size(579, 44)
        Me.TankHToolStripMenuItem.Text = "yossi.cloud(&H)..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(521, 6)
        '
        'アップデートを確認AToolStripMenuItem
        '
        Me.アップデートを確認AToolStripMenuItem.Name = "アップデートを確認AToolStripMenuItem"
        Me.アップデートを確認AToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F9), System.Windows.Forms.Keys)
        Me.アップデートを確認AToolStripMenuItem.Size = New System.Drawing.Size(524, 44)
        Me.アップデートを確認AToolStripMenuItem.Text = "アップデートを確認(&U)..."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(521, 6)
        '
        'YossiあいさつするプログラムについてAToolStripMenuItem
        '
        Me.YossiあいさつするプログラムについてAToolStripMenuItem.Name = "YossiあいさつするプログラムについてAToolStripMenuItem"
        Me.YossiあいさつするプログラムについてAToolStripMenuItem.Size = New System.Drawing.Size(524, 44)
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
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.アプリケーションを開くToolStripMenuItem, Me.ToolStripMenuItem5, Me.オプションToolStripMenuItem, Me.ToolStripMenuItem6, Me.終了ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(286, 130)
        '
        'アプリケーションを開くToolStripMenuItem
        '
        Me.アプリケーションを開くToolStripMenuItem.Name = "アプリケーションを開くToolStripMenuItem"
        Me.アプリケーションを開くToolStripMenuItem.Size = New System.Drawing.Size(285, 38)
        Me.アプリケーションを開くToolStripMenuItem.Text = "アプリケーションを開く"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(282, 6)
        '
        'オプションToolStripMenuItem
        '
        Me.オプションToolStripMenuItem.Name = "オプションToolStripMenuItem"
        Me.オプションToolStripMenuItem.Size = New System.Drawing.Size(285, 38)
        Me.オプションToolStripMenuItem.Text = "オプション"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(282, 6)
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(285, 38)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        'BackgroundWorker1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(945, 514)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "yossiあいさつするプログラム"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新規あいさつNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents オンラインヘルプOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents YossiあいさつするプログラムについてAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ウェブサイト関係EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YossiあいさつするプログラムのウェブサイトEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TankHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents アップデートを確認AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents オプションOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents オプションOToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents アプリケーションを開くToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents オプションToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
