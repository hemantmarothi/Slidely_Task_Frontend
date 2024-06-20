Imports System.Net.Http
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Drawing.Drawing2D

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private timer As Timer
    Private submissionInProgress As Boolean = False
    Private endPoint As String = "http://localhost:3000/submit"

    ' Phone Number validation
    Private Sub TextBoxNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Check if the character is not a digit and not a control character
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Function to check if a URL is valid
    Private Function IsValidUrl(url As String) As Boolean
        Dim result As Uri = Nothing
        Return Uri.TryCreate(url, UriKind.Absolute, result) AndAlso
               (result.Scheme = Uri.UriSchemeHttp Or result.Scheme = Uri.UriSchemeHttps)
    End Function

    ' Function to check if an email is valid
    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        ' Initialize and configure the timer
        timer = New Timer()
        timer.Interval = 1000 ' 1000 milliseconds = 1 second
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Start() ' Start the timer immediately

        ' Update the stopwatch label initially
        UpdateStopwatchLabel()

        ' Attach Paint event to all buttons
        AttachPaintEventToButtons(Me)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        ' Update the stopwatch label every second
        UpdateStopwatchLabel()
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            BtnToggleStopwatch_Click(Nothing, EventArgs.Empty)
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            ' Ensure the click event is not triggered multiple times
            If Not btnSubmit.Focused Then
                btnSubmit.PerformClick()
            End If
        End If
    End Sub

    Private Sub BtnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        ' Update the label text with the elapsed time of the stopwatch
        lblStopwatchTime.Text = If(stopwatch.Elapsed.Hours >= 10,
            String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed).TrimStart("0"c),
            String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed))
    End Sub

    Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If submissionInProgress Then
            Return
        End If

        ' Validate form fields before proceeding
        If Not ValidateFormFields() Then
            Return
        End If

        submissionInProgress = True
        btnSubmit.Enabled = False

        Try
            Await SubmitDataAsync()
        Finally
            btnSubmit.Enabled = True
            submissionInProgress = False
        End Try
    End Sub

    Private Function ValidateFormFields() As Boolean
        Dim Message As String = ""

        ' Validate email
        If Not IsValidEmail(TextBox2.Text) Then
            Message += "Please enter a valid Email Address. (Example - username@domain.com)" + Environment.NewLine
        End If

        ' Validate phone number length
        If TextBox3.Text.Length <> 10 Then
            Message += "Please enter a valid 10-digit Phone Number. (Example - 1234567890)" + Environment.NewLine
        End If

        ' Validate URL
        If Not IsValidUrl(TextBox4.Text) Then
            Message += "Please enter a valid GitHub Link. (Example - https://example.com)" + Environment.NewLine
        End If

        If Not Message.Equals("") Then
            MessageBox.Show(Message, "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Async Function SubmitDataAsync() As Task
        Dim submissionData As New Dictionary(Of String, String)()
        ' Populate submissionData with form data
        submissionData("name") = TextBox1.Text
        submissionData("email") = TextBox2.Text
        submissionData("phone") = TextBox3.Text
        submissionData("github_link") = TextBox4.Text
        submissionData("stopwatch_time") = stopwatch.Elapsed.ToString("hh\:mm\:ss")

        Dim json As String = JsonConvert.SerializeObject(submissionData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync(endPoint, content)
                response.EnsureSuccessStatusCode()

                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show("Data submitted successfully.")
            Catch ex As HttpRequestException
                MessageBox.Show("Error submitting data: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub AttachPaintEventToButtons(control As Control)
        For Each ctrl As Control In control.Controls
            If TypeOf ctrl Is Button Then
                AddHandler CType(ctrl, Button).Paint, AddressOf Button_Paint
            ElseIf ctrl.HasChildren Then
                AttachPaintEventToButtons(ctrl)
            End If
        Next
    End Sub

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
