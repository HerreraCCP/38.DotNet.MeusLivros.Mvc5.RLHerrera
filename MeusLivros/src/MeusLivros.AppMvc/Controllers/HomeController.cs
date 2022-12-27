using MeusLivros.AppMvc.ViewModels;
using System.Web.Mvc;

namespace MeusLivros.AppMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();

        public ActionResult About()
        {
            ViewBag.Message = "Biblioteca do Herrera";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "herrera.ccp@gmail.com";
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public ActionResult Errors(int id)
        {
            var modelErro = new ErrorViewModel();

            switch (id)
            {
                case 500:
                    modelErro.Message = "Ocorreu um erro! Tente novamente mais tarde ou contate nosso suporte.";
                    modelErro.Title = "Ocorreu um erro!";
                    modelErro.ErroCode = id;
                    break;

                case 404:
                    modelErro.Message = "A página que está procurando não existe! <br />Em caso de dúvidas entre em contato com nosso suporte";
                    modelErro.Title = "Ops! Página não encontrada.";
                    modelErro.ErroCode = id;
                    break;

                case 403:
                    modelErro.Message = "Você não tem permissão para fazer isto.";
                    modelErro.Title = "Acesso Negado";
                    modelErro.ErroCode = id;
                    break;

                default:
                    return new HttpStatusCodeResult(500);
            }

            return View("Error", modelErro);
        }
    }
}