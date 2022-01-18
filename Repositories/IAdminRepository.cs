using BBMS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BBMS.Repositories
{
    public interface IAdminRepository
    {
        Task<Admin> CheckIfAdminIsValid(string email,string password); //Method CheckIfAdminIsValid
        int AddAdmin(Admin admin);
        int UpdateAdmin(Admin admin);
        int DeleteAdmin(int id);
        Task<IEnumerable<Admin>> GetAllAdmin();
        Task<Admin>GetAdminById(int id);
    }
}
