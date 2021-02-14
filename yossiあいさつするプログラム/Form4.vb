Option Strict On
Option Explicit On
Public Class Form4
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        If My.Settings.shownotification = "True" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        NumericUpDown1.Value = My.Settings.alarm11
        NumericUpDown2.Value = My.Settings.alarm12
        NumericUpDown3.Value = My.Settings.alarm21
        NumericUpDown4.Value = My.Settings.alarm22
        NumericUpDown5.Value = My.Settings.alarm31
        NumericUpDown6.Value = My.Settings.alarm32
    End Sub
    Public Class SampleClass
        Public Number As Integer
        Public Message As String
    End Class
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iserror As Integer, iserror2 As Integer, iserror3 As Integer, iserror4 As Integer, iserror5 As Integer, iserror6 As Integer, iserror7 As Integer
        If CheckBox1.Checked = True Then
            My.Settings.shownotification = "True"
            'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
            iserror = 0
        Else
            My.Settings.shownotification = "False"
            'フォーム2が開いたときフォーム1は、フォーム1が開いたときフォーム2は非表示になるためMe.Closeは使わないこと
            iserror = 0
        End If
        If NumericUpDown1.Value > 24 Or NumericUpDown1.Value < 0 Then
            MsgBox("エラー：値は1から24の範囲内にしてください。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
            iserror2 = 1
        Else
            My.Settings.alarm11 = CInt(NumericUpDown1.Value)
            iserror2 = 0
        End If
        If NumericUpDown2.Value > 59 Or NumericUpDown2.Value < 0 Then
            MsgBox("エラー：値は1から24の範囲内にしてください。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
            iserror3 = 1
        Else
            My.Settings.alarm12 = CInt(NumericUpDown2.Value)
            iserror3 = 0
        End If
        If NumericUpDown3.Value > 24 Or NumericUpDown3.Value < 0 Then
            MsgBox("エラー：値は1から24の範囲内にしてください。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
            iserror4 = 1
        Else
            My.Settings.alarm21 = CInt(NumericUpDown3.Value)
            iserror4 = 0
        End If
        If NumericUpDown4.Value > 59 Or NumericUpDown4.Value < 0 Then
            MsgBox("エラー：値は1から24の範囲内にしてください。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
            iserror5 = 1
        Else
            My.Settings.alarm22 = CInt(NumericUpDown4.Value)
            iserror5 = 0
        End If
        If NumericUpDown5.Value > 24 Or NumericUpDown5.Value < 0 Then
            MsgBox("エラー：値は1から24の範囲内にしてください。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
            iserror6 = 1
        Else
            My.Settings.alarm31 = CInt(NumericUpDown5.Value)
            iserror6 = 0
        End If
        If NumericUpDown6.Value > 59 Or NumericUpDown6.Value < 0 Then
            MsgBox("エラー：値は1から24の範囲内にしてください。", CType(vbOKOnly + vbCritical, MsgBoxStyle), "yossiあいさつするプログラム")
            iserror7 = 1
        Else
            My.Settings.alarm32 = CInt(NumericUpDown6.Value)
            iserror7 = 0
        End If
        If iserror = 0 And iserror2 = 0 And iserror3 = 0 And iserror4 = 0 And iserror5 = 0 And iserror6 = 0 And iserror7 = 0 Then
            Me.Dispose()
        End If
    End Sub
End Class