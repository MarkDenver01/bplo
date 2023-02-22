Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO


Public Class frm_RenewBPLO

    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader



    Private Sub frm_RenewBPLO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Disabledtxt()
    End Sub
    Sub showphoto()
        Try
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = cmd

            Dim Data = New DataTable

            adapter = New MySqlDataAdapter("SELECT `Picture` FROM `tbl_ownersinformation` Where `Owners Id` = '" & txtsearch.Text & "' or `Mayors Permit` LIKE '%" & txtsearch.Text & "%' or `Last Name` LIKE '%" & txtsearch.Text & "%' or `First Name` LIKE '%" & txtsearch.Text & "%' ORDER BY `Owners Id`", con)

            Dim commandbuild = New MySqlCommandBuilder(adapter)
            adapter.Fill(Data)

            Dim lb() As Byte = Data.Rows(0).Item("Picture")
            Dim lstr As New System.IO.MemoryStream(lb)
            picboxclient.Image = Image.FromStream(lstr)
            picboxclient.SizeMode = PictureBoxSizeMode.StretchImage
            lstr.Close()
        Catch ex As Exception

        End Try
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
        btnchoose.Enabled = False
        btnsave.Enabled = False
    End Sub

    Sub Enabledtxt()
        'txtmayorspermit.Enabled = True
        DTPpermitdate.Enabled = True
        '  DTPExpireddate.Enabled = True
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
        btnchoose.Enabled = True
        btnsave.Enabled = True
    End Sub
   

    Private Sub chckboxCHECKALL_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chckboxCHECKALL.CheckedChanged
        If chckboxCHECKALL.Checked = True Then
            chckboxbrgyclearance.Checked = True
            chckboxTIN.Checked = True
            chckboxDTI.Checked = True
            Enabledtxt()
        ElseIf chckboxCHECKALL.Checked = False Then
            chckboxbrgyclearance.Checked = False
            chckboxTIN.Checked = False
            chckboxDTI.Checked = False
            Disabledtxt()
        End If
    End Sub

    'Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    If chckboxCHECKALL.Checked = True Then
    '        chckboxbrgyclearance.Checked = True
    '        chckboxTIN.Checked = True
    '        chckboxDTI.Checked = True
    '        Enabledtxt()
    '    ElseIf chckboxCHECKALL.Checked = False Then
    '        chckboxbrgyclearance.Checked = False
    '        chckboxTIN.Checked = False
    '        chckboxDTI.Checked = False
    '        Disabledtxt()
    '    End If
    'End Sub

    Sub paymententer()
        Try

            sql = "INSERT INTO `tbl_transaction`(`Mayors Permit`) VALUES ('" & txtmayorspermit.Text & "')"
            cmd = New MySqlCommand(Sql, con)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub updatenewownersinformation()
        Try

            con.Close()
            con.Open()

            If picboxclient.Image Is Nothing Or txtmayorspermit.Text = "" Or
              DTPpermitdate.Text = "" Or
              DTPExpireddate.Text = "" Or
              txtcellphonenumber.Text = "" Or
              txtbusinessname.Text = "" Or
              txtbusinessaddress.Text = "" Or
              txtownersaddress.Text = "" Or
              txtlastname.Text = "" Or
              txtfirstname.Text = "" Or
              txtMI.Text = "" Or
              cmbgender.Text = "" Or
              cmbbusinesstype.Text = "" Then
                MsgBox("please fill all the details", MsgBoxStyle.Information)
                Exit Sub
            Else
                Using ms As MemoryStream = New MemoryStream()


                    Dim bm As Bitmap = New Bitmap(picboxclient.Image)
                    bm.Save(ms, picboxclient.Image.RawFormat)

                    Dim arrPic() As Byte = ms.GetBuffer()

                    sql = "UPDATE `tbl_ownersinformation` SET `Owners Id`= '" & txtownersID.Text &
                          "' ,`Last Name`= '" & txtlastname.Text & "' ,`First Name`='" & txtfirstname.Text &
                          "',`Middle Initial`='" & txtMI.Text & "',`Gender`='" & cmbgender.Text & "',`Owners Address`='" & txtownersaddress.Text &
                          "',`Mayors Permit`='" & txtmayorspermit.Text & "',`Permit Date`='" & DTPpermitdate.Text & "',`Expired Date`='" & DTPExpireddate.Text &
                          "',`Cellphone Number`='" & txtcellphonenumber.Text & "',`Business Name`='" & txtbusinessname.Text &
                          "',`Business Address`='" & txtbusinessaddress.Text & "',`Business Organization Type` = '" & cmborganization.Text & "',`BusinessType`='" & cmbbusinesstype.Text & "',`Amount` = '" & lblamount.Text & "',`Status`= 'Renewed',Picture=@Picture WHERE `Mayors Permit` = '" & txtmayorspermit.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@Picture", arrPic)
                    cmd.ExecuteNonQuery()
                    paymententer()
                    frm_Record.showrecords("")
                    frm_expireddetails.viewdelayed("")
                    frm_listodnewbusinessintreasurer.showrecords("")
                    frm_RenewedRecords.showrecords("")
                    frm_Transaction.showrecords("")
                    ClrTXT()
                    MsgBox("Save!", MsgBoxStyle.Information)
                    frm_Record.Show()
                    Me.Hide()
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

  
    Private Sub btnshow_Click(sender As System.Object, e As System.EventArgs) Handles btnshow.Click
        DTPExpireddate.Value = DateTime.Now.AddYears(1)
        DTPExpireddate.Format = DateTimePickerFormat.Custom
        DTPExpireddate.CustomFormat = "31/12/" & DTPExpireddate.Value.Year

        'Dim effDate As Date
        '' Dim dueofDate As Date
        'Dim MatDate As Date

        'effDate = Date.ParseExact(DTPpermitdate.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        'MatDate = effDate.AddMonths(1 * 12)
        'DTPExpireddate.Text = MatDate.ToString("dd/MM/yyyy")
    End Sub

    Private Sub cmbbusinesstype_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbbusinesstype.SelectedIndexChanged
        If cmbbusinesstype.Text = "Canteen " Then
            lblamount.Text = "1000"
        ElseIf cmbbusinesstype.Text = "Sari Sari Store" Then

            lblamount.Text = "1500"
        ElseIf cmbbusinesstype.Text = "Computer Shop" Then

            lblamount.Text = "2000"
        ElseIf cmbbusinesstype.Text = "Motorcycle Shop" Then

            lblamount.Text = "3000"
        ElseIf cmbbusinesstype.Text = "Car Shop" Then

            lblamount.Text = "3000"
        ElseIf cmbbusinesstype.Text = "Convenience Store" Then

            lblamount.Text = "5000"
        ElseIf cmbbusinesstype.Text = "Gas Station" Then

            lblamount.Text = "5000"
        ElseIf cmbbusinesstype.Text = "Restraurant" Then

            lblamount.Text = "2000"
        ElseIf cmbbusinesstype.Text = "Grocery Store" Then

            lblamount.Text = "5000"
        ElseIf cmbbusinesstype.Text = "Resort" Then

            lblamount.Text = "5000"
        End If
    End Sub

    Sub upimg()
        Dim img As String = "Photo.jpg"
        Dim open As New OpenFileDialog()
        open.Title = "Upload Picture"
        open.Filter = "JPG File (*.jpg)|*.jpg| PNG FILES(*.png)|*.png"
        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Using fs As IO.FileStream = IO.File.OpenRead(open.FileName)
                Dim im As Image = Image.FromStream(fs)
                picboxclient.Image = im
                img = open.FileName

            End Using
        End If
    End Sub


    Private Sub txtcellphonenumber_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcellphonenumber.KeyPress
        Dim notAllowed As String = "`~!@#$%^&*()_=[{[};:'\|<,>.?/ abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

        If e.KeyChar <> ControlChars.Back = True Then
            If notAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

  

 
   
    Private Sub txtsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.TextChanged

        Try

            If txtsearch.Text = "" Then
                MsgBox("Please Input FirstName, LastName or Permit Number", MsgBoxStyle.Information)
                ClrTXT()
            Else
                con.Close()
                con.Open()

                Dim SqlQuery As String = "SELECT * FROM `tbl_ownersinformation` WHERE `Owners Id` = '" & txtsearch.Text & "' or `Mayors Permit` LIKE '%" & txtsearch.Text & "%' or `Last Name` LIKE '%" & txtsearch.Text & "%' or `First Name` LIKE '%" & txtsearch.Text & "%' ORDER BY `Owners Id`"
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
                txtownersID.Text = TABLE.Rows(0)("Owners Id")
                txtlastname.Text = TABLE.Rows(0)("Last Name")
                txtfirstname.Text = TABLE.Rows(0)("First Name")
                txtMI.Text = TABLE.Rows(0)("Middle Initial")
                cmbgender.Text = TABLE.Rows(0)("Gender")
                txtownersaddress.Text = TABLE(0)("Owners Address")
                txtmayorspermit.Text = TABLE(0)("Mayors Permit")
                DTPpermitdate.Text = TABLE(0)("Permit Date")
                DTPExpireddate.Text = TABLE(0)("Expired Date")
                txtcellphonenumber.Text = TABLE(0)("Cellphone Number")
                txtbusinessname.Text = TABLE(0)("Business Name")
                txtbusinessaddress.Text = TABLE(0)("Business Address")
                cmborganization.Text = TABLE(0)("Business Organization Type")
                cmbbusinesstype.Text = TABLE(0)("BusinessType")
                lblamount.Text = TABLE(0)("Amount")
                txtstatus.Text = TABLE(0)("Status")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        showphoto()
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click

        Try

            If txtsearch.Text = "" Then
                MsgBox("Please Input FirstName, LastName or Permit Number", MsgBoxStyle.Information)
                ClrTXT()
            Else
                con.Close()
                con.Open()

                Dim SqlQuery As String = "SELECT * FROM `tbl_ownersinformation` WHERE `Owners Id` = '" & txtsearch.Text & "' or `Mayors Permit` LIKE '%" & txtsearch.Text & "%' or `Last Name` LIKE '%" & txtsearch.Text & "%' or `First Name` LIKE '%" & txtsearch.Text & "%' ORDER BY `Owners Id`"
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
                txtownersID.Text = TABLE.Rows(0)("Owners Id")
                txtlastname.Text = TABLE.Rows(0)("Last Name")
                txtfirstname.Text = TABLE.Rows(0)("First Name")
                txtMI.Text = TABLE.Rows(0)("Middle Initial")
                cmbgender.Text = TABLE.Rows(0)("Gender")
                txtownersaddress.Text = TABLE(0)("Owners Address")
                txtmayorspermit.Text = TABLE(0)("Mayors Permit")
                DTPpermitdate.Text = TABLE(0)("Permit Date")
                DTPExpireddate.Text = TABLE(0)("Expired Date")
                txtcellphonenumber.Text = TABLE(0)("Cellphone Number")
                txtbusinessname.Text = TABLE(0)("Business Name")
                txtbusinessaddress.Text = TABLE(0)("Business Address")
                cmborganization.Text = TABLE(0)("Business Organization Type")
                cmbbusinesstype.Text = TABLE(0)("BusinessType")
                lblamount.Text = TABLE(0)("Amount")
                txtstatus.Text = TABLE(0)("Status")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        showphoto()
    End Sub

    Private Sub btnchoose_Click(sender As System.Object, e As System.EventArgs) Handles btnchoose.Click
        upimg()
    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        updatenewownersinformation()
    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

   
End Class