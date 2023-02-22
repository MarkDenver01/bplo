Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO


Public Class frm_createaccount
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader

    Private Sub frm_createaccount_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ClearFields()

        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtMI.Text = ""
        txtaddress.Text = ""
        cmbGender.Text = ""
        txtContractNo.Text = ""
        txtUsername.Text = ""
        txtRole.Text = ""
        txtPassword.Text = ""
        ttconfirmpassword.Text = ""
    End Sub

    Sub addaccount()


        Try
            con.Close()
            con.Open()
           
            If txtLastname.Text = "" Or
                 txtFirstname.Text = "" Or
                 txtMI.Text = "" Or
                 txtaddress.Text = "" Or
                 cmbGender.Text = "" Or
                 txtContractNo.Text = "" Or
                 txtusername.Text = "" Or
                 txtRole.Text = "" Or
                 txtpassword.Text = "" Or
                 ttconfirmpassword.Text = "" Then
                MsgBox("Please Fill out all the fields", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf txtpassword.Text <> ttconfirmpassword.Text Then
                MsgBox("Your Password does not match", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                sql = "INSERT INTO tbl_user (Lastname, Firstname, MI, Address, Gender,ContactNumber, UserName, Role, Password) VALUES('" & txtLastname.Text & "', '" & txtFirstname.Text & "', '" & txtMI.Text & "', '" & txtaddress.Text & "','" & cmbGender.Text & "', '" & txtContractNo.Text & "', '" & txtusername.Text & "', '" & txtRole.Text & "', '" & txtpassword.Text & "')"

                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("New account successfully added.", MsgBoxStyle.Information)
                frm_UsersRecords.showrecords("")
                ClearFields()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        addaccount()
    End Sub

    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        frm_UsersRecords.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class