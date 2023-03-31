using AgendaContactosV2;
using AgendaContactosV2.Clases;
using System;

List<Contacto> contactos = new List<Contacto>();

while (true)
{
    int opcion = Gestion.PantallaInicio();

    switch (opcion)
    {
        case 1:
            {
                if (Gestion.TipoContacto() == 1)
                {
                    Contacto persona = new Persona();
                    contactos.Add(persona);
                    Gestion.Crear(persona);
                }
                else
                {
                    Contacto empresa = new Empresa();
                    contactos.Add(empresa);
                    Gestion.Crear(empresa);
                }
                break;
            }
        case 2:
            {
                Console.Clear();
                Gestion.ListarContactos(contactos);
                break;
            }
        case 3:
            {
                Console.Clear();
                Gestion.EliminarContacto(contactos);
                break;
            }
        case 4:
            {
                Gestion.BuscarContacto(contactos);
                break;
            }
        case 5:
            {
                Gestion.EditarContacto(contactos);
                break;
            }
        case 6:
            {
                Environment.Exit(1);
                break;
            }
    }
    
}


Console.ReadLine();