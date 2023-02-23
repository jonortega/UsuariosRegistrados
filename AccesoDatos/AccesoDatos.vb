﻿Imports System.Data.SqlClient

Public Class AccesoDatos

    Private Shared conSGTA_DB_Erabiltzaileak As SqlConnection

    Private Sub New()
    End Sub

    Public Shared Sub Konektatu()
        Dim strconSGTA_DB_Erabiltzaileak As String = "Server=tcp:2023hads.database.windows.net,1433;Initial Catalog=HADS2023;Persist Security Info=False;User ID=pmartinez073@ikasle.ehu.eus@2023hads;Password=HolaBuenas123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
        Try
            conSGTA_DB_Erabiltzaileak =
            New SqlConnection(strconSGTA_DB_Erabiltzaileak)
            conSGTA_DB_Erabiltzaileak.Open()
        Catch ex As Exception
            Throw New ErroreaKonektatzean()
        End Try
    End Sub

    Public Shared Sub ItxiKonexioa()
        conSGTA_DB_Erabiltzaileak.Close()
    End Sub

    Public Shared Function ErabiltzaileaTxertatu(ByVal strEmail As String) As Integer
        'txertatutako erregistro kopurua (Integer) itzultzen du emaitzatzat
        Dim cmdErabiltzaileaTxertatu As SqlCommand
        Dim strSQL As String = "INSERT INTO Erabiltzaileak (email) VALUES ('" & strEmail & "')"
        cmdErabiltzaileaTxertatu = New SqlCommand(strSQL, conSGTA_DB_Erabiltzaileak)
        Try
            Return cmdErabiltzaileaTxertatu.ExecuteNonQuery() 'saiatu INSERT-a exekutatzen
        Catch
            Throw New ErroreaTxertatzean()
        End Try
    End Function
End Class