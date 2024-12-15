<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.btnexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btndeposit = New System.Windows.Forms.Button()
        Me.btnAdd_Acc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.cbshowpass = New System.Windows.Forms.CheckBox()
        Me.btnClear_Login = New System.Windows.Forms.Button()
        Me.btnLog_In = New System.Windows.Forms.Button()
        Me.txtLinPassword = New System.Windows.Forms.TextBox()
        Me.txtLinEmail = New System.Windows.Forms.TextBox()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnWithdarw = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltranslate = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnexit.Location = New System.Drawing.Point(700, 477)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(211, 53)
        Me.btnexit.TabIndex = 14
        Me.btnexit.Text = "Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 159)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btndeposit
        '
        Me.btndeposit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btndeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeposit.ForeColor = System.Drawing.Color.MediumBlue
        Me.btndeposit.Location = New System.Drawing.Point(584, 205)
        Me.btndeposit.Margin = New System.Windows.Forms.Padding(4)
        Me.btndeposit.Name = "btndeposit"
        Me.btndeposit.Size = New System.Drawing.Size(257, 53)
        Me.btndeposit.TabIndex = 10
        Me.btndeposit.Text = "Deposit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btndeposit.UseVisualStyleBackColor = False
        '
        'btnAdd_Acc
        '
        Me.btnAdd_Acc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAdd_Acc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd_Acc.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnAdd_Acc.Location = New System.Drawing.Point(584, 378)
        Me.btnAdd_Acc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd_Acc.Name = "btnAdd_Acc"
        Me.btnAdd_Acc.Size = New System.Drawing.Size(257, 73)
        Me.btnAdd_Acc.TabIndex = 9
        Me.btnAdd_Acc.Text = "Add New " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Account"
        Me.btnAdd_Acc.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(175, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(736, 70)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Philippine National Bank"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(530, 388)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(705, 487)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(529, 215)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 34)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'cbshowpass
        '
        Me.cbshowpass.AutoSize = True
        Me.cbshowpass.Checked = True
        Me.cbshowpass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbshowpass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbshowpass.Location = New System.Drawing.Point(187, 330)
        Me.cbshowpass.Name = "cbshowpass"
        Me.cbshowpass.Size = New System.Drawing.Size(130, 22)
        Me.cbshowpass.TabIndex = 64
        Me.cbshowpass.Text = "Show Password"
        Me.cbshowpass.UseVisualStyleBackColor = True
        '
        'btnClear_Login
        '
        Me.btnClear_Login.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear_Login.ForeColor = System.Drawing.Color.Red
        Me.btnClear_Login.Location = New System.Drawing.Point(319, 373)
        Me.btnClear_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear_Login.Name = "btnClear_Login"
        Me.btnClear_Login.Size = New System.Drawing.Size(123, 28)
        Me.btnClear_Login.TabIndex = 63
        Me.btnClear_Login.Text = "Clear"
        Me.btnClear_Login.UseVisualStyleBackColor = True
        '
        'btnLog_In
        '
        Me.btnLog_In.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog_In.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnLog_In.Location = New System.Drawing.Point(177, 373)
        Me.btnLog_In.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLog_In.Name = "btnLog_In"
        Me.btnLog_In.Size = New System.Drawing.Size(134, 28)
        Me.btnLog_In.TabIndex = 60
        Me.btnLog_In.Text = "Log-in "
        Me.btnLog_In.UseVisualStyleBackColor = True
        '
        'txtLinPassword
        '
        Me.txtLinPassword.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinPassword.Location = New System.Drawing.Point(187, 295)
        Me.txtLinPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinPassword.Name = "txtLinPassword"
        Me.txtLinPassword.Size = New System.Drawing.Size(245, 28)
        Me.txtLinPassword.TabIndex = 59
        '
        'txtLinEmail
        '
        Me.txtLinEmail.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinEmail.Location = New System.Drawing.Point(187, 230)
        Me.txtLinEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinEmail.Name = "txtLinEmail"
        Me.txtLinEmail.Size = New System.Drawing.Size(245, 28)
        Me.txtLinEmail.TabIndex = 58
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.Location = New System.Drawing.Point(183, 270)
        Me.lblpass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(99, 21)
        Me.lblpass.TabIndex = 62
        Me.lblpass.Text = "Password:"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(183, 196)
        Me.lbluser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(107, 21)
        Me.lbluser.TabIndex = 61
        Me.lbluser.Text = "User name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(233, 405)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 21)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Click here Register"
        '
        'btnWithdarw
        '
        Me.btnWithdarw.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnWithdarw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdarw.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnWithdarw.Location = New System.Drawing.Point(584, 295)
        Me.btnWithdarw.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWithdarw.Name = "btnWithdarw"
        Me.btnWithdarw.Size = New System.Drawing.Size(257, 53)
        Me.btnWithdarw.TabIndex = 67
        Me.btnWithdarw.Text = "Withdraw"
        Me.btnWithdarw.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(529, 304)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(48, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 68
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(329, 466)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "English"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(209, 466)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 21)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Filipino"
        '
        'lbltranslate
        '
        Me.lbltranslate.AutoSize = True
        Me.lbltranslate.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltranslate.ForeColor = System.Drawing.Color.DimGray
        Me.lbltranslate.Location = New System.Drawing.Point(259, 444)
        Me.lbltranslate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltranslate.Name = "lbltranslate"
        Me.lbltranslate.Size = New System.Drawing.Size(81, 21)
        Me.lbltranslate.TabIndex = 71
        Me.lbltranslate.Text = "Language"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(968, 543)
        Me.Controls.Add(Me.lbltranslate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnWithdarw)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbshowpass)
        Me.Controls.Add(Me.btnClear_Login)
        Me.Controls.Add(Me.btnLog_In)
        Me.Controls.Add(Me.txtLinPassword)
        Me.Controls.Add(Me.txtLinEmail)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.btndeposit)
        Me.Controls.Add(Me.btnAdd_Acc)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Philippine National Bank"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btndeposit As System.Windows.Forms.Button
    Friend WithEvents btnAdd_Acc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents cbshowpass As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear_Login As System.Windows.Forms.Button
    Friend WithEvents btnLog_In As System.Windows.Forms.Button
    Friend WithEvents txtLinPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLinEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnWithdarw As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbltranslate As System.Windows.Forms.Label
End Class
