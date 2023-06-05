namespace Portafolio.Models
{
    public class HomeIndexVM
    {
        public IEnumerable<Proyecto> Proyectos { get; set; }
        public IEnumerable<Contacto> Contactos { get; set; }

        public EjemploGuidVM EjemploGuid_1 { get; set; }
        public EjemploGuidVM EjemploGuid_2 { get; set; }
    }
}
