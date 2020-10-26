using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentaCar_Praksa.Dal.Repositories;
using RentaCar_Praksa.Dal.ViewModel;

namespace RentaCar_Praksa.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cars = await _carRepository.GetCars();
            return Ok(cars);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody]CarDto car)
        {
            var id = await _carRepository.SaveCar(car);
            return Ok(id);
        }

        [HttpPut]
        public async Task Edit(int carId, [FromBody]CarDto car)
        {
            await _carRepository.EditCar(carId, car);

        }




    }
}