using BBMS.Models;
using BBMS.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BBMS.Services
{
    public class RequestService:IRequestService
    {
        private readonly IRequestRepository _repository;

        public RequestService(IRequestRepository repository)
        {
            this._repository = repository;
        }

        public int AddRequest(Request request)
        {
           return _repository.AddRequest(request);
        }

        public int DeleteRequest(int id)
        {
            return _repository.DeleteRequest(id);
        }

        public async Task<IEnumerable<Request>> GetAllRequests()
        {
           return await _repository.GetAllRequests(); 
        }

        public async Task<Request> GetSpecificRequest(int id)
        {
            return await _repository.GetSpecificRequest(id);
        }

        public int UpdateRequest(Request request)
        {
           return _repository.UpdateRequest(request);
        }
    }
}
