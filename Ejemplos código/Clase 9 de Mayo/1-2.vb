Module ejercicio1

	Sub main()
  	Dim matriz = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25}
  	Dim suma As Integer = 0
  	Dim x As Integer = 0		


		'For x As Integer = 0 To matriz.GetUpperBound(0)
		'	suma = suma + matriz(x)
			
		'Next x


		While x < 25
		suma = suma + matriz(x)
		x += 1
		End While

                 System.Console.WriteLine(" La suma es: {0}", suma)

End Sub

End Module
