Option Strict On
Option Explicit On
Public Class Form2
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        If My.Settings.darkmode = "True" Then
            Me.BackColor = Color.Black
            Label1.BackColor = Color.White
        Else
            Me.BackColor = Color.White
        End If
    End Sub
    Private Sub Form2_FormClosing(ByVal sender As System.Object,
        ByVal e As System.Windows.Forms.FormClosingEventArgs) _
        Handles MyBase.FormClosing
        'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためこのコードを使っています
        Select Case e.CloseReason
            Case CloseReason.ApplicationExitCall

            Case Else
                If e.CloseReason = CloseReason.UserClosing Then
                    e.Cancel = True
                End If
                Me.Hide()
                Dim applicationpath As String
                applicationpath = System.Reflection.Assembly.GetExecutingAssembly().Location
                If Not applicationpath Is Nothing Then
                    Dim applicationpathlen As Integer = applicationpath.Length
                    applicationpathlen = applicationpathlen - 21
                    applicationpath = applicationpath.Substring(0, applicationpathlen)
                Else
                    MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションのパスが格納されている変数がNothingかによる分岐に問題が発生ある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
                End If
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "情報"
                NotifyIcon1.BalloonTipText = "アプリケーションはまだ起動しています。" & vbCrLf & "終了する際はタスクトレイのアイコンを右クリックして閉じてください。"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fm1 As New Form1
        fm1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("こちらこそおはようございます", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("こちらこそこんにちは", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("こちらこそこんばんは", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
    End Sub

    Private Sub 新規あいさつNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新規あいさつNToolStripMenuItem.Click
        Dim newgreetings = InputBox("返したいあいさつを入力してください。")
        If newgreetings = "おはようございます" Then
            MsgBox("こちらこそおはようございます", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
        ElseIf newgreetings = "こんにちは" Then
            MsgBox("こちらこそこんにちは", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
        ElseIf newgreetings = "こんばんは" Then
            MsgBox("こちらこそこんばんは", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
        Else
            MsgBox("正しく入力してください。「おはようございます」、「こんにちは」、「こんばんは」の中から入力してください。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
        End If
    End Sub

    Private Sub 終了XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了XToolStripMenuItem.Click
        'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
        Application.Exit()
    End Sub

    Private Sub オンラインヘルプOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles オンラインヘルプOToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://tank.sakura.ne.jp/software/help/yossi-program-to-greet/index.html")
    End Sub

    Private Sub YossiあいさつするプログラムのウェブサイトWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YossiあいさつするプログラムのウェブサイトWToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://tank.sakura.ne.jp/software/yossi-program-to-greet.html")
    End Sub

    Private Sub TankHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TankHToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://tank.sakura.ne.jp/")
    End Sub

    Private Sub アップデートを確認UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles アップデートを確認UToolStripMenuItem.Click
        Dim intptrsize As String, desktopfilepath As String
        If IntPtr.Size = 4 Then
            intptrsize = "32"
            Dim applicationpath As String
            applicationpath = System.Reflection.Assembly.GetExecutingAssembly().Location
            If Not applicationpath Is Nothing Then
                Dim applicationpathlen As Integer = applicationpath.Length
                applicationpathlen = applicationpathlen - 21
                applicationpath = applicationpath.Substring(0, applicationpathlen)
            Else
                MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションのパスが格納されている変数がNothingかによる分岐に問題が発生ある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
            End If
            Dim wc As New System.Net.WebClient()
            wc.DownloadFile("https://tank.sakura.ne.jp/software/update.json", applicationpath + "\json\update.json")
            wc.Dispose()
            Dim sr As New System.IO.StreamReader(applicationpath + "\json\update.json", System.Text.Encoding.Default)
            Dim jsonText As String = sr.ReadToEnd
            Dim root As Newtonsoft.Json.Linq.JObject = DirectCast(Newtonsoft.Json.JsonConvert.DeserializeObject(jsonText), Newtonsoft.Json.Linq.JObject)
            Dim version As String = root("version").ToString
            Dim versionfile As New System.IO.StreamReader(applicationpath + "\version.txt", System.Text.Encoding.Default)
            Dim versionfile2 As String = sr.ReadToEnd
            If version = versionfile2 Then
                MsgBox("このアプリケーションは最新です。", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            Else
                desktopfilepath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                desktopfilepath = desktopfilepath + "\"
                My.Computer.Network.DownloadFile(
        "https://tank.sakura.ne.jp/software/libs/yossi-program-to-greet/" + version + "/yossi-program-to-greet_ver" + version + "_" + intptrsize + "_setup.exe", desktopfilepath + "yossi-program-to-greet_" + version + "_" + intptrsize + "_setup.exe",
        "", "",
        True, 60000, True, FileIO.UICancelOption.DoNothing)
                Dim p2 As System.Diagnostics.Process =
        System.Diagnostics.Process.Start(desktopfilepath + "yossi-program-to-greet_" + version + "_" + intptrsize + "_setup.exe")
                Application.Exit()
            End If
        ElseIf IntPtr.Size = 8 Then
            intptrsize = "64"
            Dim applicationpath As String
            applicationpath = System.Reflection.Assembly.GetExecutingAssembly().Location
            If Not applicationpath Is Nothing Then
                Dim applicationpathlen As Integer = applicationpath.Length
                applicationpathlen = applicationpathlen - 21
                applicationpath = applicationpath.Substring(0, applicationpathlen)
            Else
                MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションのパスが格納されている変数がNothingかによる分岐に問題が発生ある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
            End If
            Dim wc As New System.Net.WebClient()
            wc.DownloadFile("https://tank.sakura.ne.jp/software/update.json", applicationpath + "\json\update.json")
            wc.Dispose()
            Dim sr As New System.IO.StreamReader(applicationpath + "\json\update.json", System.Text.Encoding.Default)
            Dim jsonText As String = sr.ReadToEnd
            Dim root As Newtonsoft.Json.Linq.JObject = DirectCast(Newtonsoft.Json.JsonConvert.DeserializeObject(jsonText), Newtonsoft.Json.Linq.JObject)
            Dim version As String = root("version").ToString
            Dim versionfile As New System.IO.StreamReader(applicationpath + "\version.txt", System.Text.Encoding.Default)
            Dim versionfile2 As String = sr.ReadToEnd
            If version = versionfile2 Then
                MsgBox("このアプリケーションは最新です。", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            Else
                desktopfilepath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                desktopfilepath = desktopfilepath + "\"
                My.Computer.Network.DownloadFile(
        "https://tank.sakura.ne.jp/software/libs/yossi-program-to-greet/" + version + "/yossi-program-to-greet_ver" + version + "_" + intptrsize + "_setup.exe", desktopfilepath + "yossi-program-to-greet_" + version + "_" + intptrsize + "_setup.exe",
        "", "",
        True, 60000, True, FileIO.UICancelOption.DoNothing)
                Dim p3 As System.Diagnostics.Process =
        System.Diagnostics.Process.Start(desktopfilepath + "yossi-program-to-greet_" + version + "_" + intptrsize + "_setup.exe")
                Application.Exit()
            End If
        Else
            MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションが32bitか64bitかによる分岐に問題がある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
        End If
    End Sub

    Private Sub YossiあいさつするプログラムについてAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YossiあいさつするプログラムについてAToolStripMenuItem.Click
        Form3.ShowDialog(Me)
    End Sub
End Class