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
        Me.btnRowWise = New System.Windows.Forms.Button()
        Me.btnColWise = New System.Windows.Forms.Button()
        Me.btnAllData = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRowWise
        '
        Me.btnRowWise.Location = New System.Drawing.Point(92, 134)
        Me.btnRowWise.Name = "btnRowWise"
        Me.btnRowWise.Size = New System.Drawing.Size(244, 75)
        Me.btnRowWise.TabIndex = 0
        Me.btnRowWise.Text = "Display data items row wise"
        Me.btnRowWise.UseVisualStyleBackColor = True
        '
        'btnColWise
        '
        Me.btnColWise.Location = New System.Drawing.Point(92, 284)
        Me.btnColWise.Name = "btnColWise"
        Me.btnColWise.Size = New System.Drawing.Size(244, 75)
        Me.btnColWise.TabIndex = 1
        Me.btnColWise.Text = "Display data items column wise"
        Me.btnColWise.UseVisualStyleBackColor = True
        '
        'btnAllData
        '
        Me.btnAllData.Location = New System.Drawing.Point(522, 134)
        Me.btnAllData.Name = "btnAllData"
        Me.btnAllData.Size = New System.Drawing.Size(244, 75)
        Me.btnAllData.TabIndex = 2
        Me.btnAllData.Text = "Display all data items at once"
        Me.btnAllData.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(522, 284)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(244, 75)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search for a person"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 537)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAllData)
        Me.Controls.Add(Me.btnColWise)
        Me.Controls.Add(Me.btnRowWise)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRowWise As Button
    Friend WithEvents btnColWise As Button
    Friend WithEvents btnAllData As Button
    Friend WithEvents btnSearch As Button
End Class
