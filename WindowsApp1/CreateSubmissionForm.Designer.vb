<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.Heading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblStopwatchTime = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Heading
        '
        Me.Heading.AutoSize = True
        Me.Heading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Heading.Location = New System.Drawing.Point(40, 40)
        Me.Heading.Name = "Heading"
        Me.Heading.Size = New System.Drawing.Size(683, 39)
        Me.Heading.TabIndex = 3
        Me.Heading.Text = "John Doe, Slidely Task 2 - Slidely Form App"
        Me.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(80, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(80, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(40, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 39)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Phone Num"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(40, 365)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 78)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "GitHub Link" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Task 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.Khaki
        Me.btnToggleStopwatch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnToggleStopwatch.FlatAppearance.BorderSize = 2
        Me.btnToggleStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(40, 500)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(450, 60)
        Me.btnToggleStopwatch.TabIndex = 8
        Me.btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.TextBox1.Location = New System.Drawing.Point(270, 140)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(490, 49)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.TextBox2.Location = New System.Drawing.Point(270, 220)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(490, 49)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.TextBox3.Location = New System.Drawing.Point(270, 300)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(490, 49)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.TextBox4.Location = New System.Drawing.Point(270, 380)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(490, 49)
        Me.TextBox4.TabIndex = 12
        '
        'lblStopwatchTime
        '
        Me.lblStopwatchTime.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStopwatchTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStopwatchTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblStopwatchTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblStopwatchTime.Location = New System.Drawing.Point(510, 503)
        Me.lblStopwatchTime.MinimumSize = New System.Drawing.Size(250, 55)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.ReadOnly = True
        Me.lblStopwatchTime.ShortcutsEnabled = False
        Me.lblStopwatchTime.Size = New System.Drawing.Size(250, 55)
        Me.lblStopwatchTime.TabIndex = 13
        Me.lblStopwatchTime.Text = "00:00:00"
        Me.lblStopwatchTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSubmit.FlatAppearance.BorderSize = 2
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(15, 650)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(750, 60)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        AddHandler Me.btnSubmit.Click, AddressOf Me.BtnSubmit_Click
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 800)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblStopwatchTime)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Heading)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        AddHandler Load, AddressOf Me.CreateSubmissionForm_Load
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Heading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblStopwatchTime As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Button1 As Button

End Class
