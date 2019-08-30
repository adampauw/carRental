using System;
using RentmanLib;
using System.Collections.Generic;

namespace Rentman
{
  public class CustomerViewModel
  {
    public List<Customer> CustomerList;

    public CustomerViewModel(List<Customer> customerList)
    {
      CustomerList = customerList;

    }
  }
}