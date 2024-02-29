Public Class 理論パフェ率計算
    Private Sub FirstLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Data.AllowUserToResizeColumns = False
        Data.AllowUserToResizeRows = False
        Data.Columns(0).Resizable = DataGridViewTriState.False
        Data.Rows(0).Resizable = DataGridViewTriState.False
        Data.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        setup.SortMode = DataGridViewColumnSortMode.NotSortable
        Data.Height = 300
        frontmostON.Visible = False
        result.DefaultCellStyle.ForeColor = Color.Red
        error1.Visible = False
        error2.Visible = False

        Dim files As String() = IO.Directory.GetFiles("..\..\..\..\pcdata", "*", IO.SearchOption.AllDirectories)
        For file = 0 To files.Count - 1
            files(file) = IO.Path.GetFileNameWithoutExtension(files(file))
        Next
        ListBox1.Items.AddRange(files)
    End Sub
    Private Sub Frontmostbar_Scroll(sender As Object, e As EventArgs) Handles frontmostbar.Scroll
        If frontmostbar.Value = 0 Then
            frontmostON.Visible = False
            TopMost = False
        Else
            frontmostON.Visible = True
            TopMost = True
        End If
    End Sub
    Private Sub Calc_Click(sender As Object, e As EventArgs) Handles calc.Click
        Data.Sort(setup, ComponentModel.ListSortDirection.Ascending)
        Dim sumsetupp = 0
        Dim sumpc = 0
        Dim sumdpc = 0
        Dim iserror = False
        For i = 0 To Data.RowCount - 2
            If Data(6, i) IsNot Nothing And Data(8, i).Value Then
                Dim setupp = Math.Round(Data(6, i).Value * 50.4)
                Dim pcp = Math.Round(Data(2, i).Value * 50.4)
                Dim dpcp = Math.Round(Data(4, i).Value * 50.4)
                Data(9, i).Value = Format(Math.Round(pcp * (setupp - sumsetupp) / 254016, 2), "0.0") + ", " + Format(Math.Round(dpcp * (setupp - sumsetupp) / 254016, 1), "0.0")
                Data(9, i).Style.ForeColor = SystemColors.ControlText
                If (Data(6, i).Value = Math.Round(setupp / 50.4, 2)) And (Data(2, i).Value = Math.Round(pcp / 50.4, 2)) And (Data(4, i).Value = Math.Round(dpcp / 50.4, 2)) Then
                    sumpc += pcp * (setupp - sumsetupp)
                    sumdpc += dpcp * (setupp - sumsetupp)
                    sumsetupp = setupp
                Else
                    CellError(9, i)
                    iserror = True
                End If
            End If
        Next
        If Not iserror Then
            Console.WriteLine(sumpc)
            Console.WriteLine(sumdpc)
            pcsolution.Text = "PC : " + Math.Round(sumpc / 254016, 3).ToString() + "%"
            dpcsolution.Text = "DPC : " + Math.Round(sumdpc / 254016, 3).ToString() + "%"
        End If
    End Sub
    Private Sub CellError(colmns As Short, rows As Short)
        Data(colmns, rows).Value = "エラー"
        Data(colmns, rows).Style.ForeColor = Color.Red
    End Sub
    Private Sub Deletefu_Click(sender As Object, e As EventArgs) Handles deletefu.Click
        For Each row As DataGridViewRow In Data.SelectedRows
            If Not row.Index = Data.Rows.Count - 1 Then
                Data.Rows.RemoveAt(row.Index)
            End If
        Next
    End Sub
    Private Sub PreciseSort(sender As Object, e As DataGridViewSortCompareEventArgs) Handles Data.SortCompare
        If e.Column.Index = 2 Then
            e.SortResult = CInt(e.CellValue1) - CInt(e.CellValue2)
            e.Handled = True
        End If
        If e.Column.Index = 4 Then
            e.SortResult = CInt(e.CellValue1) - CInt(e.CellValue2)
            e.Handled = True
        End If
        If e.Column.Index = 6 Then
            e.SortResult = CInt(e.CellValue1) - CInt(e.CellValue2)
            e.Handled = True
        End If
    End Sub
    Private Sub Data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim readme = New ArrayList
        Dim output = New ArrayList
        If dgv.Columns(e.ColumnIndex).Name = "PCbutton" Or dgv.Columns(e.ColumnIndex).Name = "DPCbutton" Or dgv.Columns(e.ColumnIndex).Name = "setupbutton" Then
            Using txt As New IO.StreamReader("..\..\..\..\..\readme.txt", System.Text.Encoding.UTF8)
                While txt.Peek > -1
                    readme.Add(txt.ReadLine())
                End While
            End Using
            Using txt As New IO.StreamReader(readme(0).ToString + "\output\last_output.txt", System.Text.Encoding.UTF8)
                While txt.Peek > -1
                    output.Add(txt.ReadLine())
                End While
            End Using
        End If
        error1.Visible = False
        error2.Visible = False
        If Not e.RowIndex = -1 Then
            If Data(9, e.RowIndex).Value = "エラー" Then
                Data(9, e.RowIndex).Value = ""
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "tetfubutton" Then
            Dim canvas As New Bitmap(30, 30)
            Dim g As Graphics = Graphics.FromImage(canvas)
            If Sfgui.Path.SelectedIndex = -1 Then
                g.DrawImage(Sfgui.Image(""), 0, 0, 30, 30)
                Data(10, e.RowIndex).Value = ""
            Else
                If e.RowIndex = Data.Rows.Count - 1 Then
                    Data.Rows.Add()
                End If
                g.DrawImage(Sfgui.Image(Sfgui.Path.Items(Sfgui.Path.SelectedIndex)), 0, 0, 30, 30)
                Data(10, e.RowIndex).Value = Sfgui.Path.Items(Sfgui.Path.SelectedIndex)
            End If
            Data(0, e.RowIndex).Value = canvas
        End If
        If dgv.Columns(e.ColumnIndex).Name = "PCbutton" Then
            If output(output.Count - 2).IndexOf("%") = -1 Then
                CellError(9, e.RowIndex)
            Else
                If e.RowIndex = Data.Rows.Count - 1 Then
                    Data.Rows.Add()
                End If
                Data(2, e.RowIndex).Value = output(output.Count - 2).SubString(6, output(output.Count - 2).IndexOf("%") - 6).Trim()
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "DPCbutton" Then
            If output(output.Count - 2).IndexOf("%") = -1 Then
                CellError(9, e.RowIndex)
            Else
                If e.RowIndex = Data.Rows.Count - 1 Then
                    Data.Rows.Add()
                End If
                Data(4, e.RowIndex).Value = output(output.Count - 2).SubString(6, output(output.Count - 2).IndexOf("%") - 6).Trim()
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "setupbutton" Then
            If output(output.Count - 2).IndexOf("%") = -1 Then
                CellError(9, e.RowIndex)
            Else
                If e.RowIndex = Data.Rows.Count - 1 Then
                    Data.Rows.Add()
                End If
                Data(6, e.RowIndex).Value = output(output.Count - 2).SubString(6, output(output.Count - 2).IndexOf("%") - 6).Trim()
            End If
        End If
    End Sub
    Private Sub Data_SelectionChanged(sender As Object, e As EventArgs) Handles Data.SelectionChanged
        error1.Visible = False
        error2.Visible = False
        For Each row As DataGridViewRow In Data.SelectedRows
            If Not row.Index = -1 Then
                If Data(9, row.Index).Value = "エラー" Then
                    Data(9, row.Index).Value = ""
                End If
            End If
        Next
        Data.EditMode = DataGridViewEditMode.EditOnEnter
    End Sub
    Private Sub Data_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Data.CellValueChanged
        error1.Visible = False
        error2.Visible = False
        If Not (e.ColumnIndex = 9 Or e.RowIndex = -1) Then
            If Data(9, e.RowIndex).Value = "エラー" Then
                Data(9, e.RowIndex).Value = ""
            End If
        End If
    End Sub
    Private Sub OnSort(sender As Object, e As EventArgs) Handles Data.Sorted
        If Data.SortOrder = SortOrder.Ascending And Not Data.SortedColumn.Index = 6 Then
            Data.Sort(Data.SortedColumn, ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As New ArrayList
        If ListBox1.SelectedIndex = -1 Then
            error1.Visible = True
        Else
            error1.Visible = False
            Data.Rows.Clear()
            Using txt As New IO.StreamReader("..\..\..\..\pcdata\" + ListBox1.SelectedItem.ToString() + ".txt", System.Text.Encoding.GetEncoding("Unicode"))
                While txt.Peek > -1
                    input.Add(txt.ReadLine())
                End While
            End Using
            For i As Short = 0 To (input.Count / 5) - 2
                Data.Rows.Add()
                Data(10, i).Value = input(i * 5)
                Data(2, i).Value = input(i * 5 + 1)
                Data(4, i).Value = input(i * 5 + 2)
                Data(6, i).Value = input(i * 5 + 3)
                Data(8, i).Value = input(i * 5 + 4) = "True"
                Dim canvas As New Bitmap(30, 30)
                Dim g As Graphics = Graphics.FromImage(canvas)
                g.DrawImage(Sfgui.Image(input(i * 5)), 0, 0, 30, 30)
                Data(0, i).Value = canvas
                If Sfgui.Path.Items.IndexOf(input(i * 5)) = -1 Then
                    Sfgui.Path.Items.Add(input(i * 5))
                End If
            Next
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex = -1 Then
            error2.Visible = True
        Else
            error2.Visible = False
            Dim output As New ArrayList
            For Each row In Data.Rows
                output.Add(Data(10, row.Index).Value)
                output.Add(Data(2, row.Index).Value)
                output.Add(Data(4, row.Index).Value)
                output.Add(Data(6, row.Index).Value)
                output.Add(Data(8, row.Index).Value)
            Next
            Using txt As New IO.StreamWriter("..\..\..\..\pcdata\" + ListBox1.SelectedItem.ToString() + ".txt", False, System.Text.Encoding.GetEncoding("Unicode"))
                For Each str As String In output
                    txt.WriteLine(str)
                Next
            End Using
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim output As New ArrayList
        For Each row In Data.Rows
            output.Add(Data(10, row.Index).Value)
            output.Add(Data(2, row.Index).Value)
            output.Add(Data(4, row.Index).Value)
            output.Add(Data(6, row.Index).Value)
            output.Add(Data(8, row.Index).Value)
        Next
        Using txt As New IO.StreamWriter("..\..\..\..\pcdata\" + txtname.Text + ".txt", False, System.Text.Encoding.GetEncoding("Unicode"))
            For Each str As String In output
                txt.WriteLine(str)
            Next
        End Using
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("..\..\..\..\pcdata")
    End Sub
End Class