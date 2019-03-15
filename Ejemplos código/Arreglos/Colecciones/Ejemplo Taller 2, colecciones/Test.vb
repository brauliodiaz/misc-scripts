Public Class Test
	Public Shared Sub Main()
		
		Dim coleccion As New Collection()
		Dim Cliente1 As Cliente = New Cliente()
		
		Cliente1.Rut = "12.345.678-9"
		Cliente1.Nombre = "Braulio"
		Cliente1.Apellido = "Díaz"
		Cliente1.Edad = 30
		Cliente1.EstadoCivil = "Soltero"
		Cliente1.CiudadOrigen = "Curicó"
		Cliente1.TiendaCompra = "Talca"
		Cliente1.DepMasGusto = "Tecnología"
		Cliente1.DepMenosGusto = "Calzado"
		Cliente1.Nota = 6
		
		coleccion.Add(Cliente1,Cliente1.Rut())
		
		System.Console.WriteLine("*****  Cliente 1    *****")
		System.Console.WriteLine("Nombre: " & coleccion.Item("12.345.678-9").Nombre())
		System.Console.WriteLine("Cuenta: " & coleccion.Item("12.345.678-9").Rut())

		Dim Cliente2 As Cliente = New Cliente()
		
		Cliente2.Rut = "11.111.111-1"
		Cliente2.Nombre = "Braulio_2"
		Cliente2.Apellido = "Díaz"
		Cliente2.Edad = 30
		Cliente2.EstadoCivil = "Soltero"
		Cliente2.CiudadOrigen = "Curicó"
		Cliente2.TiendaCompra = "Talca"
		Cliente2.DepMasGusto = "Tecnología"
		Cliente2.DepMenosGusto = "Calzado"
		Cliente2.Nota = 5
		
		coleccion.Add(Cliente2,Cliente2.Rut())
		System.Console.WriteLine("*****  Cliente 2    *****")
		System.Console.WriteLine("Nombre: " & coleccion.Item("11.111.111-1").Nombre())
		System.Console.WriteLine("Cuenta: " & coleccion.Item("11.111.111-1").Rut())
		
	End Sub
End Class
