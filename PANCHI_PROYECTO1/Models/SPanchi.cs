using System.ComponentModel.DataAnnotations;

namespace PANCHI_PROYECTO1.Models
{
    public class SPanchi
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nombre { get; set; }

        []

        public float Peso { get; set; }

        public Boolean Extranjero { get; set; }

        public  string Fecha { get; set; }





       


         


    }
}
