using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RentaCar_Praksa.Controllers
{
    public class BookedCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}