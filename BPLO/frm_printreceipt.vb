Public Class frm_printreceipt

    Private Sub frm_printreceipt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
        Me.Close()
    End Sub

  
    Private Sub btnprint_Click(sender As System.Object, e As System.EventArgs) Handles btnprint.Click
        Dim y As Integer

        'Me.Close()
        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel1.Height += y
            PrintDocument1.Print()
            frm_treasurer.Show()
            Me.Close()
        End If

    End Sub
End Class