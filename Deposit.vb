
Imports System.Data.OleDb

Public Class Deposit

    Dim dep As New bankclass

    ' Dim adminmain As New LOGIN_Form

    Public Shared AdminMain

    Private Sub Deposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbluser.Text = AdminMain
        dep.Conn()
        displaydata()


    End Sub
    Public Sub displayprofile()
        Dim connect As New Profile
        Profile.Connect = AdminMain
        Profile.Show()
        Me.Close()
    End Sub

    Private Sub btnprofile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprofile.Click
        displayprofile()

    End Sub
    Public Sub displaydata()
        Try
            lbluser.Text = AdminMain
            dep.con.Open()
            Dim query As New OleDbCommand("SELECT * FROM member WHERE USERNAME='" & lbluser.Text & "'", dep.con)
            Dim read As OleDbDataReader
            read = query.ExecuteReader
            If read.HasRows Then
                If read.Read() Then
                    FNAME.Text = (read("FNAME"))
                    LNAME.Text = (read("LNAME"))
                    MNAME.Text = (read("MNAME"))
                    txtcurrBal.Text = (read("BALANCE"))
                    dep.currbalance = "₱" & CDbl(txtcurrBal.Text)
                    txtnewBal.Text = "₱" & dep.currbalance


                End If
            End If
        Catch ex As Exception
        Finally
            dep.con.Close()

        End Try
    End Sub
    Public Sub cleartext()
        FNAME.Clear()
        LNAME.Clear()
        MNAME.Clear()
        lbluser.Text = ""
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            cleartext()
            logoutload.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCreateNew_email_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNew_email.Click
        Try
            cleartext()
            depoload.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Try
            cleartext()
            logoutload.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    'Private Sub btndeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    dep.depAmount = Val(InputBox("How much?"))
    '    Try



    '        dep.DepositCount()
    '        dep.currbalance = txtcurrBal.Text
    '        txtnewBal.Text = "₱" & CDbl(dep.newbal)
    '        txtcurrBal.Text = dep.newbal - Val(txtAmount.Text)
    '        dep.con.Open()


    '        Dim str As String = "UPDATE member SET BALANCE='" & txtnewBal.Text & "' WHERE USERNAME='" & AdminMain & "'"
    '        Dim cmd As OleDbCommand
    '        cmd = New OleDbCommand(str, dep.con)

    '        If cmd.ExecuteNonQuery Then
    '            MessageBox.Show("You have already deposit Amount of ₱" & txtAmount.Text & ", Your New Balance Is " & txtnewBal.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If

    '        dep.con.Close()
    '    Catch ex As Exception
    '        dep.con.Close()
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub


  
  

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            cleartext()
            logoutload.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        dep.depAmount = Val(InputBox("How much?", "[Deposit] Philippine National Bank"))
        txtAmount.Text = "₱" & dep.depAmount
    End Sub
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        dep.DepositCount()    
        dep.currbalance = txtcurrBal.Text
        txtnewBal.Text = "₱" & CDbl(dep.newbal)
        txtcurrBal.Text = "₱" & dep.newbal - dep.depAmount
        lblbal.Text = "NEW BALANCE:"
        dep.con.Open()

        Try

            Dim str As String = "UPDATE member SET BALANCE='" & txtnewBal.Text & "' WHERE USERNAME='" & AdminMain & "'"
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(str, dep.con)

            If cmd.ExecuteNonQuery Then
                MessageBox.Show("You have already deposit Amount of ₱" & dep.depAmount & ", Your New Balance Is " & txtnewBal.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
        Finally
            dep.con.Close()

        End Try

    End Sub

    Private Sub lbluser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbluser.Click
        displayprofile()
    End Sub
End Class