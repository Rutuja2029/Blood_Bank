using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BBMS.Services;
using BBMS.Models;
using System.Threading.Tasks;
using System;

namespace BBMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodStockController : ControllerBase // Inherited from base class Controller
    {
        private readonly IBloodStockService _bloodStockService;
        //Dependency injection of interface BloodStockService in BloodStockController
        public BloodStockController(IBloodStockService bloodStockService)
        {
           this._bloodStockService = bloodStockService;
        }

        [HttpPost]
        [Route("AddNewBloodStock")] // Route for AddNewBloodstock
        public IActionResult AddNewBloodStock(Bloodstock bloodstock)
        {
            try  //Exception Handling
            {
                return new ObjectResult(_bloodStockService.AddNewBloodStock(bloodstock));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        [HttpPut]
        [Route("UpdateBloodStock")] //Route for UpdateBloodStock
        public IActionResult UpdateBloodStock(Bloodstock bloodstock)
        {
            try
            {
                return new ObjectResult(_bloodStockService.UpdateBloodStock(bloodstock));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        [HttpDelete]
        [Route("DeleteBloodStock/{id}")] // Route for DeleteBloodStock with id parameter 
        public IActionResult DeleteBloodStock(int id)
        {
            try
            {
                return new ObjectResult(_bloodStockService.DeleteBloodStock(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        [HttpGet]
        [Route("GetAllBloodStock")] // Route for GetAllBloodStock
        public async Task<IActionResult> GetAllBloodStock()
        {
            try
            {
                return new ObjectResult(await _bloodStockService.GetAllBloodStock());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        [HttpGet]
        [Route("GetSpecificBloodStock/{blood_type}")] // Route for GetSpecificBloodStock using blood_type parameter
        public async Task<IActionResult> GetSpecificBloodStock(string blood_type)
        {
            try
            {
                return new ObjectResult(await _bloodStockService.GetSpecificBloodStock(blood_type));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }



    }
}
