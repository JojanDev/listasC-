using System;
using System.Collections.Generic;

namespace VotacionGrammy
{
    class Grammy
    {
        private List<string> canciones;
        private int[,] votos = {
            { 0},
            { 0},
            { 0},
            { 0},
            { 0}
        };
        public Grammy()
        {
            canciones = new List<string>() {"Waka Waka", "4 Baby's", "Perfect", "Tiempo de valz", "Fiebre" };
        }
        public void mostrarInstrucciones()
        {
            Console.WriteLine("INSTRUCCIONES: \n" +
                              "\n1. Vote por su cancion favorita escribieno su nombre.\n" +
                              "2. Las 2 canciones con menos seran eliminadas.\n" +
                              "3. Las 3 canciones con mas votaciones seran mostradas al final de la votacion.\n" +
                              "0. Salir.\n");

            Console.Write("Ingrese el numero (1) para mostrar la lista de las canciones: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    votar();
                    break;
                default:
                    break;
            }
        }

        public void votar()
        {
            Console.WriteLine("\n- Lista de canciones disponibles: \n");
            for (int i = 0; i < canciones.Count; i++)
            {
                Console.WriteLine($"{i+1}. {canciones[i]}");
            }

            while (true)
            {
                Console.Write("\nIngrese el numero de su cancion favorita: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        votos[0, 0] += 1;
                        break;
                    case 2:
                        votos[1, 0] += 1;
                        break;
                    case 3:
                        votos[2, 0] += 1;
                        break;
                    case 4:
                        votos[3, 0] += 1;
                        break;
                    case 5:
                        votos[4, 0] += 1;
                        break;
                    case 0:

                    default:
                        break;
                }

            }
        }
        static void Main(string[] args)
        {
            Grammy pers1 = new Grammy();

            Console.WriteLine("----------- BIENVENIDO A LAS VOTACIONES DE LOS PREMIOS GRAMMY -----------");

            pers1.mostrarInstrucciones();
        }
    }
}
