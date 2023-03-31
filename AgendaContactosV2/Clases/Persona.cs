using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactosV2.Clases
{
    public class Persona : Contacto
    {
        public Persona()
        {
            genero = string.Empty;            
        }

        private string genero;        
        private int edad;

        public string Genero { get => genero; set => genero = value; }
        public int Edad { get => edad; set => edad = value; }


        public override void Crear()
        {
            base.Crear();

            Console.Clear();

            Console.WriteLine("\nEdad: ");
            Edad = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nGenero: ");
            Genero = Console.ReadLine() ?? String.Empty;

            Console.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine("Genero: " + Genero);
            sb.AppendLine("Edad: " + Edad);
            sb.AppendLine("----------------------");

            return sb.ToString();
        }
    }

    
}
