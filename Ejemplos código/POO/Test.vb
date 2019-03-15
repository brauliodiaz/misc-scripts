Public Class Test
	Public Shared Sub Main()
		Dim cuenta01 As CCuenta = New CCuenta()
		cuenta01.Nombre = "AIEP"
		cuenta01.Cuenta = "Cuenta Corriente 1"
		cuenta01.TipoDeInteres = 2.5
		
		cuenta01.ingreso(12000)
        cuenta01.reintegro(3000)
        cuenta01.ingreso(12000)
		
		System.Console.WriteLine("Nombre: " & cuenta01.Nombre)
		System.Console.WriteLine("Cuenta: " &cuenta01.Cuenta)
		System.Console.WriteLine("Saldo: " &cuenta01.Saldo)
		System.Console.WriteLine("Interés: " &cuenta01.TipoDeInteres)
	End Sub
End Class