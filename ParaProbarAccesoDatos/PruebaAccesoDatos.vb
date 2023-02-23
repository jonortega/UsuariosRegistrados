Module PruebaAccesoDatos

    Sub Main()
        Dim accesoDatos As New AccesoDatos.AccesoDatos()

        Console.WriteLine("Acceso a datos conectado")
        Console.WriteLine("Introduce un numero referente a la accion que quieras realizar: " + vbCrLf + "1:Insertar usuario " + vbCrLf + "2:Obtener usuario" + vbCrLf + "3:Comprobar usuario " + vbCrLf + "4:Modificar contraseña usuario" + vbCrLf + "5:Cerrar conexion")

        Dim val As Integer = Console.ReadLine()
        Select Case val
            Case 1
                Console.WriteLine("Introduce un")
            Case 2
                Console.WriteLine("Introduce la direccion de email")
                Dim correo As String = Console.ReadLine()
                accesoDatos.ErabiltzaileakLortu(correo)
            Case 3

            Case 4
            Case 5
            Case Else
                Console.WriteLine("Numero invalido, introduce un numero referente a la accion que quieras realizar")

        End Select

        Console.ReadLine()




    End Sub

End Module
