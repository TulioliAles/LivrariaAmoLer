using LivrariaAmoLer.Context;
using LivrariaAmoLer.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace LivrariaAmoLer.Controllers
{
    [RoutePrefix("livros")]
    public class LivroController : Controller
    {
        LivrariaAmoLerDataContext _db = new LivrariaAmoLerDataContext();

        [Route("criar")]
        public ActionResult Create()
        {
            var categorias = _db.Categorias.ToList();
            var model = new CreateLivroViewModel
            {
                Titulo = "",
                ISBN = "",
                CategoriaId = 0,
                CategoriaOtions = new SelectList(categorias, "Id", "Nome")
            };

            return View(model);
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(CreateLivroViewModel model)
        {
            return View();
        }
    }
}