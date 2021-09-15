using Microsoft.AspNetCore.Mvc;

namespace CarDelear.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}