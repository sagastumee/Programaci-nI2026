using System;

class Program
{
    static void Main()
    {
        char[,] tablero = new char[3, 3];

        // Llenar tablero
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tablero[i, j] = '-';
            }
        }

        char jugador = 'X';

        for (int turno = 0; turno < 9; turno++)
        {
            Console.Clear();

            // Mostrar tablero
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Turno de: " + jugador);

            // Pedir posición
            Console.Write("Fila (0-2): ");
            int fila = int.Parse(Console.ReadLine()!);

            Console.Write("Columna (0-2): ");
            int columna = int.Parse(Console.ReadLine()!);

            // Validar espacio vacío
            if (tablero[fila, columna] == '-')
            {
                tablero[fila, columna] = jugador;

                // Cambiar jugador
                if (jugador == 'X')
                    jugador = 'O';
                else
                    jugador = 'X';
            }
            else
            {
                Console.WriteLine("Ya está ocupado, intenta otra vez");
                Console.ReadKey();
                turno--; // repetir turno
            }
        }

        Console.Clear();

        // Mostrar tablero final
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tablero[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Juego terminado");
        Console.ReadKey();
    }
}