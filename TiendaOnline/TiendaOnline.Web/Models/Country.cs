using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Web.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo nombre es requerido")]
        [MaxLength(50,ErrorMessage ="El campo {0} debe contener al menos un caracter")]
        public string Name { get; set; }


    }
}
