Class CCuenta
	'Atributos
	Private _nombre As String
	Private _cuenta As String
	Private _saldo As String
	Private _tipoDeInteres As String
	
	'Metodos
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
	
	
	Public Property Cuenta() As String
		Get
			Return _cuenta
		End Get
		Set(ByVal cue As String)
			If cue.Length = 0 Then
				System.Console.WriteLine("Error: Cadena Vacía")
			Else
				_cuenta = cue 
			End If
			
		End Set
	End Property
	
	Public ReadOnly Property Saldo() As Double
		Get
			Return _saldo
		End Get
	End Property
	
	Public Sub ingreso(ByVal cantidad as Double)
		If cantidad < 0 Then
			System.Console.WriteLine("Error: Cantidad negativa")
		Else 
			_saldo = _saldo + cantidad
		End If
	End Sub
	
	Public Sub reintegro(ByVal cantidad As Double)
		If _saldo - cantidad < 0 Then
			System.Console.WriteLine("Error: no dispone de saldo suficiente.")
		Else
			_saldo = _saldo - cantidad
		End If
	End Sub
	
	Public Property TipoDeInteres() As Double 
		Get
			Return _tipoDeInteres
		End Get
		Set (ByVal tipo As Double)
			If tipo < 0 Then
				System.Console.WriteLine("Error: tipo no válido")
			Else
				_tipoDeInteres = tipo
			End If
		End Set
	End Property
End Class