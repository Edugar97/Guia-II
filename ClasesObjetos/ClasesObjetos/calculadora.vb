Public Class calculadora

    Public Sub suma(a As Double, b As Double)
        Console.WriteLine(a + b)
    End Sub

    Public Sub resta(a As Double, b As Double)
        Console.WriteLine(a - b)
    End Sub

    Public Sub multi(a As Double, b As Double)
        Console.WriteLine(a * b)
    End Sub

    Public Sub divi(a As Double, b As Double)
        Console.WriteLine(a / b)
    End Sub

    Public Sub todas(a As Double, b As Double)
        Console.WriteLine("Suma")
        suma(a, b)
        Console.WriteLine("Resta")
        resta(a, b)
        Console.WriteLine("Multiplicacion")
        multi(a, b)
        Console.WriteLine("Division")
        divi(a, b)
    End Sub

End Class


