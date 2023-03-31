using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactosV2.Clases
{
    public class Empresa : Contacto
    {

        public Empresa()
        {

            sector = string.Empty;

        }

        private string sector;
        private int nEmpleados;

        public string Sector { get => sector; set => sector = value; }
        public int NEmpleados { get => nEmpleados; set => nEmpleados = value; }

        public override void Crear()
        {
            base.Crear();

            Console.Clear();

            Console.WriteLine("\nSector: ");
            Sector = Console.ReadLine() ?? String.Empty;

            Console.Clear();

            Console.WriteLine("\nNúmero de empleados");
            NEmpleados = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine("Sector: " + Sector);
            sb.AppendLine("Número de empleados: " + NEmpleados);
            sb.AppendLine("----------------------");

            return sb.ToString();
        }
    }
}
