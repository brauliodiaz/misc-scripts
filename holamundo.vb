'Primer programa en VB.NET
Module Modulo1
Sub Main()
	Dim nombre As string
	System.Console.WriteLine("Ingrese un texto: ")
	nombre = System.Console.ReadLine()  
	System.Console.WriteLine("El texto ingresado es: " & nombre)
	System.Console.WriteLine("Presione una tecla para terminar")
	System.Console.ReadKey()

End Sub
End Module  