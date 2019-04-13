Public Class CuentaBancaria
    Private NumeroCuenta As Integer
    Private Balance As Double

    Public Sub New(NumeroCuenta, Balance)
        Me.NumeroCuenta = NumeroCuenta
        Me.Balance = Balance
    End Sub

    Public Sub depositar(monto As Double)
        Balance = Balance + monto

    End Sub

    Public Sub retirar(monto As Double)
        Balance = Balance - monto
    End Sub

    Public Sub Mostrar()
        Console.WriteLine("Balance: " & Balance)
        Console.ReadLine()
    End Sub

End Class
