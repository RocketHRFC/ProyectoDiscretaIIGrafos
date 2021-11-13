using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscretaIIGrafos
{
    internal class Program
    {
        //Cambio Prueba Hugo Florian
        //Cambio Prueba Samer Aranki
        //Cambio prueba Jose Recinos

        //C:\Users\Rocket55\Desktop\Prueba.txt
        static void Main(string[] args)
        {
            Herramientas herramientas = new Herramientas();
            Grafo grafo = new Grafo();
            TeoremasCiclo TeoremaOysteinOre = new TeoremasCiclo();

            string direccion;

            Console.WriteLine("Ingrese direccion: \n");
            direccion = Console.ReadLine();
            direccion = direccion.ToString();
            herramientas.ObtenerGrafo(direccion, ref grafo);
            Console.WriteLine(TeoremaOysteinOre.OysteinOre(ref grafo));

            Console.ReadKey();

        }
    }
}
