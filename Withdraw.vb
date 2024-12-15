Imports System.Data.OleDb
Public Class Withdraw
    Dim Wid As New bankclass

    ' Dim adminmain As New LOGIN_Form
  
    Public Shared AdminMain

    Private Sub Deposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbluser.Text = AdminMain
        Wid.Conn()
        displaydata()
    End Sub
    Private Sub btnprofile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprofile.Click
        displayprofile()

    End Sub
    Public Sub displayprofile()
        Dim connecting As New Profwidraw
        Profwidraw.Connecting = AdminMain
        Profwidraw.Show()
        Me.Close()
    End Sub
    Public Sub displaydata()
        Try

            lbluser.Text = AdminMain
            Wid.con.Open()
            Dim query As New OleDbCommand("SELECT * FROM member WHERE USERNAME='" & lbluser.Text & "'", Wid.con)
            Dim read As OleDbDataReader
            read = query.ExecuteReader
            If read.HasRows Then
                If read.Read() Then
                    FNAME.Text = (read("FNAME"))
                    LNAME.Text = (read("LNAME"))
                    MNAME.Text = (read("MNAME"))
                    txtCurrbal.Text = (read("BALANCE"))
                    Wid.currbalance = "₱" & CDbl(txtCurrbal.Text)
                    txtnewBal.Text = "₱" & Wid.currbalance
                    txtmaintainbal.Text = "₱" & Wid.maintainFixedbal
                    txtAvailableBal.Text = "₱" & txtCurrbal.Text - txtmaintainbal.Text


                End If
            End If
        Catch ex As Exception
        Finally
            Wid.con.Close()

        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Try
            Wid.withdraw()
            txtnewBal.Text = "₱" & Wid.newbal
            Wid.currbalance = txtCurrbal.Text
            txtAvailableBal.Text = "₱" & Wid.newbal - Wid.maintainFixedbal
            If txtAvailableBal.Text < 0 Then
                displaydata()
                'txtAvailableBal.Text = Wid.currbalance - Wid.maintainFixedbal
                MessageBox.Show(" Insufficient Savings Account Balance, Your Available balance is " & txtAvailableBal.Text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                lblavailbal.Text = "NEW BALANCE AVAILABLE:"
                lblbal.Text = "NEW BALANCE:"
                Wid.con.Open()
                Dim str As String = "UPDATE member SET BALANCE='" & txtnewBal.Text & "' WHERE USERNAME='" & AdminMain & "'"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(str, Wid.con)

                If cmd.ExecuteNonQuery Then
                    MessageBox.Show("You have already withdraw Amount of ₱" & Wid.WdrawAmount & ", Your New Available Balance Is " & txtAvailableBal.Text & " and Your New Balance Is " & txtnewBal.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
        Finally
            Wid.con.Close()

        End Try

    End Sub
    Private Sub btndeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwithdraw.Click

        'Try

        '
        Wid.WdrawAmount = Val(InputBox("How much?", "[Withdraw] Philippine National Bank"))

        '    txtAvailableBal.Text = Wid.newbal - Wid.maintainFixedbal
        '    lblavailbal.Text = "NEW BALANCE AVAILABLE:"
        '    lblbal.Text = "NEW BALANCE:"
        '    If txtAvailableBal.Text < 0 Then
        '        'txtAvailableBal.Text = Wid.currbalance - Wid.maintainFixedbal
        '        MessageBox.Show(" Insufficient Savings Account Balance, Your Available balance is " & txtAvailableBal.Text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        '    End If
        '    Wid.con.Open()
        '    Dim str As String = "UPDATE member SET BALANCE='" & txtnewBal.Text & "' WHERE USERNAME='" & AdminMain & "'"
        '    Dim cmd As OleDbCommand
        '    cmd = New OleDbCommand(str, Wid.con)

        '    If cmd.ExecuteNonQuery Then
        '        MessageBox.Show("You have already withdraw Amount of ₱" & Wid.WdrawAmount & ", Your New Available Balance Is " & txtAvailableBal.Text & " and Your New Balance Is " & txtnewBal.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If


        'Catch ex As Exception
        'Finally
        '    Wid.con.Close()

        'End Try

        'Try

        '    dep.DepositCount()
        '    dep.depAmount = Val(txtAmount.Text)
        '    dep.currbalance = txtcurrBal.Text
        '    txtnewBal.Text = "₱" & CDbl(dep.newbal)
        '    txtcurrBal.Text = dep.newbal - Val(txtAmount.Text)
        '    dep.con.Open()


        '    Dim str As String = "UPDATE member SET BALANCE='" & txtnewBal.Text & "' WHERE USERNAME='" & AdminMain & "'"
        '    Dim cmd As OleDbCommand
        '    cmd = New OleDbCommand(str, dep.con)

        '    If cmd.ExecuteNonQuery Then
        '        MessageBox.Show("You have already deposit Amount of ₱" & txtAmount.Text & "Your New Balance Is " & txtnewBal.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If

        '    dep.con.Close()
        'Catch ex As Exception
        '    dep.con.Close()
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try


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

   
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cleartext()
            logoutload.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lbluser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbluser.Click
        displayprofile()
    End Sub
End Class