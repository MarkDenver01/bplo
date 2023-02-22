Public Class frm_printcertificate

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.pnlcert.Width, Me.pnlcert.Height)

        pnlcert.DrawToBitmap(bm, New Rectangle(0, 0, Me.pnlcert.Width, Me.pnlcert.Height))

        e.Graphics.DrawImage(bm, 0, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
        Me.Close()
    End Sub

    Private Sub frm_printcertificate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnprint_Click(sender As System.Object, e As System.EventArgs) Handles btnprint.Click
        Dim y As Integer

        'Me.Close()
        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            pnlcert.Height += y
            PrintDocument1.Print()
            Me.Close()
            frm_treasurer.Show()
        End If

    End Sub

    'Private Sub PrintDocument2_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
    '    Dim bm As New Bitmap(Me.Panel5.Width, Me.Panel5.Height)

    '    Panel5.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel5.Width, Me.Panel5.Height))

    '    e.Graphics.DrawImage(bm, 0, 40)
    '    Dim aPS As New PageSetupDialog
    '    aPS.Document = PrintDocument2
    '    Me.Close()
    'End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        frm_treasurer.Show()
        Me.Hide()
    End Sub
End Class