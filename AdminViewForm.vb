Imports System.Windows.Forms
Imports SqlCommand = Microsoft.Data.SqlClient.SqlCommand
Imports SqlConnection = Microsoft.Data.SqlClient.SqlConnection
Imports SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader

Public Class AdminViewForm
    Inherits Form

    ' Connection string to the database
    Private connectionString As String = "Server=BRYTLYF;Database=Group_Project;Integrated Security=True;TrustServerCertificate=True;"

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Handles the Load button click event to load student data
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim connection As SqlConnection = Nothing
        Dim command As SqlCommand = Nothing
        Dim reader As SqlDataReader = Nothing
        Dim dt As New DataTable()

        Try
            connection = New SqlConnection(connectionString)
            connection.Open()

            ' SQL query to retrieve all student records
            Dim query As String = "SELECT * FROM NewStudent"
            command = New SqlCommand(query, connection)

            ' Execute the query and get data
            reader = command.ExecuteReader()

            ' Load data into DataTable
            dt.Load(reader)

            ' Bind DataTable to DataGridView1
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Dispose of objects to free up resources
            If reader IsNot Nothing Then reader.Dispose()
            If command IsNot Nothing Then command.Dispose()
            If connection IsNot Nothing Then connection.Dispose()
        End Try
    End Sub

    ' Handles the Search button click event to filter the student data based on the search criteria
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim connection As SqlConnection = Nothing
        Dim command As SqlCommand = Nothing
        Dim reader As SqlDataReader = Nothing
        Dim dt As New DataTable()

        Try
            connection = New SqlConnection(connectionString)
            connection.Open()

            ' SQL query to search by studentID or Student_name (based on the text in txtSearch)
            Dim query As String = "SELECT * FROM NewStudent WHERE studentID LIKE @search OR Student_name LIKE @search"
            command = New SqlCommand(query, connection)

            ' Add the search term as a parameter (with wildcards for LIKE)
            command.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")

            ' Execute the query and get data
            reader = command.ExecuteReader()

            ' Load data into DataTable
            dt.Load(reader)

            ' Bind DataTable to DataGridView1
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Dispose of objects to free up resources
            If reader IsNot Nothing Then reader.Dispose()
            If command IsNot Nothing Then command.Dispose()
            If connection IsNot Nothing Then connection.Dispose()
        End Try
    End Sub

    ' Form Load event to initialize the form (optional)
    Private Sub AdminViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optionally, load data on form load
        ' btnLoad.PerformClick() ' Uncomment to automatically load data on form load
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Return
        End If

        Dim studentID As String = DataGridView1.SelectedRows(0).Cells("studentID").Value.ToString()

        If MessageBox.Show($"Are you sure you want to delete student {studentID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM NewStudent WHERE studentID = @studentID"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@studentID", studentID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Student deleted successfully.")
                        btnLoad.PerformClick() ' Reload data
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Clear()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub
End Class

