using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BBMS.Models;
using BBMS.Services;
using System.Threading.Tasks;
using System;

namespace BBMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase // HospitalController Inherited from base class Controller
    {
        private readonly IHospitalService _hospitalService;
        //Dependency injection of interface HospitalService in HospitalController
        public HospitalController(IHospitalService hospitalService)
        {

            this._hospitalService = hospitalService;
        }

        [HttpGet]
        [Route("CheckIfHospitalIsValid/{email}/{password}")] // Route to check if hospital is valid using two parameters email and password
        public async Task<IActionResult> CheckIfHospitalIsValid(string email,string password)
        {
            try
            {
                return new ObjectResult(await _hospitalService.CheckIfHospitalIsValid(email, password));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpGet]
        [Route("GetAllHospital")] //Route for GetAllHospital
        public async Task<IActionResult> GetAllHospital()
        {
            try
            {
                return new ObjectResult(await _hospitalService.GetAllHospital());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpGet]
        [Route("GetHospitalById/{id}")] //Route GetHospitalById with id parameter
        public async Task<IActionResult> GetHospitalById(int id)
        {
            try
            {
                return new ObjectResult(await _hospitalService.GetHospitalById(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpPost]
        [Route("AddHospital")] //Route for AddHospital
        public IActionResult AddHospital(Hospital hospital)
        {
            try
            {
                return new ObjectResult(_hospitalService.AddHospital(hospital));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpPut]
        [Route("UpdateHospital")] // Route for UpdateHospital
        public IActionResult UpdateHospital(Hospital hospital)
        {
            try
            {
                return new ObjectResult(_hospitalService.UpdateHospital(hospital));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpDelete]
        [Route("DeleteHospital/{id}")] // Route for DeleteHospital
        public IActionResult DeleteHospital(int id)
        {
            try //Exception handling
            {
                return new ObjectResult(_hospitalService.DeleteHospital(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
