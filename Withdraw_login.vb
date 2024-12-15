Imports System.Data.OleDb
Public Class Withdraw_login
    Dim Login As New bankclass

    Public Sub cleartext()
        txtLinEmail.Clear()
        txtLinPassword.Clear()
        txtLinEmail.Focus()
    End Sub

    Private Sub btnLog_In_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLog_In.Click
        If txtLinEmail.Text = "" Or txtLinPassword.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE REQUIRED FIELDS...", " AUTHENTICATION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Login.con.Open()
                Using cmd As New OleDbCommand("SELECT * FROM member WHERE [USERNAME] = @USERNAME OR [PASSWORD] = @PASSWORD", Login.con)
                    cmd.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtLinEmail.Text.Trim
                    cmd.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtLinPassword.Text.Trim

                    Dim ds As New OleDbDataAdapter(cmd)
                    Dim mytable As New DataTable
                    ds.Fill(mytable)
                    If mytable.Rows(0)("USERTYPE") = "member" Then
                        Dim message As String = "You have successfully login... Please click [OK] to Proceed"
                        Dim caption As String = "Success!!!"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim adminMain As New Withdraw
                        Withdraw.AdminMain = txtLinEmail.Text

                        logInWidrawLOad.Show()
                        Me.Close()

                        cleartext()
                    ElseIf mytable.Rows(0)("USERTYPE") = "Admin" Then
                        Dim message As String = "You have successfully login... Please click [OK] to Proceed"
                        Dim caption As String = "Success!!!"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim adminMain As New Withdraw
                        Withdraw.AdminMain = txtLinEmail.Text

                        logInWidrawLOad.Show()
                        Me.Close()
                        cleartext()
                    ElseIf mytable.Rows(0)("USERTYPE") = "New Account" Then
                        Dim message As String = "You have successfully login... Please click [OK] to Proceed"
                        Dim caption As String = "Success!!!"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim adminMain As New Withdraw
                        Withdraw.AdminMain = txtLinEmail.Text

                        logInWidrawLOad.Show()
                        Me.Close()
                        cleartext()

                    Else
                        MessageBox.Show("User and Password Do not match...", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cleartext()

                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("User and Password Do not match...", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Login.con.Close()

            End Try

        End If
    End Sub

    Private Sub Withdraw_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.Conn()

    End Sub
    Private Sub cbshowpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbshowpass.CheckedChanged
        If cbshowpass.Checked = True Then
            txtLinPassword.UseSystemPasswordChar = False
        Else
            txtLinPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnClear_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear_Login.Click
        cleartext()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            cleartext()
            Home.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Try
            Register.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class