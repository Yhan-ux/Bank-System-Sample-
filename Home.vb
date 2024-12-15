Imports System.Data.OleDb

Public Class Home
    Dim Log As New bankclass
    Private Sub btndeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeposit.Click

        Try
            clearText()
            LOGIN_Form.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Acc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd_Acc.Click

        Try
            clearText()
            Register.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
   

    Private Sub btnLog_In_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLog_In.Click, btnLog_In.Enter
        If txtLinEmail.Text = "" Or txtLinPassword.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE REQUIRED FIELDS...", " AUTHENTICATION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Log.con.Open()
                Using cmd As New OleDbCommand("SELECT * FROM member WHERE [USERNAME] = @USERNAME OR [PASSWORD] = @PASSWORD", Log.con)
                    cmd.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtLinEmail.Text.Trim
                    cmd.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtLinPassword.Text.Trim

                    Dim ds As New OleDbDataAdapter(cmd)
                    Dim mytable As New DataTable
                    ds.Fill(mytable)
                    If mytable.Rows(0)("USERTYPE") = "member" Then
                        Dim message As String = "You have successfully Login... Please click [OK] to Proceed"
                        Dim caption As String = "Success!!!"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim adminMain As New Profile2
                        Profile2.Connect = txtLinEmail.Text

                        Profile2.Show()
                        Me.Close()

                        clearText()
                    ElseIf mytable.Rows(0)("USERTYPE") = "Admin" Then
                        Dim message As String = "You have successfully Login... Please click [OK] to Proceed"
                        Dim caption As String = "Success!!!"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim adminMain As New Profile2
                        Profile2.Connect = txtLinEmail.Text

                        Profile2.Show()
                        Me.Close()
                        clearText()
                    ElseIf mytable.Rows(0)("USERTYPE") = "New Account" Then
                        Dim message As String = "You have successfully Login... Please click [OK] to Proceed"
                        Dim caption As String = "Success!!!"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim adminMain As New Profile2
                        Profile2.Connect = txtLinEmail.Text

                        Profile2.Show()
                        Me.Close()
                        clearText()

                    Else
                        MessageBox.Show("User and Password Do not match...", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        clearText()

                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("User and Password Do not match...", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Log.con.Close()

            End Try

        End If
    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Log.Conn()

    End Sub

    Private Sub cbshowpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbshowpass.CheckedChanged
        If cbshowpass.Checked = True Then
            txtLinPassword.UseSystemPasswordChar = False
        Else
            txtLinPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Try
            clearText()
            Register.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdarw.Click
        Try

            clearText()
            Withdraw_login.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        lbluser.Text = "Pangalang gumagamit:"
        lblpass.Text = "Password:"
        cbshowpass.Text = "Ipakita ang Password"

        btnAdd_Acc.Text = "Magdagdag ng bagong Account"
        btndeposit.Text = "Mag-Deposito"
        btnexit.Text = "Lumabas"
        btnWithdarw.Text = "Mag-Withdraw"
        btnLog_In.Text = "Mag-log in"
        btnClear_Login.Text = "Burahin"
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        lbluser.Text = "User name:"
        lblpass.Text = "Password:"
        cbshowpass.Text = "Show Password"
        lbltranslate.Text = "Language"
        btnAdd_Acc.Text = "Add New Account"

        btndeposit.Text = "Deposit"
        btnexit.Text = "Exit"
        btnWithdarw.Text = "Withdraw"
        btnLog_In.Text = "log-in"
        btnClear_Login.Text = "Clear"
    End Sub
    Public Sub clearText()
        txtLinEmail.Text = ""
        txtLinPassword.Text = ""

    End Sub

    Private Sub btnClear_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear_Login.Click
        clearText()
        txtLinEmail.Focus()
    End Sub

   
   
End Class