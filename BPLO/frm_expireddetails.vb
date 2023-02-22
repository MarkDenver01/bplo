Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class frm_expireddetails
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader
    Private Sub frm_Treasury_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        viewdelayed("")
    End Sub

    Sub viewdelayed(ByVal strSearch As String)

        Dim sqlqry As String
        Dim daset As New DataSet
        Dim daa As MySqlDataAdapter
        daset.Clear()
        sqlqry = "SELECT `Owners Id`, `Last Name`, `First Name`, `Middle Initial`, `Gender`, `Owners Address`, `Mayors Permit`, `Permit Date`, str_to_date(`Expired Date`, '%d/%m/%Y') as ExpiredDate, `Cellphone Number`, `Business Name`, `Business Address`, `BusinessType`, `Status` FROM `tbl_ownersinformation` WHERE str_to_date(`Expired Date`, '%d/%m/%Y') <= str_to_date('" & Date.Today & "','%d/%m/%Y') AND `Mayors Permit` LIKE '%" & strSearch & "%'  "
        daa = New MySqlDataAdapter(sqlqry, con)
        daa.Fill(daset)
        dgRecordsissue.DataSource = daset.Tables(0)
        frm_Record.btnneedsrenewal.Text = ("(" & daset.Tables(0).Rows.Count & ")" & " " & "Expired Date")
    End Sub

    Sub showphoto()

        Try
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = cmd

            Dim Data = New DataTable

            adapter = New MySqlDataAdapter("SELECT `Picture` FROM `tbl_ownersinformation` Where `Mayors Permit` = '" & frm_RenewBPLO.txtmayorspermit.Text & "' ORDER BY `Owners Id`", con)

            Dim commandbuild = New MySqlCommandBuilder(adapter)
            adapter.Fill(Data)

            Dim lb() As Byte = Data.Rows(0).Item("Picture")
            Dim lstr As New System.IO.MemoryStream(lb)
            frm_RenewBPLO.picboxclient.Image = Image.FromStream(lstr)
            frm_RenewBPLO.picboxclient.SizeMode = PictureBoxSizeMode.StretchImage
            lstr.Close()
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub btnhome_Click(sender As System.Object, e As System.EventArgs) Handles btnhome.Click
        frm_Record.Show()
        Me.Hide()

    End Sub

    Private Sub btnrenew_Click(sender As System.Object, e As System.EventArgs) Handles btnrenew.Click
        frm_RenewBPLO.Show()
        Me.Hide()
    End Sub

    Private Sub txtsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.TextChanged
        viewdelayed(txtsearch.Text)
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        viewdelayed(txtsearch.Text)
    End Sub

    Private Sub dgRecordsissue_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRecordsissue.CellClick
        Try

            con.Close()
            con.Open()

            Dim SqlQuery As String = "SELECT * FROM `tbl_ownersinformation` WHERE `Owners Id` = " & dgRecordsissue.SelectedCells(0).Value & " "
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

            frm_RenewBPLO.txtsearch.Text = TABLE.Rows(0)("Owners Id")

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    Private Sub dgRecordsissue_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRecordsissue.CellContentClick
        Try

            con.Close()
            con.Open()

            Dim SqlQuery As String = "SELECT * FROM `tbl_ownersinformation` WHERE `Owners Id` = " & dgRecordsissue.SelectedCells(0).Value & " "
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

            frm_RenewBPLO.txtsearch.Text = TABLE.Rows(0)("Owners Id")

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub dgRecordsissue_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRecordsissue.CellDoubleClick
        frm_RenewBPLO.Show()
    End Sub
End Class