

using AgendaContactosV2.Clases;

namespace AgendaContactosV2
{
    public static class Gestion
    {
        public static int PantallaInicio()
        {
            Console.WriteLine("\n1. Añadir Contactos");
            Console.WriteLine("2. Listar Contactos");
            Console.WriteLine("3. Eliminar Contactos");
            Console.WriteLine("4. Buscar Contactos");
            Console.WriteLine("5. Editar Contactos");
            Console.WriteLine("6. Cerrar programa");

            return Int16.Parse(Console.ReadLine());
        }        

        public static int TipoContacto()
        {
            Console.Clear();

            Console.WriteLine("\n1. Persona");
            Console.WriteLine("2. Empresa");

            return Int16.Parse(Console.ReadLine());
        }

        public static void Crear(Contacto contacto)
        {
            contacto.Crear();
        }

        public static void ListarContactos(List<Contacto> contactos)
        {
            foreach (Contacto contacto in contactos)
            {
                Console.WriteLine(contacto.ToString());
            }
        }

        public static void EliminarContacto(List<Contacto> contacto)
        {
            Console.Clear();

            Console.WriteLine("\nIntroduce el DNI del contacto a eliminar: ");

            string dniBusqueda = Console.ReadLine();

            var borrarContacto = contacto.Where(x => x.DNI == dniBusqueda).ToList();

            if (borrarContacto.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("\nNo existe ningún contacto con ese DNI, vuelve a intentarlo.");
            }
            else
            {
                foreach (var datos in borrarContacto)
                {
                    contacto.Remove(datos);
                }

                Console.Clear();
                Console.WriteLine("\nSe ha eliminado correctamente");

            }
        }

        public static void BuscarContacto(List<Contacto> contacto)
        {

            Console.Clear();

            Console.WriteLine("\nIntroduce el DNI del contacto a buscar: ");

            Console.Clear();

            string dniBusqueda = Console.ReadLine();

            var buscarDNI = contacto.Where(x => x.DNI == dniBusqueda);

            if (buscarDNI.Count() == 0)
            {
                Console.Clear();
                Console.WriteLine("\nNo existe ningún contacto con ese DNI, vuelve a intentarlo.");
            }
            else
            {
                foreach (var datos in buscarDNI)
                {
                    Console.WriteLine(datos.ToString());

                }
            }

        }

        public static void EditarContactos(List<Contacto> contacto)
        {
            Console.Clear();

            Console.WriteLine("\nIntroduce el DNI del contacto a buscar: ");

            string dniBusqueda = Console.ReadLine();

            var buscarDNI = contacto.Where(x => x.DNI == dniBusqueda);

            if (buscarDNI.Count() == 0)
            {
                Console.Clear();
                Console.WriteLine("\nNo existe ningún contacto con ese DNI, vuelve a intentarlo.");
            }
            /*else
            {

            }*/
        }
    }
}
