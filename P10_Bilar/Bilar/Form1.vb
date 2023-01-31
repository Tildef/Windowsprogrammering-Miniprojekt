Imports System.ComponentModel.Design.Serialization
Imports System.Data.OleDb


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' connecta till databaskopplingen i modData
        DbConnect()

        ' Utför funktionen reloadT som hämtar alla länder, fyller trädvyn och sorterar dem 
        reloadT()

        ' Gömmer "lägg till ny bilmodell" knappen
        btnNewCarModel.Visible = False
    End Sub

    Private Sub reloadT()
        ' Clearar trädvyn
        tvwCountries.Nodes.Clear()

        ' Hämtar alla länder från countries tabellen i databasen
        Dim dtCountries As DataTable = hamtaData("SELECT * FROM countries")

        ' Fyll trädvyn med alla länderna
        fyllTrad(dtCountries, 0, Nothing, "Name", "CountryID")

        ' Sorterar listan i bokstavsordning
        tvwCountries.Sort()

    End Sub

    Private Sub fyllTrad(tabell As DataTable, parentId As Integer, nod As TreeNode, name As String, tag As String)
        ' For Each loop för att fylla trädet
        For Each row As DataRow In tabell.Rows

            ' Skapa en ny trädnode och sätt text till den
            Dim child As New TreeNode
            child.Text = row(name).ToString

            ' Sätt en tag som möjliggör sökning av "child"
            child.Tag = tag & "=" & row(tag)

            If parentId = 0 Then
                ' Om det är en rot-nod, lägg noden i trädvyn
                tvwCountries.Nodes.Add(child)

                ' Hämta information om bilmärken som tillhör de olika länderna
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
            ' Rot nod = (countries) visa alla bilmärken från den noden
            showDataGrid("SELECT * FROM car_brands where " & e.Node.Tag)

            ' Förhindra att man kan lägga till bilmodell
            btnNewCarModel.Visible = False

            ' Ändra/Ta bort knappen blir aktiverad
            btnChangeRemove.Enabled = True
        Else
            ' BilmärkenNoden, visa alla bilmodeller från bilmärket
            showDataGrid("SELECT * FROM car_models where " & e.Node.Tag)

            ' Tillåt att man kan lägga till bilmodeller
            btnNewCarModel.Visible = True

            ' Ändra/Ta bort knappen blir oaktiverad
            btnChangeRemove.Enabled = False

        End If
    End Sub

    Private Sub showDataGrid(sql As String)
        ' Rensa data som finns redan
        grdDetail.DataSource = Nothing

        ' Hämta ny data
        grdDetail.DataSource = hamtaData(sql)

        ' Justera automatiskt för innehållet (och inte för rubrikerna)
        grdDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders

        ' Dölj id-kolumnen
        grdDetail.Columns(0).Visible = False
    End Sub

    Private Sub btnNewCountry_Click(sender As Object, e As EventArgs) Handles btnNewCountry.Click
        ' Om frmNewCountry visar ok 
        If frmNewCountry.ShowDialog() = DialogResult.OK Then
            ' Ladda om trädvyn
            reloadT()
        End If
    End Sub

    Private Sub btnNewCarBrand_Click(sender As Object, e As EventArgs) Handles btnNewCarBrand.Click
        ' Om frmNewCarBrand visar ok 
        If frmNewCarBrand.ShowDialog() = DialogResult.OK Then
            ' Ladda om trädvyn
            reloadT()
        End If
    End Sub

    Private Sub btnNewCarModel_Click(sender As Object, e As EventArgs) Handles btnNewCarModel.Click
        ' Den valda nodens tag har formatet *CarBrandId=XXX" dvs CarBrandId-talet börjar i position 11
        Dim CarBrandID As Integer = tvwCountries.SelectedNode.Tag.ToString.Substring(11)
        frmNewCarModel.CarbrandId = CarBrandID

        ' Om frmNewCarModel visar ok
        If frmNewCarModel.ShowDialog() = DialogResult.OK Then
            ' Visa allt från car_models tabellen till den noden man klickat på
            showDataGrid("SELECT * FROM car_models where " & tvwCountries.SelectedNode.Tag)
        End If
    End Sub

    Private Sub btnChangeRemove_Click(sender As Object, e As EventArgs) Handles btnChangeRemove.Click
        ' Noden har formatet "CountryID=XXX" så CountryID börjar i position 10
        Dim countryId As Integer = tvwCountries.SelectedNode.Tag.ToString.Substring(10)
        frmNewCountry.countryid = countryId

        ' Om frmNewCountry visar ok
        If frmNewCountry.ShowDialog() = DialogResult.OK Then
            ' Ladda om trädvyn
            reloadT()
        End If
    End Sub

End Class

