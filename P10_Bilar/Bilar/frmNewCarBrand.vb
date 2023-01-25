Imports System.Data.OleDb

Public Class frmNewCarBrand

    Private Sub frmNewCarBrand_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Rensa textrutan 
        txtCarBrand.Text = ""

        'Fyll comboboxen
        cboCountry.DataSource = hamtaData("select * from countries order by name")
        cboCountry.DisplayMember = "name"
        cboCountry.ValueMember = "CountryId"

        'Disabla spara-knappen
        btnSave.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Skapa en dataadapter för koppling mot tabellen
        Dim dataAdapter As New OleDb.OleDbDataAdapter("select * from car_brands", con)

        'Skapa en commandBuilder för enklare hantering av insert updates
        Dim commandBuilder As New OleDbCommandBuilder(dataAdapter)
        Dim dbRow As DataRow
        Dim ds As New DataSet

        'Fyll adaptern
        dataAdapter.Fill(ds, "car_brands")

        'Skapa ny rad
        dbRow = ds.Tables("car_brands").NewRow

        'Tilldela raden värden från formuläret
        dbRow.Item("name") = txtCarBrand.Text
        dbRow.Item("CountryId") = cboCountry.SelectedValue

        'Lägg till raden i datasettet
        ds.Tables("car_brands").Rows.Add(dbRow)

        'Uppdatera dataadaptern
        dataAdapter.Update(ds, "car_brands")

        'Skicka tillbaka ok
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtCarBrand_TextChanged(sender As Object, e As EventArgs) Handles txtCarBrand.TextChanged
        If txtCarBrand.Text = "" Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub
End Class