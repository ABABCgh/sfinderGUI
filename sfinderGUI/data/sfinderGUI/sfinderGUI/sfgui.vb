Public Class Sfgui
    Public solutionmode = 0
    Public clearlineheight = 0
    Public pcmode = "normal"
    Public dropmode = "softdrop"
    Public loadToAdd = False
    Public usemargin = False
    Public usemargin2 = False
    Private Sub FirstLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        error1.Visible = False
        error2.Visible = False
        error3.Visible = False
        error4.Visible = False
        error5.Visible = False
        error6.Visible = False
        copy.Visible = False
        clear2.Visible = False
        RPC.Visible = False
        Dim input As New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\input.txt", System.Text.Encoding.GetEncoding("Unicode"))
            While txt.Peek > -1
                input.Add(txt.ReadLine())
            End While
        End Using
        page.Text = input(1)
        p1.Text = input(2)
        p2.Text = input(3)
        solutionmode = input(4)
        clearlineheight = input(5)
        lineheight.Text = input(5)
        pcmode = input(6)
        dropmode = input(8)
        tetfu.Text = input(0)
        If solutionmode = 0 Then
            Label7.Visible = True
            lineheight.Visible = True
            Dim toshort As Short
            If IsNumeric(lineheight.Text) Then
                Try
                    toshort = CInt(lineheight.Text)
                Catch ex As Exception
                    error4.Visible = True
                End Try
                If toshort > 0 And toshort < 11 Then
                    error4.Visible = False
                    error5.Visible = False
                Else
                    error4.Visible = True
                End If
            Else
                error4.Visible = True
            End If
        Else
            Label7.Visible = False
            lineheight.Visible = False
            error4.Visible = False
        End If
        NotNormalMode()
        addload.Text = ""
        Path_Load()
    End Sub
    Private Sub Paste_Click(sender As Object, e As EventArgs) Handles paste.Click
        If Clipboard.ContainsText() Then
            If TypeOf tetfu.Text Is String Then
                If tetfu.Text.Length > 10 Then
                    If tetfu.Text.Substring(1, 4) = "115@" Then
                        Dim bool As Boolean = False
                        Dim befo As Short() = Fumen(tetfu.Text, 1, True)
                        tetfu.Text = Clipboard.GetText()
                        Dim afte As Short() = Fumen(tetfu.Text, 1, True)
                        For i = 0 To befo.Length - 1
                            If Not befo(i) = afte(i) Then
                                bool = True
                            End If
                        Next
                        If bool Then
                            page.Text = 1
                        End If
                    End If
                End If
            End If
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
    Private Sub TetfuChanged(sender As Object, e As EventArgs) Handles tetfu.TextChanged, page.TextChanged, lineheight.TextChanged
        Dim Input = New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\input.txt", System.Text.Encoding.GetEncoding("Unicode"))
            While txt.Peek > -1
                Input.Add(txt.ReadLine())
            End While
        End Using
        If TypeOf tetfu.Text Is String Then
            If tetfu.Text.Length > 10 Then
                If tetfu.Text.Substring(1, 4) = "115@" Then
                    error1.Visible = False
                    Input(0) = tetfu.Text
                Else
                    error1.Visible = True
                End If
            Else
                error1.Visible = True
            End If
        Else
            error1.Visible = True
        End If
        Input(1) = page.Text
        Dim p As Integer
        If Integer.TryParse(page.Text, p) Then
            If error1.Visible = False Then
                If 0 < p And p < FumenLength(tetfu.Text) + 1 Then
                    error3.Visible = False
                Else
                    error3.Visible = True
                    p = 1
                End If
            Else
                error3.Visible = False
                p = 1
            End If
        Else
            error3.Visible = True
            p = 1
        End If
        Dim data() As Short
        If error1.Visible = True Then
            Input(0) = "v115@vhAAAA"
            data = Fumen("v115@vhAAAA", 1, True)
        Else
            data = Fumen(tetfu.Text, p, True)
        End If
        If tetfu.Text = "" Then
            error1.Visible = False
        End If
        If page.Text = "" Then
            error3.Visible = False
        End If
        Dim toshort As Short
        If IsNumeric(lineheight.Text) Then
            Try
                toshort = CInt(lineheight.Text)
            Catch ex As Exception
                error4.Visible = True
            End Try
            If toshort > 0 Then
                error4.Visible = False
                error5.Visible = False
                clearlineheight = lineheight.Text
                Input(5) = lineheight.Text
            Else
                error4.Visible = True
            End If
        Else
            error4.Visible = True
        End If
        Using txt As New IO.StreamWriter("..\..\..\..\input.txt", False, System.Text.Encoding.GetEncoding("Unicode"))
            For Each str As String In Input
                txt.WriteLine(str)
            Next
        End Using
        preview1.SizeMode = PictureBoxSizeMode.StretchImage
        preview1.Image = Drawing(data, 10, solutionmode = 0)
    End Sub
    Public Function Image(ByVal tfu As String)
        If tfu = "" Then
            Return New Bitmap(30, 30)
        Else
            Return Drawing(Fumen(tfu, FumenLength(tfu), False), 10, False)
        End If
    End Function
    Private Sub P1_TextChanged(sender As Object, e As EventArgs) Handles p1.TextChanged
        Dim input As New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\input.txt", System.Text.Encoding.GetEncoding("Unicode"))
            While txt.Peek > -1
                input.Add(txt.ReadLine())
            End While
        End Using
        input(2) = p1.Text
        Using txt As New IO.StreamWriter("..\..\..\..\input.txt", False, System.Text.Encoding.GetEncoding("Unicode"))
            For Each str As String In input
                txt.WriteLine(str)
            Next
        End Using
    End Sub
    Private Sub P2_TextChanged(sender As Object, e As EventArgs) Handles p2.TextChanged
        Dim input As New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\input.txt", System.Text.Encoding.GetEncoding("Unicode"))
            While txt.Peek > -1
                input.Add(txt.ReadLine())
            End While
        End Using
        input(3) = p2.Text
        Using txt As New IO.StreamWriter("..\..\..\..\input.txt", False, System.Text.Encoding.GetEncoding("Unicode"))
            For Each str As String In input
                txt.WriteLine(str)
            Next
        End Using
    End Sub
    Private Sub P1_KeyDown(sender As Object, e As KeyEventArgs) Handles p1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Setup.Focus()
        End If
    End Sub
    Private Sub P2_KeyDown(sender As Object, e As KeyEventArgs) Handles p2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cover.Focus()
        End If
    End Sub
    Private Sub Lineheight_KeyDown(sender As Object, e As KeyEventArgs) Handles lineheight.KeyDown
        If e.KeyCode = Keys.Enter Then
            p1.Focus()
        End If
    End Sub
    Public Sub SolutionDetailChanged()
        Dim input As New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\input.txt", System.Text.Encoding.GetEncoding("Unicode"))
            While txt.Peek > -1
                input.Add(txt.ReadLine())
            End While
        End Using
        input(4) = solutionmode
        input(5) = clearlineheight
        input(6) = pcmode
        input(8) = dropmode
        Using txt As New IO.StreamWriter("..\..\..\..\input.txt", False, System.Text.Encoding.GetEncoding("Unicode"))
            For Each str As String In input
                txt.WriteLine(str)
            Next
        End Using
        If solutionmode = 0 Then
            Label7.Visible = True
            lineheight.Visible = True
            Dim toshort As Short
            If IsNumeric(lineheight.Text) Then
                Try
                    toshort = CInt(lineheight.Text)
                Catch ex As Exception
                    error4.Visible = True
                End Try
                If toshort > 0 Then
                    error4.Visible = False
                    error5.Visible = False
                Else
                    error4.Visible = True
                End If
            Else
                error4.Visible = True
            End If
        Else
            Label7.Visible = False
            lineheight.Visible = False
            error4.Visible = False
        End If
        lineheight.Text = 0
        lineheight.Text = clearlineheight
    End Sub
    Private Sub Path_Load()
        Dim beforeRange = 0
        If loadToAdd Then
            beforeRange = Path.Items.Count
        Else
            Path.Items.Clear()
        End If
        Using txt As New IO.StreamReader("..\..\..\..\result.txt", System.Text.Encoding.GetEncoding("Unicode"))
            While txt.Peek > -1
                Path.Items.Add(txt.ReadLine())
            End While
        End Using
        For i = beforeRange To Path.Items.Count - 1
            Path.SetItemChecked(i, True)
        Next
    End Sub
    Private Sub Path_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Path.SelectedIndexChanged
        Dim selected = 0
        For i = 0 To Path.Items.Count - 1
            If Path.GetItemChecked(i) Then
                selected += 1
            End If
        Next
        clear2.Visible = If(selected = Path.Items.Count Or selected = 0, False, True)
        Dim tfu = Path.SelectedIndex
        If Not tfu = -1 Then
            Dim data() As Short = Fumen(Path.Items(tfu), FumenLength(Path.Items(tfu)), False)
            preview2.SizeMode = PictureBoxSizeMode.StretchImage
            preview2.Image = Drawing(data, 10, False)
            copy.Visible = True
        End If
    End Sub
    Private Sub Clear2_Click(sender As Object, e As EventArgs) Handles clear2.Click
        Dim list = New ArrayList
        For i = 0 To Path.Items.Count - 1
            If Path.GetItemChecked(i) Then
                list.Add(Path.Items(i))
            End If
        Next
        Path.Items.Clear()
        Dim c = 0
        For Each csv In list
            Path.Items.Add(csv)
            Path.SetItemChecked(c, True)
            c += 1
        Next
        Path.SetSelected(0, True)
    End Sub
    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles copy.Click
        Clipboard.SetText(Path.SelectedItem)
    End Sub
    Private Sub Detail1_Click(sender As Object, e As EventArgs) Handles detail1.Click
        Dim f As New Solution1
        f.ShowDialog(Me)
    End Sub
    Private Sub Detail2_Click(sender As Object, e As EventArgs) Handles detail2.Click
        Dim f As New Solution2
        f.ShowDialog(Me)
    End Sub
    Public Sub NotNormalMode()
        If pcmode = "normal" Then
            If dropmode = "softdrop" Or Not usemargin2 Then
                detail2.BackColor = SystemColors.ControlLight
            Else
                detail2.BackColor = SystemColors.ActiveBorder
            End If
        Else
            detail2.BackColor = SystemColors.ActiveBorder
        End If
    End Sub
    Private Sub Addfu(sender As Object, e As EventArgs) Handles Add.Click
        Dim f As New Addtetfu
        f.ShowDialog(Me)
    End Sub
    Private Sub AddLoad_Click(sender As Object, e As EventArgs) Handles addload.Click
        If loadToAdd Then
            loadToAdd = False
            addload.Text = ""
        Else
            loadToAdd = True
            addload.Text = "-"
            RPC.Visible = True
            usemargin = True
        End If
    End Sub
    Private Sub Load_Click(sender As Object, e As EventArgs) Handles loadtxt.Click
        Path_Load()
    End Sub
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        Path.Items.Clear()
    End Sub
    Private Sub Loadsuccess_Click(sender As Object, e As EventArgs) Handles loadsuccess.Click
        Dim readme = New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\..\readme.txt", System.Text.Encoding.UTF8)
            While txt.Peek > -1
                readme.Add(txt.ReadLine())
            End While
        End Using
        Dim output = New ArrayList
        Using txt As New IO.StreamReader(readme(0).ToString + "\output\last_output.txt", System.Text.Encoding.UTF8)
            While txt.Peek > -1
                output.Add(txt.ReadLine())
            End While
        End Using
        If output(output.Count - 2).IndexOf("%") = -1 Then
            error6.Visible = True
        Else
            error6.Visible = False
            success.Text = output(output.Count - 2).SubString(6, output(output.Count - 2).IndexOf("%") - 5)
        End If
    End Sub
    Private Sub Lastoutput_Click(sender As Object, e As EventArgs) Handles lastoutput.Click
        Dim readme As New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\..\readme.txt", System.Text.Encoding.UTF8)
            While txt.Peek > -1
                readme.Add(txt.ReadLine())
            End While
        End Using
        Dim output As New ArrayList
        Process.Start(readme(0) + "\output\last_output.txt")
    End Sub
    Private Sub RPC_MouseEnter(sender As Object, ByVal e As System.EventArgs) Handles RPC.MouseEnter
        RPC.FlatStyle = FlatStyle.Standard
        RPC.ForeColor = SystemColors.ControlText
        usemargin2 = True
    End Sub
    Private Sub RPC_Click(sender As Object, e As EventArgs) Handles RPC.Click
        Dim f As New 理論パフェ率計算
        f.Show()
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
            End If
            tetfu = tetfu.Insert(fnum, blank)
        End While
        FumenLength = p
    End Function
    Private Function Hight(ByVal tetfu() As Short)
        Dim h As Short
        For i = 0 To 22
            For c = 0 To 9
                If Not tetfu((22 - i) * 10 + c) = 0 Then
                    h = 22 - i + 1
                    Exit For
                End If
            Next
            If Not h = 0 Then
                Exit For
            End If
        Next
        Hight = h
    End Function
    Private Function Drawing(ByVal tetfu() As Short, ByVal hight As Short, ByVal line As Boolean)
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
        If line Then
            If hight - clearlineheight >= 0 And clearlineheight > 0 Then
                For w = 0 To quality * 10 - 1
                    fumen.SetPixel(w, (hight - clearlineheight) * quality, Color.FromArgb(255, 0, 0))
                Next
            End If
        End If
        Dim g As Graphics = Graphics.FromImage(fumen)
        g.InterpolationMode = Drawing2D.InterpolationMode.Default
        Drawing = fumen
    End Function

    Private Sub Setup_Click(sender As Object, e As EventArgs) Handles Setup.Click
        If error4.Visible Then
            error5.Visible = True
        Else
            If solutionmode = 0 Then
                Process.Start("..\..\..\..\path.bat")
            Else
                Dim input As New ArrayList
                Using txt As New IO.StreamReader("..\..\..\..\input.txt", System.Text.Encoding.GetEncoding("Unicode"))
                    While txt.Peek > -1
                        input.Add(txt.ReadLine())
                    End While
                End Using
                If input(7) = "True" Then
                    Process.Start("..\..\..\..\setupm.bat")
                Else
                    Process.Start("..\..\..\..\setup.bat")
                End If
            End If
        End If
    End Sub
    Private Sub Cover_Click(sender As Object, e As EventArgs) Handles Cover.Click
        If (Not usemargin2) And Not dropmode = "softdrop" Then
            dropmode = "softdrop"
            SolutionDetailChanged()
        End If
        Dim list As New ArrayList
        For Each i In Path.Items
            list.Add(i)
        Next
        Using txt As New IO.StreamWriter("..\..\..\..\select.txt", False, System.Text.Encoding.GetEncoding("Unicode"))
            For fu = 0 To list.Count - 1
                If Path.GetItemChecked(fu) Then
                    txt.WriteLine(list(fu))
                End If
            Next
        End Using
        Process.Start("..\..\..\..\cover.bat")
    End Sub

    Private Sub IKey(sender As Object, e As EventArgs) Handles Imino.Click
        p1.Text = "I*p7"
        p2.Text = "I*p7"
    End Sub
    Private Sub OKey(sender As Object, e As EventArgs) Handles Omino.Click
        p1.Text = "O*p7"
        p2.Text = "O*p7"
    End Sub
    Private Sub SKey(sender As Object, e As EventArgs) Handles Smino.Click
        p1.Text = "S*p7"
        p2.Text = "S*p7"
    End Sub
    Private Sub ZKey(sender As Object, e As EventArgs) Handles Zmino.Click
        p1.Text = "Z*p7"
        p2.Text = "Z*p7"
    End Sub
    Private Sub JKey(sender As Object, e As EventArgs) Handles Jmino.Click
        p1.Text = "J*p7"
        p2.Text = "J*p7"
    End Sub
    Private Sub LKey(sender As Object, e As EventArgs) Handles Lmino.Click
        p1.Text = "L*p7"
        p2.Text = "L*p7"
    End Sub
    Private Sub TKey(sender As Object, e As EventArgs) Handles Tmino.Click
        p1.Text = "T*p7"
        p2.Text = "T*p7"
    End Sub
    Private Sub NKey(sender As Object, e As EventArgs) Handles Nmino.Click
        p1.Text = "*p7"
        p2.Text = "*p7"
    End Sub
End Class
