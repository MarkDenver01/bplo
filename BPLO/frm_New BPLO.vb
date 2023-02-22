Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO


Public Class New_BPLO
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader
    Public noMonth As String

    Private Sub New_BPLO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'GetBusinessID()
        'computeexpireddate()

        DTPpermitdate.Text = Date.Today
        GetOwnersID()
        txtmayorspermit.Text = ("Permit - 0000" + txtownersID.Text)
        Disabledtxt()
        'auto()
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
        btnchoose.Enabled = False
        btnsave.Enabled = False
        btnshow.Enabled = False
    End Sub

    'Sub Enabledtxtfordtp()
    '    'txtmayorspermit.Enabled = True
    '    DTPpermitdate.Enabled = True
    '    DTPExpireddate.Enabled = True
    '    btnshow.Enabled = True
    'End Sub
    Sub Enabledtxt()
        txtcellphonenumber.Enabled = True
        txtbusinessname.Enabled = True
        txtbusinessaddress.Enabled = True
        txtownersaddress.Enabled = True
        txtlastname.Enabled = True
        txtfirstname.Enabled = True
        txtMI.Enabled = True
        cmbgender.Enabled = True
        cmbbusinesstype.Enabled = True
        btnchoose.Enabled = True
        btnsave.Enabled = True

    End Sub
    'Private Sub GetBusinessID()

    '    Try
    '        con.Close()
    '        con.Open()
    '        With cmd
    '            .Connection = con
    '            .CommandText = "SELECT `Business Id` FROM tbl_businessidentification ORDER BY `Business Id` DESC"

    '            dr = cmd.ExecuteReader
    '        End With
    '        If dr.Read = True Then
    '            txtbusinessID.Text = dr("Business Id") + 1
    '        Else
    '            txtbusinessID.Text = 1
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        cmd.Dispose()
    '        con.Close()
    '    End Try
    'End Sub
    Private Sub GetOwnersID()

        Try

            con.Close()
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT `Owners Id` FROM tbl_ownersinformation ORDER BY `Owners Id` DESC"

                dr = cmd.ExecuteReader
            End With
            If dr.Read = True Then
                txtownersID.Text = dr("Owners Id") + 1
            Else
                txtownersID.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try


    End Sub






    'Sub addnew()

    '    con.Close()
    '    con.Open()

    '    Dim theQuery As String = "SELECT CONCAT('PER', `Mayors Permit`) FROM `tbl_ownersinformation` WHERE `Mayors Permit`=@MayorsPermit"
    '    Dim cmd1 As MySqlCommand = New MySqlCommand(theQuery, con)
    '    txtmayorspermit.Text = 98231
    '    cmd1.Parameters.AddWithValue("@MayorsPermit", (txtmayorspermit.Text) + 1)


    '    Using reader As MySqlDataReader = cmd1.ExecuteReader()
    '        If reader.HasRows Then
    '            ' User already exists
    '            MsgBox("User Already Exist!", MsgBoxStyle.Exclamation, "Add New User!")
    '        Else
    '            ' User does not exist, add them
    '            Dim cmd As MySqlCommand = New MySqlCommand("INSERT INTO `tbl_ownersinformation`(`Owners Id`, `Last Name`, `First Name`, `Middle Initial`, `Gender`, `Owners Address`, `Mayors Permit`, `Permit Date`,`Expired Date`, `Cellphone Number`, `Business Name`, `Business Address`, `BusinessType`,`Status`) VALUES ('" & txtownersID.Text &
    '            "','" & txtlastname.Text & "','" & txtfirstname.Text & "','" & txtMI.Text & "','" & cmbgender.Text & "','" & txtownersaddress.Text & "','" & txtmayorspermit.Text & "','" & permitdatedt.Text & "','" & DTPexpdate.Text & "','" & txtcellphonenumber.Text & "','" & txtbusinessname.Text &
    '            "','" & txtbusinessaddress.Text & "','" & cmbbusinesstype.Text & "','New')", con)
    '            con.Close()
    '            con.Open()
    '            cmd.ExecuteNonQuery()
    '            MsgBox("Records Successfully Added!", MsgBoxStyle.Information, "Add New Customer!")

    '        End If
    '    End Using

    '    con.Close()

    'End Sub


    Public Sub addnewownersinformation()
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

                    sql = "INSERT INTO `tbl_ownersinformation`(`Owners Id`, `Last Name`, `First Name`, `Middle Initial`, `Gender`, `Owners Address`, `Mayors Permit`, `Permit Date`,`Expired Date`, `Cellphone Number`, `Business Name`, `Business Address`,`Business Organization Type`, `BusinessType`,`Amount`,`Status`,`Picture`) VALUES ('" & txtownersID.Text &
                        "','" & txtlastname.Text & "','" & txtfirstname.Text & "','" & txtMI.Text & "','" & cmbgender.Text & "','" & txtownersaddress.Text & "','" & txtmayorspermit.Text & "','" & DTPpermitdate.Text & "','" & DTPExpireddate.Text & "','" & txtcellphonenumber.Text & "','" & txtbusinessname.Text &
                        "','" & txtbusinessaddress.Text & "','" & cmborganization.Text & "','" & cmbbusinesstype.Text & "','" & lblamount.Text & "','New',@Picture)"
                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@Picture", arrPic)
                    cmd.ExecuteNonQuery()
                    paymententer()
                    frm_Record.showrecords("")
                    frm_expireddetails.viewdelayed("")
                    frm_listodnewbusinessintreasurer.showrecords("")
                    frm_RenewedRecords.showrecords("")
                    frm_Transaction.showrecords("")
                    frm_Record.Show()
                    ClrTXT()
                    GetOwnersID()
                    txtmayorspermit.Text = ("Permit - 0000" + txtownersID.Text)
                    MsgBox("Save!", MsgBoxStyle.Information)
                    Me.Hide()
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        con.Close()
    End Sub
    Sub paymententer()

        Try

            sql = "INSERT INTO `tbl_transaction`(`Mayors Permit`) VALUES ('" & txtmayorspermit.Text & "')"
            cmd = New MySqlCommand(Sql, con)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub computeexpireddate()
            DTPExpireddate.Format = DateTimePickerFormat.Custom
        DTPExpireddate.CustomFormat = "31/12/" & Date.Now.ToString("yyyy")
    End Sub


    'Sub comppp()

    '    Dim birthday As New DateTime(1990, 1, 1)
    '    Dim ts As TimeSpan = DateTime.Now.Subtract(birthday)

    '    Dim years As Integer, months As Integer, days As Integer, hours As Integer, minutes As Integer, seconds As Integer

    '    ' compute difference in total months
    '    months = 12 * (DateTime.Now.Year - birthday.Year) + (DateTime.Now.Month - birthday.Month)

    '    ' based upon the 'days',
    '    ' adjust months & compute actual days difference
    '    If DateTime.Now.Day < birthday.Day Then
    '        months -= 1
    '        days = DateTime.DaysInMonth(birthday.Year, birthday.Month) - birthday.Day + DateTime.Now.Day
    '    Else
    '        days = DateTime.Now.Day - birthday.Day
    '    End If
    '    ' compute years & actual months
    '    years = Math.Floor(months / 12)
    '    months -= years * 12

    '    hours = ts.Hours
    '    minutes = ts.Minutes
    '    seconds = ts.Seconds
    'End Sub

    'Private Sub btnshow_Click(sender As System.Object, e As System.EventArgs)


    '    Dim effDate As Date
    '    ' Dim dueofDate As Date
    '    Dim MatDate As Date

    '    effDate = Date.ParseExact(DTPpermitdate.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
    '    MatDate = effDate.AddMonths(1 * 12)
    '    DTPExpireddate.Text = "31/12" + Date.Now.ToString("yyyy")
    'End Sub



   

    Private Sub chckboxCHECKALL_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chckboxCHECKALL.CheckedChanged
        If chckboxCHECKALL.Checked = True Then
            chckboxbrgyclearance.Checked = True
            chckboxTIN.Checked = True
            chckboxDTI.Checked = True
            'Enabledtxtfordtp()
            Enabledtxt()
            computeexpireddate()
            MsgBox("Your Expired Date is " & DTPExpireddate.Text, MsgBoxStyle.Information)
        ElseIf chckboxCHECKALL.Checked = False Then
            chckboxbrgyclearance.Checked = False
            chckboxTIN.Checked = False
            chckboxDTI.Checked = False
            Disabledtxt()
        End If

    End Sub


    'Private Sub IntMonth()

    '    noMonth = ""
    '    If cmbMonth.Text = "January" Then
    '        noMonth = "01"
    '    ElseIf cmbMonth.Text = "February" Then
    '        noMonth = "02"
    '    ElseIf cmbMonth.Text = "March" Then
    '        noMonth = "03"
    '    ElseIf cmbMonth.Text = "April" Then
    '        noMonth = "04"
    '    ElseIf cmbMonth.Text = "May" Then
    '        noMonth = "05"
    '    ElseIf cmbMonth.Text = "June" Then
    '        noMonth = "06"
    '    ElseIf cmbMonth.Text = "July" Then
    '        noMonth = "07"
    '    ElseIf cmbMonth.Text = "August" Then
    '        noMonth = "08"
    '    ElseIf cmbMonth.Text = "September" Then
    '        noMonth = "09"
    '    ElseIf cmbMonth.Text = "October" Then
    '        noMonth = "10"
    '    ElseIf cmbMonth.Text = "November" Then
    '        noMonth = "11"
    '    ElseIf cmbMonth.Text = "December" Then
    '        noMonth = "12"
    '    End If
    'End Sub

    Private Sub btnshow_Click_1(sender As System.Object, e As System.EventArgs) Handles btnshow.Click
        'Dim effDate As Date
        '' Dim dueofDate As Date
        'Dim MatDate As Date

        'effDate = Date.ParseExact(DTPpermitdate.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        'MatDate = effDate.AddMonths(1 * 12)
        'DTPExpireddate.Text = MatDate.ToString("dd/MM/yyyy")
        'Enabledtxt()
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


  
    Private Sub btnchoose_Click(sender As System.Object, e As System.EventArgs) Handles btnchoose.Click
        upimg()

    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        addnewownersinformation()
    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

End Class