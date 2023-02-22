
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO
Public Class frm_UpdateUserAccount

    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader

    Private Sub frm_UpdateUserAccount_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClearFields()

        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtMI.Text = ""
        txtaddress.Text = ""
        cmbGender.Text = ""
        txtContractNo.Text = ""
        txtusername.Text = ""
        txtRole.Text = ""
        txtpassword.Text = ""
        ttconfirmpassword.Text = ""

    End Sub

    Sub disabledtxt()
        txtLastname.Enabled = False
        txtFirstname.Enabled = False
        txtMI.Enabled = False
        txtaddress.Enabled = False
        cmbGender.Enabled = False
        txtContractNo.Enabled = False
        txtusername.Enabled = False
        txtRole.Enabled = False
        txtpassword.Enabled = False
        ttconfirmpassword.Enabled = False
    End Sub


    Sub enabledtxt()
        txtLastname.Enabled = True
        txtFirstname.Enabled = True
        txtMI.Enabled = True
        txtaddress.Enabled = True
        cmbGender.Enabled = True
        txtContractNo.Enabled = True
        txtusername.Enabled = True
        txtRole.Enabled = True
        txtpassword.Enabled = True
        ttconfirmpassword.Enabled = True
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click
        enabledtxt()
        btnedit.Hide()
        btnadd.Show()
    End Sub

    Private Sub editloanofficer()
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
                sql = "Update tbl_user SET Lastname = '" & txtLastname.Text & "', Firstname = '" & txtFirstname.Text & "', MI = '" & txtMI.Text & "', Address = '" & txtaddress.Text & "',Gender = '" & cmbGender.Text & "', ContactNumber = '" & txtContractNo.Text & "', UserName ='" & txtusername.Text & "', Role = '" & txtRole.Text & "', Password = '" & txtpassword.Text & "' WHERE User_Id = '" & txtuserid.Text & "'"

                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Record successfully updated", MsgBoxStyle.Information)
                frm_UsersRecords.showrecords("")
                ClearFields()
                frm_UsersRecords.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        frm_UsersRecords.Show()
        Me.Hide()
    End Sub

  
    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        editloanofficer()
    End Sub
End Class