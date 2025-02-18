using System;
using System.Collections.Generic;

namespace VotacionGrammy
{
    class Grammy
    {
        private List<string> canciones;
        private List<int> votos;
        public Grammy()
        {
            canciones = new List<string>() {"Waka Waka", "4 Baby's", "Perfect", "Tiempo de valz", "Fiebre" };
            votos = new List<int>() { 0, 0, 0, 0, 0 };
        }
        public void mostrarInstrucciones()
        {
            Console.WriteLine("\nINSTRUCCIONES: \n" +
                              "\n1. Vote por su cancion favorita escribieno su nombre.\n" +
                              "2. Las 2 canciones con menos seran eliminadas.\n" +
                              "3. Las 3 canciones con mas votaciones seran mostradas al final de la votacion.\n");

            Console.Write("Presione Enter para mostrar la lista de las canciones: ");
            Console.ReadLine();

            votarCanciones();
        }

        public void votarCanciones()
        {
            Console.WriteLine("\n- Lista de canciones disponibles: \n");
            for (int i = 0; i < canciones.Count; i++)
            {
                Console.WriteLine($"{i+1}. {canciones[i]}");
            }

            int opcion;

            while (true)
            {
                Console.Write("\nIngrese el numero de su cancion favorita (0 para terminar): ");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 0)
                {
                    break;
                }
                votos[opcion - 1]++;
            } 

            eliminarCanciones();
        }

        public void eliminarCanciones()
        {
            for (int i = votos.Count - 1; i >= 0; i--)
            {
                if (votos[i] < 5)
                {
                    votos.RemoveAt(i);
                    canciones.RemoveAt(i);
                }
            }
            ordenarCanciones();
        }

        public void ordenarCanciones()
        {
            for (int i = 0; i < votos.Count; i++)
            {
                for (int j = i+1; j < votos.Count; j++)
                {
                    if (votos[i] < votos[j])
                    {
                        int auxV = votos[i];
                        string auxC = canciones[i];

                        votos[i] = votos[j];
                        canciones[i] = canciones[j];

                        votos[j] = auxV;
                        canciones[j] = auxC;
                    }
                }
            }
            imprimirResultados();
        }

        public void imprimirResultados()
        {
            Console.WriteLine("\n----------- RESULTADOS DE LAS VOTACIONES -----------\n");

            Console.WriteLine($"CANCION GANADORA: {canciones[0]}: {votos[0]} votos");

            for (int i = 1; i < canciones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {canciones[i]}: {votos[i]} votos");
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
