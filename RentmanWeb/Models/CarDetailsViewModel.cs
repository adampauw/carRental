using System;
using RentmanLib;
using System.Collections.Generic;

namespace Rentman
{
  public class CarViewModel
  {
    public List<Car> CarList;

    public CarViewModel(List<Car> carList)
    {
      CarList = carList;
    }
  }
}