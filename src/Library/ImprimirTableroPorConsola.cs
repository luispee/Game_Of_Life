using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    //Cumple con SRP porque su unica responsabilidad es imprimir el tablero por consola
    public class ImprimirTableroPorConsola
    {
        public static void ImprimirTablero(bool [,] b)
        {
            int width = b.GetLength(1);
            int height = b.GetLength(0);


            Logica logica= new Logica();
            while (true)
                {
                    Console.Clear();
                    StringBuilder s = new StringBuilder();
                    for (int y = 0; y<height;y++)
                    {
                        for (int x = 0; x<width; x++)
                        {
                            if (b[x, y])
                            {
                                s.Append("|X|");
                            }
                            else
                            {
                                s.Append("___");
                            }
                        }
                        s.Append("\n");
                    }
                    Console.WriteLine(s.ToString());
                    //=================================================
                    //Invocar método para calcular siguiente generación
                    b = logica.NextGen(b);
                    //=================================================
                    Thread.Sleep(300);
                }

        }
    }
}



