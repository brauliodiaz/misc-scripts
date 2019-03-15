Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class BaseDeDatos

' Se declaran los componentes, para acceder a la Base de Datos 
	Private ConexionConBD As OleDbConnection
	Private Orden As OleDbCommand
	Private Lector As OleDbDataReader

	'Método para leer BD
	Public Sub LeerDeBaseDeDatos()

		'Se declara el string de conexión (acceso a archivo local de base de datos)
		Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=C:\Users\xxxxx\Documents\testdb.mdb;"
		
		'"Data Source=C:.\..\..\tfnos.mdb;"

		'Se inicializa el conector, utilizando el string de conexión
		ConexionConBD = New OleDbConnection(strConexion)

		'Se crea un string con la consulta para obtener los datos	
		Dim consulta As String = "SELECT nombre, telefono from telefonos"
		Orden = New OleDbCommand(consulta, ConexionConBD)

		'Abre conexión con Base de datos
		ConexionConBD.Open()

		'Realizar la consulta (devuelve un OleDbDataReader)
		Lector = Orden.ExecuteReader()

		'Nota: llamar siempre a Read antes de acceder a los datos
		While Lector.Read()

			Console.WriteLine(Lector("nombre") + " " + Lector("telefono"))

		End While

		'Debe cerrarse Lector una vez utlizado

		Lector.Close()
	End Sub

	Public Sub CerrarConexion()

		If (Not Lector Is Nothing)
			Lector.Close()
		End If

		If (Not ConexionConBD Is Nothing)
			ConexionConBd.Close()
		End If

	End Sub

	Public Shared Sub Main()

		Dim bd As BaseDeDatos = New BaseDeDatos()
		try
			bd.LeerDeBaseDeDatos()
		Catch e As Exception
			Console.WriteLine("Error: " + e.Message)
		Finally
			bd.CerrarConexion()
		End Try
	End Sub
End Class












