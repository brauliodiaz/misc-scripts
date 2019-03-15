Public Class Test
	Public Shared Sub Main()
		
		Dim matriz() As CCuenta = New CCuenta(10) {}
		Dim cuenta01 As CCuenta = New CCuenta()
		cuenta01.Nombre = "AIEP"
		cuenta01.Cuenta = "Cuenta Corriente 1"
		cuenta01.TipoDeInteres = 2.5
		
		cuenta01.ingreso(12000)
                cuenta01.reintegro(3000)
                cuenta01.ingreso(12000)
		
		matriz(0) = cuenta01

		System.Console.WriteLine("Nombre: " & matriz(0).Nombre)
		System.Console.WriteLine("Cuenta: " & matriz(0).Cuenta)
		System.Console.WriteLine("Saldo: " & matriz(0).Saldo)
		System.Console.WriteLine("Interés: " & matriz(0).TipoDeInteres)
	End Sub
End Class
