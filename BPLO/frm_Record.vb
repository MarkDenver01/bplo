Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class frm_Record
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader

    Private Sub Record_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        showrecords("")
        frm_expireddetails.viewdelayed("")
    End Sub

    Sub showrecords(ByVal strSearch As String)

        With cmd
            .Connection = con
            .CommandText = "SELECT `Owners Id`, `Last Name`, `First Name`, `Middle Initial`, `Gender`, `Owners Address`, `Mayors Permit`, `Permit Date`, `Expired Date`, `Cellphone Number`, `Business Name`, `Business Address`, `BusinessType`, `Status` FROM `tbl_ownersinformation` WHERE `Mayors Permit` LIKE '%" & strSearch & "%' or `Last Name` LIKE '%" & strSearch & "%' or `First Name` LIKE '%" & strSearch & "%' ORDER BY `Owners Id` "
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        dgRecords.DataSource = dt
    End Sub

    Sub showphoto()

        Try
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = cmd

            Dim Data = New DataTable

            adapter = New MySqlDataAdapter("SELECT `Picture` FROM `tbl_ownersinformation` Where `Mayors Permit` = '" & frm_updateBPLO.txtmayorspermit.Text & "' ORDER BY `Owners Id`", con)

            Dim commandbuild = New MySqlCommandBuilder(adapter)
            adapter.Fill(Data)

            Dim lb() As Byte = Data.Rows(0).Item("Picture")
            Dim lstr As New System.IO.MemoryStream(lb)
            frm_updateBPLO.picboxclient.Image = Image.FromStream(lstr)
            frm_updateBPLO.picboxclient.SizeMode = PictureBoxSizeMode.StretchImage
            lstr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgRecords_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRecords.CellClick

        Try

            con.Close()
            con.Open()

            Dim SqlQuery As String = "SELECT * FROM `tbl_ownersinformation` WHERE `Owners Id` = " & dgRecords.SelectedCells(0).Value & " "
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
            frm_updateBPLO.txtownersID.Text = TABLE.Rows(0)("Owners Id")
            frm_updateBPLO.txtlastname.Text = TABLE.Rows(0)("Last Name")
            frm_updateBPLO.txtfirstname.Text = TABLE.Rows(0)("First Name")
            frm_updateBPLO.txtMI.Text = TABLE.Rows(0)("Middle Initial")
            frm_updateBPLO.cmbgender.Text = TABLE.Rows(0)("Gender")
            frm_updateBPLO.txtownersaddress.Text = TABLE(0)("Owners Address")
            frm_updateBPLO.txtmayorspermit.Text = TABLE(0)("Mayors Permit")
            frm_updateBPLO.DTPpermitdate.Text = TABLE(0)("Permit Date")
            frm_updateBPLO.DTPExpireddate.Text = TABLE(0)("Expired Date")
            frm_updateBPLO.txtcellphonenumber.Text = TABLE(0)("Cellphone Number")
            frm_updateBPLO.txtbusinessname.Text = TABLE(0)("Business Name")
            frm_updateBPLO.txtbusinessaddress.Text = TABLE(0)("Business Address")
            frm_updateBPLO.cmborganization.Text = TABLE(0)("Business Organization Type")
            frm_updateBPLO.cmbbusinesstype.Text = TABLE(0)("BusinessType")
            frm_updateBPLO.lblamount.Text = TABLE(0)("Amount")
            frm_updateBPLO.txtstatus.Text = TABLE(0)("Status")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try



    End Sub

    Private Sub dgRecords_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRecords.CellContentClick

    End Sub

    'Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click
    '    frm_updateBPLO.Show()
    '    frm_updateBPLO.Enabledtxt()
    '    frm_updateBPLO.btnsave.Show()
    '    frm_updateBPLO.btnedit.Hide()
    '    frm_updateBPLO.btncancel.Show()
    '    showphoto()
    '    Me.Hide()
    'End Sub

    'Private Sub btnview_Click(sender As System.Object, e As System.EventArgs) Handles btnview.Click
    '    frm_updateBPLO.Show()
    '    frm_updateBPLO.Disabledtxt()
    '    frm_updateBPLO.btnsave.Hide()
    '    frm_updateBPLO.btnedit.Show()
    '    frm_updateBPLO.btncancel.Show()
    '    showphoto()
    '    Me.Hide()
    'End Sub

   
    Private Sub txtsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.TextChanged
        showrecords(txtsearch.Text)
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs)
        showrecords(txtsearch.Text)
    End Sub

    Private Sub btnneedsrenewal_Click(sender As System.Object, e As System.EventArgs)
        frm_expireddetails.Show()
        Me.Hide()

    End Sub

    Private Sub btnhome_Click(sender As System.Object, e As System.EventArgs)
        frm_Main.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_payment.Show()
        Me.Hide()

    End Sub

    Private Sub btnview_Click(sender As System.Object, e As System.EventArgs) Handles btnview.Click
        frm_updateBPLO.Show()
        frm_updateBPLO.Disabledtxt()
        frm_updateBPLO.lbltitle.Text = "View Record"
        frm_updateBPLO.btnsave.Hide()
        frm_updateBPLO.btnedit.Show()
        frm_updateBPLO.btncancel.Show()
        showphoto()
        Me.Hide()
    End Sub

    Private Sub btneditrecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_updateBPLO.Show()
        frm_updateBPLO.Enabledtxt()
        frm_updateBPLO.lbltitle.Text = "Edit Record"
        frm_updateBPLO.btnsave.Show()
        frm_updateBPLO.btnedit.Hide()
        frm_updateBPLO.btncancel.Show()
        showphoto()
        Me.Hide()
    End Sub

    Private Sub btnaddrecords_Click(sender As System.Object, e As System.EventArgs) Handles btnaddrecords.Click
        New_BPLO.Show()
        Me.Hide()
    End Sub

    Private Sub btnneedsrenewal_Click_1(sender As System.Object, e As System.EventArgs) Handles btnneedsrenewal.Click
        frm_expireddetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        frm_treasurer.Show()
        Me.Hide()
    End Sub


    Private Sub btnhome_Click_1(sender As System.Object, e As System.EventArgs) Handles btnhome.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

    Private Sub btnrefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnrefresh.Click
        showrecords("")
    End Sub

    Private Sub dgRecords_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRecords.CellDoubleClick
        frm_updateBPLO.Show()
    End Sub
End Class