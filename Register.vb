Imports System.Data.OleDb

Public Class Register
   
    Dim register As New bankclass

    Public Sub cleartext()
        txtLastName.Clear()
        txtFirstNAme.Clear()
        txtMidNAme.Clear()
        txtCont_Num.Clear()      
        txtNewEmail.Clear()
        txtuser.Clear()
        txtPassword.Clear()
        ComboBox1.Text = ""
        bod.Text = ""
        txtPIN.Clear()
        ComboBox1.Focus()
        txtbal.Text = "₱"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            cleartext()
            Home.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cleartext()
        txtLastName.Focus()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Try
            cleartext()
            Home.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        register.Conn()

    End Sub
    Private Sub btnCreateNew_email_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNew_email.Click
        If txtLastName.Text = "" Or txtFirstNAme.Text = "" Or txtMidNAme.Text = "" Or txtCont_Num.Text = "" Or txtNewEmail.Text = "" Or txtuser.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show(" Pllease Enter Empty details...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtLastName.Text = "Last Name" Or txtFirstNAme.Text = "First NAme" Or txtMidNAme.Text = " Middle Name" Or txtCont_Num.Text = "Contact #" Or txtNewEmail.Text = "Email Address" Or txtuser.Text = " Username" Or txtPassword.Text = "Password" Or ComboBox1.Text = "Select" Or txtPIN.Text = "" Then
            MessageBox.Show(" Pllease Enter Empty details...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'If con.State = ConnectionState.Closed Then
            'con.Open()
            'End If
        ElseIf txtbal.Text = "₱" Then
            MessageBox.Show(" Please pay first amount of ₱500 or more to open Account...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtbal.Text < 500 Then
            MessageBox.Show("Please pay Exact amount or more to open Account...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try




                If register.con.State = ConnectionState.Closed Then
                    register.con.Open()
                End If
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM member WHERE [USERNAME] = @USERNAME ", register.con)
                    cmd.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtuser.Text.Trim


                    Dim count = Convert.ToInt32(cmd.ExecuteScalar)
                    If count > 0 Then
                        MessageBox.Show(" Opps!!! Username and Password has already taken...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                Using cmd1 As New OleDbCommand("SELECT COUNT(*) FROM member WHERE [PASSWORD] = @PASSWORD", register.con)

                    cmd1.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPassword.Text.Trim

                    Dim count1 = Convert.ToInt32(cmd1.ExecuteScalar)
                    If count1 > 0 Then
                        MessageBox.Show(" Opps!!! Username and Password has already taken...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                End Using


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            Using create As New OleDbCommand("INSERT INTO member([USERNAME],[PASSWORD],[USERTYPE],[FNAME],[LNAME],[MNAME],[CONTNUM],[BOD],[EMAILADD],[PIN CODE],[BALANCE])VALUES(@USERNAME,@PASSWORD,@USERTYPE,@FNAME,@LNAME,@MNAME,@CONTNUM,@BOD,@EMAILADD,@PIN_CODE,@BALANCE)", register.con)
                create.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtuser.Text.Trim
                create.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPassword.Text.Trim
                create.Parameters.AddWithValue("@USERTYPE", OleDbType.VarChar).Value = ComboBox1.Text.Trim
                create.Parameters.AddWithValue("@FNAME", OleDbType.VarChar).Value = txtFirstNAme.Text.Trim
                create.Parameters.AddWithValue("@LNAME", OleDbType.VarChar).Value = txtLastName.Text.Trim
                create.Parameters.AddWithValue("@MNAME", OleDbType.VarChar).Value = txtMidNAme.Text.Trim
                create.Parameters.AddWithValue("@CONTNUM", OleDbType.VarChar).Value = txtCont_Num.Text.Trim
                create.Parameters.AddWithValue("@BOD", OleDbType.VarChar).Value = bod.Text.Trim
                create.Parameters.AddWithValue("@EMAILADD", OleDbType.VarChar).Value = txtNewEmail.Text.Trim
                create.Parameters.AddWithValue("@PIN_CODE", OleDbType.VarChar).Value = txtPIN.Text.Trim
                create.Parameters.AddWithValue("@BALANCE", OleDbType.VarChar).Value = txtbal.Text.Trim
                If create.ExecuteNonQuery Then
                    MessageBox.Show("Acount Registered!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cleartext()
                    logoutload.Show()
                    Me.Hide()

                End If
            End Using

            register.con.Close()
        End If
        'Using cmd As New OleDbCommand("SELECT COUNT(*) FROM member WHERE [USERNAME] = @USERNAME OR [PASSWORD] = @PASSWORD", con)
        'cmd.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtuser.Text.Trim
        'cmd.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPassword.Text.Trim

        ''Dim count = Convert.ToInt32(cmd.ExecuteScalar)
        'If count > 0 Then
        'MessageBox.Show(" Opps!!! Username and Password has already taken...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ' Exit Sub
        ' End If

        ' End Using
        'Using create As New OleDbCommand("INSERT INTO member([USERNAME],[PASSWORD],[USERTYPE],[FNAME],[LNAME],[MNAME],[CONTNUM],[BOD],[EMAILADD])VALUES(@USERNAME,@PASSWORD,@USERTYPE,@FNAME,@LNAME,@MNAME,@CONTNUM,@BOD,@EMAILADD)", con)
        'create.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtuser.Text.Trim
        ' create.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPassword.Text.Trim
        ' create.Parameters.AddWithValue("@FNAME", OleDbType.VarChar).Value = txtFirstNAme.Text.Trim
        'create.Parameters.AddWithValue("@LNAME", OleDbType.VarChar).Value = txtLastName.Text.Trim
        ' create.Parameters.AddWithValue("@MNAME", OleDbType.VarChar).Value = txtMidNAme.Text.Trim
        'create.Parameters.AddWithValue("@CONTNUM", OleDbType.VarChar).Value = txtCont_Num.Text.Trim
        ' create.Parameters.AddWithValue("@BOD", OleDbType.VarChar).Value = bod.Text.Trim
        ' create.Parameters.AddWithValue("@EMAILADD", OleDbType.VarChar).Value = txtNewEmail.Text.Trim
        ' create.Parameters.AddWithValue("@USERTYPE", OleDbType.VarChar).Value = ComboBox1.Text.Trim
        ' If create.ExecuteNonQuery Then
        'MessageBox.Show("Acount Created!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' cleartext()
        ' End If
        ' End Using
        ' con.Close()

    End Sub


    Private Sub ComboBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.Enter
        If ComboBox1.Text = "Select" Then
            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ComboBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.Leave
        If ComboBox1.Text = "" Then
            ComboBox1.Text = "Select"
            ComboBox1.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtLastName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.Enter
        If txtLastName.Text = "Last Name" Then
            txtLastName.Text = ""
            txtLastName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtLastName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.Leave
        If txtLastName.Text = "" Then
            txtLastName.Text = "Last Name"
            txtLastName.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtFirstNAme_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstNAme.Enter
        If txtFirstNAme.Text = "First Name" Then
            txtFirstNAme.Text = ""
            txtFirstNAme.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtFirstNAme_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstNAme.Leave
        If txtFirstNAme.Text = "" Then
            txtFirstNAme.Text = "First Name"
            txtFirstNAme.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtMidNAme_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMidNAme.Enter
        If txtMidNAme.Text = "Middle Name" Then
            txtMidNAme.Text = ""
            txtMidNAme.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtMidNAme_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMidNAme.Leave
        If txtMidNAme.Text = "" Then
            txtMidNAme.Text = "Middle Name"
            txtMidNAme.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtCont_Num_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCont_Num.Enter
        If txtCont_Num.Text = "Contact #" Then
            txtCont_Num.Text = ""
            txtCont_Num.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCont_Num_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCont_Num.Leave
        If txtCont_Num.Text = "" Then
            txtCont_Num.Text = "Contact #"
            txtCont_Num.ForeColor = Color.Silver
        End If
    End Sub

 


    Private Sub txtuser_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.Leave
        If txtuser.Text = "" Then
            txtuser.Text = "Username"
            txtuser.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtuser_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.Enter
        If txtuser.Text = "Username" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Silver
        End If
    End Sub
   


    Private Sub cbshowpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbshowpass.CheckedChanged
        If cbshowpass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

   
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPIN.CheckedChanged
        If cbPIN.Checked = True Then
            txtPIN.UseSystemPasswordChar = False
        Else
            txtPIN.UseSystemPasswordChar = True
        End If
    End Sub
End Class