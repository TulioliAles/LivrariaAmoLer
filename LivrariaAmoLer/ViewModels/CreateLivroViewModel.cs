using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LivrariaAmoLer.ViewModels
{
    public class CreateLivroViewModel
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "Nome do livro")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "*")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        public SelectList CategoriaOtions { get; set; }
    }
}