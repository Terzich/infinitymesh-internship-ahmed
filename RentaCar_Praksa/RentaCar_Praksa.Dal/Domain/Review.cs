using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Domain
{
    public class Review:BaseEntity
    {
        public int ReviewID { get; set; }
        public int BookedCarID { get; set; }
        public BookedCar BookedCar { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
