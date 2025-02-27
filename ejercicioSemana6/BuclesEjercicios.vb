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

    Function ejemploDoWhileLoop(number As Integer)
        Dim valor As Integer
        valor = 0
        Do While valor < number
            Console.WriteLine(valor * valor)
            valor = valor + 1
        Loop
    End Function

    Function ejemploDWhileLoop(number As Integer)
        Dim valor As Integer
        valor = 100
        Do

            Console.WriteLine(number)
            number = number + 1
        Loop While valor > number
    End Function

End Class
