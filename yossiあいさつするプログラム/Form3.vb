﻿Option Strict On
Option Explicit On
Public Class Form3
    Private Sub Form3_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        If IntPtr.Size = 4 Then
            Label4.Text = " (x86)"
        ElseIf IntPtr.Size = 8 Then
            Label4.Text = " (x64)"
        Else
            MsgBox("技術的な問題が発生しました。" & vbCrLf & "エラー:if分岐の全てに当てはまりません。アプリケーションが32bitか64bitかによる分岐に問題がある可能性があります。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
        End If
        If My.Settings.darkmode = "True" Then
            Me.BackColor = Color.Black
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
        Else
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
End Class