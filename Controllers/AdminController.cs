using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BBMS.Services;
using System.Threading.Tasks;
using System;
using BBMS.Models;

namespace BBMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            this._adminService = adminService;
        }


        [HttpGet]
        [Route("CheckIfAdminIsValid/{email}/{password}")] // Route for checking admin is valid or not
        public async Task<IActionResult> CheckIfAdminIsValid(string email, string password)
        {
            try //Exception handling
            {
                return new ObjectResult(await _adminService.CheckIfAdminIsValid(email, password));
            }
            catch(Exception ex)
            {   
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        [HttpGet]
        [Route("GetAllAdmin")] //Route for GetAllAdmin
        public async Task<IActionResult> GetAllAdmin()
        {
            try
            {
                return new ObjectResult(await _adminService.GetAllAdmin());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpGet]
        [Route("GetAdminById/{id}")] //Route GetAdminById with id parameter
        public async Task<IActionResult> GetAdminById(int id)
        {
            try
            {
                return new ObjectResult(await _adminService.GetAdminById(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        [HttpPost]
        [Route("AddAdmin")] //Route for AddAdmin
        public IActionResult AddAdmin(Admin admin)
        {
            try
            {
                return new ObjectResult(_adminService.AddAdmin(admin));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        [HttpPut]
        [Route("UpdateAdmin")] // Route for UpdateAdmin
        public IActionResult UpdateAdmin(Admin admin)
        {
            try
            {
                return new ObjectResult(_adminService.UpdateAdmin(admin));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpDelete]
        [Route("DeleteAdmin/{id}")] // Route for DeleteAdmin
        public IActionResult DeleteAdmin(int id)
        {
            try //Exception handling
            {
                return new ObjectResult(_adminService.DeleteAdmin(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
