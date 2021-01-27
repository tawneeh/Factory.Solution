using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;
using System.Collections.Generic;

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
      var engineers = _db.Engineers.ToList();
      var machines = _db.Machines.ToList();
      Dictionary<string, object> model = new Dictionary<string, object> {};
      model.Add("machine", machines);
      model.Add("engineer", engineers);
      return View(model);
    }
  }
}