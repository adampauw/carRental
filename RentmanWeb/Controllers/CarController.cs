using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rentman.Models;
using RentmanLib;
using RentmanWeb.Models;

namespace Rentman.Controllers
{

  public class CarController : Controller
  {
    CarRepository carRepo = new RentmanLib.CarRepository();


    public IActionResult Index()
    {
      var carList = carRepo.List();
      var viewModel = new CarViewModel(carList);
      return View(viewModel);
    }
    public IActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Create([FromForm]CarEditViewModel vm)
    {
      System.Diagnostics.Debug.Write(vm.Make);
      return View(vm);
      
    }
  }

}