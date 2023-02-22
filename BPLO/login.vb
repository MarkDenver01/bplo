Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loging.Hide()

    End Sub

    Private Sub loginbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbutton.Click
        loging.Show()

    End Sub

    Private Sub exitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbutton.Click
        Me.Close()

    End Sub

    Private Sub cancelb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelb.Click
        loging.Hide()

    End Sub
End Class