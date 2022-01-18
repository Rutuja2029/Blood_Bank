using BBMS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BBMS.Services
{
    public interface IAdminService
    {
        Task<Admin> CheckIfAdminIsValid(string email, string password);
        Task<IEnumerable<Admin>> GetAllAdmin();
        int AddAdmin(Admin admin);
        int UpdateAdmin(Admin admin);
        int DeleteAdmin(int id);
        Task<Admin> GetAdminById(int id);
    }
}
