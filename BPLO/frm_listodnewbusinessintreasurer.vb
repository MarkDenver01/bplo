
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class frm_listodnewbusinessintreasurer
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader


    Private Sub frm_listodnewbusinessintreasurer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        showrecords("")
    End Sub

    Sub showrecords(ByVal strSearch As String)
        With cmd
            .Connection = con
            .CommandText = "SELECT O.`Owners Id`, O.`Last Name`, O.`First Name`, O.`Middle Initial`, O.`Gender`, O.`Owners Address`, O.`Mayors Permit`, O.`Permit Date`, O.`Expired Date`, O.`Cellphone Number`, O.`Business Name`, O.`Business Address`, O.`Business Organization Type`, O.`BusinessType`, O.`Amount`, O.`Status`, T.`Amount Entry`  FROM `tbl_ownersinformation` as O , tbl_transaction as T WHERE O.`Mayors Permit` = T.`Mayors Permit` AND O.`Mayors Permit`LIKE '%" & strSearch & "%' AND O.`Status` = 'New' AND `Amount Entry` <= 0"
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        dgNewBusinesses.DataSource = dt
    End Sub

    Sub showphoto()
        Try

            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = cmd

            Dim Data = New DataTable

            adapter = New MySqlDataAdapter("SELECT `Picture` FROM `tbl_ownersinformation` Where `Mayors Permit` = '" & frm_payment.txtmayorspermit.Text & "' ORDER BY `Owners Id`", con)

            Dim commandbuild = New MySqlCommandBuilder(adapter)
            adapter.Fill(Data)

            Dim lb() As Byte = Data.Rows(0).Item("Picture")
            Dim lstr As New System.IO.MemoryStream(lb)
            frm_payment.picboxclient.Image = Image.FromStream(lstr)
            frm_payment.picboxclient.SizeMode = PictureBoxSizeMode.StretchImage
            lstr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgNewBusinesses_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgNewBusinesses.CellClick
        Try

            con.Close()
            con.Open()

            Dim SqlQuery As String = "SELECT * FROM `tbl_ownersinformation` WHERE `Owners Id` = " & dgNewBusinesses.SelectedCells(0).Value & " "
            Dim SqlCommand As New MySqlCommand
            Dim SqlAdapter As New MySqlDataAdapter
            Dim TABLE As New DataTable


            With SqlCommand
                .CommandText = SqlQuery
                .Connection = con

            End With

            With SqlAdapter
                .SelectCommand = SqlCommand
                .Fill(TABLE)
            End With
            frm_payment.txtownersID.Text = TABLE.Rows(0)("Owners Id")
            frm_payment.txtlastname.Text = TABLE.Rows(0)("Last Name")
            frm_payment.txtfirstname.Text = TABLE.Rows(0)("First Name")
            frm_payment.txtMI.Text = TABLE.Rows(0)("Middle Initial")
            frm_payment.cmbgender.Text = TABLE.Rows(0)("Gender")
            frm_payment.txtownersaddress.Text = TABLE(0)("Owners Address")
            frm_payment.txtmayorspermit.Text = TABLE(0)("Mayors Permit")
            frm_payment.DTPpermitdate.Text = TABLE(0)("Permit Date")
            frm_payment.DTPExpireddate.Text = TABLE(0)("Expired Date")
            frm_payment.txtcellphonenumber.Text = TABLE(0)("Cellphone Number")
            frm_payment.txtbusinessname.Text = TABLE(0)("Business Name")
            frm_payment.txtbusinessaddress.Text = TABLE(0)("Business Address")
            frm_payment.cmborganization.Text = TABLE(0)("Business Organization Type")
            frm_payment.cmbbusinesstype.Text = TABLE(0)("BusinessType")
            frm_payment.lblamount.Text = TABLE(0)("Amount")
            frm_payment.txttotalamount.Text = TABLE(0)("Amount")
            frm_payment.txtstatus.Text = TABLE(0)("Status")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    
    Private Sub dgNewBusinesses_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgNewBusinesses.CellContentClick

    End Sub

    'Private Sub btnpayment_Click(sender As System.Object, e As System.EventArgs) Handles btnpayment.Click
    '    showphoto()
    '    frm_payment.Show()
    '    Me.Hide()
    'End Sub



    Private Sub btnhome_Click(sender As System.Object, e As System.EventArgs) Handles btnhome.Click
        frm_treasurer.Show()
        Me.Hide()
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        showrecords(txtsearch.Text)
    End Sub

    Private Sub txtsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.TextChanged
        showrecords(txtsearch.Text)
    End Sub

    Private Sub btntransaction_Click(sender As System.Object, e As System.EventArgs) Handles btntransaction.Click

        frm_payment.Show()
        showphoto()
        Me.Hide()

    End Sub

    Private Sub pnlheader_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlheader.Paint

    End Sub

    Private Sub btnrefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnrefresh.Click
        showrecords("")
    End Sub

    Private Sub dgNewBusinesses_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgNewBusinesses.CellDoubleClick
        frm_payment.Show()

    End Sub
End Class