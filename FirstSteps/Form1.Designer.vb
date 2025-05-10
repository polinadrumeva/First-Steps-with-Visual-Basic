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
        Me.btnSum = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.Panel()
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSum
        '
        Me.btnSum.BackColor = System.Drawing.Color.Chocolate
        Me.btnSum.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSum.Location = New System.Drawing.Point(228, 163)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(203, 73)
        Me.btnSum.TabIndex = 0
        Me.btnSum.Text = "PRESS"
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel.Controls.Add(Me.btnSum)
        Me.panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.panel.Location = New System.Drawing.Point(73, 20)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(653, 395)
        Me.panel.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSum As Button
    Friend WithEvents panel As Panel
End Class
