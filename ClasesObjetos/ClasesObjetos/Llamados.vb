Module Module1
    Sub Main()
        Dim ObjecSaludo As HolaMundo = New HolaMundo
        ObjecSaludo.oli()


        Dim carro1 As Carros = New Carros
        carro1.marca = "toyota"
        carro1.modelo = "2019"
        carro1.anho = "2000"
        carro1.color = "amarillo"
        carro1.atributos()
        Dim carro2 As Carros = New Carros
        carro2.marca = "audi"
        carro2.modelo = "RE09"
        carro2.anho = "2005"
        carro2.color = "rojo"
        carro2.atributos()
        Dim carro3 As Carros = New Carros
        carro3.marca = "nissa"
        carro3.modelo = "asdhj"
        carro3.anho = "1999"
        carro3.color = "azul"
        carro3.atributos()
        Console.ReadLine()

        Dim cuenta As CuentaBancaria = New CuentaBancaria(1, 10.5)
        cuenta.depositar(100)
        cuenta.retirar(20)
        cuenta.Mostrar()


        'CALCULADORA
        'Definir variables

        'Dim operacionesValidas() As String = {"s", "r", "m", "d", "t"}
        Dim operacion As String
        Dim a, b As Double
        Dim calcular As calculadora = New calculadora


        'Solicitar operación a realizar
        Console.WriteLine("¿Qué operación deseas realizar? Presiona la letra que corresponda y luego Enter.")
        Console.WriteLine("[s]umar, [r]estar, [m]ultiplicar, [d]ividir, [t]odas")
        operacion = Console.ReadLine()
        Console.WriteLine("Ingrese su primer numero")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese su segundo numero")
        b = Console.ReadLine()


        Select Case operacion
            Case "s"

                Console.WriteLine("La suma de esos números es: ")
                calcular.suma(a, b)
            Case "r"
                Console.WriteLine("La resta de esos números es: ")
                calcular.resta(a, b)
            Case "m"
                Console.WriteLine("La multiplicacion de esos números es: ")
                calcular.multi(a, b)
            Case "d"
                Console.WriteLine("La division de esos números es: ")
                calcular.divi(a, b)
            Case "t"
                Console.WriteLine("El total de las operaciones es: ")
                calcular.todas(a, b)
            Case Else
                Console.WriteLine("Opcion invalida ")

        End Select

        Console.WriteLine("Presiona Enter para salir del programa...")
        Console.ReadLine()
    End Sub






End Module
