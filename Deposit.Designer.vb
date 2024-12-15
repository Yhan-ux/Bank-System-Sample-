<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deposit))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtnewBal = New System.Windows.Forms.TextBox()
        Me.txtcurrBal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblbal = New System.Windows.Forms.Label()
        Me.FNAME = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MNAME = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LNAME = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnCreateNew_email = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightPink
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(2, 579)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(954, 38)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Back to home"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(91, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 21)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "WELCOME TO PNB>> "
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbluser.Location = New System.Drawing.Point(308, 243)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(198, 21)
        Me.lbluser.TabIndex = 50
        Me.lbluser.Text = "WELCOME TO PNB>> "
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtAmount.Enabled = False
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(372, 367)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(159, 34)
        Me.txtAmount.TabIndex = 51
        '
        'txtnewBal
        '
        Me.txtnewBal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtnewBal.Enabled = False
        Me.txtnewBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewBal.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtnewBal.Location = New System.Drawing.Point(372, 494)
        Me.txtnewBal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnewBal.Name = "txtnewBal"
        Me.txtnewBal.Size = New System.Drawing.Size(159, 34)
        Me.txtnewBal.TabIndex = 52
        '
        'txtcurrBal
        '
        Me.txtcurrBal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtcurrBal.Enabled = False
        Me.txtcurrBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurrBal.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtcurrBal.Location = New System.Drawing.Point(372, 433)
        Me.txtcurrBal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcurrBal.Name = "txtcurrBal"
        Me.txtcurrBal.Size = New System.Drawing.Size(159, 34)
        Me.txtcurrBal.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(170, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 21)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "DEPOSIT AMOUNT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 446)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 21)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = " CURRENT BALANCE:"
        '
        'lblbal
        '
        Me.lblbal.AutoSize = True
        Me.lblbal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbal.Location = New System.Drawing.Point(200, 507)
        Me.lblbal.Name = "lblbal"
        Me.lblbal.Size = New System.Drawing.Size(96, 21)
        Me.lblbal.TabIndex = 56
        Me.lblbal.Text = "BALANCE:"
        '
        'FNAME
        '
        Me.FNAME.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FNAME.Enabled = False
        Me.FNAME.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNAME.ForeColor = System.Drawing.Color.DarkBlue
        Me.FNAME.Location = New System.Drawing.Point(363, 279)
        Me.FNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.FNAME.Name = "FNAME"
        Me.FNAME.Size = New System.Drawing.Size(245, 28)
        Me.FNAME.TabIndex = 61
        Me.FNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(423, 308)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 21)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "First Name:"
        '
        'MNAME
        '
        Me.MNAME.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MNAME.Enabled = False
        Me.MNAME.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNAME.ForeColor = System.Drawing.Color.DarkBlue
        Me.MNAME.Location = New System.Drawing.Point(641, 276)
        Me.MNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.MNAME.Name = "MNAME"
        Me.MNAME.Size = New System.Drawing.Size(245, 28)
        Me.MNAME.TabIndex = 62
        Me.MNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(711, 308)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 21)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Middle Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LNAME
        '
        Me.LNAME.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LNAME.Enabled = False
        Me.LNAME.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNAME.ForeColor = System.Drawing.Color.DarkBlue
        Me.LNAME.Location = New System.Drawing.Point(79, 279)
        Me.LNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.LNAME.Name = "LNAME"
        Me.LNAME.Size = New System.Drawing.Size(245, 28)
        Me.LNAME.TabIndex = 60
        Me.LNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(158, 311)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 21)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Last Name:"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.PowderBlue
        Me.btncancel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.DarkRed
        Me.btncancel.Location = New System.Drawing.Point(775, 175)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(110, 31)
        Me.btncancel.TabIndex = 66
        Me.btncancel.Text = "Log-out"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnCreateNew_email
        '
        Me.btnCreateNew_email.BackColor = System.Drawing.Color.PowderBlue
        Me.btnCreateNew_email.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNew_email.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCreateNew_email.Location = New System.Drawing.Point(631, 175)
        Me.btnCreateNew_email.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateNew_email.Name = "btnCreateNew_email"
        Me.btnCreateNew_email.Size = New System.Drawing.Size(117, 31)
        Me.btnCreateNew_email.TabIndex = 67
        Me.btnCreateNew_email.Text = "Log-in "
        Me.btnCreateNew_email.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label9.Location = New System.Drawing.Point(362, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(245, 17)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "click here to login to other account>> "
        '
        'btnprofile
        '
        Me.btnprofile.BackColor = System.Drawing.Color.PowderBlue
        Me.btnprofile.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprofile.ForeColor = System.Drawing.SystemColors.GrayText
        Me.btnprofile.Location = New System.Drawing.Point(715, 219)
        Me.btnprofile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnprofile.Name = "btnprofile"
        Me.btnprofile.Size = New System.Drawing.Size(116, 45)
        Me.btnprofile.TabIndex = 69
        Me.btnprofile.Text = "Profile"
        Me.btnprofile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprofile.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightBlue
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(719, 225)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 70
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LightPink
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(370, 584)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 71
        Me.PictureBox3.TabStop = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnupdate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnupdate.Location = New System.Drawing.Point(603, 433)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(150, 56)
        Me.btnupdate.TabIndex = 88
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Tomato
        Me.Button4.Location = New System.Drawing.Point(603, 515)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 56)
        Me.Button4.TabIndex = 87
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Blue
        Me.Button5.Location = New System.Drawing.Point(603, 345)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 56)
        Me.Button5.TabIndex = 86
        Me.Button5.Text = "DEPOSIT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 159)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(161, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(736, 70)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Philippine National Bank"
        '
        'Deposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(956, 609)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnprofile)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnCreateNew_email)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.FNAME)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MNAME)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LNAME)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblbal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcurrBal)
        Me.Controls.Add(Me.txtnewBal)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Deposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[Deposit] Philippine National Bank"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtnewBal As System.Windows.Forms.TextBox
    Friend WithEvents txtcurrBal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblbal As System.Windows.Forms.Label
    Friend WithEvents FNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnCreateNew_email As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnprofile As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
