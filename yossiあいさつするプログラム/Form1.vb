Option Strict On
Option Explicit On
Imports System.ComponentModel
Public Class Form1
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
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

            Else
                Dim update = MsgBox("アップデートがあります。アップデートしますか？", CType(vbYesNo + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
                If update = vbYes Then
                    applicationpath = System.Reflection.Assembly.GetExecutingAssembly().Location
                    If Not applicationpath Is Nothing Then
                        Dim applicationpathlen As Integer = applicationpath.Length
                        applicationpathlen = applicationpathlen - 21
                        applicationpath = applicationpath.Substring(0, applicationpathlen)
                    Else
                        MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションのパスが格納されている変数がNothingかによる分岐に問題が発生ある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
                    End If
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

            Else
                Dim update = MsgBox("アップデートがあります。アップデートしますか？", CType(vbYesNo + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
                If update = vbYes Then
                    desktopfilepath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                    desktopfilepath = desktopfilepath + "\"
                    MsgBox(desktopfilepath)
                    My.Computer.Network.DownloadFile(
        "https://tank.sakura.ne.jp/software/libs/yossi-program-to-greet/" + version + "/yossi-program-to-greet_ver" + version + "_" + intptrsize + "_setup.exe", desktopfilepath + "yossi-program-to-greet_" + version + "_" + intptrsize + "_setup.exe",
        "", "",
        True, 60000, True, FileIO.UICancelOption.DoNothing)
                    Dim p3 As System.Diagnostics.Process =
        System.Diagnostics.Process.Start(desktopfilepath + "yossi-program-to-greet_" + version + "_" + intptrsize + "_setup.exe")
                    Application.Exit()
                End If
            End If
        Else
            MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションが32bitか64bitかによる分岐に問題がある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
        End If
        BackgroundWorker1.RunWorkerAsync(100)
    End Sub
    Private Sub bgWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ' 別スレッドで実行されるため、このメソッドでは
        ' UI（コントロール）を操作してはいけない

        ' このメソッドへのパラメータ
        Dim bgWorkerArg As Integer = CType(e.Argument, Integer)

        ' senderの値はbgWorkerの値と同じ
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        ' 時間のかかる処理
        Dim dtNow As DateTime = DateTime.Now
        Dim applicationpath2 As String
        applicationpath2 = System.Reflection.Assembly.GetExecutingAssembly().Location
        If Not applicationpath2 Is Nothing Then
            Dim applicationpathlen As Integer = applicationpath2.Length
            applicationpathlen = applicationpathlen - 21
            applicationpath2 = applicationpath2.Substring(0, applicationpathlen)
        Else
            MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションのパスが格納されている変数がNothingかによる分岐に問題が発生ある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
        End If
        Do
            If dtNow.Hour = My.Settings.alarm11 And dtNow.Minute = My.Settings.alarm12 Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath2 + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "アラーム"
                NotifyIcon1.BalloonTipText = CStr(My.Settings.alarm11) + "時" + CStr(My.Settings.alarm12) + "分になりました。"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
                Exit Do
            Else
                System.Threading.Thread.Sleep(1000)
            End If
        Loop

        ' このメソッドからの戻り値
        e.Result = "すべて完了"

        ' この後、RunWorkerCompletedイベントが発生
    End Sub

    Private Function Shell() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Form1_FormClosing(ByVal sender As System.Object,
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
        'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dtNow As DateTime = DateTime.Now
        Dim fm2 As New Form2
        Dim variablemsgbox As Integer, get_nowtimetype As String
        Dim applicationpath As String
        applicationpath = System.Reflection.Assembly.GetExecutingAssembly().Location
        If Not applicationpath Is Nothing Then
            Dim applicationpathlen As Integer = applicationpath.Length
            applicationpathlen = applicationpathlen - 21
            applicationpath = applicationpath.Substring(0, applicationpathlen)
        Else
            MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションのパスが格納されている変数がNothingかによる分岐に問題が発生ある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
        End If
        'チェックボックスにチェックが入っているときはこんにちはを、入っていないときは時間帯に合わせて「おはようございます」「こんにちは」「こんばんは」を使い分けます
        If CheckBox1.Checked = True Then
            MsgBox("こんにちは" & vbCrLf & "現在時刻は" + CStr(dtNow) + "時です。", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If My.Settings.shownotification = "True" Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "あいさつ"
                NotifyIcon1.BalloonTipText = "こんにちは"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
            End If
            variablemsgbox = MsgBox("あいさつを返しますか？返すなら「はい」を、返さないなら「いいえ」を、前のウィンドウに戻るなら「キャンセル」をクリックしてください。", CType(vbYesNoCancel + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If variablemsgbox = vbYes Then
                fm2.Show()
                Me.Hide()
            ElseIf variablemsgbox = vbNo Then
                'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
                Application.Exit()
            End If
        ElseIf dtNow.Hour >= 5 And dtNow.Hour < 10 Then
            get_nowtimetype = "おはようございます"
            MsgBox(get_nowtimetype, CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If My.Settings.shownotification = "True" Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "あいさつ"
                NotifyIcon1.BalloonTipText = "おはようございます"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
            End If
            variablemsgbox = MsgBox("あいさつを返しますか？返すなら「はい」を、返さないなら「いいえ」を、前のウィンドウに戻るなら「キャンセル」をクリックしてください。", CType(vbYesNoCancel + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If variablemsgbox = vbYes Then
                fm2.Show()
                Me.Hide()
            ElseIf variablemsgbox = vbNo Then
                'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
                Application.Exit()
            End If
        ElseIf dtNow.Hour >= 10 And dtNow.Hour < 17 Then
            get_nowtimetype = "こんにちは"
            MsgBox(get_nowtimetype, CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If My.Settings.shownotification = "True" Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "あいさつ"
                NotifyIcon1.BalloonTipText = "こんにちは"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
            End If
            variablemsgbox = MsgBox("あいさつを返しますか？返すなら「はい」を、返さないなら「いいえ」を、前のウィンドウに戻るなら「キャンセル」をクリックしてください。", CType(vbYesNoCancel + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If variablemsgbox = vbYes Then
                fm2.Show()
                Me.Hide()
            ElseIf variablemsgbox = vbNo Then
                'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
                Application.Exit()
            End If
        ElseIf dtNow.Hour >= 17 And dtNow.Hour < 25 Then
            get_nowtimetype = "こんばんは"
            MsgBox(get_nowtimetype, CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If My.Settings.shownotification = "True" Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "あいさつ"
                NotifyIcon1.BalloonTipText = "こんばんは"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
            End If
            variablemsgbox = MsgBox("あいさつを返しますか？返すなら「はい」を、返さないなら「いいえ」を、前のウィンドウに戻るなら「キャンセル」をクリックしてください。", CType(vbYesNoCancel + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If variablemsgbox = vbYes Then
                fm2.Show()
                Me.Hide()
            ElseIf variablemsgbox = vbNo Then
                'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
                Application.Exit()
            End If
        ElseIf dtNow.Hour >= 0 And dtNow.Hour < 5 Then
            get_nowtimetype = "こんばんは"
            MsgBox(get_nowtimetype, CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If My.Settings.shownotification = "True" Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "あいさつ"
                NotifyIcon1.BalloonTipText = "こんばんは"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
            End If
            variablemsgbox = MsgBox("あいさつを返しますか？返すなら「はい」を、返さないなら「いいえ」を、前のウィンドウに戻るなら「キャンセル」をクリックしてください。", CType(vbYesNoCancel + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If variablemsgbox = vbYes Then
                fm2.Show()
                Me.Hide()
            ElseIf variablemsgbox = vbNo Then
                'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
                Application.Exit()
            End If
        Else
            MsgBox("技術的な問題が発生しました。今すぐにこのプログラムを実行したい場合はチェックボックスにチェックを入れて実行してみてください。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。時間帯による分岐に問題がある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
        End If
    End Sub

    Private Sub 新規あいさつNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新規あいさつNToolStripMenuItem.Click
        Dim dtNow As DateTime = DateTime.Now
        Dim fm2 As New Form2
        Dim variablemsgbox As Integer, get_nowtimetype As String
        Dim applicationpath As String
        applicationpath = System.Reflection.Assembly.GetExecutingAssembly().Location
        If Not applicationpath Is Nothing Then
            Dim applicationpathlen As Integer = applicationpath.Length
            applicationpathlen = applicationpathlen - 21
            applicationpath = applicationpath.Substring(0, applicationpathlen)
        Else
            MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションのパスが格納されている変数がNothingかによる分岐に問題が発生ある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
        End If
        'チェックボックスにチェックが入っているときはこんにちはを、入っていないときは時間帯に合わせて「おはようございます」「こんにちは」「こんばんは」を使い分けます
        If CheckBox1.Checked = True Then
            MsgBox("こんにちは", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If My.Settings.shownotification = "True" Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "あいさつ"
                NotifyIcon1.BalloonTipText = "こんにちは"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
            End If
            variablemsgbox = MsgBox("あいさつを返しますか？返すなら「はい」を、返さないなら「いいえ」を、前のウィンドウに戻るなら「キャンセル」をクリックしてください。", CType(vbYesNoCancel + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If variablemsgbox = vbYes Then
                fm2.Show()
                Me.Hide()
            ElseIf variablemsgbox = vbNo Then
                'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
                Application.Exit()
            End If
        ElseIf dtNow.Hour >= 5 And dtNow.Hour < 10 Then
            get_nowtimetype = "おはようございます"
            MsgBox(get_nowtimetype, CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If My.Settings.shownotification = "True" Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "あいさつ"
                NotifyIcon1.BalloonTipText = "おはようございます"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
            End If
            variablemsgbox = MsgBox("あいさつを返しますか？返すなら「はい」を、返さないなら「いいえ」を、前のウィンドウに戻るなら「キャンセル」をクリックしてください。", CType(vbYesNoCancel + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If variablemsgbox = vbYes Then
                fm2.Show()
                Me.Hide()
            ElseIf variablemsgbox = vbNo Then
                'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
                Application.Exit()
            End If
        ElseIf dtNow.Hour >= 10 And dtNow.Hour < 17 Then
            get_nowtimetype = "こんにちは"
            MsgBox(get_nowtimetype, CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If My.Settings.shownotification = "True" Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "あいさつ"
                NotifyIcon1.BalloonTipText = "こんにちは"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
            End If
            variablemsgbox = MsgBox("あいさつを返しますか？返すなら「はい」を、返さないなら「いいえ」を、前のウィンドウに戻るなら「キャンセル」をクリックしてください。", CType(vbYesNoCancel + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If variablemsgbox = vbYes Then
                fm2.Show()
                Me.Hide()
            ElseIf variablemsgbox = vbNo Then
                'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
                Application.Exit()
            End If
        ElseIf dtNow.Hour >= 17 And dtNow.Hour < 25 Then
            get_nowtimetype = "こんばんは"
            MsgBox(get_nowtimetype, CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If My.Settings.shownotification = "True" Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "あいさつ"
                NotifyIcon1.BalloonTipText = "こんばんは"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
            End If
            variablemsgbox = MsgBox("あいさつを返しますか？返すなら「はい」を、返さないなら「いいえ」を、前のウィンドウに戻るなら「キャンセル」をクリックしてください。", CType(vbYesNoCancel + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If variablemsgbox = vbYes Then
                fm2.Show()
                Me.Hide()
            ElseIf variablemsgbox = vbNo Then
                'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
                Application.Exit()
            End If
        ElseIf dtNow.Hour >= 0 And dtNow.Hour < 5 Then
            get_nowtimetype = "こんばんは"
            MsgBox(get_nowtimetype, CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If My.Settings.shownotification = "True" Then
                NotifyIcon1.Icon = New System.Drawing.Icon(applicationpath + "\icon.ico")
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "あいさつ"
                NotifyIcon1.BalloonTipText = "こんばんは"
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(10000)
            End If
            variablemsgbox = MsgBox("あいさつを返しますか？返すなら「はい」を、返さないなら「いいえ」を、前のウィンドウに戻るなら「キャンセル」をクリックしてください。", CType(vbYesNoCancel + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
            If variablemsgbox = vbYes Then
                fm2.Show()
                Me.Hide()
            ElseIf variablemsgbox = vbNo Then
                'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
                Application.Exit()
            End If
        Else
            MsgBox("技術的な問題が発生しました。今すぐにこのプログラムを実行したい場合はチェックボックスにチェックを入れて実行してみてください。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。時間帯による分岐に問題が発生ある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
        End If
    End Sub

    Private Sub 終了XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了XToolStripMenuItem.Click
        'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
        Application.Exit()
    End Sub

    Private Sub ヘルプHToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ヘルプHToolStripMenuItem1.Click
        Dim helpfilepath As String
        helpfilepath = System.Reflection.Assembly.GetExecutingAssembly().Location
        If Not helpfilepath Is Nothing Then
            Dim helpfilepathlen As Integer = helpfilepath.Length
            helpfilepathlen = helpfilepathlen - 21
            helpfilepath = helpfilepath.Substring(0, helpfilepathlen)
            helpfilepath = helpfilepath + "\help.chm"
            Help.ShowHelp(Me, helpfilepath)
        Else
            MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションのパスが格納されている変数がNothingかによる分岐に問題が発生ある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
        End If
    End Sub

    Private Sub オンラインヘルプOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles オンラインヘルプOToolStripMenuItem.Click
        MsgBox("この機能は将来実装される予定です。大変申し訳ございませんがそれまでお待ちください。", CType(vbOKOnly + vbInformation, MsgBoxStyle), "yossiあいさつするプログラム")
    End Sub

    Private Sub YossiあいさつするプログラムのウェブサイトEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YossiあいさつするプログラムのウェブサイトEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://tank.sakura.ne.jp/software/yossi-program-to-greet.html")
    End Sub

    Private Sub TankHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TankHToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://tank.sakura.ne.jp/")
    End Sub

    Private Sub アップデートを確認AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles アップデートを確認AToolStripMenuItem.Click
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
                Dim p4 As System.Diagnostics.Process =
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
                Dim p5 As System.Diagnostics.Process =
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

    Private Sub オプションOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles オプションOToolStripMenuItem1.Click
        Form4.ShowDialog(Me)
    End Sub
End Class
