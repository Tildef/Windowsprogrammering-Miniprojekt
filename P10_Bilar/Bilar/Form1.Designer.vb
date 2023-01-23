<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tvwCountries = New System.Windows.Forms.TreeView()
        Me.grdDetail = New System.Windows.Forms.DataGridView()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNodTag = New System.Windows.Forms.Label()
        Me.btnChangeRemove = New System.Windows.Forms.Button()
        Me.btnNewCarModel = New System.Windows.Forms.Button()
        Me.btnNewCarBrand = New System.Windows.Forms.Button()
        Me.btnNewCountry = New System.Windows.Forms.Button()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvwCountries
        '
        Me.tvwCountries.BackColor = System.Drawing.Color.Azure
        Me.tvwCountries.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvwCountries.Location = New System.Drawing.Point(0, 0)
        Me.tvwCountries.Name = "tvwCountries"
        Me.tvwCountries.Size = New System.Drawing.Size(237, 382)
        Me.tvwCountries.TabIndex = 0
        '
        'grdDetail
        '
        Me.grdDetail.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetail.Location = New System.Drawing.Point(237, 0)
        Me.grdDetail.Name = "grdDetail"
        Me.grdDetail.RowTemplate.Height = 25
        Me.grdDetail.Size = New System.Drawing.Size(563, 382)
        Me.grdDetail.TabIndex = 1
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.MintCream
        Me.pnlButtons.Controls.Add(Me.Label1)
        Me.pnlButtons.Controls.Add(Me.lblNodTag)
        Me.pnlButtons.Controls.Add(Me.btnChangeRemove)
        Me.pnlButtons.Controls.Add(Me.btnNewCarModel)
        Me.pnlButtons.Controls.Add(Me.btnNewCarBrand)
        Me.pnlButtons.Controls.Add(Me.btnNewCountry)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(237, 271)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(563, 111)
        Me.pnlButtons.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(447, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tag:"
        '
        'lblNodTag
        '
        Me.lblNodTag.AutoSize = True
        Me.lblNodTag.Location = New System.Drawing.Point(498, 76)
        Me.lblNodTag.Name = "lblNodTag"
        Me.lblNodTag.Size = New System.Drawing.Size(48, 15)
        Me.lblNodTag.TabIndex = 4
        Me.lblNodTag.Text = "NodTag"
        '
        'btnChangeRemove
        '
        Me.btnChangeRemove.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnChangeRemove.Location = New System.Drawing.Point(447, 17)
        Me.btnChangeRemove.Name = "btnChangeRemove"
        Me.btnChangeRemove.Size = New System.Drawing.Size(104, 32)
        Me.btnChangeRemove.TabIndex = 3
        Me.btnChangeRemove.Text = "Change/Remove"
        Me.btnChangeRemove.UseVisualStyleBackColor = False
        '
        'btnNewCarModel
        '
        Me.btnNewCarModel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNewCarModel.Location = New System.Drawing.Point(232, 17)
        Me.btnNewCarModel.Name = "btnNewCarModel"
        Me.btnNewCarModel.Size = New System.Drawing.Size(100, 32)
        Me.btnNewCarModel.TabIndex = 2
        Me.btnNewCarModel.Text = "New Car Model"
        Me.btnNewCarModel.UseVisualStyleBackColor = False
        '
        'btnNewCarBrand
        '
        Me.btnNewCarBrand.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNewCarBrand.Location = New System.Drawing.Point(120, 17)
        Me.btnNewCarBrand.Name = "btnNewCarBrand"
        Me.btnNewCarBrand.Size = New System.Drawing.Size(94, 32)
        Me.btnNewCarBrand.TabIndex = 1
        Me.btnNewCarBrand.Text = "New Car Brand"
        Me.btnNewCarBrand.UseVisualStyleBackColor = False
        '
        'btnNewCountry
        '
        Me.btnNewCountry.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNewCountry.Location = New System.Drawing.Point(6, 17)
        Me.btnNewCountry.Name = "btnNewCountry"
        Me.btnNewCountry.Size = New System.Drawing.Size(96, 32)
        Me.btnNewCountry.TabIndex = 0
        Me.btnNewCountry.Text = "New Country"
        Me.btnNewCountry.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 382)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.grdDetail)
        Me.Controls.Add(Me.tvwCountries)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlButtons.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvwCountries As TreeView
    Friend WithEvents grdDetail As DataGridView
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnChangeRemove As Button
    Friend WithEvents btnNewCarModel As Button
    Friend WithEvents btnNewCarBrand As Button
    Friend WithEvents btnNewCountry As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNodTag As Label
End Class
