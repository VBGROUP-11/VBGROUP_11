<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        txtFirstname = New TextBox()
        lblFirstname = New Label()
        lblSurname = New Label()
        txtSurname = New TextBox()
        lblGender = New Label()
        cboGender = New ComboBox()
        lblStudentID = New Label()
        txtStudentID = New TextBox()
        Label1 = New Label()
        cboCourseSelection = New ComboBox()
        btnClear = New Button()
        btnClose = New Button()
        btnRegister = New Button()
        lblTelephone = New Label()
        txtTelephone = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblConfirmEmail = New Label()
        txtConfirmEmail = New TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        btnPrintPreview = New Button()
        btnOpenAdminView = New Button()
        SuspendLayout()
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(262, 60)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(182, 31)
        txtFirstname.TabIndex = 0
        ' 
        ' lblFirstname
        ' 
        lblFirstname.AutoSize = True
        lblFirstname.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        lblFirstname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFirstname.Location = New Point(85, 57)
        lblFirstname.Name = "lblFirstname"
        lblFirstname.Size = New Size(156, 32)
        lblFirstname.TabIndex = 1
        lblFirstname.Text = "FIRSTNAME:"
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        lblSurname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSurname.Location = New Point(102, 131)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(139, 32)
        lblSurname.TabIndex = 2
        lblSurname.Text = "SURNAME:"
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(262, 134)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(182, 31)
        txtSurname.TabIndex = 3
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        lblGender.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGender.Location = New Point(124, 216)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(117, 32)
        lblGender.TabIndex = 4
        lblGender.Text = "GENDER:"
        ' 
        ' cboGender
        ' 
        cboGender.FormattingEnabled = True
        cboGender.Location = New Point(262, 219)
        cboGender.Name = "cboGender"
        cboGender.Size = New Size(182, 33)
        cboGender.TabIndex = 5
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        lblStudentID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentID.Location = New Point(86, 294)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(155, 32)
        lblStudentID.TabIndex = 6
        lblStudentID.Text = "STUDENTID:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(262, 297)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(182, 31)
        txtStudentID.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(514, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(245, 32)
        Label1.TabIndex = 8
        Label1.Text = "COURSE SELECTION:"
        ' 
        ' cboCourseSelection
        ' 
        cboCourseSelection.FormattingEnabled = True
        cboCourseSelection.Location = New Point(801, 219)
        cboCourseSelection.Name = "cboCourseSelection"
        cboCourseSelection.Size = New Size(182, 33)
        cboCourseSelection.TabIndex = 9
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Gray
        btnClear.BackgroundImageLayout = ImageLayout.Stretch
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(293, 529)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(140, 58)
        btnClear.TabIndex = 11
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.BackgroundImageLayout = ImageLayout.Stretch
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(495, 529)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(140, 58)
        btnClose.TabIndex = 12
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnRegister.BackgroundImageLayout = ImageLayout.Stretch
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(85, 529)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(140, 58)
        btnRegister.TabIndex = 13
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' lblTelephone
        ' 
        lblTelephone.AutoSize = True
        lblTelephone.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        lblTelephone.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTelephone.Location = New Point(86, 374)
        lblTelephone.Name = "lblTelephone"
        lblTelephone.Size = New Size(156, 32)
        lblTelephone.TabIndex = 14
        lblTelephone.Text = "TELEPHONE:"
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Location = New Point(262, 377)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(182, 31)
        txtTelephone.TabIndex = 15
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(665, 54)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(94, 32)
        lblEmail.TabIndex = 18
        lblEmail.Text = "EMAIL:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(801, 54)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(182, 31)
        txtEmail.TabIndex = 19
        ' 
        ' lblConfirmEmail
        ' 
        lblConfirmEmail.AutoSize = True
        lblConfirmEmail.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        lblConfirmEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblConfirmEmail.Location = New Point(547, 131)
        lblConfirmEmail.Name = "lblConfirmEmail"
        lblConfirmEmail.Size = New Size(212, 32)
        lblConfirmEmail.TabIndex = 20
        lblConfirmEmail.Text = "CONFIRM EMAIL:"
        ' 
        ' txtConfirmEmail
        ' 
        txtConfirmEmail.Location = New Point(801, 134)
        txtConfirmEmail.Name = "txtConfirmEmail"
        txtConfirmEmail.Size = New Size(182, 31)
        txtConfirmEmail.TabIndex = 21
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' btnPrintPreview
        ' 
        btnPrintPreview.BackColor = Color.Blue
        btnPrintPreview.BackgroundImageLayout = ImageLayout.Stretch
        btnPrintPreview.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrintPreview.Location = New Point(547, 309)
        btnPrintPreview.Name = "btnPrintPreview"
        btnPrintPreview.Size = New Size(256, 80)
        btnPrintPreview.TabIndex = 22
        btnPrintPreview.Text = "PRINT PREVIEW"
        btnPrintPreview.UseVisualStyleBackColor = False
        ' 
        ' btnOpenAdminView
        ' 
        btnOpenAdminView.BackColor = Color.Lime
        btnOpenAdminView.BackgroundImageLayout = ImageLayout.Stretch
        btnOpenAdminView.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOpenAdminView.Location = New Point(777, 497)
        btnOpenAdminView.Name = "btnOpenAdminView"
        btnOpenAdminView.Size = New Size(176, 81)
        btnOpenAdminView.TabIndex = 23
        btnOpenAdminView.Text = "ADMIN VIEW"
        btnOpenAdminView.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        ClientSize = New Size(1100, 652)
        Controls.Add(btnOpenAdminView)
        Controls.Add(btnPrintPreview)
        Controls.Add(txtConfirmEmail)
        Controls.Add(lblConfirmEmail)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(txtTelephone)
        Controls.Add(lblTelephone)
        Controls.Add(btnRegister)
        Controls.Add(btnClose)
        Controls.Add(btnClear)
        Controls.Add(cboCourseSelection)
        Controls.Add(Label1)
        Controls.Add(txtStudentID)
        Controls.Add(lblStudentID)
        Controls.Add(cboGender)
        Controls.Add(lblGender)
        Controls.Add(txtSurname)
        Controls.Add(lblSurname)
        Controls.Add(lblFirstname)
        Controls.Add(txtFirstname)
        Name = "Form2"
        Text = "RegistrationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents lblFirstname As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents lblStudentID As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCourseSelection As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblTelephone As Label
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblConfirmEmail As Label
    Friend WithEvents txtConfirmEmail As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnPrintPreview As Button
    Friend WithEvents btnOpenAdminView As Button

End Class
