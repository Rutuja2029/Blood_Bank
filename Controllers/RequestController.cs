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
    public class RequestController : ControllerBase // Inherited from base class Controller
    {
        private readonly IRequestService _requestService;
        //Dependency injection of interface RequestService in RequestController
        public RequestController(IRequestService requestService)
        {
            this._requestService = requestService;
        }

        [HttpGet]
        [Route("GetAllRequests")] // Route for GetAllRequests
        public async Task<IActionResult> GetAllRequests()
        {
            try
            {
                return new ObjectResult(await _requestService.GetAllRequests());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        [HttpGet]
        [Route("GetSpecificRequest/{id}")] // Route for GetSpecificRequest with id parameter
        public async Task<IActionResult> GetSpecificRequest(int id)
        {
            try
            {
                return new ObjectResult(await _requestService.GetSpecificRequest(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }


        [HttpPost]
        [Route("AddRequest")] // Route for AddRequest
        public IActionResult AddRequest(Request request)
        {
            try
            {
                return new ObjectResult(_requestService.AddRequest(request));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        [HttpPut]
        [Route("UpdateRequest")] // Route for UpdateRequest
        public IActionResult UpdateRequest(Request request)
        {
            try
            {
                return new ObjectResult(_requestService.UpdateRequest(request));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }


        [HttpDelete]
        [Route("DeleteRequest/{id}")] // Route for DeleteRequest
        public IActionResult DeleteRequest(int id)
        {
            try //Exception handling
            {
                return new ObjectResult(_requestService.DeleteRequest(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }


    }
}
