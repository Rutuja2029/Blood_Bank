using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BBMS.Services;
using System.Threading.Tasks;
using System;

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
    }
}
