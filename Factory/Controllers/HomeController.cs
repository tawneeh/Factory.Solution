using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller 
  {

    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Engineer = _db.Engineers.ToList();
      ViewBag.Machine = _db.Machines.ToList();
      return View(); 
    }
  }
}