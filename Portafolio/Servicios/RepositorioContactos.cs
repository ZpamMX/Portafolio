using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioContactos
    {
        List<Contacto> ObtenerContactos();
    }

    public class RepositorioContactos : IRepositorioContactos
    {  
        public List<Contacto> ObtenerContactos()
        {
            return new List<Contacto> {
                new Contacto
                {
                    ImagenURL="/Imagenes/avatar.jpg",
                    Nombre="Juan",
                    ApellidoPaterno="Quinonez",
                    ApellidoMaterno="Muniz",
                    Telefono="686 11 11 11"
                },
                new Contacto
                {
                    ImagenURL="/Imagenes/avatar.jpg",
                    Nombre="Alejandro",
                    ApellidoPaterno="Rodriguez",
                    ApellidoMaterno="Solis",
                    Telefono="686 22 22 22"
                },
                new Contacto
                {
                    ImagenURL="/Imagenes/avatar.jpg",
                    Nombre="Roberto",
                    ApellidoPaterno="Danubio",
                    ApellidoMaterno="Iglesias",
                    Telefono="686 33 33 33"
                },
            };
        }
    }
}
