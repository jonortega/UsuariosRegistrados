Imports System.Data.SqlClient

Public Class AccesoDatos

    Private Shared conSGTA_DB_Erabiltzaileak As SqlConnection
    Private Shared cmdErabiltzailea As SqlCommand

    Private Sub New()
    End Sub

    Public Shared Sub Konektatu()
        Dim strconSGTA_DB_Erabiltzaileak As String = "Server=tcp:2023hads.database.windows.net,1433;Initial Catalog=HADS2023;Persist Security Info=False;User ID=pmartinez073@ikasle.ehu.eus@2023hads;Password=HolaBuenas123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
        Try
            conSGTA_DB_Erabiltzaileak = New SqlConnection(strconSGTA_DB_Erabiltzaileak)
            conSGTA_DB_Erabiltzaileak.Open()
        Catch ex As Exception
            Throw New ErroreaKonektatzean()
        End Try
    End Sub

    Public Shared Sub ItxiKonexioa()
        conSGTA_DB_Erabiltzaileak.Close()
    End Sub

    Public Shared Function ErabiltzaileaTxertatu(ByVal strEmail As String, ByVal strIzena As String, ByVal strAbizena As String, ByVal strGalderaEzkutua As String, ByVal strErantzuna As String, ByVal strNa As Integer, ByVal strEgiaztatzeZenbakia As Integer, ByVal strEgiaztatua As Byte, ByVal strLanTaldeKodea As String, ByVal strAzpitaldeKodea As String, ByVal strErabiltzaileMota As String, ByVal strPasahitza As String) As Integer
        'txertatutako erregistro kopurua (Integer) itzultzen du emaitzatzat
        Dim strSQL As String = "INSERT INTO Erabiltzaileak (email,izena,abizena,galderaEzkutua,erantzuna,na,egiaztatzeZenbakia,egiaztatua,lantaldeKodea,azpitaldeKodea,erabiltzaileMota,pasahitza) VALUES ('" & strEmail & "','" & strIzena & "','" & strAbizena & "','" & strGalderaEzkutua & "','" & strErantzuna & "'," & strNa & "," & strEgiaztatzeZenbakia & "," & strEgiaztatua & ",'" & strLanTaldeKodea & "','" & strAzpitaldeKodea & "','" & strErabiltzaileMota & "','" & strPasahitza & "')"
        cmdErabiltzailea = New SqlCommand(strSQL, conSGTA_DB_Erabiltzaileak)
        Try
            Return cmdErabiltzailea.ExecuteNonQuery() 'saiatu INSERT-a exekutatzen
        Catch
            Throw New ErroreaTxertatzean()
        End Try
    End Function


    Public Shared Function ErabiltzaileakLortu(ByVal strEmail As String) As SqlDataReader
        Dim strSQL = "SELECT * FROM Erabiltzaileak WHERE (email) = ('" & strEmail & "')"
        cmdErabiltzailea = New SqlCommand(strSQL, conSGTA_DB_Erabiltzaileak)
        Try
            Return (cmdErabiltzailea.ExecuteReader())
        Catch
            Throw New ErroreaIrakurtzean()
        End Try
    End Function

    Public Shared Function ErabiltzaileaEgiaztatu(ByVal strEmail As String) As Integer
        Dim strSQL As String = "UPDATE Erabiltzaileak SET egiaztatua = 1 WHERE (email) = ('" & strEmail & "')"
        Try
            Dim intNumRegistrosAfectados As Integer = 0
            cmdErabiltzailea = New SqlCommand(strSQL, conSGTA_DB_Erabiltzaileak)
            intNumRegistrosAfectados = cmdErabiltzailea.ExecuteNonQuery()
            Return intNumRegistrosAfectados
        Catch ex As Exception
            Throw New ErroreaAldatzean()
        End Try
    End Function


    Public Shared Function ErabiltzailearenPasahitzaAldatu(ByVal strEmail As String, ByVal strcontra As String) As Integer
        Dim strSQL = "UPDATE Erabiltzaileak SET pasahitza = ('" & strcontra & "') WHERE (email) = ('" & strEmail & "')"
        Try
            cmdErabiltzailea = New SqlCommand(strSQL, conSGTA_DB_Erabiltzaileak)
            Dim numRegistrosAfectados As Integer = cmdErabiltzailea.ExecuteNonQuery()
            Return numRegistrosAfectados
        Catch
            Throw New ErroreaAldatzean()
        End Try
    End Function

End Class
