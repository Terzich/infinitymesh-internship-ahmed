using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Domain
{
    public class Color
    {
        public int ColorID { get; set; }
        public string ColorName { get; set; }
        public List<Car> Cars { get; set; }
    }
}
