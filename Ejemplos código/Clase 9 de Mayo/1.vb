module ejercicio1

	Sub main()
  'Dim matriz As Integer() {1,2,3,4,5,6,7,8,9,0,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25}
	Dim matriz(24) As Integer
		For i As Integer = 0 To 24
			matriz(i) = i + 1		
					
		Next i

		For x As Integer = 0 To matriz.GetUpperBound(0)
			If matriz(x) Mod 2 = 0 Then	
				System.Console.WriteLine("{0} es Par", matriz(x))
			Else
				System.Console.WriteLine("{0} es Impar", matriz(x))	
			End If		
		Next x

End Sub

End Module
