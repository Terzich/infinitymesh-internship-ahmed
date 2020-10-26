using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentaCar_Praksa.Dal.ViewModel
{
    public class CarViewModel
    {
        public CarViewModel(IReadOnlyCollection<Car> cars)
        {
            Collection = cars.Select(car => new CarDto(car)).ToList();

        }

        public IReadOnlyCollection<CarDto> Collection { get; set; }
    }
}
