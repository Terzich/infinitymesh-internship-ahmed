using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Domain
{
    public class BookedCar:BaseEntity
    {
        public int CarID { get; set; }
        public int UserID { get; set; }
        public Car Car { get; set; }
        public User User { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public decimal TotalPrice { get; set; }
        public int ReviewID { get; set; }
        public Review Review { get; set; }

        public BookedCar(string username):base(username)
        {

        }


    }
}
