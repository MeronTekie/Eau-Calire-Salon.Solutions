using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Models;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController: Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db =db;
    }
    public ActionResult Index()
    {
      List<Client> model =_db.Clients.Include(client =>client.Stylist).ToList();
      return View(model);
    }
  }
 
}