using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AgendaContactosV2.Clases
{
    public abstract class Contacto
    {
        public Contacto()
        {
            nombre = string.Empty;
            apellidos = string.Empty;
            dni = string.Empty;
            telefono = string.Empty;
        }

        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }

        private string apellidos;
        public string Apellidos { get => apellidos; set => apellidos = value; }

        private string dni;
        public string DNI { get => dni; set => dni = value; }

        private string telefono;
        public string Telefono { get => telefono; set => telefono = value; }


        public virtual void Crear()
        {
            Console.Clear();

            Console.WriteLine("\nNombre: ");
            Nombre = Console.ReadLine() ?? String.Empty;

            Console.Clear();

            Console.WriteLine("\nApellidos: ");
            Apellidos = Console.ReadLine() ?? String.Empty;

            Console.Clear();

            Console.WriteLine("\nDNI: ");
            DNI = Console.ReadLine() ?? String.Empty;

            Console.Clear();

            Console.WriteLine("\nTelefono: ");
            Telefono = Console.ReadLine() ?? String.Empty;
        }

        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine("----------------------");
            mensaje.AppendLine("Nombre: " + Nombre);
            mensaje.AppendLine("Apellidos: " + Apellidos);
            mensaje.AppendLine("DNI: " + DNI);
            mensaje.AppendLine("Teléfono: " + Telefono);            

            return mensaje.ToString();
        }
    }

   
}
