using System.Collections.Generic;
using System.Threading.Tasks;
using BBMS.Models;
namespace BBMS.Repositories
{
    public interface IBloodStockRepository
    {
        //Methods
        int AddNewBloodStock(Bloodstock stock);
        int UpdateBloodStock(Bloodstock bloodstock);
        int DeleteBloodStock(int id);
        Task<IEnumerable<Bloodstock>> GetAllBloodStock();
       Task<Bloodstock> GetSpecificBloodStock(string bloodtype);

    }
}
