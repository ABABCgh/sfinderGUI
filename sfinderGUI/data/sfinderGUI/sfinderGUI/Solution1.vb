Public Class Solution1
    Private Sub FirstLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        mode.Value = Sfgui.solutionmode
        If mode.Value = 0 Then
            unique.Visible = True
            minimal.Visible = True
            open.Visible = True
        Else
            unique.Visible = False
            minimal.Visible = False
            open.Visible = False
        End If
    End Sub
    Private Sub Mode_Scroll(sender As Object, e As EventArgs) Handles mode.Scroll
        Sfgui.solutionmode = mode.Value
        Sfgui.SolutionDetailChanged()
        If mode.Value = 0 Then
            unique.Visible = True
            minimal.Visible = True
            open.Visible = True
        Else
            unique.Visible = False
            minimal.Visible = False
            open.Visible = False
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
End Class