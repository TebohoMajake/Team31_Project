<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisease
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
        Me.grdDisplay = New UJGrid.UJGrid()
        Me.btnAddC = New System.Windows.Forms.Button()
        Me.btnSelectC = New System.Windows.Forms.Button()
        Me.txtExplorer = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grdDisplay
        '
        Me.grdDisplay.FixedCols = 1
        Me.grdDisplay.FixedRows = 1
        Me.grdDisplay.Location = New System.Drawing.Point(240, 68)
        Me.grdDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDisplay.Name = "grdDisplay"
        Me.grdDisplay.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDisplay.Size = New System.Drawing.Size(526, 344)
        Me.grdDisplay.TabIndex = 0
        '
        'btnAddC
        '
        Me.btnAddC.Location = New System.Drawing.Point(22, 35)
        Me.btnAddC.Name = "btnAddC"
        Me.btnAddC.Size = New System.Drawing.Size(161, 58)
        Me.btnAddC.TabIndex = 1
        Me.btnAddC.Text = "Add Country"
        Me.btnAddC.UseVisualStyleBackColor = True
        '
        'btnSelectC
        '
        Me.btnSelectC.Location = New System.Drawing.Point(22, 113)
        Me.btnSelectC.Name = "btnSelectC"
        Me.btnSelectC.Size = New System.Drawing.Size(161, 56)
        Me.btnSelectC.TabIndex = 2
        Me.btnSelectC.Text = "Select Country"
        Me.btnSelectC.UseVisualStyleBackColor = True
        '
        'txtExplorer
        '
        Me.txtExplorer.Enabled = False
        Me.txtExplorer.Location = New System.Drawing.Point(251, 39)
        Me.txtExplorer.Name = "txtExplorer"
        Me.txtExplorer.Size = New System.Drawing.Size(505, 22)
        Me.txtExplorer.TabIndex = 3
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(22, 315)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(161, 52)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDI
        '
        Me.btnDI.Location = New System.Drawing.Point(22, 194)
        Me.btnDI.Name = "btnDI"
        Me.btnDI.Size = New System.Drawing.Size(161, 55)
        Me.btnDI.TabIndex = 5
        Me.btnDI.Text = "View Disease Info"
        Me.btnDI.UseVisualStyleBackColor = True
        '
        'frmDisease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDI)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtExplorer)
        Me.Controls.Add(Me.btnSelectC)
        Me.Controls.Add(Me.btnAddC)
        Me.Controls.Add(Me.grdDisplay)
        Me.Name = "frmDisease"
        Me.Text = "Disease Control App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdDisplay As UJGrid.UJGrid
    Friend WithEvents btnAddC As Button
    Friend WithEvents btnSelectC As Button
    Friend WithEvents txtExplorer As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDI As Button
End Class
