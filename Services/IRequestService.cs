using System.Collections.Generic;
using System.Threading.Tasks;
using BBMS.Models;
namespace BBMS.Services
{
    public interface IRequestService
    {
        int AddRequest(Request request);
        int UpdateRequest(Request request);
        int DeleteRequest(int id);
        Task<IEnumerable<Request>> GetAllRequests();
        Task<Request> GetSpecificRequest(int id);
    }
}
