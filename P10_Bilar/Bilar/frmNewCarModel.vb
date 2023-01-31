Imports System.Data.OleDb

Public Class frmNewCarModel
    Public CarbrandId As Integer = -1
    Private Sub frmNewCarModel_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Visa CarBrand ID
        lblCarBrand.Text = CarbrandId

        ' töm textrutorna
        txtName.Text = ""
        txtEngineSize.Text = ""
        txtFuel.Text = ""
        txtConsumption.Text = ""


    End Sub

    Private Sub txtEngineSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEngineSize.KeyPress, txtConsumption.KeyPress
        'Tillåter att man kan skriva in en punkt 
        If e.KeyChar = "."c AndAlso InStr(sender.text, ".") > 0 Then
            e.Handled = True
        End If

        ' Tillåter att man kan skriva in siffor mellan 0-9 och punkt
        If (e.KeyChar < "0"c OrElse e.KeyChar > "9"c) AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Skapa en dataadapter mot tabellen car_models
        Dim dataadapter As New OleDb.OleDbDataAdapter("select * from car_models", con)

        ' Skapa en commandbuilder
        Dim commandBuilder As New OleDbCommandBuilder(dataadapter)

        ' Skapa en datarad och dataset för att tillfälligt lagra informationen
        Dim dbRow As DataRow
        Dim ds As New DataSet

        ' Fyll dataadaptern
        dataadapter.Fill(ds, "Carmodels")

        ' Skapa ny rad och fyll den med data från formuläret 
        dbRow = ds.Tables("Carmodels").NewRow
        dbRow.Item("Name") = txtName.Text
        dbRow.Item("EngineSize") = Val(txtEngineSize.Text)
        dbRow.Item("Fuel") = txtFuel.Text
        dbRow.Item("Consumption") = Val(txtConsumption.Text)
        dbRow.Item("CarBrandID") = lblCarBrand.Text
        dbRow.Item("YearModel") = cboYearModel.Text

        ' Lägg till dataraden i datasettet
        ds.Tables("Carmodels").Rows.Add(dbRow)

        ' Uppdatera dataadaptern
        dataadapter.Update(ds, "Carmodels")

        ' Skicka tillbaka ok
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ' Avbryter formuläret
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, txtEngineSize.TextChanged, txtFuel.TextChanged, txtConsumption.TextChanged
        ' Om textrutorna är tomma
        If txtName.Text = "" OrElse txtEngineSize.Text = "" OrElse txtFuel.Text = "" OrElse txtConsumption.Text = "" Then
            ' Oaktivera spararknappen 
            btnSave.Enabled = False
        Else
            ' Annars aktivera den
            btnSave.Enabled = True
        End If
    End Sub


End Class