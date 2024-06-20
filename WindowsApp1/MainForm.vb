Imports System.Drawing.Drawing2D

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        ' Attach Paint event to all buttons
        AttachPaintEventToButtons(Me)
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            If Application.OpenForms.OfType(Of CreateSubmissionForm)().Any() Then
                MessageBox.Show("Create Submission form is already open.")
            Else
                OpenCreateSubmissionForm()
            End If
        End If
    End Sub

    Private Sub BtnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub BtnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        If Not Application.OpenForms.OfType(Of CreateSubmissionForm)().Any() Then
            OpenCreateSubmissionForm()
        End If
    End Sub

    Private Sub OpenCreateSubmissionForm()
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

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

    Private Sub MainForm_Load_1(sender As Object, e As EventArgs)

    End Sub
End Class
