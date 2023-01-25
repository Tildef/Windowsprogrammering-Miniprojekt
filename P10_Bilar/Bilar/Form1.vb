Imports System.ComponentModel.Design.Serialization
Imports System.Data.OleDb


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
        reloadT()
    End Sub

    Private Sub reloadT()
        tvwCountries.Nodes.Clear()

        ' Hämta alla länder
        Dim dtCountries As DataTable = hamtaData("SELECT * FROM countries")

        ' Fyll trädvyn med länder
        fyllTrad(dtCountries, 0, Nothing, "Name", "CountryID")

        ' Sortera listan
        tvwCountries.Sort()

    End Sub

    Private Sub fyllTrad(tabell As DataTable, parentId As Integer, nod As TreeNode, name As String, tag As String)
        ' Rekursiv funktion för att fylla trädet
        For Each row As DataRow In tabell.Rows
            ' Skapa en ny trädnode och sätta text
            Dim child As New TreeNode
            child.Text = row(name).ToString
            ' Sätt en tag som möjliggör sökning av "barn"
            child.Tag = tag & "=" & row(tag)

            If parentId = 0 Then
                ' Det är en rot-nod, lägg noden i trädvyn
                tvwCountries.Nodes.Add(child)
                ' Hämta information om ländernas bilmärken
                Dim dtCarBrand As DataTable = hamtaData("SELECT * from car_brands where " & child.Tag)
                fyllTrad(dtCarBrand, row(tag), child, "Name", "CarBrandId")
            Else
                ' Tilldela noden till ovanliggande nod
                nod.Nodes.Add(child)
            End If
        Next
    End Sub

    Private Sub tvwCountries_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvwCountries.NodeMouseClick
        lblNodTag.Text = e.Node.Tag
        If IsNothing(e.Node.Parent) Then
            ' Rot nod (countries) visa alla bilmärken
            showDataGrid("SELECT * FROM car_brands where " & e.Node.Tag)

            'Förhindra att man kan lägga till bilmodell
            btnNewCarModel.Enabled = False
            btnChangeRemove.Enabled = True
        Else
            ' BilmärkenNod, visa alla bilmodeller
            showDataGrid("SELECT * FROM car_models where " & e.Node.Tag)

            'Tillåt att man kan lägga till bilmodeller
            btnNewCarModel.Enabled = True
            btnChangeRemove.Enabled = False

        End If
    End Sub

    Private Sub showDataGrid(sql As String)
        ' Rensa befintlig data
        grdDetail.DataSource = Nothing

        ' Hämta ny data
        grdDetail.DataSource = hamtaData(sql)

        ' Autojustera för innehållet (och inte för rubrikerna)
        grdDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders

        ' Dölj id-kolumnen
        grdDetail.Columns(0).Visible = False
    End Sub

    Private Sub btnNewCountry_Click(sender As Object, e As EventArgs) Handles btnNewCountry.Click
        If frmNewCountry.ShowDialog() = DialogResult.OK Then
            'Ladda om trädvyn
            reloadT()
        End If
    End Sub

    Private Sub btnNewCarBrand_Click(sender As Object, e As EventArgs) Handles btnNewCarBrand.Click
        If frmNewCarBrand.ShowDialog() = DialogResult.OK Then
            'Ladda om trädvyn
            reloadT()
        End If
    End Sub


End Class

