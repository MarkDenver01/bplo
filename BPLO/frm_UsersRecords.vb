Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class frm_UsersRecords
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader


    Private Sub frm_UsersRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        showrecords("")
    End Sub

    Sub showrecords(ByVal strSearch As String)

        With cmd
            .Connection = con
            .CommandText = "SELECT `User_Id`, `LastName`, `FirstName`, `MI`, `Gender`, `Address`, `ContactNumber`, `Username`, `Password`, `Role` FROM `tbl_user` WHERE `User_Id` LIKE '%" & strSearch & "%'  AND Role = 'Treasurer' or Role = 'Officer'"

        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        dgUsersRecord.DataSource = dt

    End Sub

    Private Sub dgUsersRecord_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUsersRecord.CellClick

        Try
            con.Close()
            con.Open()

            Dim SqlQuery As String = "SELECT * FROM `tbl_user` WHERE `User_Id` = " & dgUsersRecord.SelectedCells(0).Value & " "
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


            frm_UpdateUserAccount.txtuserid.Text = TABLE.Rows(0)("User_Id")
            frm_UpdateUserAccount.txtLastname.Text = TABLE.Rows(0)("LastName")
            frm_UpdateUserAccount.txtFirstname.Text = TABLE.Rows(0)("FirstName")
            frm_UpdateUserAccount.txtMI.Text = TABLE.Rows(0)("MI")
            frm_UpdateUserAccount.cmbGender.Text = TABLE.Rows(0)("Gender")
            frm_UpdateUserAccount.txtaddress.Text = TABLE(0)("Address")
            frm_UpdateUserAccount.txtContractNo.Text = TABLE(0)("ContactNumber")
            frm_UpdateUserAccount.txtusername.Text = TABLE(0)("Username")
            frm_UpdateUserAccount.txtpassword.Text = TABLE(0)("Password")
            frm_UpdateUserAccount.ttconfirmpassword.Text = TABLE(0)("Password")
            frm_UpdateUserAccount.txtRole.Text = TABLE(0)("Role")


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    Private Sub dgUsersRecord_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUsersRecord.CellContentClick

    End Sub

    Private Sub btnhome_Click(sender As System.Object, e As System.EventArgs) Handles btnhome.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

    Private Sub btnaddrecords_Click(sender As System.Object, e As System.EventArgs) Handles btnaddrecords.Click
        frm_createaccount.Show()
        Me.Hide()
    End Sub

    Private Sub btneditrecords_Click(sender As System.Object, e As System.EventArgs) Handles btneditrecords.Click
        frm_UpdateUserAccount.Show()
        frm_UpdateUserAccount.enabledtxt()
        frm_UpdateUserAccount.btnedit.Hide()
        frm_UpdateUserAccount.btnadd.Show()
        frm_UpdateUserAccount.lbltitle.Text = "Edit Account Record"
        Me.Hide()
    End Sub

    Private Sub btndeterecords_Click(sender As System.Object, e As System.EventArgs) Handles btndeterecords.Click

    End Sub

    Private Sub btnview_Click(sender As System.Object, e As System.EventArgs) Handles btnview.Click
        frm_UpdateUserAccount.Show()
        frm_UpdateUserAccount.disabledtxt()
        frm_UpdateUserAccount.btnedit.Show()
        frm_UpdateUserAccount.btnadd.Hide()
        frm_UpdateUserAccount.lbltitle.Text = "View Account Record"
        Me.Hide()
    End Sub

    Private Sub pnlheader_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlheader.Paint

    End Sub

    Private Sub dgUsersRecord_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUsersRecord.CellDoubleClick
        frm_UpdateUserAccount.Show()
    End Sub
End Class