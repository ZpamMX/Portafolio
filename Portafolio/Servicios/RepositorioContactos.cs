using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioContactos
    {
        public List<Contacto> ObtenerContactos()
        {
            return new List<Contacto> {
                new Contacto
                {
                    Nombre="Juan",
                    ApellidoPaterno="Quinonez",
                    ApellidoMaterno="Muniz",
                    Telefono="686 11 11 11"
                },
                new Contacto
                {
                    Nombre="Alejandro",
                    ApellidoPaterno="Rodriguez",
                    ApellidoMaterno="Solis",
                    Telefono="686 11 11 11"
                },
                new Contacto
                {
                    Nombre="Roberto",
                    ApellidoPaterno="Danubio",
                    ApellidoMaterno="Iglesias",
                    Telefono="686 11 11 11"
                },
            };
        }
    }
}
