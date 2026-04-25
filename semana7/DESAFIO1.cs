using using System;

class Program
{
    static void Main()
    {
        // Matriz: 5 clientes (filas) y 5 compras (columnas)
        double[,] compras = new double[5, 5]
        {
            {100, 200, 150, 300, 250},
            {50, 60, 70, 80, 90},
            {500, 200, 100, 50, 150},
            {1000, 200, 300, 400, 100},
            {20, 30, 40, 50, 60}
        };

        CalcularDescuentos(compras);

        Console.ReadKey();
    }

    static void CalcularDescuentos(double[,] datos)
    {
        for (int i = 0; i < 5; i++)
        {
            double total = 0;

            // Sumar las 5 compras del cliente
            for (int j = 0; j < 5; j++)
            {
                total += datos[i, j];
            }

            double descuento = 0;

            // 🔽 CAMBIA ESTO si tu profe dio otras reglas
            if (total > 1000)
                descuento = total * 0.20;
            else if (total > 500)
                descuento = total * 0.10;

            double totalFinal = total - descuento;

            Console.WriteLine("Cliente " + (i + 1));
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total a pagar: " + totalFinal);
            Console.WriteLine("-------------------------");
        }
    }
}