
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO
Public Class frm_Transaction
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader


    Private Sub frm_Transaction_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        showrecords("")
    End Sub

    Sub showrecords(ByVal strSearch As String)
      
        With cmd
            .Connection = con
            .CommandText = "SELECT CONCAT(O.`Last Name`,',',' ',O.`First Name`,' ',O.`Middle Initial`) As Name, O.`Gender`, O.`Owners Address`, O.`Mayors Permit`, O.`Permit Date`, O.`Expired Date`, O.`Cellphone Number`, O.`Business Name`, O.`Business Address`,O.`Business Organization Type`, O.`BusinessType`, O.`Status`,T.`Date`, T.`Time`, T.`Total Amount`, T.`Amount Entry`, T.`Name of Treasurer`  FROM `tbl_ownersinformation` as O, `tbl_transaction` as T WHERE O.`Mayors Permit` = T.`Mayors Permit` AND O.`Mayors Permit` LIKE '%" & strSearch & "%' AND `Amount Entry` > 0"
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        dgtransaction.DataSource = dt
    End Sub
    Sub showphoto()

        Try
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = cmd

            Dim Data = New DataTable

            adapter = New MySqlDataAdapter("SELECT `Picture` FROM `tbl_ownersinformation` Where `Mayors Permit` = '" & frm_printreport.txtmayorspermit.Text & "' ORDER BY `Owners Id`", con)

            Dim commandbuild = New MySqlCommandBuilder(adapter)
            adapter.Fill(Data)

            Dim lb() As Byte = Data.Rows(0).Item("Picture")
            Dim lstr As New System.IO.MemoryStream(lb)
            frm_printreport.picboxclient.Image = Image.FromStream(lstr)
            frm_printreport.picboxclient.SizeMode = PictureBoxSizeMode.StretchImage
            lstr.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnhome_Click(sender As System.Object, e As System.EventArgs) Handles btnhome.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

    Private Sub pnlheader_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlheader.Paint

    End Sub

    Private Sub dgtransaction_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgtransaction.CellClick
        frm_printreport.txtlastname.Text = dgtransaction.Item(0, e.RowIndex).Value
        frm_printreport.cmbgender.Text = dgtransaction.Item(1, e.RowIndex).Value
        frm_printreport.txtownersaddress.Text = dgtransaction.Item(2, e.RowIndex).Value
        frm_printreport.txtmayorspermit.Text = dgtransaction.Item(3, e.RowIndex).Value
        frm_printreport.DTPpermitdate.Text = dgtransaction.Item(4, e.RowIndex).Value
        frm_printreport.DTPExpireddate.Text = dgtransaction.Item(5, e.RowIndex).Value
        frm_printreport.txtcellphonenumber.Text = dgtransaction.Item(6, e.RowIndex).Value
        frm_printreport.txtbusinessname.Text = dgtransaction.Item(7, e.RowIndex).Value
        frm_printreport.txtbusinessaddress.Text = dgtransaction.Item(8, e.RowIndex).Value
        frm_printreport.cmborganization.Text = dgtransaction.Item(9, e.RowIndex).Value
        frm_printreport.cmbbusinesstype.Text = dgtransaction.Item(10, e.RowIndex).Value
        'frm_printreport.lblamount.Text = TABLE(0)("Amount")
        'frm_printreport.txtstatus.Text = TABLE(0)("Status")
        frm_printreport.txtamountentry.Text = dgtransaction.Item(14, e.RowIndex).Value
        frm_printreport.txttresurer.Text = dgtransaction.Item(16, e.RowIndex).Value
        ' Try

        'con.Close()
        'con.Open()

        'Dim SqlQuery As String = "SELECT CONCAT(O.`Last Name`,',',' ',O.`First Name`,' ',O.`Middle Initial`) As Name, O.`Gender`, O.`Owners Address`, O.`Mayors Permit`, O.`Permit Date`, O.`Expired Date`, O.`Cellphone Number`, O.`Business Name`, O.`Business Address`, O.`BusinessType`, T.`Amount Entry`, T.`Name of Treasurer` FROM `tbl_ownersinformation` WHERE `Owners Id` = " & dgtransaction.SelectedCells(0).Value & " "
        'Dim SqlCommand As New MySqlCommand
        'Dim SqlAdapter As New MySqlDataAdapter
        'Dim TABLE As New DataTable


        'With SqlCommand
        '    .CommandText = SqlQuery
        '    .Connection = con

        'End With

        'With SqlAdapter
        '    .SelectCommand = SqlCommand
        '    .Fill(TABLE)
        'End With
        '' frm_printreport.txtownersID.Text = TABLE.Rows(0)("Owners Id")
        'frm_printreport.txtlastname.Text = TABLE.Rows(0)("Name")
        ''frm_printreport.txtfirstname.Text = TABLE.Rows(0)("First Name")
        ''frm_printreport.txtMI.Text = TABLE.Rows(0)("Middle Initial")
        'frm_printreport.cmbgender.Text = TABLE.Rows(0)("Gender")
        'frm_printreport.txtownersaddress.Text = TABLE(0)("Owners Address")
        'frm_printreport.txtmayorspermit.Text = TABLE(0)("Mayors Permit")
        'frm_printreport.DTPpermitdate.Text = TABLE(0)("Permit Date")
        'frm_printreport.DTPExpireddate.Text = TABLE(0)("Expired Date")
        'frm_printreport.txtcellphonenumber.Text = TABLE(0)("Cellphone Number")
        'frm_printreport.txtbusinessname.Text = TABLE(0)("Business Name")
        'frm_printreport.txtbusinessaddress.Text = TABLE(0)("Business Address")
        'frm_printreport.cmborganization.Text = TABLE(0)("Business Organization Type")
        'frm_printreport.cmbbusinesstype.Text = TABLE(0)("BusinessType")
        ''frm_printreport.lblamount.Text = TABLE(0)("Amount")
        'frm_printreport.txtstatus.Text = TABLE(0)("Status")
        'frm_printreport.txtamountentry.Text = TABLE(0)("Amount Entry")
        'frm_printreport.txttresurer.Text = TABLE(0)("Name of Treasurer")
        ''Catch ex As Exception
        ''    MsgBox(ex.Message.ToString)
        ''End Try
    End Sub

    Private Sub dgtransaction_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgtransaction.CellContentClick

    End Sub

    Private Sub btnview_Click(sender As System.Object, e As System.EventArgs) Handles btnview.Click
        frm_printreport.Show()
        showphoto()
        Me.Hide()
    End Sub

    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        frm_treasurer.Show()
        Me.Hide()
    End Sub

    Private Sub btnrefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnrefresh.Click
        showrecords("")
    End Sub

    Private Sub txtsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.TextChanged
        showrecords(txtsearch.Text)
    End Sub

    Private Sub dgtransaction_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgtransaction.CellDoubleClick
        frm_printreport.Show()
    End Sub
End Class