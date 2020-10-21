using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Domain
{
    public class Car:BaseEntity
    {
        public string CarName { get; set; }
        public int YearOFProduction { get; set; }
        public int HorsePower { get; set; }
        public int NumberOfDoors { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public int ColorID { get; set; }
        public Color Color { get; set; }
        public List<BookedCar> BookedCars { get; set; }

        public Car(string username):base(username)
        {

        }

    }
}
