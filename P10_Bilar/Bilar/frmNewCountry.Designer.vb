<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCountry
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
        Me.lblNewCountry = New System.Windows.Forms.Label()
        Me.txtNewCountry = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNewCountry
        '
        Me.lblNewCountry.AutoSize = True
        Me.lblNewCountry.Location = New System.Drawing.Point(138, 43)
        Me.lblNewCountry.Name = "lblNewCountry"
        Me.lblNewCountry.Size = New System.Drawing.Size(77, 15)
        Me.lblNewCountry.TabIndex = 0
        Me.lblNewCountry.Text = "New Country"
        '
        'txtNewCountry
        '
        Me.txtNewCountry.Location = New System.Drawing.Point(74, 78)
        Me.txtNewCountry.Name = "txtNewCountry"
        Me.txtNewCountry.Size = New System.Drawing.Size(201, 23)
        Me.txtNewCountry.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSave.Location = New System.Drawing.Point(28, 126)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 31)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUndo.Location = New System.Drawing.Point(112, 126)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(66, 31)
        Me.btnUndo.TabIndex = 3
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(237, 126)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 31)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'frmNewCountry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(363, 211)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNewCountry)
        Me.Controls.Add(Me.lblNewCountry)
        Me.Name = "frmNewCountry"
        Me.Text = "frmNewCountry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewCountry As Label
    Friend WithEvents txtNewCountry As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnDelete As Button
End Class
