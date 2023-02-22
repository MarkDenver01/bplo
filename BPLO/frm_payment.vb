

Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class frm_payment


    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader
    Private Sub frm_payment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub ClrTXT()

        txtmayorspermit.Text = ""
        DTPpermitdate.Text = ""
        txtcellphonenumber.Text = ""
        txtbusinessname.Text = ""
        txtbusinessaddress.Text = ""
        txtownersaddress.Text = ""
        txtlastname.Text = ""
        txtfirstname.Text = ""
        txtMI.Text = ""
        cmbgender.Text = ""
        cmbbusinesstype.Text = ""
        cmborganization.Text = ""
        lblamount.Text = ""

    End Sub

    Sub Disabledtxt()
        txtmayorspermit.Enabled = False
        DTPpermitdate.Enabled = False
        DTPExpireddate.Enabled = False
        txtcellphonenumber.Enabled = False
        txtbusinessname.Enabled = False
        txtbusinessaddress.Enabled = False
        txtownersaddress.Enabled = False
        txtlastname.Enabled = False
        txtfirstname.Enabled = False
        txtMI.Enabled = False
        cmbgender.Enabled = False
        cmbbusinesstype.Enabled = False
        cmborganization.Enabled = False
    End Sub

    Sub Enabledtxt()
        'txtmayorspermit.Enabled = True
        DTPpermitdate.Enabled = True
        DTPExpireddate.Enabled = True
        txtcellphonenumber.Enabled = True
        txtbusinessname.Enabled = True
        txtbusinessaddress.Enabled = True
        txtownersaddress.Enabled = True
        txtlastname.Enabled = True
        txtfirstname.Enabled = True
        txtMI.Enabled = True
        cmbgender.Enabled = True
        cmbbusinesstype.Enabled = True
        cmborganization.Enabled = True
    End Sub

    




    Sub paymententer()
        Try

            con.Close()
            con.Open()

          

            sql = "UPDATE `tbl_transaction` SET `Date`= '" & Date.Today & "', `Time` = '" & Date.Now.ToString("hh:mm:ss") & "',`Total Amount` = '" & txttotalamount.Text & "',`Amount Entry`= '" & txtentryamount.Text & "',`Name of Treasurer`= '" & frm_treasurer.txttreasurername.Text & "' WHERE `Mayors Permit` = '" & txtmayorspermit.Text & "'"
                cmd = New MySqlCommand(Sql, con)

            cmd.ExecuteNonQuery()
            printdetails()
            frm_Record.showrecords("")
            frm_expireddetails.viewdelayed("")
            frm_listodnewbusinessintreasurer.showrecords("")
            frm_RenewedRecords.showrecords("")
            frm_Transaction.showrecords("")
            MsgBox("Transaction Success!", MsgBoxStyle.Information)
            'frm_listodnewbusinessintreasurer.Show()
            ClrTXT()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        con.Close()
    End Sub

   
    Private Sub txtmayorspermit_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtmayorspermit.TextChanged

    End Sub


    Sub printdetails()
        Try
            con.Close()
            con.Open()

            Dim SqlQuery As String = "SELECT `Mayors Permit`,`Business Name`,CONCAT(`Last Name`,',',' ',`First Name`,' ',`Middle Initial`) as Name,`Business Organization Type`,`BusinessType`,`Business Address`,`Permit Date`,`Expired Date`,`Amount` FROM `tbl_ownersinformation` WHERE `Mayors Permit` = '" & txtmayorspermit.Text & "' "
            Dim SqlQueryfortransaction As String = "SELECT `TransactionNumber`, `Amount Entry`,`Name of Treasurer` FROM `tbl_transaction` WHERE `Mayors Permit` = '" & txtmayorspermit.Text & "' "


            Dim SqlCommand As New MySqlCommand
            Dim SqlAdapter As New MySqlDataAdapter
            Dim TABLE As New DataTable


            Dim SqlCommandtr As New MySqlCommand
            Dim SqlAdaptertr As New MySqlDataAdapter
            Dim TABLEtr As New DataTable

            With SqlCommand
                .CommandText = SqlQuery
                .Connection = con

            End With

            With SqlAdapter
                .SelectCommand = SqlCommand
                .Fill(TABLE)
            End With

            With SqlCommandtr
                .CommandText = SqlQueryfortransaction
                .Connection = con

            End With

            With SqlAdaptertr
                .SelectCommand = SqlCommandtr
                .Fill(TABLEtr)
            End With
            frm_printcertificate.txtyear.Text = DTPExpireddate.Value.Year
            frm_printcertificate.txtplatenymber.Text = TABLE.Rows(0)("Mayors Permit")
            frm_printcertificate.txtownersname.Text = TABLE.Rows(0)("Name")
            frm_printcertificate.txtbusinessname.Text = TABLE.Rows(0)("Business Name")
            frm_printcertificate.txtbusinessorgtype.Text = TABLE.Rows(0)("Business Organization Type")
            frm_printcertificate.txtregistrationtype.Text = TABLE.Rows(0)("BusinessType")
            frm_printcertificate.txtbarangay.Text = TABLE.Rows(0)("Business Address")
            frm_printcertificate.txtissue.Text = TABLE.Rows(0)("Permit Date")
            frm_printcertificate.txtexpiry.Text = TABLE.Rows(0)("Expired Date")
            
            frm_printreceipt.txttotalamount.Text = TABLE.Rows(0)("Amount")
            frm_printreceipt.txttransactionnumber.Text = TABLEtr.Rows(0)("TransactionNumber")
            frm_printreceipt.txtcahsier.Text = TABLEtr.Rows(0)("Name of Treasurer")
            frm_printreceipt.txtname.Text = TABLE.Rows(0)("Name")
            frm_printreceipt.txttotalamount.Text = TABLE.Rows(0)("Amount")
            frm_printreceipt.txtcash.AppendText(txtentryamount.Text)
            frm_printreceipt.txtchange.AppendText(txtchange.Text)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnsave_Click_1(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
       
        If Val(txttotalamount.Text.Replace(",", "") > Val(txtentryamount.Text.Replace(",", ""))) Then
            MsgBox("Insuficient cash to paid the total amount", MsgBoxStyle.Exclamation, "payment")
            txtentryamount.Focus()
        ElseIf Val(txttotalamount.Text.Replace(",", "") <= Val(txtentryamount.Text.Replace(",", ""))) Then
            txtchange.Text = Val(txtentryamount.Text.Replace(",", "")) - Val(txttotalamount.Text.Replace(",", ""))
            paymententer()
            frm_printcertificate.Show()
            'frm_printreceipt.Show()
            Me.Hide()
            '    Dim y As Integer

            '    frm_printcertificate.PrintDialog1.Document = frm_printcertificate.PrintDocument1

            '    Dim ButtonPressed As DialogResult = frm_printcertificate.PrintDialog1.ShowDialog()
            '    If (ButtonPressed = DialogResult.OK) Then
            '        frm_printcertificate.PrintDocument1.Print()
            '        Me.Close()
            '    End If
            '    frm_printreceipt.PrintDialog1.Document = frm_printreceipt.PrintDocument1

            '    Dim ButtonPressed1 As DialogResult = frm_printreceipt.PrintDialog1.ShowDialog()
            '    If (ButtonPressed1 = DialogResult.OK) Then
            '        frm_printreceipt.Panel1.Height += y
            '        frm_printreceipt.PrintDocument1.Print()
            '        Me.Close()
            '    End If
        End If
    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        frm_treasurer.Show()
        Me.Hide()
    End Sub



   
 
End Class