using System.ComponentModel.DataAnnotations;

namespace LivrariaAmoLer.ViewModels
{
    public class VincularLivroAutorViewModel
    {
        [Required(ErrorMessage = "*")]
        public int AutorId { get; set; }

        [Required(ErrorMessage = "*")]
        public int LivroId { get; set; }
    }
}