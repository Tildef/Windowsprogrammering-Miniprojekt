<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCarModel
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
        Me.lblNewCarModel = New System.Windows.Forms.Label()
        Me.lblCarBrandId = New System.Windows.Forms.Label()
        Me.lblCarBrand = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEngineSize = New System.Windows.Forms.Label()
        Me.lblFuel = New System.Windows.Forms.Label()
        Me.lblConsumption = New System.Windows.Forms.Label()
        Me.lblYearModel = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEngineSize = New System.Windows.Forms.TextBox()
        Me.txtFuel = New System.Windows.Forms.TextBox()
        Me.txtConsumption = New System.Windows.Forms.TextBox()
        Me.cboYearModel = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNewCarModel
        '
        Me.lblNewCarModel.AutoSize = True
        Me.lblNewCarModel.BackColor = System.Drawing.Color.Transparent
        Me.lblNewCarModel.Location = New System.Drawing.Point(150, 24)
        Me.lblNewCarModel.Name = "lblNewCarModel"
        Me.lblNewCarModel.Size = New System.Drawing.Size(89, 15)
        Me.lblNewCarModel.TabIndex = 0
        Me.lblNewCarModel.Text = "New Car Model"
        '
        'lblCarBrandId
        '
        Me.lblCarBrandId.AutoSize = True
        Me.lblCarBrandId.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblCarBrandId.Location = New System.Drawing.Point(12, 81)
        Me.lblCarBrandId.Name = "lblCarBrandId"
        Me.lblCarBrandId.Size = New System.Drawing.Size(66, 15)
        Me.lblCarBrandId.TabIndex = 1
        Me.lblCarBrandId.Text = "CarBrandId"
        '
        'lblCarBrand
        '
        Me.lblCarBrand.AutoSize = True
        Me.lblCarBrand.Location = New System.Drawing.Point(159, 81)
        Me.lblCarBrand.Name = "lblCarBrand"
        Me.lblCarBrand.Size = New System.Drawing.Size(69, 15)
        Me.lblCarBrand.TabIndex = 2
        Me.lblCarBrand.Text = "lblCarBrand"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblName.Location = New System.Drawing.Point(12, 145)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 15)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblEngineSize
        '
        Me.lblEngineSize.AutoSize = True
        Me.lblEngineSize.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblEngineSize.Location = New System.Drawing.Point(12, 196)
        Me.lblEngineSize.Name = "lblEngineSize"
        Me.lblEngineSize.Size = New System.Drawing.Size(66, 15)
        Me.lblEngineSize.TabIndex = 4
        Me.lblEngineSize.Text = "Engine Size"
        '
        'lblFuel
        '
        Me.lblFuel.AutoSize = True
        Me.lblFuel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblFuel.Location = New System.Drawing.Point(12, 244)
        Me.lblFuel.Name = "lblFuel"
        Me.lblFuel.Size = New System.Drawing.Size(29, 15)
        Me.lblFuel.TabIndex = 5
        Me.lblFuel.Text = "Fuel"
        '
        'lblConsumption
        '
        Me.lblConsumption.AutoSize = True
        Me.lblConsumption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblConsumption.Location = New System.Drawing.Point(12, 290)
        Me.lblConsumption.Name = "lblConsumption"
        Me.lblConsumption.Size = New System.Drawing.Size(80, 15)
        Me.lblConsumption.TabIndex = 6
        Me.lblConsumption.Text = "Consumption"
        '
        'lblYearModel
        '
        Me.lblYearModel.AutoSize = True
        Me.lblYearModel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblYearModel.Location = New System.Drawing.Point(12, 344)
        Me.lblYearModel.Name = "lblYearModel"
        Me.lblYearModel.Size = New System.Drawing.Size(66, 15)
        Me.lblYearModel.TabIndex = 7
        Me.lblYearModel.Text = "Year Model"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(110, 142)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(177, 23)
        Me.txtName.TabIndex = 8
        '
        'txtEngineSize
        '
        Me.txtEngineSize.Location = New System.Drawing.Point(110, 188)
        Me.txtEngineSize.Name = "txtEngineSize"
        Me.txtEngineSize.Size = New System.Drawing.Size(177, 23)
        Me.txtEngineSize.TabIndex = 9
        '
        'txtFuel
        '
        Me.txtFuel.Location = New System.Drawing.Point(110, 236)
        Me.txtFuel.Name = "txtFuel"
        Me.txtFuel.Size = New System.Drawing.Size(177, 23)
        Me.txtFuel.TabIndex = 10
        '
        'txtConsumption
        '
        Me.txtConsumption.Location = New System.Drawing.Point(110, 282)
        Me.txtConsumption.Name = "txtConsumption"
        Me.txtConsumption.Size = New System.Drawing.Size(177, 23)
        Me.txtConsumption.TabIndex = 11
        '
        'cboYearModel
        '
        Me.cboYearModel.FormattingEnabled = True
        Me.cboYearModel.Items.AddRange(New Object() {"2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950"})
        Me.cboYearModel.Location = New System.Drawing.Point(110, 336)
        Me.cboYearModel.Name = "cboYearModel"
        Me.cboYearModel.Size = New System.Drawing.Size(177, 23)
        Me.cboYearModel.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSave.Location = New System.Drawing.Point(110, 386)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 32)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUndo.Location = New System.Drawing.Point(210, 386)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(77, 32)
        Me.btnUndo.TabIndex = 14
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'frmNewCarModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(410, 454)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboYearModel)
        Me.Controls.Add(Me.txtConsumption)
        Me.Controls.Add(Me.txtFuel)
        Me.Controls.Add(Me.txtEngineSize)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblYearModel)
        Me.Controls.Add(Me.lblConsumption)
        Me.Controls.Add(Me.lblFuel)
        Me.Controls.Add(Me.lblEngineSize)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCarBrand)
        Me.Controls.Add(Me.lblCarBrandId)
        Me.Controls.Add(Me.lblNewCarModel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewCarModel"
        Me.Text = "frmNewCarModel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewCarModel As Label
    Friend WithEvents lblCarBrandId As Label
    Friend WithEvents lblCarBrand As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEngineSize As Label
    Friend WithEvents lblFuel As Label
    Friend WithEvents lblConsumption As Label
    Friend WithEvents lblYearModel As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEngineSize As TextBox
    Friend WithEvents txtFuel As TextBox
    Friend WithEvents txtConsumption As TextBox
    Friend WithEvents cboYearModel As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUndo As Button
End Class
