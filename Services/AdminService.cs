using BBMS.Models;
using BBMS.Repositories;
using System.Collections.Generic;
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
        public async Task<IEnumerable<Admin>> GetAllAdmin()
        {
            return await _adminRepository.GetAllAdmin();
        }
        public int AddAdmin(Admin admin)
        {
            return _adminRepository.AddAdmin(admin);
        }
        public int DeleteAdmin(int id)
        {
            return _adminRepository.DeleteAdmin(id);
        }
        public int UpdateAdmin(Admin admin)
        {
            return _adminRepository.UpdateAdmin(admin);
        }
        public async Task<Admin> GetAdminById(int id)
        {
            return await _adminRepository.GetAdminById(id);
        }
    }

}
