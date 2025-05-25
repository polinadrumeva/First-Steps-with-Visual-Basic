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
        Me.btnLinearSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLinearSearch
        '
        Me.btnLinearSearch.BackColor = System.Drawing.Color.LightCoral
        Me.btnLinearSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLinearSearch.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnLinearSearch.Font = New System.Drawing.Font("Pristina", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLinearSearch.Location = New System.Drawing.Point(187, 159)
        Me.btnLinearSearch.Name = "btnLinearSearch"
        Me.btnLinearSearch.Size = New System.Drawing.Size(394, 109)
        Me.btnLinearSearch.TabIndex = 0
        Me.btnLinearSearch.Text = "Linear Search"
        Me.btnLinearSearch.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLinearSearch)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLinearSearch As Button
End Class
