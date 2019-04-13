Module Program
    Sub Main()
        Llamada()
        'Multiplo()
        'ResultadoAcademico()
        'Temperatura()
        'TickTock()
        'PersonajesFavoritos()

    End Sub

    Sub Llamada()
        Dim z As Integer
        Console.WriteLine("Escoga el progama a utilizar")
        Console.WriteLine("1. Multiplo")
        Console.WriteLine("2. Resultado academico")
        Console.WriteLine("3. Temperatura")
        Console.WriteLine("4. Tick Tock")
        Console.WriteLine("5. Personaje favorito")
        z = Console.ReadLine()
        Select Case z
            Case Is = 1
                Call Multiplo()
            Case Is = 2
                Call ResultadoAcademico()
            Case Is = 3
                Call Temperatura()
            Case Is = 4
                Call TickTock()
            Case Is = 5
                Call PersonajesFavoritos()
            Case Else
                Console.WriteLine("Opcion no valida")
                Console.ReadLine()
        End Select
        Return
    End Sub

    Sub Multiplo()
        Dim x1 As Integer, x2 As Integer
        Console.WriteLine("Ingrese su primer numero por favor.")
        x1 = Console.ReadLine()
        Console.WriteLine("Ingrese su segundo numero por favor.", x2)
        x2 = Console.ReadLine()

        If x1 Mod 5 = 0 Then
            Console.WriteLine("Su numero es multiplo de 5")
            Console.ReadLine()
        End If

        If x2 Mod 3 = 0 Then
            Console.WriteLine("Su numero es multiplo de 3")
            Console.ReadLine()
        Else
            Console.WriteLine("Su numero no es multiplo de 3")
            Console.ReadLine()


        End If

    End Sub

    Sub ResultadoAcademico()
        Dim nombre As String
        Dim apellido As String
        Dim nota As Double
        Dim asis As Double
        Dim resul As String

        Console.WriteLine("Ingrese su nombre")
        nombre = Console.ReadLine()
        Console.WriteLine("Ingrese su apellido")
        apellido = Console.ReadLine()
        Console.WriteLine("Ingrese su nota")
        nota = Console.ReadLine()
        Console.WriteLine("Ingrese la asistencia")
        asis = Console.ReadLine()

        If nota > 100 Or nota < 0 Or asis < 0 Or asis > 100 Then
            Console.WriteLine("Valor ingresado fuera de rango")
            Console.ReadLine()
        Else

            If nota > 60 And asis >= 75 Then
                resul = ("Aprovada")
            Else
                If nota < 60 And nota >= 50 And asis >= 75 Then
                    resul = ("Complementario")
                Else
                    If nota < 50 Or asis < 75 Then
                        resul = ("Reprobada")
                    End If
                End If

            End If
            Console.WriteLine($"Con una calificacion de {nota} y asistencia de {asis} usted {nombre} {apellido} tiene un resultado de: {resul}")
            Console.ReadLine()
        End If





    End Sub

    Sub Temperatura()
        Dim temp As Integer
        Console.WriteLine("Ingrese la temperatura en celcius")
        temp = Console.ReadLine()
        Select Case temp

            Case Is > 40
                Console.WriteLine("EL clima esta caluroso favor refresarse")
                Console.ReadLine()
            Case Is < 10
                Console.WriteLine("Favor de abrigarse")
                Console.ReadLine()
            Case Is < 0
                Console.WriteLine("Clima bajo cero")
                Console.ReadLine()
            Case Is > 24, Is < 35
                Console.WriteLine("Clima agradable")
                Console.ReadLine()


        End Select
        Exit Sub

    End Sub

    Sub TickTock()
        Dim num1 As Integer
        Dim num2 As Integer
        'Dim i = 1
        Console.WriteLine("Ingrese su primer numero")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese su segundo numero que no sea multiplo del primero")
        num2 = Console.ReadLine()

        For index = 1 To 100
            If index Mod num1 = 0 Then
                Console.WriteLine("Tick")
            ElseIf index Mod num2 = 0 Then
                Console.WriteLine("Tock")
            Else
                Console.WriteLine($"{index}")
            End If
        Next
        Console.ReadLine()
        Exit Sub
    End Sub

    Sub PersonajesFavoritos()
        Dim x As Integer
        Console.WriteLine("Escoga su deporte favorito")
        Console.WriteLine("1. Futbol")
        Console.WriteLine("2. Basketbol")
        Console.WriteLine("3. Futbol americano")
        x = Console.ReadLine()
        Select Case x
            Case Is = 1
                Console.WriteLine("Escoga su equipo de futbool favorito")
                Console.WriteLine("1. Fas")
                Console.WriteLine("2. Metapan")
                Console.WriteLine("3. Aguila")
                Console.ReadLine()
            Case Is = 2
                Console.WriteLine("Escoga su equipo de BKB favorito")
                Console.WriteLine("1. Chicago bulls")
                Console.WriteLine("2. Lakers")
                Console.WriteLine("3. Miamia Heat")
                Console.ReadLine()
            Case Is = 3
                Console.WriteLine("Escoga su equipo favorito de futbol americano")
                Console.WriteLine("1. Patriots")
                Console.WriteLine("2. Cowboys")
                Console.WriteLine("3. Eagles")
                Console.ReadLine()
            Case Else
                Console.WriteLine("Opcion no valida")
                Console.ReadLine()
        End Select
        Exit Sub
    End Sub
End Module
