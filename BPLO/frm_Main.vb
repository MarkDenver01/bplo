Public Class frm_Main


    Private Sub main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lblDate.Text = Date.Today
        Timer1.Enabled = True

    End Sub

  
 

    

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblTimer.Text = Date.Now.ToString("hh:mm:ss")
    End Sub


   

  
    Private Sub btnrecords_Click(sender As System.Object, e As System.EventArgs) Handles btnrecords.Click
        frm_Record.Show()
        Me.Hide()
    End Sub

    Private Sub btnnewrecord_Click(sender As System.Object, e As System.EventArgs) Handles btnnewrecord.Click
        New_BPLO.Show()
        Me.Hide()
    End Sub

    Private Sub btnrenew_Click(sender As System.Object, e As System.EventArgs) Handles btnrenew.Click
        frm_RenewBPLO.Show()
        Me.Hide()
    End Sub

    Private Sub btntransaction_Click(sender As System.Object, e As System.EventArgs) Handles btntransaction.Click
        frm_Transaction.Show()
        Me.Hide()
    End Sub

    Private Sub btncreateaccount_Click(sender As System.Object, e As System.EventArgs) Handles btncreateaccount.Click
        frm_UsersRecords.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click_1(sender As System.Object, e As System.EventArgs) Handles btnlogout.Click
        If MsgBox("Do you want to logout ?", MsgBoxStyle.YesNo) = vbYes Then
            frm_Login.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
