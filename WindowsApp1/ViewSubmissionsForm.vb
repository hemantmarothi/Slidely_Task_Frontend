Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Drawing.Drawing2D

Public Class ViewSubmissionsForm
    Private index As Integer = 0
    Private fetchingInProgress As Boolean = False
    Private endPoint = "http://localhost:3000/read"

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        ' Attach Paint event to all buttons
        AttachPaintEventToButtons(Me)

        ' Call the method to make the GET request
        Await FetchSubmissionsAsync(index)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            NavigatePrevious()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            NavigateNext()
        End If
    End Sub

    Private Async Function FetchSubmissionsAsync(index As Integer) As Task
        If fetchingInProgress Then
            Return
        End If

        fetchingInProgress = True

        Using client As New HttpClient()
            Try
                ' Build the request URI with the query parameter
                Dim requestUri As String = endPoint + $"?index={index}"

                ' Make the GET request
                Dim response As HttpResponseMessage = Await client.GetAsync(requestUri)
                response.EnsureSuccessStatusCode()

                ' Read and process the response content
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize JSON response to your data model (adjust as per your API response structure)
                Dim data As ApiResponse = JsonConvert.DeserializeObject(Of ApiResponse)(responseBody)

                ' Display data in UI
                If data.success Then
                    UpdateUI(data.submission)
                Else
                    MessageBox.Show("Failed to fetch submission.")
                End If

            Catch ex As HttpRequestException
                index -= 2
                MessageBox.Show($"Error fetching data: {ex.Message}")
            End Try
        End Using

        fetchingInProgress = False
    End Function

    Private Sub UpdateUI(submission As SubmissionData)
        ' Update the UI with the submission data
        TextBox1.Text = submission.name
        TextBox2.Text = submission.email
        TextBox3.Text = submission.phone
        TextBox4.Text = submission.github_link
        TextBox5.Text = submission.stopwatch_time
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        NavigatePrevious()
    End Sub

    Private Async Sub NavigatePrevious()
        If fetchingInProgress Then
            Return
        End If

        If index > 0 Then
            index -= 1
            Await FetchSubmissionsAsync(index)
        Else
            MessageBox.Show("Already at the beginning.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        NavigateNext()
    End Sub

    Private Async Sub NavigateNext()
        If fetchingInProgress Then
            Return
        End If

        index += 1
        Await FetchSubmissionsAsync(index)
    End Sub

    ' Define your data model classes based on the structure of the API response
    Private Class ApiResponse
        Public Property success As Boolean
        Public Property submission As SubmissionData
    End Class

    Private Class SubmissionData
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class

    ' Attach Paint event to all buttons
    Private Sub AttachPaintEventToButtons(control As Control)
        For Each ctrl As Control In control.Controls
            If TypeOf ctrl Is Button Then
                AddHandler CType(ctrl, Button).Paint, AddressOf Button_Paint
            ElseIf ctrl.HasChildren Then
                AttachPaintEventToButtons(ctrl)
            End If
        Next
    End Sub

    ' Paint event handler for buttons to create rounded corners and 2-pixel border
    Private Sub Button_Paint(sender As Object, e As PaintEventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim rect As New Rectangle(0, 0, btn.Width, btn.Height)
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()

        ' Add arcs to create rounded corners
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(btn.Width - radius, 0, radius, radius), -90, 90)
        path.AddArc(New Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, btn.Height - radius, radius, radius), 90, 90)
        path.CloseAllFigures()

        btn.Region = New Region(path)

        ' Draw the background and text
        Using brush As New SolidBrush(btn.BackColor)
            e.Graphics.FillPath(brush, path)
        End Using
        TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, rect, btn.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)

        ' Draw the border
        Using pen As New Pen(btn.ForeColor, 2)
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub
End Class
