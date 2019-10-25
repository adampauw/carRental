using System;
using RentmanLib;
using System.Collections.Generic;

namespace Rentman
{
  public class CustomerListViewModel
  {
    public List<Customer> CustomerList;

    public CustomerListViewModel(List<Customer> customerList)
    {
      CustomerList = customerList;

    }
  }
}