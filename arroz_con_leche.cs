using System;

class Program
{
    static void Main(string[] args)
    {
        Principal();
    }

    static int PedirDatos()
    {
        while (true)
        {
            try
            {
                Console.Write("Digite la cantidad de porciones: ");
                int porciones = int.Parse(Console.ReadLine());

                if (porciones % 4 == 0)
                {
                    return porciones;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite una cantidad de porciones multiplo de 4!!!");
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite solo enteros positivos multiplos de 4!!");
                Console.WriteLine();
            }
        }
    }

    static (double, double, double, double) CalcularIngredientes(int porciones)
    {
        if (porciones % 4 == 0)
        {
            double cantArroz = (450.0 / 8) * porciones;
            double cantAzucar = (200.0 / 8) * porciones;
            double cantLeche = (2.0 / 8) * porciones;
            double cantLecheCondensada = (400.0 / 8) * porciones;
            return (cantArroz, cantLeche, cantAzucar, cantLecheCondensada);
        }
        else
        {
            return (0.0, 0.0, 0.0, 0.0);
        }
    }

    static void MostrarResultados(int porciones, (double, double, double, double) datos)
    {
        var (arroz, leche, azucar, lecheCond) = datos;
        Console.WriteLine($"Los ingredientes para {porciones} son:");
        Console.WriteLine($"Arroz: {arroz}");
        Console.WriteLine($"Azucar: {azucar}");
        Console.WriteLine($"Leche: {leche}");
        Console.WriteLine($"Leche Condensada: {lecheCond}");
    }

    static void Principal()
    {
        int dato = PedirDatos();
        var calcular = CalcularIngredientes(dato);
        MostrarResultados(dato, calcular);
    }
}

