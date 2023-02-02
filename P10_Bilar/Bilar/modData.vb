Imports System.Data.OleDb
Imports System.Data

Module modData
    Public con As New OleDb.OleDbConnection
    Public dsBilar As New DataSet
    Public daBilar As New OleDbDataAdapter

    Public Function DbConnect()
        ' Kombinera sökvägar, databasens namn mm till en dbSource
        Dim dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        Dim dbName As String = "Miniprojekt2.accdb"
        Dim dbPath As String = "C:\Users\TildeFagerström\Documents\GitHub\Windowsprogrammering-Miniprojekt\Miniprojekt"
        Dim dbSource As String = "Data source=" & dbPath & "\" & dbName
        Dim sql As String


        ' Sätt ihop kopplingssträngen med variablerna ovan
        con.ConnectionString = dbProvider & dbSource


        ' Öppna databasen
        con.Open()


        ' Välj data att visa allt från tabellen countries
        sql = "SELECT * FROM countries"


        ' Koppla in databasen och fyll den
        daBilar = New OleDbDataAdapter(sql, con)
        daBilar.MissingSchemaAction = MissingSchemaAction.AddWithKey
        daBilar.Fill(dsBilar, "Miniprojekt")

    End Function

    Public Function hamtaData(sql As String) As DataTable
        ' Skapa en Datatable för returen
        Dim dt As New DataTable

        ' Skapa ett kommandoobjekt för att läsa databasen
        Dim cmd As New OleDbCommand(sql, con)

        ' Skapa en dataadapter för att köra kommandot
        Dim da As New OleDbDataAdapter(cmd)

        ' Fyll returobjektet
        da.Fill(dt)

        ' Returnera datatabellen
        Return dt
    End Function

End Module
