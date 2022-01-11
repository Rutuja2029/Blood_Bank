using BBMS.Models;
using BBMS.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BBMS.Services
{
    public class BloodStockService:IBloodStockService
    {
        private readonly IBloodStockRepository _repository;
        //Dependency injection of repository interface in service class
        public BloodStockService(IBloodStockRepository repository)
        {
            this._repository = repository;
        }

        public int AddNewBloodStock(Bloodstock stock)
        {
            return _repository.AddNewBloodStock(stock);
        }

        public int DeleteBloodStock(int id)
        {
            return _repository.DeleteBloodStock(id);
        }

        public async Task<IEnumerable<Bloodstock>> GetAllBloodStock()
        {
           return await _repository.GetAllBloodStock();
        }

        public async Task<Bloodstock> GetSpecificBloodStock(string bloodtype)
        {
           return await _repository.GetSpecificBloodStock(bloodtype);
        }

        public int UpdateBloodStock(Bloodstock bloodstock)
        {
            return _repository.UpdateBloodStock(bloodstock);    
        }
    }
}
