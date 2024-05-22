Public Class Solution2
    Private Sub FirstLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        pcmode.SelectedIndex = pcmode.Items.IndexOf(Sfgui.pcmode)
        If Sfgui.dropmode = "softdrop" Then
            dropmode.SelectedIndex = 0
        Else
            dropmode.SelectedIndex = dropmode.Items.IndexOf(Sfgui.dropmode)
        End If
        dropmode.Visible = Sfgui.usemargin2
        Label2.Visible = Sfgui.usemargin2
    End Sub
    Private Sub PCmode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pcmode.SelectedIndexChanged
        Sfgui.pcmode = pcmode.SelectedItem
        Sfgui.NotNormalMode()
        Sfgui.SolutionDetailChanged()
    End Sub
    Private Sub Dropmode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropmode.SelectedIndexChanged
        If dropmode.SelectedItem = "normal" Then
            Sfgui.dropmode = "softdrop"
        Else
            Sfgui.dropmode = dropmode.SelectedItem
        End If
        Sfgui.NotNormalMode()
        Sfgui.SolutionDetailChanged()
    End Sub
End Class