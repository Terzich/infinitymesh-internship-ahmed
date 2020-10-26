using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.ViewModel
{
    public class CarDto
    {
        public CarDto()
        {

        }
        public CarDto(Car car)
        {
            Id = car.Id;
            CarName = car.CarName;
            YearOFProduction = car.YearOFProduction;
            HorsePower = car.HorsePower;
            NumberOfDoors = car.NumberOfDoors;
            Price = car.Price;
            ImageURL = car.ImageURL;
            ColorID = car.ColorID;
        }

        public int Id { get; set; }
        public string CarName { get; set; }
        public int YearOFProduction { get; set; }
        public int HorsePower { get; set; }
        public int NumberOfDoors { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public int ColorID { get; set; }

    }
}
