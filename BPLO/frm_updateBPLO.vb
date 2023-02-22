Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class frm_updateBPLO
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader

    Private Sub frm_updateBPLO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub ClrTXT()
        picboxclient.Image = Nothing
        txtmayorspermit.Text = ""
        DTPpermitdate.Text = Date.Today
        DTPExpireddate.Text = Date.Today
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

        'DTPpermitdate.Enabled = True
        'DTPExpireddate.Enabled = True
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
                          "',`Mayors Permit`='" & txtmayorspermit.Text & "',`Cellphone Number`='" & txtcellphonenumber.Text & "',`Business Name`='" & txtbusinessname.Text &
                          "',`Business Address`='" & txtbusinessaddress.Text & "',`Business Organization Type` = '" & cmborganization.Text & "',`BusinessType`='" & cmbbusinesstype.Text & "',`Amount` = '" & lblamount.Text & "',`Status`= '" & txtstatus.Text & "',Picture=@Picture WHERE `Mayors Permit` = '" & txtmayorspermit.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@Picture", arrPic)
                    cmd.ExecuteNonQuery()
                    frm_Record.showrecords("")
                    frm_expireddetails.viewdelayed("")
                    frm_listodnewbusinessintreasurer.showrecords("")
                    frm_RenewedRecords.showrecords("")
                    frm_Transaction.showrecords("")
                    frm_Record.Show()
                    ClrTXT()
                    MsgBox("Save!", MsgBoxStyle.Information)
                    
                    Me.Hide()
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        con.Close()
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs)
        frm_Record.Show()
        Me.Hide()
    End Sub

    Private Sub btnshow_Click(sender As System.Object, e As System.EventArgs) Handles btnshow.Click
        Dim effDate As Date
        ' Dim dueofDate As Date
        Dim MatDate As Date

        effDate = Date.ParseExact(DTPpermitdate.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        MatDate = effDate.AddMonths(1 * 12)
        DTPExpireddate.Text = MatDate.ToString("dd/MM/yyyy")
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


    Private Sub btnchoose_Click(sender As System.Object, e As System.EventArgs)
        upimg()
    End Sub

    Private Sub txtcellphonenumber_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcellphonenumber.KeyPress
        Dim notAllowed As String = "`~!@#$%^&*()_=[{[};:'\|<,>.?/ abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

        If e.KeyChar <> ControlChars.Back = True Then
            If notAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

  
    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click
        btnedit.Hide()
        lbltitle.Text = "Edit Record"
        btnsave.Show()
        Enabledtxt()

    End Sub

    Private Sub btnsave_Click_1(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        updatenewownersinformation()
    End Sub

    Private Sub btncancel_Click_1(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        frm_Record.Show()
        Me.Hide()
    End Sub

   
End Class