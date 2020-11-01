using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentaCar_Praksa.Dal.ViewModel
{
    public class CarViewModel
    {
        public CarViewModel(List<Car> cars)
        {
            Collection = cars.Select(car => new CarDto(car)).ToList();

        }

        public List<CarDto> Collection { get; set; }
    }
}
