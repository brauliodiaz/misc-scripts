Module Module1
    Sub Main()
	Dim Valor1 As Integer
   
    While True
	On Error GoTo Controlador1
        System.Console.WriteLine("Ingrese un Número: ")
        Valor1 = System.Console.ReadLine()
        Exit While
    Controlador1:
        System.Console.WriteLine("Valor ingresado no es número. Intente nuevamente")
        
End While
    System.Console.WriteLine("El valor ingresado es {0}",Valor1)
    End Sub
End Module 

