using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DrSillyStringzFactory.Models;

namespace DrSillyStringzFactory.Controllers
{
    public class MachinesController : Controller
    {
    private readonly EngineerMachineContext _db;
    public MachinesController(EngineerMachineContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.OrderBy(x => x.Name).ToList();
      return View(model);
    }
     public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
        
    }
}