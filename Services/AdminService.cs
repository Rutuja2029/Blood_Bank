using BBMS.Models;
using BBMS.Repositories;
using System.Threading.Tasks;

namespace BBMS.Services
{
    public class AdminService:IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        //Dependency injection of repository interface in service class
        public AdminService(IAdminRepository adminRepository)
        {
            this._adminRepository = adminRepository;
        }

        public async Task<Admin> CheckIfAdminIsValid(string email, string password) //Async & await
        {
            return await _adminRepository.CheckIfAdminIsValid(email, password);
        }
    }
}
