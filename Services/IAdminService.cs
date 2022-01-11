using BBMS.Models;
using System.Threading.Tasks;

namespace BBMS.Services
{
    public interface IAdminService
    {
        Task<Admin> CheckIfAdminIsValid(string email, string password);
    }
}
