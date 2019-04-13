Module Module1

    Sub Main()
        Multiplo()
        SumNum()
        Adivinar()
        Factorial()
        Tablas()
        Palabras()
        concatenacion()
        Oracion()
        ConjuntosAritmeticos()
    End Sub

    Sub Multiplo()
        Dim x As Integer = 0
        While x < 40
            If x Mod 2 > 0 Then
                Console.WriteLine(x)
            End If
            x += 1
        End While
        Console.ReadLine()
    End Sub

    Sub SumNum()
        Dim x As Integer
        Dim y As Integer = 0
        Console.WriteLine("Ingrese un numero entero.")
        x = Console.ReadLine()
        Dim cont As Integer = 0
        While y <= x
            cont += y
            y += 1
        End While
        Console.WriteLine($"Su numero ingresado es: {x}")
        Console.WriteLine($"La suma total es: {cont}")
        Console.ReadLine()
    End Sub

    Sub Adivinar()
        Dim numGenerado As Int16 = New Random().Next(11)
        Dim x As Integer
        Console.WriteLine("Ingrese un numero")
        x = Console.ReadLine()
        Do
            If numGenerado <> x Then
                Console.WriteLine("Numero incorrecto vuelva a intentarlo")
                x = Console.ReadLine()
            Else
                Console.WriteLine("Numero correcto")
                Console.ReadLine()
                Exit Do

            End If

        Loop


    End Sub

    Sub Factorial()
        Dim fac As Double
        Dim x As Integer
        Console.WriteLine("Ingrese un numero para saber su factor")
        fac = Console.ReadLine()
        For x = fac - 1 To 1 Step -1
            fac = fac * x
        Next x
        Console.WriteLine($"Su factor es {fac}")
        Console.ReadLine()
    End Sub

    Sub Tablas()
        Dim tabla As Integer
        Dim multi As Integer = 1
        Dim contador As Integer = 1
        Dim total As Integer
        Console.WriteLine("Ingrese la tabla que desea saber: ")
        tabla = Console.ReadLine()
        For multi = 1 To 10
            total = tabla * contador
            contador = contador + 1
            Console.WriteLine($"Su resultado es {total}")
        Next multi
        Console.ReadLine()
    End Sub

    Sub Palabras()
        Dim palabra As String

        Console.WriteLine("Ingrese una palabra")
        palabra = Console.ReadLine()
        Dim RevePalabra As String = StrReverse(palabra)
        Console.WriteLine("Su palabra al inversa es: " & RevePalabra)
        Console.ReadLine()

    End Sub

    Sub concatenacion()
        Dim estudiantes As New List(Of String) From {"Raul", "mau", "Glendy", "LLerar", "Cuellar"}
        Console.WriteLine("Estudiantes de POO")
        For Each i As String In estudiantes
            Console.WriteLine(i)
        Next
        Console.ReadLine()
    End Sub

    Sub Oracion()
        Dim ora As String
        Console.WriteLine("Ingrese una oracion")
        ora = Console.ReadLine()

        Dim palabras() As String = ora.Split(" ")

        Console.WriteLine("La frase '" & ora & "' tiene " & palabras.Count & " palabras.")
        For Each palabra As String In palabras
            Console.WriteLine("La palabra '" & palabra & "' tiene " & palabra.Length & " letras.")
        Next

        Console.ReadLine()
    End Sub


    Sub ConjuntosAritmeticos()
        Dim team1() As Integer = {60, 70, 80, 90, 100}
        Dim team2() As Integer = {10, 20, 30, 40, 50}


        Console.WriteLine("Suma: ")
        For i = 0 To team1.Length - 1
            Console.WriteLine(team1(i) & " + " & team2(i) & " = " & (team1(i) + team2(i)))
        Next

        Console.WriteLine()

        Console.WriteLine("Resta: ")
        For i = 0 To team1.Length - 1
            Console.WriteLine(team1(i) & " - " & team2(i) & " = " & (team1(i) - team2(i)))
        Next

        Console.WriteLine()

        Console.WriteLine("Multiplicacion: ")
        For i = 0 To team1.Length - 1
            Console.WriteLine(team1(i) & " * " & team2(i) & " = " & (team1(i) * team2(i)))
        Next

        Console.WriteLine()

        Console.WriteLine("Division: ")
        For i = 0 To team1.Length - 1
            Console.WriteLine(team1(i) & " / " & team2(i) & " = " & (team1(i) / team2(i)))
        Next

        Console.ReadLine()
    End Sub


End Module
