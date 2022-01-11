using BBMS.Models;
using System.Threading.Tasks;

namespace BBMS.Repositories
{
    public interface IAdminRepository
    {
        Task<Admin> CheckIfAdminIsValid(string email,string password); //Method CheckIfAdminIsValid

    }
}
