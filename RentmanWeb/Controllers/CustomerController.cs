using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentmanLib;
using RentmanWeb.Models;

namespace Rentman.Controllers
{

  public class CustomerController : Controller
  {
    CustomerRepository custRepo = new RentmanLib.CustomerRepository();


    public IActionResult Index()
    {
      var customerList = custRepo.List();
      var viewModel = new CustomerViewModel(customerList);
      return View(viewModel);
    }
  }

}