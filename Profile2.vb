Imports System.Data.OleDb
Public Class Profile2
    '
    Public Shared Connect
    Dim Prof As New bankclass
    Public Sub display_profile()
        Try
            txtUser.Text = Connect
            Prof.con.Open()
            Dim query As New OleDbCommand("SELECT * FROM member WHERE USERNAME='" & txtUser.Text & "'", Prof.con)
            Dim read As OleDbDataReader
            read = query.ExecuteReader
            If read.HasRows Then
                If read.Read() Then
                    txtID.Text = (read("ID"))
                    txtUser.Text = (read("USERNAME"))
                    txtPass.Text = (read("PASSWORD"))
                    txtAccType.Text = (read("USERTYPE"))
                    txtFname.Text = (read("FNAME"))
                    txtLname.Text = (read("LNAME"))
                    txtMname.Text = (read("MNAME"))
                    txtContNUm.Text = (read("CONTNUM"))
                    txtBday.Text = (read("BOD"))
                    txtEmail.Text = (read("EMAILADD"))
                    txtBal.Text = (read("BALANCE"))
                    TXTpIN.Text = (read("PIN CODE"))
                    txtBal.Text = "₱" & CDbl(txtBal.Text)
                End If
            End If
        Catch ex As Exception
        Finally
            Prof.con.Close()

        End Try
    End Sub
    Private Sub Profile2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Prof.Conn()
        display_profile()
        txtUser.Text = Connect
    End Sub

    Private Sub btnCreateNew_email_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNew_email.Click
        Try

            depoload.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Try

            logoutload.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Home.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class