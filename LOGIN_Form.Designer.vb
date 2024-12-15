<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN_Form))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClear_Login = New System.Windows.Forms.Button()
        Me.btnLog_In = New System.Windows.Forms.Button()
        Me.txtLinPassword = New System.Windows.Forms.TextBox()
        Me.txtLinEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbshowpass = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightPink
        Me.Button1.Location = New System.Drawing.Point(-5, 490)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(973, 28)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Back to home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnClear_Login
        '
        Me.btnClear_Login.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear_Login.ForeColor = System.Drawing.Color.Red
        Me.btnClear_Login.Location = New System.Drawing.Point(525, 376)
        Me.btnClear_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear_Login.Name = "btnClear_Login"
        Me.btnClear_Login.Size = New System.Drawing.Size(100, 39)
        Me.btnClear_Login.TabIndex = 34
        Me.btnClear_Login.Text = "Clear"
        Me.btnClear_Login.UseVisualStyleBackColor = True
        '
        'btnLog_In
        '
        Me.btnLog_In.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog_In.ForeColor = System.Drawing.Color.Blue
        Me.btnLog_In.Location = New System.Drawing.Point(392, 376)
        Me.btnLog_In.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLog_In.Name = "btnLog_In"
        Me.btnLog_In.Size = New System.Drawing.Size(100, 39)
        Me.btnLog_In.TabIndex = 3
        Me.btnLog_In.Text = "Log-in "
        Me.btnLog_In.UseVisualStyleBackColor = True
        '
        'txtLinPassword
        '
        Me.txtLinPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinPassword.Location = New System.Drawing.Point(392, 282)
        Me.txtLinPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinPassword.Name = "txtLinPassword"
        Me.txtLinPassword.Size = New System.Drawing.Size(245, 27)
        Me.txtLinPassword.TabIndex = 2
        '
        'txtLinEmail
        '
        Me.txtLinEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinEmail.Location = New System.Drawing.Point(392, 232)
        Me.txtLinEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinEmail.Name = "txtLinEmail"
        Me.txtLinEmail.Size = New System.Drawing.Size(245, 27)
        Me.txtLinEmail.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 282)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 21)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 233)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "User name:"
        '
        'cbshowpass
        '
        Me.cbshowpass.AutoSize = True
        Me.cbshowpass.Checked = True
        Me.cbshowpass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbshowpass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbshowpass.Location = New System.Drawing.Point(392, 329)
        Me.cbshowpass.Name = "cbshowpass"
        Me.cbshowpass.Size = New System.Drawing.Size(130, 22)
        Me.cbshowpass.TabIndex = 57
        Me.cbshowpass.Text = "Show Password"
        Me.cbshowpass.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(425, 433)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 21)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Click here Register"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 159)
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(165, 99)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(736, 70)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Philippine National Bank"
        '
        'LOGIN_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 514)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbshowpass)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear_Login)
        Me.Controls.Add(Me.btnLog_In)
        Me.Controls.Add(Me.txtLinPassword)
        Me.Controls.Add(Me.txtLinEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "LOGIN_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Philippine National Bank"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnClear_Login As System.Windows.Forms.Button
    Friend WithEvents btnLog_In As System.Windows.Forms.Button
    Friend WithEvents txtLinPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLinEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbshowpass As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
