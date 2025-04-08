Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Imports AdminViewForm

Public Class Form2
    Inherits Form

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Connection string to the database
    Private connectionString As String = "Server=BRYTLYF;Database=Group_Project;Integrated Security=True;TrustServerCertificate=True;"

    ' Method to register a student
    Private Sub RegisterStudent()
        Dim connection As SqlConnection = Nothing
        Dim command As SqlCommand = Nothing

        Try
            connection = New SqlConnection(connectionString)
            connection.Open()

            ' Step 1: Check if Student ID already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM NewStudent WHERE studentID = @studentID"
            command = New SqlCommand(checkQuery, connection)
            command.Parameters.AddWithValue("@studentID", txtStudentID.Text.Trim())

            Dim studentExists As Integer = Convert.ToInt32(command.ExecuteScalar())

            If studentExists > 0 Then
                MessageBox.Show("Student ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Step 2: Insert student if ID is unique
            Dim query As String = "INSERT INTO NewStudent (Student_name, studentID, gender, telephone, course, email, RegistrationDate) " &
                                  "VALUES (@Student_name, @studentID, @gender, @telephone, @course, @Email, @RegistrationDate)"
            command = New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@Student_name", txtFirstname.Text.Trim() & " " & txtSurname.Text.Trim())
            command.Parameters.AddWithValue("@studentID", txtStudentID.Text.Trim())
            command.Parameters.AddWithValue("@gender", If(cboGender.SelectedItem IsNot Nothing, cboGender.SelectedItem.ToString(), ""))
            command.Parameters.AddWithValue("@telephone", txtTelephone.Text.Trim())
            command.Parameters.AddWithValue("@course", If(cboCourseSelection.SelectedItem IsNot Nothing, cboCourseSelection.SelectedItem.ToString(), ""))
            command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
            command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now)

            command.ExecuteNonQuery()
            MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Show the print preview window
            btnPrintPreview.PerformClick()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If command IsNot Nothing Then command.Dispose()
            If connection IsNot Nothing Then connection.Dispose()
        End Try
    End Sub

    ' Register button click
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtFirstname.Text = "" OrElse txtSurname.Text = "" OrElse cboGender.SelectedIndex = -1 OrElse
            txtStudentID.Text = "" OrElse txtTelephone.Text = "" OrElse cboCourseSelection.SelectedIndex = -1 OrElse
            txtEmail.Text = "" OrElse txtConfirmEmail.Text = "" Then

            MessageBox.Show("Please fill in all fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Student ID format check
        Dim idPattern = "^STU\d{5}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtStudentID.Text.Trim, idPattern) Then
            MessageBox.Show("Student ID must start with 'STU' followed by 5 digits (e.g., STU12345).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Phone validation
        Dim phonePattern = "^\d{10}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtTelephone.Text.Trim, phonePattern) Then
            MessageBox.Show("Telephone must be 10 digits only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Email format
        Dim emailPattern = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.Trim, emailPattern) Then
            MessageBox.Show("Invalid email format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirm email match
        If txtEmail.Text.Trim.ToLower <> txtConfirmEmail.Text.Trim.ToLower Then
            MessageBox.Show("Emails do not match.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        RegisterStudent()
    End Sub

    ' Clear button click
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' Close button click
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    ' Clear form
    Private Sub ClearFields()
        txtFirstname.Clear()
        txtSurname.Clear()
        cboGender.SelectedIndex = -1
        txtStudentID.Clear()
        txtTelephone.Clear()
        cboCourseSelection.SelectedIndex = -1
        txtEmail.Clear()
        txtConfirmEmail.Clear()
        txtFirstname.Focus()
    End Sub

    ' Load event
    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboGender.Items.AddRange(New String() {"Male", "Female", "Other"})
        cboCourseSelection.Items.AddRange(New String() {
            "Programming", "Electronics", "Cyber Security", "Gaming", "Networking", "Web Development"
        })
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim font As New Font("Arial", 12)
        Dim yPos As Integer = 100

        e.Graphics.DrawString("STUDENT REGISTRATION SUMMARY", New Font("Arial", 16, FontStyle.Bold), Brushes.Black, 100, yPos)
        yPos += 40

        e.Graphics.DrawString("Name: " & txtFirstname.Text & " " & txtSurname.Text, font, Brushes.Black, 100, yPos)
        yPos += 30

        e.Graphics.DrawString("Student ID: " & txtStudentID.Text, font, Brushes.Black, 100, yPos)
        yPos += 30

        e.Graphics.DrawString("Gender: " & cboGender.Text, font, Brushes.Black, 100, yPos)
        yPos += 30

        e.Graphics.DrawString("Telephone: " & txtTelephone.Text, font, Brushes.Black, 100, yPos)
        yPos += 30

        e.Graphics.DrawString("Email: " & txtEmail.Text, font, Brushes.Black, 100, yPos)
        yPos += 30

        e.Graphics.DrawString("Course: " & cboCourseSelection.Text, font, Brushes.Black, 100, yPos)
        yPos += 30

        e.Graphics.DrawString("Date Registered: " & DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"), font, Brushes.Black, 100, yPos)
    End Sub

    Private Sub btnOpenAdminView_Click(sender As Object, e As EventArgs) Handles btnOpenAdminView.Click
        Dim pin As String = InputBox("Enter the 4-digit Admin PIN to access:", "Admin Verification")

        ' Check if user pressed Cancel
        If String.IsNullOrEmpty(pin) Then
            MessageBox.Show("Access cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Validate PIN
        If pin = "0247" Then

            ' Create a new instance of AdminViewForm
            Dim adminForm As New AdminViewForm.AdminViewForm()

            ' Show the AdminViewForm
            adminForm.Show()
        Else
            MessageBox.Show("Incorrect PIN. Access denied.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
