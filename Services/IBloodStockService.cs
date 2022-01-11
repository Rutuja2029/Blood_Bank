using System.Collections.Generic;
using System.Threading.Tasks;
using BBMS.Models;
namespace BBMS.Services
{
    public interface IBloodStockService
    {

        int AddNewBloodStock(Bloodstock stock);
        int UpdateBloodStock(Bloodstock bloodstock);
        int DeleteBloodStock(int id);
        Task<IEnumerable<Bloodstock>> GetAllBloodStock();
        Task<Bloodstock> GetSpecificBloodStock(string bloodtype);
    }
}
