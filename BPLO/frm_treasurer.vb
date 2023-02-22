Public Class frm_treasurer

   

    Private Sub frm_treasurer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today
        Timer1.Enabled = True
    End Sub

    Private Sub btnnew_Click(sender As System.Object, e As System.EventArgs)
        frm_listodnewbusinessintreasurer.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblTimer.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub btnrenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_expireddetails.Show()
        Me.Hide()

    End Sub

    Private Sub btnviewallrecords_Click(sender As System.Object, e As System.EventArgs) Handles btnviewallrecords.Click
        frm_Record.btnview.Enabled = False

        frm_Record.btnaddrecords.Enabled = False
        frm_Record.btnhome.Enabled = False
        frm_Record.btnneedsrenewal.Enabled = False
        frm_Record.btnrefresh.Show()
        frm_Record.btnback.Show()
        frm_Record.Show()
        frm_Record.showrecords("")
        Me.Hide()


    End Sub

    Private Sub btnviewnewbusiness_Click(sender As System.Object, e As System.EventArgs) Handles btnviewnewbusiness.Click
        frm_listodnewbusinessintreasurer.Show()
        frm_listodnewbusinessintreasurer.showrecords("")
        Me.Hide()
    End Sub

    Private Sub btnhome_Click(sender As System.Object, e As System.EventArgs) Handles btnhome.Click
        Me.Show()

    End Sub

    Private Sub btnviewrenewbusiness_Click(sender As System.Object, e As System.EventArgs) Handles btnviewrenewbusiness.Click
        frm_RenewedRecords.Show()
        frm_RenewedRecords.showrecords("")
        Me.Hide()
    End Sub

    Private Sub pnlheader_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlheader.Paint

    End Sub

  

    Private Sub btnlogout_Click(sender As System.Object, e As System.EventArgs) Handles btnlogout.Click
        If MsgBox("Do you want to logout ?", MsgBoxStyle.YesNo) = vbYes Then
            frm_Login.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btntransaction_Click_1(sender As System.Object, e As System.EventArgs) Handles btntransaction.Click
        frm_Transaction.Show()
        frm_Transaction.showrecords("")
        frm_Transaction.btnback.Show()
        frm_Transaction.btnhome.Enabled = False
        Me.Hide()
    End Sub
End Class