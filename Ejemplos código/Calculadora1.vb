Module Module1

    Sub Main()
        Dim a, b As Integer


        System.Console.WriteLine("***** Calculadora *****")

        System.Console.WriteLine("Ingrese el primer número: ")
        a = System.Console.ReadLine()

        System.Console.WriteLine("Ingrese el segundo número: ")
        b = System.Console.ReadLine()

        System.Console.WriteLine("Ingrese operación a realizar:" + vbCr + "1.- Suma  2.- Resta  3.- Multiplicación  4.- División 5.- Salir ")
        Dim opcion = System.Console.ReadLine()

        Select Case opcion
            Case 1
                System.Console.WriteLine("Resultado Suma: {0}", a + b)
            Case 2
                System.Console.WriteLine("Resultado Resta: {0}", a - b)
            Case 3
                System.Console.WriteLine("Resultado Multiplicación: {0}", a * b)
            Case 4
                System.Console.WriteLine("Resultado División: {0}", a / b)
            Case 5
                System.Console.WriteLine("Saliendo del sistema. Presione una tecla para continuar...")
                System.Console.Read()
                Environment.Exit(0)




            Case Else
                System.Console.WriteLine("opción no válida")
        End Select
        System.Console.WriteLine("Presione una tecla para continuar...")
        System.Console.Read()
    End Sub

End Module
