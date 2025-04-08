<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Label1 = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        BtnLogin = New Button()
        BtnClose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(417, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 48)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN PAGE"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblUsername.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(70, 265)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(178, 38)
        lblUsername.TabIndex = 1
        lblUsername.Text = "USERNAME:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblPassword.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(70, 389)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(180, 38)
        lblPassword.TabIndex = 2
        lblPassword.Text = "PASSWORD:"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(281, 272)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(290, 24)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(281, 403)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(290, 24)
        txtPassword.TabIndex = 4
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        BtnLogin.BackgroundImageLayout = ImageLayout.Stretch
        BtnLogin.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnLogin.Location = New Point(301, 523)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(141, 54)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "LOGIN"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' BtnClose
        ' 
        BtnClose.BackColor = Color.Red
        BtnClose.BackgroundImageLayout = ImageLayout.Stretch
        BtnClose.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnClose.Location = New Point(505, 523)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(141, 54)
        BtnClose.TabIndex = 6
        BtnClose.Text = "CLOSE"
        BtnClose.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1075, 653)
        Controls.Add(BtnClose)
        Controls.Add(BtnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(Label1)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnClose As Button

End Class
