Imports MySql.Data.MySqlClient

Public Class frm_Login
    Public isLoanofficer As Boolean
    Public isTresurer As Boolean
    Public isAdmin As Boolean
    Public strloanofficer As String
    Public strtreasurer As String
    Dim sql As String
    'Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim int As Integer
    Dim i As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As MySqlDataReader

    Private Sub Login_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Login()

        Else
            Me.Show()

        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1

    End Sub
    Private Sub Login()


        Try

            con.Open()
            sql = "SELECT * FROM tbl_user WHERE Username = '" & txtusername.Text & "' AND Password = '" & txtpassword.Text & "'"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()
            If txtusername.Text = "" And txtpassword.Text = "" Then
                MsgBox("Please input a Username and Password", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Exit Sub
            ElseIf txtusername.Text = "" Then
                MsgBox("Please input a Username!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Exit Sub
            ElseIf txtpassword.Text = "" Then
                MsgBox("Please input a Password!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            If dr.Read = True Then

                If LCase(dr("Role")) = "admin" Then
                    MsgBox("Welcome!", MsgBoxStyle.Information, "Login")
                    frm_Main.Show()
                    frm_Main.tsslUser.Text = dr("role")
                    'frm_Main.tsslUser.Text = UCase(txtusername.Text)
                    frm_Main.tsslUser.Tag = dr("User_Id")
                    '  frm_Main.btntransaction.Enabled = False
                    isLoanofficer = False
                    isTresurer = False
                    isAdmin = True
                    Me.Hide()
                    txtusername.Clear()
                    txtpassword.Clear()
                ElseIf LCase(dr("Role")) = "officer" Then
                    MsgBox("Welcome!", MsgBoxStyle.Information, "Login")
                    isLoanofficer = dr("User_Id")
                    frm_Main.Show()

                    frm_Main.tsslUser.Text = dr("Role")
                    'POS.Label1.Text = dr("FirstName")
                    frm_Main.tsslUser.Tag = dr("User_Id")
                    'frm_Main.btntransaction.Enabled = False
                    frm_UsersRecords.btnaddrecords.Enabled = False
                    isLoanofficer = True
                    isTresurer = False
                    isAdmin = False
                    Me.Hide()
                    txtusername.Clear()
                    txtpassword.Clear()
                ElseIf LCase(dr("Role")) = "treasurer" Then
                    MsgBox("Welcome!", MsgBoxStyle.Information, "Login")
                    isTresurer = dr("User_Id")
                    frm_treasurer.Show()
                    '  frm_Main.choices()
                    frm_treasurer.tsslUser.Text = dr("Role")
                    frm_treasurer.txttreasurername.Text = dr("LastName") & ", " & dr("FirstName") & " " & dr("MI")
                    'POS.Label1.Text = dr("FirstName")
                    frm_treasurer.tsslUser.Tag = dr("User_Id")
                    isLoanofficer = False
                    isTresurer = True
                    isAdmin = False
                    Me.Hide()
                    txtusername.Clear()
                    txtpassword.Clear()

                End If

                Exit Sub
            Else

                MsgBox("Incorrect username or password.", MsgBoxStyle.Critical, "Login")
                txtusername.SelectAll()
                txtpassword.SelectAll()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
   


   
    
    Private Sub btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        Login()
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        If MsgBox("Do you want close?", MsgBoxStyle.YesNo) = vbYes Then
            End
        Else
            Me.Show()

        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.TextChanged
        Label1.Text = TimeOfDay

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.TextChanged
        Label2.Text = DateString

    End Sub

    Private Sub lbltitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitle.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub pnlheader_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlheader.Paint

    End Sub
End Class
