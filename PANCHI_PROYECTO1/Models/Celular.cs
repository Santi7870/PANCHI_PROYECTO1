using System.ComponentModel.DataAnnotations;

namespace PANCHI_PROYECTO1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }

        public string Modelo { get; set; }

        public int Anio { get; set; }
        public int Precio { get; set; }





    }
}
