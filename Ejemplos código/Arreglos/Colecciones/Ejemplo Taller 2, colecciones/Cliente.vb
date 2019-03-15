Class Cliente
	'Atributos
	Private _rut As String
	Private _nombre As String
	Private _apellido As String
	Private _edad As Integer
	Private _estadoCivil As String
	Private _ciudadOrigen As String
	Private _tiendaCompra As String
	Private _depMasGusto As String
	Private _depMenosGusto As String
	Private _nota As Double
	
	'Metodos
	Public Property Rut() As String
		Get
			Return _rut
		End Get
		Set(ByVal nom As String)
			If nom.Length = 0 Then
				System.Console.WriteLine("Error: Cadena Vacía")
			Else
				_rut = nom 
			End If
			
		End Set
	End Property
	
	Public Property Nombre() As String
		Get
			Return _nombre
		End Get
		Set(ByVal nom As String)
			If nom.Length = 0 Then
				System.Console.WriteLine("Error: Cadena Vacía")
			Else
				_nombre = nom 
			End If
			
		End Set
	End Property
	Public Property Apellido() As String
		Get
			Return _apellido
		End Get
		Set(ByVal nom As String)
			If nom.Length = 0 Then
				System.Console.WriteLine("Error: Cadena Vacía")
			Else
				_apellido = nom 
			End If
			
		End Set
	End Property
	Public Property Edad() As Integer
		Get
			Return _edad
		End Get
		Set(ByVal nom As Integer)
			
				_edad = nom 
			
		End Set
	End Property
	Public Property EstadoCivil() As String
		Get
			Return _estadoCivil
		End Get
		Set(ByVal nom As String)
			If nom.Length = 0 Then
				System.Console.WriteLine("Error: Cadena Vacía")
			Else
				_estadoCivil = nom 
			End If
			
		End Set
	End Property
	Public Property CiudadOrigen() As String
		Get
			Return _ciudadOrigen
		End Get
		Set(ByVal nom As String)
			If nom.Length = 0 Then
				System.Console.WriteLine("Error: Cadena Vacía")
			Else
				_ciudadOrigen = nom 
			End If
			
		End Set
	End Property
	Public Property TiendaCompra() As String
		Get
			Return _tiendaCompra
		End Get
		Set(ByVal nom As String)
			If nom.Length = 0 Then
				System.Console.WriteLine("Error: Cadena Vacía")
			Else
				_tiendaCompra = nom 
			End If
			
		End Set
	End Property
	Public Property DepMasGusto() As String
		Get
			Return _depMasGusto
		End Get
		Set(ByVal nom As String)
			If nom.Length = 0 Then
				System.Console.WriteLine("Error: Cadena Vacía")
			Else
				_depMasGusto = nom 
			End If
			
		End Set
	End Property
	Public Property DepMenosGusto() As String
		Get
			Return _depMenosGusto
		End Get
		Set(ByVal nom As String)
			If nom.Length = 0 Then
				System.Console.WriteLine("Error: Cadena Vacía")
			Else
				_depMenosGusto = nom 
			End If
			
		End Set
	End Property
	Public Property Nota() As Double
		Get
			Return _nota
		End Get
		Set(ByVal nom As Double)
			
				_nota = nom 
			
		End Set
	End Property
End Class
