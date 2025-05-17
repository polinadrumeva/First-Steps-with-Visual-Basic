<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pnl = New System.Windows.Forms.Panel()
        Me.lblGradeNumber = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtGradeNumber = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnGrading = New System.Windows.Forms.Button()
        Me.lblModResult = New System.Windows.Forms.Label()
        Me.txtResultGrading = New System.Windows.Forms.TextBox()
        Me.txtModNumber = New System.Windows.Forms.TextBox()
        Me.lblGradingResult = New System.Windows.Forms.Label()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.DarkGray
        Me.pnl.Controls.Add(Me.lblGradingResult)
        Me.pnl.Controls.Add(Me.txtModNumber)
        Me.pnl.Controls.Add(Me.txtResultGrading)
        Me.pnl.Controls.Add(Me.lblModResult)
        Me.pnl.Controls.Add(Me.lblGradeNumber)
        Me.pnl.Controls.Add(Me.lblNumber)
        Me.pnl.Controls.Add(Me.txtGradeNumber)
        Me.pnl.Controls.Add(Me.txtNumber)
        Me.pnl.Controls.Add(Me.btnMod)
        Me.pnl.Controls.Add(Me.btnGrading)
        Me.pnl.Location = New System.Drawing.Point(35, 14)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(666, 434)
        Me.pnl.TabIndex = 0
        '
        'lblGradeNumber
        '
        Me.lblGradeNumber.AutoSize = True
        Me.lblGradeNumber.Location = New System.Drawing.Point(129, 67)
        Me.lblGradeNumber.Name = "lblGradeNumber"
        Me.lblGradeNumber.Size = New System.Drawing.Size(58, 16)
        Me.lblGradeNumber.TabIndex = 5
        Me.lblGradeNumber.Text = " Степен"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(39, 145)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(47, 16)
        Me.lblNumber.TabIndex = 4
        Me.lblNumber.Text = "Число"
        '
        'txtGradeNumber
        '
        Me.txtGradeNumber.Location = New System.Drawing.Point(205, 61)
        Me.txtGradeNumber.Name = "txtGradeNumber"
        Me.txtGradeNumber.Size = New System.Drawing.Size(58, 22)
        Me.txtGradeNumber.TabIndex = 3
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(102, 139)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(117, 22)
        Me.txtNumber.TabIndex = 2
        '
        'btnMod
        '
        Me.btnMod.BackColor = System.Drawing.Color.LightGreen
        Me.btnMod.Location = New System.Drawing.Point(396, 209)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(175, 57)
        Me.btnMod.TabIndex = 1
        Me.btnMod.Text = "Модулно деление"
        Me.btnMod.UseVisualStyleBackColor = False
        '
        'btnGrading
        '
        Me.btnGrading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGrading.Location = New System.Drawing.Point(65, 209)
        Me.btnGrading.Name = "btnGrading"
        Me.btnGrading.Size = New System.Drawing.Size(175, 57)
        Me.btnGrading.TabIndex = 0
        Me.btnGrading.Text = "Степенуване"
        Me.btnGrading.UseVisualStyleBackColor = False
        '
        'lblModResult
        '
        Me.lblModResult.AutoSize = True
        Me.lblModResult.Location = New System.Drawing.Point(209, 296)
        Me.lblModResult.Name = "lblModResult"
        Me.lblModResult.Size = New System.Drawing.Size(223, 16)
        Me.lblModResult.TabIndex = 6
        Me.lblModResult.Text = "Резултат след модулно деление"
        '
        'txtResultGrading
        '
        Me.txtResultGrading.Location = New System.Drawing.Point(398, 61)
        Me.txtResultGrading.Name = "txtResultGrading"
        Me.txtResultGrading.Size = New System.Drawing.Size(212, 22)
        Me.txtResultGrading.TabIndex = 7
        '
        'txtModNumber
        '
        Me.txtModNumber.Location = New System.Drawing.Point(512, 139)
        Me.txtModNumber.Name = "txtModNumber"
        Me.txtModNumber.Size = New System.Drawing.Size(97, 22)
        Me.txtModNumber.TabIndex = 8
        '
        'lblGradingResult
        '
        Me.lblGradingResult.AutoSize = True
        Me.lblGradingResult.Location = New System.Drawing.Point(416, 25)
        Me.lblGradingResult.Name = "lblGradingResult"
        Me.lblGradingResult.Size = New System.Drawing.Size(193, 16)
        Me.lblGradingResult.TabIndex = 9
        Me.lblGradingResult.Text = "Резултат след степенуване"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl As Panel
    Friend WithEvents btnGrading As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents lblGradeNumber As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents txtGradeNumber As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtModNumber As TextBox
    Friend WithEvents txtResultGrading As TextBox
    Friend WithEvents lblModResult As Label
    Friend WithEvents lblGradingResult As Label
End Class
