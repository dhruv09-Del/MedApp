using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedWeb.Models;
using MedWeb.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MedWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
       

       
        private readonly IMedicineRepo _medicineRepo;

        public HomeController(IMedicineRepo medicineRepo)
        {
            
            _medicineRepo = medicineRepo;
        }

        [HttpGet]
        [Route("GetMedicineList")]
        public IActionResult Get()
        {
            var medList = _medicineRepo.GetMedicinesList();
            return Ok(medList);
        }

        [HttpPost]
        [Route("AddMedicineDetail")]
        public IActionResult Add([FromBody]Medicine medicine)
        {
            
            var med = _medicineRepo.AddMedicineToList(medicine);
            if (med == true)
                return Ok("Added");
            else
                return NoContent();
        }
    }
}
