using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PANCHI_PROYECTO1.Models
{
    public class Celular
    {
        [Key]
        public int IdCelular { get; set; }

        [Required(ErrorMessage ="El campo de modelo es obligatorio")]
        [MaxLength(50)]

        

        public string Modelo { get; set; }

        [ForeignKey(nameof(Celular))]


        [Range(2000,2025)]
        public int Anio { get; set; }

        [Range(1000,10000)]
        public int Precio { get; set; }

        [ForeignKey("SPanchi")]
        public int SPanchiId { get; set; }

        public SPanchi sPanchi { get; set; }






    }
}
