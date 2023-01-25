<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCarBrand
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
        Me.lblNewCarBrand = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.lblCarBrand = New System.Windows.Forms.Label()
        Me.txtCarBrand = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNewCarBrand
        '
        Me.lblNewCarBrand.AutoSize = True
        Me.lblNewCarBrand.Location = New System.Drawing.Point(144, 18)
        Me.lblNewCarBrand.Name = "lblNewCarBrand"
        Me.lblNewCarBrand.Size = New System.Drawing.Size(86, 15)
        Me.lblNewCarBrand.TabIndex = 0
        Me.lblNewCarBrand.Text = "New Car Brand"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(158, 83)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(50, 15)
        Me.lblCountry.TabIndex = 1
        Me.lblCountry.Text = "Country"
        '
        'cboCountry
        '
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Location = New System.Drawing.Point(94, 113)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(191, 23)
        Me.cboCountry.TabIndex = 2
        '
        'lblCarBrand
        '
        Me.lblCarBrand.AutoSize = True
        Me.lblCarBrand.Location = New System.Drawing.Point(158, 176)
        Me.lblCarBrand.Name = "lblCarBrand"
        Me.lblCarBrand.Size = New System.Drawing.Size(59, 15)
        Me.lblCarBrand.TabIndex = 3
        Me.lblCarBrand.Text = "Car Brand"
        '
        'txtCarBrand
        '
        Me.txtCarBrand.Location = New System.Drawing.Point(94, 205)
        Me.txtCarBrand.Name = "txtCarBrand"
        Me.txtCarBrand.Size = New System.Drawing.Size(191, 23)
        Me.txtCarBrand.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSave.Location = New System.Drawing.Point(94, 260)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 32)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUndo.Location = New System.Drawing.Point(208, 260)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(77, 32)
        Me.btnUndo.TabIndex = 6
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'frmNewCarBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(380, 337)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtCarBrand)
        Me.Controls.Add(Me.lblCarBrand)
        Me.Controls.Add(Me.cboCountry)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblNewCarBrand)
        Me.Name = "frmNewCarBrand"
        Me.Text = "frmNewCarBrand"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewCarBrand As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents cboCountry As ComboBox
    Friend WithEvents lblCarBrand As Label
    Friend WithEvents txtCarBrand As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUndo As Button
End Class
