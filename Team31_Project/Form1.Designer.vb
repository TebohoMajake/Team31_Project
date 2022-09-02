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
        Me.UjGrid1 = New UJGrid.UJGrid()
        Me.SuspendLayout()
        '
        'UjGrid1
        '
        Me.UjGrid1.FixedCols = 1
        Me.UjGrid1.FixedRows = 1
        Me.UjGrid1.Location = New System.Drawing.Point(316, 131)
        Me.UjGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.UjGrid1.Name = "UjGrid1"
        Me.UjGrid1.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.UjGrid1.Size = New System.Drawing.Size(335, 195)
        Me.UjGrid1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UjGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UjGrid1 As UJGrid.UJGrid
End Class
