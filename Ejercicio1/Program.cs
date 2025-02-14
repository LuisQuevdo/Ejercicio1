using System;

class Ejercicio1
{
    static void Main()
    {
        // Ejercicio 1: Declaración de variables y muestra en consola
        int entero = 10;
        float flotante = 5.5f;
        double doble = 15.75;
        char caracter = 'A';
        string cadena = "Hola, soy Luis Fernando Quevedo Vanegas";
        bool booleano = true;

        Console.WriteLine("Valores de las variables:");
        Console.WriteLine($"Entero: {entero}");
        Console.WriteLine($"Flotante: {flotante}");
        Console.WriteLine($"Doble: {doble}");
        Console.WriteLine($"Caracter: {caracter}");
        Console.WriteLine($"Cadena: {cadena}");
        Console.WriteLine($"Booleano: {booleano}");

        // Ejercicio 2: Operaciones con variables
        int num1 = 8, num2 = 12;
        double num3 = 2.5;
        char letra = 'Q';
        string texto = "Quevedo";

        Console.WriteLine("\nOperaciones:");
        Console.WriteLine($"Suma de enteros: {num1 + num2}");
        Console.WriteLine($"Multiplicación de double por int: {num3 * num1}");
        Console.WriteLine($"Concatenación de char con string: {letra + texto}");

        // Ejercicio 3: Conversión de tipos
        double valorDouble = 9.99;
        int valorInt = (int)valorDouble;
        int otroEntero = 7;
        double otroDouble = (double)otroEntero;

        Console.WriteLine("\nConversiones:");
        Console.WriteLine($"Double a int (pérdida de decimales): {valorInt}");
        Console.WriteLine($"Int a double: {otroDouble}");

        // Ejercicio 4: Uso de booleanos en condiciones
        bool esMayor = num1 > num2;

        if (esMayor)
        {
            Console.WriteLine("\nLa condición es verdadera");
        }
        else
        {
            Console.WriteLine("\nLa condición es falsa");
        }
    }
}
