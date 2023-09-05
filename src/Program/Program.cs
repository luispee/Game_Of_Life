using System;

namespace PII_Game_Of_Life
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
            bool [,] tablero = LectorArchivosTxt.LeerArchivo();
            ImprimirTableroPorConsola.ImprimirTablero(tablero);
            
        }
    }
}
