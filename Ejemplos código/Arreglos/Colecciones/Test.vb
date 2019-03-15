Public Class Test
	Public Shared Sub Main()
		
		Dim coleccion As New Collection()
		Dim cuenta01 As CCuenta = New CCuenta()
		cuenta01.Nombre = "AIEP"
		cuenta01.Cuenta = "Cuenta Corriente 1"
		cuenta01.TipoDeInteres = 2.5
		
		cuenta01.ingreso(12000)
                cuenta01.reintegro(3000)
                cuenta01.ingreso(12000)
		
		coleccion.Add(cuenta01)

		System.Console.WriteLine("Nombre: " & coleccion(1).Nombre)
		System.Console.WriteLine("Cuenta: " & coleccion(1).Cuenta)
		System.Console.WriteLine("Saldo: " & coleccion(1).Saldo)
		System.Console.WriteLine("Interés: " & coleccion(1).TipoDeInteres)
	End Sub
End Class
