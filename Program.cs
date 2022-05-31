using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        //Reynoso Rosales Eduardo Guadalupe #21212036
        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter("ejemplo.txt",true);

            //Si no existe el archivo, se creará.
            //Si existe, solo escribirá en él
            //Con true, se esta añadiendo nuevas lineas de texto. En vez de estar sobreescribiendo

            string[] lines =
            {
                "Esta es una nueva linea",
                "Segunda linea",
                "Tercera linea",
                "Fin del texto"

            };

            foreach(string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close(); //Se debe cerrar el archivo

            Console.WriteLine("Se escribió en el archivo...");
            Console.ReadKey();
        }
    }
}
