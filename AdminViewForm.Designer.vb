<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminViewForm
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
        DataGridView1 = New DataGridView()
        btnLoad = New Button()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnClose = New Button()
        btnBack = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 23)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(967, 390)
        DataGridView1.TabIndex = 0
        ' 
        ' btnLoad
        ' 
        btnLoad.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnLoad.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoad.Location = New Point(40, 544)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(219, 72)
        btnLoad.TabIndex = 1
        btnLoad.Text = "LOAD STUDENTS"
        btnLoad.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(411, 487)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(231, 39)
        txtSearch.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Gray
        btnSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(448, 532)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(153, 64)
        btnSearch.TabIndex = 3
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGray
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(797, 470)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(160, 56)
        btnClear.TabIndex = 4
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LightGray
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(797, 544)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(160, 56)
        btnDelete.TabIndex = 5
        btnDelete.Text = "DELETE "
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(797, 612)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(160, 56)
        btnClose.TabIndex = 6
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(40, 454)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(147, 61)
        btnBack.TabIndex = 7
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' AdminViewForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(991, 680)
        Controls.Add(btnBack)
        Controls.Add(btnClose)
        Controls.Add(btnDelete)
        Controls.Add(btnClear)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnLoad)
        Controls.Add(DataGridView1)
        Name = "AdminViewForm"
        Text = "ADMIN VIEW"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnBack As Button

End Class
