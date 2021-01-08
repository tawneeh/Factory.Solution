using Microsoft.AspNetCore.Mvc;

namespace TODO.Controllers
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