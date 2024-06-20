<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.Heading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Khaki
        Me.btnViewSubmissions.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnViewSubmissions.FlatAppearance.BorderSize = 2
        Me.btnViewSubmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewSubmissions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnViewSubmissions.Location = New System.Drawing.Point(15, 100)
        Me.btnViewSubmissions.Margin = New System.Windows.Forms.Padding(5)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(750, 60)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCreateSubmission.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCreateSubmission.FlatAppearance.BorderSize = 2
        Me.btnCreateSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateSubmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnCreateSubmission.Location = New System.Drawing.Point(15, 180)
        Me.btnCreateSubmission.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(750, 60)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        AddHandler Me.btnCreateSubmission.Click, AddressOf Me.BtnCreateSubmission_Click
        '
        'Heading
        '
        Me.Heading.AutoSize = True
        Me.Heading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Heading.Location = New System.Drawing.Point(40, 40)
        Me.Heading.Name = "Heading"
        Me.Heading.Size = New System.Drawing.Size(683, 39)
        Me.Heading.TabIndex = 2
        Me.Heading.Text = "John Doe, Slidely Task 2 - Slidely Form App"
        Me.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 273)
        Me.Controls.Add(Me.Heading)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        AddHandler Load, AddressOf Me.MainForm_Load_1
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents Heading As Label
End Class
