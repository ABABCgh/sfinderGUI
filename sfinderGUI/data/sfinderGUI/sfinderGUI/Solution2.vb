Public Class Solution2
    Private Sub FirstLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        pcmode.SelectedIndex = pcmode.Items.IndexOf(Sfgui.pcmode)
    End Sub
    Private Sub PCmode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pcmode.SelectedIndexChanged
        Sfgui.pcmode = pcmode.SelectedItem
        Sfgui.NotNormalMode()
        Sfgui.SolutionDetailChanged()
    End Sub
End Class