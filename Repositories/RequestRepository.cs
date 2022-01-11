using System.Linq;
using System.Collections.Generic;
using BBMS.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BBMS.Repositories
{
    public class RequestRepository:IRequestRepository
    {
        private readonly BBMSContext _context;
        public RequestRepository(BBMSContext _context)
        {
            this._context = _context;
        }
        //To add request by hospital
        public int AddRequest(Request request)
        {
            _context.Requests.Add(request);
            _context.SaveChanges();
            return 1;
        }
        // To delete request (only Admin has access) 
        public int DeleteRequest(int id)
        {
            var request =  _context.Requests.Where(requests=> requests.RequestId == id).SingleOrDefault();
            _context.Requests.Remove(request);
            return 1;
        
        }
        // To get All requests made by hospital 
        public async Task<IEnumerable<Request>> GetAllRequests()
        {
            return await _context.Requests.ToListAsync();
        }
        // To get particular request using hospital id
        public async Task<Request> GetSpecificRequest(int id)
        {
            return await _context.Requests.Where(request => request.RequestId == id).SingleOrDefaultAsync();
        }
        // To update the all details of request database  (specifically to update the status and blood stock)
        public int UpdateRequest(Request request)
        {
            var requestInDb = _context.Requests.Where(requests => requests.RequestId == request.RequestId).SingleOrDefault();
            requestInDb.AmountToPay=request.AmountToPay;
            requestInDb.UpdatedOn=request.UpdatedOn;    
            requestInDb.PaymentStatus=request.PaymentStatus;
            requestInDb.RequestDate = request.RequestDate;
            requestInDb.HospitalId = request.HospitalId;
            requestInDb.RequiredQuantity = request.RequiredQuantity;
            requestInDb.StockId = request.StockId;
            requestInDb.Status = request.Status;
            requestInDb.UpdatedOn = request.UpdatedOn;
            _context.SaveChanges();
            return 1;
        }
    }
}
