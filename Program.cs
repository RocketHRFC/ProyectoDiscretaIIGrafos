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
        static void Main(string[] args)
        {
            Herramientas herramientas = new Herramientas();
            Grafo grafo = new Grafo();

            string direccion;

            Console.WriteLine("Ingrese direccion: \n");
            direccion = Console.ReadLine();
            direccion = direccion.ToString();
            grafo.getLista() = herramientas.ObtenerGrafo(direccion);

        }
    }
}
