using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name = "País")]//ASí ES COMO SE VA A MOSTAR POR UI
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]//lONGITUD MAXIMA(NVARCHAR(50))
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

    }
}
