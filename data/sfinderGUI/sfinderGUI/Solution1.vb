Public Class Solution1
    Private Sub FirstLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        mode.Value = Sfgui.solutionmode
        If mode.Value = 0 Then
            unique.Visible = True
            minimal.Visible = True
            open.Visible = True
            marginO.Visible = False
        Else
            unique.Visible = False
            minimal.Visible = False
            open.Visible = False
            If Sfgui.usemargin Then
                marginO.Visible = True
            End If
        End If
            Dim input As New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\input.txt", System.Text.Encoding.GetEncoding("Unicode"))
            While txt.Peek > -1
                input.Add(txt.ReadLine())
            End While
        End Using
        marginO.Checked = input(7) = "True"
    End Sub
    Private Sub Mode_Scroll(sender As Object, e As EventArgs) Handles mode.Scroll
        Sfgui.solutionmode = mode.Value
        Sfgui.SolutionDetailChanged()
        If mode.Value = 0 Then
            unique.Visible = True
            minimal.Visible = True
            open.Visible = True
            marginO.Visible = False
        Else
            unique.Visible = False
            minimal.Visible = False
            open.Visible = False
            If Sfgui.usemargin Then
                marginO.Visible = True
            End If
        End If
    End Sub
    Private Sub Minimal_Click(sender As Object, e As EventArgs) Handles minimal.Click
        Dim readme As New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\..\readme.txt", System.Text.Encoding.UTF8)
            While txt.Peek > -1
                readme.Add(txt.ReadLine())
            End While
        End Using
        Dim output As New ArrayList
        Process.Start(readme(0) + "\output\path_minimal.html")
    End Sub
    Private Sub Unique_Click(sender As Object, e As EventArgs) Handles unique.Click
        Dim readme As New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\..\readme.txt", System.Text.Encoding.UTF8)
            While txt.Peek > -1
                readme.Add(txt.ReadLine())
            End While
        End Using
        Dim output As New ArrayList
        Process.Start(readme(0) + "\output\path_unique.html")
    End Sub
    Private Sub Margin_CheckedChanged(sender As Object, e As EventArgs) Handles marginO.CheckedChanged
        Dim input As New ArrayList
        Using txt As New IO.StreamReader("..\..\..\..\input.txt", System.Text.Encoding.GetEncoding("Unicode"))
            While txt.Peek > -1
                input.Add(txt.ReadLine())
            End While
        End Using
        input(7) = marginO.Checked
        Using txt As New IO.StreamWriter("..\..\..\..\input.txt", False, System.Text.Encoding.GetEncoding("Unicode"))
            For Each str As String In input
                txt.WriteLine(str)
            Next
        End Using
    End Sub
End Class