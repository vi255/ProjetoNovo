using System.Web.Mvc;

namespace ProjetoNovo.Web.Controllers
{
    public class HomeController : ProjetoNovoControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}