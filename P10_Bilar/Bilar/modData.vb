Imports System.Data.OleDb

Module modData
    Public con As New OleDb.OleDbConnection
    Public dsBilar As New DataSet
    Public daBilar As OleDbDataAdapter

    Public Sub dbConnect()
        'Kombinera sökvägar, databasens namn mm till en dbSouce
        Dim dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        Dim dbName As String = "Miniprojekt.accdb"
        Dim dbPath As String = "C:\Users\TildeFagerström\Documents\GitHub\Windowsprogrammering-Miniprojekt\Miniprojekt"
        Dim dbSource As String = "Data source=" & dbPath & "\" & dbName
        Dim sql As String


        'Sätt ihop kopplingssträngen med variablerna ovan
        con.ConnectionString = dbProvider & dbSource


        'Öppna databasen
        con.Open()


        'Välj data att visa
        'sql = "SELECT * FROM adresser"


        'Koppla in databasen och fyll den
        'daBilar = New OleDbDataAdapter(sql, con)
        'daBilar.MissingSchemaAction = MissingSchemaAction.AddWithKey
        'daBilar.Fill(dsBilar, "Adressbok")

    End Sub

    Public Function hamtaData(sql As String) As DataTable
        ' Skapa en Datatable för returen
        Dim dt As New DataTable

        ' Skapa ett kommandoobjekt för att läsa databasen
        Dim cmd As New OleDb.OleDbConnection(sql, cnChinook())

        ' Skapa en dataadapter för att exekvera kommandot
        Dim da As New SQLite.SQLiteDataAdapter(cmd)

        ' Fyll returobjektet
        da.Fill(dt)

        ' Returnera datatabellen
        Return dt
    End Function
End Module
