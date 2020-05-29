using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;
    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet, ActionName("Index")]
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name")
      return View(model);
    }
  }
}
