using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentmanWeb.Models;

namespace RentmanWeb.Controllers
{
  public class RentalController : Controller
  {
    public IActionResult Index() {

      var rentalVm = new RentalViewModel();
      rentalVm.Begin = DateTime.Now;

        return View(rentalVm);
    }

  public IActionResult Description() => View();

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
}
