Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmNewCountry
    Private dataAdapter As OleDbDataAdapter
    Private dbRow As DataRow
    Private ds As New DataSet
    Public countryid As Integer = -1

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ' Svara att vi abryter formen
        DialogResult = DialogResult.Cancel

        ' Formuläret stängs när man trycker på kappen
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Skapa dataadapter och tilldela data via datakopplingen i modData
        dataAdapter = New OleDbDataAdapter("select * from countries", con)

        ' Skapa CommandBuilder så att vi slipper skriva insert/update-kod
        Dim commandBuilder As New OleDbCommandBuilder(dataAdapter)

        ' Fyll raden med data från formuläret
        dbRow.Item("Name") = txtNewCountry.Text

        ' Uppdatera tabellen countries
        dataAdapter.Update(ds, "countries")

        ' Meddela att allt är ok
        DialogResult = DialogResult.OK

        ' Stäng formuläret
        Me.Close()
    End Sub

    Private Sub frmNewCountry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cleara datasetet
        ds.Clear()

        ' Hämta data om countryId inte är lika med -1
        If countryid <> -1 Then

            ' Skapa Dataadapter och tilldela data via datakopplingen i modData
            dataAdapter = New OleDbDataAdapter("select * from countries where countryid=" & countryid, con)

            ' Fyll datasetet från dataadaptern
            dataAdapter.Fill(ds, "countries")

            ' Läs in till en datarow
            dbRow = ds.Tables("countries").Rows(0)
            txtNewCountry.Text = dbRow.Item("name")

            ' Aktivera spara knappen
            btnSave.Enabled = True

            ' Visa radera knappen
            btnDelete.Visible = True

        Else
            ' Skapa dataadapter och tilldela data via datakopplingen i modData
            dataAdapter = New OleDb.OleDbDataAdapter("select * from countries", con)

            ' Fyll datasetet från dataadaptern
            dataAdapter.Fill(ds, "countries")

            ' Läs in en till en datarow
            dbRow = ds.Tables("countries").NewRow

            ' Lägg till dataraden till datasetet
            ds.Tables("countries").Rows.Add(dbRow)

            ' Nollställ textrutan
            txtNewCountry.Text = ""

            ' Avaktivera spara knappen
            btnSave.Enabled = False

            ' Dölj Radera knappen
            btnDelete.Visible = False
        End If
    End Sub

    Private Sub txtNewCountry_TextChanged(sender As Object, e As EventArgs) Handles txtNewCountry.TextChanged
        ' Aktivera spara knappen om texten inte är tom
        If txtNewCountry.Text <> "" Then
            btnSave.Enabled = True
        Else
            ' Annars oaktivera den
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Lägg till en msg box som har ett yes/no fomulär och fråga om man vill radera landet
        If MsgBox("Are you sure you wanna delete this country?", vbYesNo + vbQuestion) = vbYes Then

            ' Skapa en commandBuilder
            Dim commandBuilder As New OleDbCommandBuilder(dataAdapter)

            ' Radera aktuell post och uppdatera dataadaptern
            ds.Tables("countries").Rows(0).Delete()
            dataAdapter.Update(ds, "countries")

            ' Returnera Ok!
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub frmNewCountry_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Antag att nästa gång formuläret öppnas är det för att lägga till ny artist
        countryid = -1
    End Sub


End Class