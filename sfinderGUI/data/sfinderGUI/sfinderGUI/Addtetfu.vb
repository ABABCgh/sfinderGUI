Public Class Addtetfu
    Private Sub FirstLoad(sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        error1.Visible = False
        error2.Visible = False
        error3.Visible = False
        error4.Visible = False
    End Sub
    Private Sub Paste_Click(sender As Object, e As EventArgs) Handles paste.Click
        If Clipboard.ContainsText() Then
            tetfu.Text = Clipboard.GetText()
        End If
    End Sub
    Private Sub Tetfu_Click(sender As Object, ByVal e As EventArgs) Handles tetfu.Click
        tetfu.SelectAll()
    End Sub
    Private Sub Open_Click(sender As Object, e As EventArgs) Handles open.Click
        If error1.Visible Then
            error2.Visible = True
        Else
            error2.Visible = False
            Process.Start("https://fumen.zui.jp/?" + tetfu.Text)
        End If
    End Sub
    Private Sub TetfuChanged(sender As Object, e As EventArgs) Handles tetfu.TextChanged
        error4.Visible = False
        If TypeOf tetfu.Text Is String Then
            If tetfu.Text.Length > 10 Then
                If tetfu.Text.Substring(1, 4) = "115@" Then
                    error1.Visible = False
                    error2.Visible = False
                    error3.Visible = False
                    If autoadd.Checked Then
                        Addfu(Add, EventArgs.Empty)
                    End If
                Else
                    error1.Visible = True
                End If
            Else
                error1.Visible = True
            End If
        Else
            error1.Visible = True
        End If
        Dim data() As Short
        If error1.Visible = True Then
            data = Fumen("v115@vhAAAA", 1, False)
        Else
            data = Fumen(tetfu.Text, FumenLength(tetfu.Text), False)
        End If
        If tetfu.Text = "" Then
            error1.Visible = False
        End If
        preview.SizeMode = PictureBoxSizeMode.StretchImage
        preview.Image = Drawing(data, 10)
    End Sub
    Private Function Fumen(ByVal tetfu As String, ByVal page As Integer, ByVal clear As Boolean)
        Dim cr() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+", "/"}
        tetfu = tetfu.Replace("https://fumen.zui.jp/?", "")
        tetfu = tetfu.Replace("v115@", "")
        tetfu = tetfu.Replace("m115@", "")
        tetfu = tetfu.Replace("i115@", "")
        tetfu = tetfu.Replace("?", "")
        Dim fnum = 0
        Dim lineclear(23) As Short
        Dim clearline As New ArrayList
        Dim poll As Short = 2
        Dim data0(240 * page - 1) As Short
        For p = 0 To page - 1
            Dim blank As String = ""
            If tetfu.Substring(fnum, 2) = "vh" Then
                If Not tetfu.Substring(fnum + 2, 1) = "A" Then
                    blank = "vh" + cr(Array.IndexOf(cr, tetfu.Substring(fnum + 2, 1)) - 1)
                End If
                fnum += 3
                If Not p = 0 Then
                    For n = 0 To 239
                        If n \ 10 - lineclear(n \ 10) < 0 Then
                            data0(p * 240 + n) = 0
                        Else
                            data0(p * 240 + n) = data0((p - 1) * 240 + n - lineclear(n \ 10) * 10)
                        End If
                    Next
                End If
            Else
                If Not p = 0 Then
                    error4.Visible = True
                End If
                Dim data(((tetfu.Length - fnum) \ poll) - 1) As Integer
                For i = 0 To ((tetfu.Length - fnum) / poll) - 1
                    For c = 0 To poll - 1
                        data(i) += Array.IndexOf(cr, tetfu.Substring((poll * i) + c + fnum, 1)) * (64 ^ c)
                    Next
                Next
                Dim data2(data.Length * 2) As Short
                For i = 0 To data.Length - 1
                    data2(i * 2) = data(i) \ 240
                    data2(i * 2 + 1) = data(i) Mod 240
                Next
                Dim n = -1
                For i = 0 To data2.Length * 2 - 2 Step 2
                    For c = 0 To data2(i + 1)
                        n += 1
                        If 239 < n Then
                            fnum += i
                            Exit For
                        End If
                        If p = 0 Then
                            data0(n) = data2(i) - 8
                        Else
                            If n \ 10 - lineclear(n \ 10) < 0 Then
                                data0(p * 240 + n) = 0
                            Else
                                data0(p * 240 + n) = data0((p - 1) * 240 + n - lineclear(n \ 10) * 10) + data2(i) - 8
                            End If
                        End If
                    Next
                    If 239 < n Then
                        Exit For
                    End If
                Next
            End If
            Dim value = New Integer
            For i = 0 To 2
                value += Array.IndexOf(cr, tetfu.Substring(fnum + i, 1)) * (64 ^ i)
            Next
            Dim piece = value Mod 8
            value = value \ 8
            Dim rotation = value Mod 4
            value = value \ 4
            Dim rocation = value Mod 240
            value = value \ 240
            Dim flag_raise = value Mod 2
            value = value \ 2
            Dim flag_mirror = value Mod 2
            value = value \ 2
            Dim flag_color = value Mod 2
            value = value \ 2
            Dim flag_comment = value Mod 2
            value = value \ 2
            Dim flag_lock = (value + 1) Mod 2
            fnum += 3
            If Not flag_comment = 0 Then
                Dim txt As Integer = 0
                For i = 0 To 1
                    txt += Array.IndexOf(cr, tetfu.Substring(fnum + i, 1)) * (64 ^ i)
                Next
                fnum += ((txt + 3) \ 4) * 5 + 2
            End If
            tetfu = tetfu.Insert(fnum, blank)
            Dim mino() As Integer = {-1, 0, 1, 2, -10, 0, 10, 20, -1, 0, 1, 2, -10, 0, 10, 20,
                                     -1, 0, 1, 9, -10, 0, 10, 11, -9, -1, 0, 1, -11, -10, 0, 10,
                                      0, 1, 10, 11, 0, 1, 10, 11, 0, 1, 10, 11, 0, 1, 10, 11,
                                     -1, 0, 10, 11, -9, 0, 1, 10, -1, 0, 10, 11, -9, 0, 1, 10,
                                     -1, 0, 1, 10, -10, 0, 1, 10, -10, -1, 0, 1, -10, -1, 0, 10,
                                     -1, 0, 1, 11, -10, -9, 0, 10, -11, -1, 0, 1, -10, 0, 9, 10,
                                     0, 1, 9, 10, -11, -1, 0, 10, 0, 1, 9, 10, -11, -1, 0, 10}
            If Not piece = 0 Then
                For i = 0 To 3
                    data0(p * 240 + rocation + mino((piece - 1) * 16 + rotation * 4 + i)) = piece
                Next
            End If
            If page - 1 = p And Not clear Then
                Dim conv As New ArrayList
                Dim num = 0
                Dim num1 = 0
                Dim elem = ""
                While True
                    If clearline.Count < num + 1 Then
                        Exit While
                    End If
                    If clearline(num) = -1 Then
                        conv.Insert(num1, -1)
                        num += 1
                        num1 = 0
                    Else
                        For i = 0 To 10
                            conv.Insert(num1, clearline(num))
                            num1 += 1
                            num += 1
                        Next
                    End If
                End While
                clearline = conv
                num = 0
                While True
                    If clearline.Count < num + 1 Then
                        Exit While
                    End If
                    If clearline(num) = -1 Then
                        num += 1
                    Else
                        Dim li = clearline(num)
                        num += 1
                        For i = 0 To 229
                            If i < li * 10 Then
                                data0(p * 240 + i) = data0(p * 240 + i + 10)
                            ElseIf i < li * 10 + 10 Then
                                num += 1
                                data0(p * 240 + i) = clearline(num - 1)
                            End If
                        Next
                    End If
                End While
            End If
            Dim line As Short = 0
            Dim coly As Short = 0
            For i = 0 To 23
                Dim fill As Boolean = True
                For l = 0 To 9
                    If data0(p * 240 + (23 - i) * 10 + l) = 0 Then
                        fill = False
                    End If
                Next
                If i = 0 Then
                    fill = False
                End If
                If fill Then
                    line += 1
                    clearline.Add((23 - i).ToString)
                    For l = 0 To 9
                        clearline.Add(data0(p * 240 + (23 - i) * 10 + l))
                    Next
                Else
                    If Not i = 0 Then
                        coly += 1
                    End If
                End If
                If Not coly = 23 Then
                    lineclear(22 - coly) = line
                End If
            Next
            clearline.Add(-1)
            If coly = 0 Then
                lineclear(1) = 1
            Else
                For i = coly To 23
                    lineclear(23 - coly) = lineclear(coly - 1)
                Next
            End If
        Next
        Dim output(230) As Short
        For i = 0 To 229
            output(i) = data0(((page - 1) * 240) + (229 - i))
        Next
        For Each i In output
        Next
        Fumen = output
    End Function
    Private Function FumenLength(ByVal tetfu As String)
        Dim cr() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+", "/"}
        tetfu = tetfu.Replace("https://fumen.zui.jp/?", "")
        tetfu = tetfu.Replace("v115@", "")
        tetfu = tetfu.Replace("?", "")
        Dim fnum = 0
        Dim p = 0
        While True
            If tetfu.Length - fnum < 1 Then
                Exit While
            End If
            p += 1
            Dim blank As String = ""
            If tetfu.Substring(fnum, 2) = "vh" Then
                If Not tetfu.Substring(fnum + 2, 1) = "A" Then
                    blank = "vh" + cr(Array.IndexOf(cr, tetfu.Substring(fnum + 2, 1)) - 1)
                End If
                fnum += 3
            Else
                Dim data(((tetfu.Length - fnum) \ 2) - 1) As Integer
                For i = 0 To ((tetfu.Length - fnum) / 2) - 1
                    For c = 0 To 2 - 1
                        data(i) += Array.IndexOf(cr, tetfu.Substring((2 * i) + c + fnum, 1)) * (64 ^ c)
                    Next
                Next
                Dim data2(data.Length * 2) As Short
                For i = 0 To data.Length - 1
                    data2(i * 2) = data(i) \ 240
                    data2(i * 2 + 1) = data(i) Mod 240
                Next
                Dim n = -1
                For i = 0 To data2.Length * 2 - 2 Step 2
                    For c = 0 To data2(i + 1)
                        n += 1
                        If 239 < n Then
                            fnum += i
                            Exit For
                        End If
                    Next
                    If 239 < n Then
                        Exit For
                    End If
                Next
            End If
            Dim value = New Integer
            For i = 0 To 2
                value += Array.IndexOf(cr, tetfu.Substring(fnum + i, 1)) * (64 ^ i)
            Next
            value = value \ 8
            value = value \ 4
            value = value \ 240
            value = value \ 2
            value = value \ 2
            value = value \ 2
            Dim flag_comment = value Mod 2
            fnum += 3
            If Not flag_comment = 0 Then
                Dim txt As Integer = 0
                For i = 0 To 1
                    txt += Array.IndexOf(cr, tetfu.Substring(fnum + i, 1)) * (64 ^ i)
                Next
                fnum += ((txt + 3) \ 4) * 5 + 2
                Dim a = tetfu.Substring(fnum, 3)
            End If
            tetfu = tetfu.Insert(fnum, blank)
        End While
        FumenLength = p
    End Function
    Private Function Drawing(ByVal tetfu() As Short, ByVal hight As Short)
        Const quality = 15
        Dim fumen As New Bitmap(10 * quality, hight * quality)
        For i = 0 To hight * 10 - 1
            Dim c As Color
            Select Case tetfu(i)
                Case 0
                    c = Color.FromArgb(0, 0, 0)
                Case 1
                    c = Color.FromArgb(0, 255, 255)
                Case 2
                    c = Color.FromArgb(255, 180, 0)
                Case 3
                    c = Color.FromArgb(255, 255, 0)
                Case 4
                    c = Color.FromArgb(255, 0, 0)
                Case 5
                    c = Color.FromArgb(255, 0, 255)
                Case 6
                    c = Color.FromArgb(0, 0, 255)
                Case 7
                    c = Color.FromArgb(0, 255, 0)
                Case 8
                    c = Color.FromArgb(200, 200, 200)
                Case Else
                    c = Color.FromArgb(200, 20, 147)
            End Select
            For w = 0 To quality - 1
                For h = 0 To quality - 1
                    fumen.SetPixel((9 - i Mod 10) * quality + w, (hight - i \ 10 - 1) * quality + h, c)
                Next
            Next
        Next
        Dim g As Graphics = Graphics.FromImage(fumen)
        g.InterpolationMode = Drawing2D.InterpolationMode.Default
        Drawing = fumen
    End Function
    Private Sub Addfu(sender As Object, e As EventArgs) Handles Add.Click
        If error1.Visible Or tetfu.Text = "" Then
            error3.Visible = True
        Else
            Sfgui.Path.Items.Add(tetfu.Text)
            Sfgui.Path.SetItemChecked(Sfgui.Path.Items.Count - 1, True)
        End If
    End Sub
End Class