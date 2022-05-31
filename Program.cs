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

            

            string nombre;
            int cant;
            

            Console.Write("-Cuantos nombres quieres agregar?");
            cant = int.Parse(Console.ReadLine());

            string[] lines = new string[cant];

            for(int i=0; i<cant; i++) 
            { 

                Console.Write("-Indica un nuevo nombre: ");
                nombre = Console.ReadLine();

                lines[i] = nombre;
                Console.WriteLine("Se añadió el nombre");

            }

           

            
            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            Console.WriteLine("Se sobreescribió en el archivo...");
            
            
            
            sw.Close(); //Se debe cerrar el archivo

            
            Console.ReadKey();
        }
    }
}
