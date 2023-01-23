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
        Me.SuspendLayout()
        '
        'lblNewCountry
        '
        Me.lblNewCountry.AutoSize = True
        Me.lblNewCountry.Location = New System.Drawing.Point(217, 58)
        Me.lblNewCountry.Name = "lblNewCountry"
        Me.lblNewCountry.Size = New System.Drawing.Size(77, 15)
        Me.lblNewCountry.TabIndex = 0
        Me.lblNewCountry.Text = "New Country"
        '
        'txtNewCountry
        '
        Me.txtNewCountry.Location = New System.Drawing.Point(139, 117)
        Me.txtNewCountry.Name = "txtNewCountry"
        Me.txtNewCountry.Size = New System.Drawing.Size(247, 23)
        Me.txtNewCountry.TabIndex = 1
        '
        'frmNewCountry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 344)
        Me.Controls.Add(Me.txtNewCountry)
        Me.Controls.Add(Me.lblNewCountry)
        Me.Name = "frmNewCountry"
        Me.Text = "frmNewCountry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewCountry As Label
    Friend WithEvents txtNewCountry As TextBox
End Class
