Imports Mysql.Data.MysqlClient
Module Module1

    Sub Main()
  
        Dim ConexionString As String = "server=xxx.xxx.xxx.xxx;Uid=taller;Pwd=xxxxxxxx;Database=usuarios;"
        Dim conexion As New MySqlConnection(ConexionString)

        Try 

        conexion.Open()

        catch 
        
        Console.Writeline("Error.")
        
        End Try
        Dim comando As String = "select * from user"
        Dim consulta As New MysqlCommand(comando, conexion)

        Dim lector As MySqlDataReader = consulta.ExecuteReader()

        While lector.Read

        Console.Writeline(lector.GetString(0) & VbTab & lector.GetString(1) & VbTab & lector.GetString(2) ) 

        End While

        
        Console.ReadKey()



     End Sub

End Module
