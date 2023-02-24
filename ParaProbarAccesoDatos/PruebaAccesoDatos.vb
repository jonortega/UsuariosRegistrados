Imports System.Data.SqlClient

Module PruebaAccesoDatos

    Sub Main()

        Try
            AccesoDatos.AccesoDatos.Konektatu()
            Console.WriteLine("Acceso a datos conectado.")
        Catch ex As AccesoDatos.ErroreaKonektatzean
            Console.WriteLine("Error al contectarse a la BD!")
        End Try

        While True
            DrawMenu()
            Dim seleccion As Integer = Console.ReadLine()

            Select Case seleccion
                Case 1
                    Console.WriteLine("Introduzca los siguientes campos")
                    Console.WriteLine("-------------------------------------")
                    Console.Write("Nombre: ")
                    Dim nombre As String = Console.ReadLine()
                    Console.Write("Apellido: ")
                    Dim apellido As String = Console.ReadLine()
                    Console.Write("Correo electronico. ")
                    Dim correo As String = Console.ReadLine()
                    Console.Write("Contrasenia: ")
                    Dim contrasenia As String = Console.ReadLine()
                    Console.Write("Pregunta oculta: ")
                    Dim pregunta As String = Console.ReadLine()
                    Console.Write("Respuesta a la pregunta oculta: ")
                    Dim respuesta As String = Console.ReadLine()
                    Console.Write("Numero de telefono (para verificacion): ")
                    Dim numTlf As Integer = Console.ReadLine()
                    Console.WriteLine("-------------------------------------")

                    Try
                        AccesoDatos.AccesoDatos.ErabiltzaileaTxertatu(correo, nombre, apellido, pregunta, respuesta, 0, numTlf, False, Nothing, Nothing, Nothing, contrasenia)
                    Catch ex As AccesoDatos.ErroreaTxertatzean
                        Console.WriteLine("Error al introducir los datos!")
                    Finally
                        AccesoDatos.AccesoDatos.ItxiKonexioa()
                    End Try

                    Console.WriteLine("Nuevo usuario creado!")
                Case 2
                    Console.Write("Introduce la direccion de email: ")
                    Dim correo As String = Console.ReadLine()
                    Dim usrData As SqlDataReader = Nothing

                    Try
                        usrData = AccesoDatos.AccesoDatos.ErabiltzaileakLortu(correo)
                    Catch ex As AccesoDatos.ErroreaIrakurtzean
                        Console.WriteLine("Error al introducir los datos!")
                    Finally
                        AccesoDatos.AccesoDatos.ItxiKonexioa()
                    End Try

                    Console.WriteLine("Datos extraidos sobre " & correo & ":")
                    Console.WriteLine(usrData)
                Case 3
                    Console.Write("Introduce la direccion de email: ")
                    Dim correo As String = Console.ReadLine()
                    Dim regAfectados As Integer

                    Try
                        regAfectados = AccesoDatos.AccesoDatos.ErabiltzaileaEgiaztatu(correo)
                    Catch ex As Exception
                        Console.WriteLine("Error al modificar los datos!")
                    Finally
                        AccesoDatos.AccesoDatos.ItxiKonexioa()
                    End Try

                    Console.WriteLine(regAfectados & " registro(s) verificado(s).")
                Case 4
                    Console.Write("Introduce la direccion de email: ")
                    Dim correo As String = Console.ReadLine()
                    Console.Write("Introduce la nueva contrasenia: ")
                    Dim contrasenia As String = Console.ReadLine()

                    Try
                        AccesoDatos.AccesoDatos.ErabiltzailearenPasahitzaAldatu(correo, contrasenia)
                    Catch ex As Exception
                        Console.WriteLine("Error al modificar los datos!")
                    Finally
                        AccesoDatos.AccesoDatos.ItxiKonexioa()
                    End Try

                    Console.WriteLine("Contrasenia actualizada.")
                Case 5
                    AccesoDatos.AccesoDatos.ItxiKonexioa()
                    Console.WriteLine("Conexion con la BD cerrada.")
                    Exit While
                Case Else
                    Console.WriteLine("Numero introducido no valido!")
            End Select
        End While

    End Sub

    Private Sub DrawMenu()
        Console.WriteLine()
        Console.WriteLine("1. Insertar usuario")
        Console.WriteLine("2. Obtener usuario")
        Console.WriteLine("3. Comprobar usuario")
        Console.WriteLine("4. Modificar contraseña usuario")
        Console.WriteLine("5. Cerrar conexion")
        Console.WriteLine()
        Console.Write("Introduce un numero referente a la accion que quieras realizar: ")
    End Sub

End Module
