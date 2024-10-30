using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PANCHI_PROYECTO1.Models
{
    public class SPanchi
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo de nombre es obligatorio")]

        [MaxLength(100, ErrorMessage = "No puede exeder de 100 caracteres")]
        public string Nombre { get; set; }
        [Range(0.2, 500)]
     

        public float Peso { get; set; }

        [Required]
        public Boolean Extranjero { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Fecha de registro")]

        public  string Fecha { get; set; }

        public Celular celular { get; set; }






       


         


    }
}
