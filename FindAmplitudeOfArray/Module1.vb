Module Module1

    Sub Main()
		Dim oRnd = New Random()
		Console.WriteLine("Input a count of elements:")
		Dim nElems As Integer
		Integer.TryParse(Console.ReadLine(), nElems)
		If nElems = 0 Then
			Console.WriteLine("Empty arrays not allowed")
			Console.Read()
			Return
		End If
		Console.WriteLine($"Generating array by filling {nElems}:")
		Dim iNumbers(nElems - 1) As Integer
		For i As Integer = 0 To nElems - 1
			iNumbers(i) = oRnd.Next(1, 100)
			Console.Write(iNumbers(i) & " ")
		Next i
		Dim iMax = iNumbers(0)
		Dim iMin = iNumbers(0)
		Dim nMaxIndex = 0
		Dim nMinIndex = 0
		For i As Integer = 1 To nElems - 1
			If iNumbers(i) > iMax Then
				iMax = iNumbers(i)
				nMaxIndex = i
			End If
			If iNumbers(i) < iMin Then
				iMin = iNumbers(i)
				nMinIndex = i
			End If
		Next i
		Console.WriteLine(String.Format(vbCrLf & "Found maximum element:{0} with index {1}", iMax, nMaxIndex))
		Console.WriteLine(String.Format("Found minimum element:{0} with index {1}", iMin, nMinIndex))
		Console.WriteLine($"Found amplitude: {iMax - iMin}")
		Console.Read()
	End Sub

End Module
