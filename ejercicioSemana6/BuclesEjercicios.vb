Public Class BuclesEjercicios

    Function pasoApaso(number As Integer)
        Dim i As Integer

        For i = 0 To number
            Console.WriteLine(i)
        Next
    End Function

    Function forEachejemplo(num1 As Integer,
                            num2 As Integer,
                            num3 As Integer)

        Dim miArray(2) As Integer
        miArray(0) = num1
        miArray(1) = num2
        miArray(2) = num3

        For Each temp In miArray
            Dim v As Integer = temp
            Dim valor1 = Integer.Parse(Console.ReadLine())
            Console.WriteLine(temp & " + " & valor1)
            Console.WriteLine(v + valor1)


        Next


    End Function

End Class
