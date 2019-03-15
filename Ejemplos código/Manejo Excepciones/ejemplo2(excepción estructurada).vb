Module Module1
    Sub Main()
	Dim Valor1 As Integer
   While True
	Try
        System.Console.WriteLine("Ingrese un Número: ")
        Valor1 = System.Console.ReadLine()
        Exit While
    Catch
        System.Console.WriteLine("Valor ingresado no es número. Intente nuevamente")

    End Try
    End While 
        System.Console.WriteLine("El valor ingresado es {0}",Valor1)

    End Sub
End Module 

