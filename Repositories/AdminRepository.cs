using System.Linq;
using System.Collections.Generic;
using BBMS.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BBMS.Repositories
{
    public class AdminRepository : IAdminRepository
     {
        // Dependency injection of DBContext (database) in repository
        private readonly BBMSContext _context; 
        public AdminRepository(BBMSContext context) 
        {
            this._context = context;
        }
        //To check if admin is valid or not using email & password
        public async Task<Admin> CheckIfAdminIsValid(string email, string password) 
        {
            return await _context.Admins.Where(admin=>admin.AdminEmail==email && admin.AdminPassword==password).SingleOrDefaultAsync();
        }
        //To get details of All registered Admins
        public async Task<IEnumerable<Admin>> GetAllAdmin()
        {
            return await _context.Admins.ToListAsync();
        }
        //To get specific Admin by admin id
        public async Task<Admin> GetAdminById(int id)
        {
            return await _context.Admins.Where(admin => admin.AdminId == id).SingleOrDefaultAsync();
        }
        public int AddAdmin(Admin admin)
        {
            _context.Admins.Add(admin); 
            _context.SaveChanges();
            return 1;
        }
        // To Delete Admin record using hospital id
        public int DeleteAdmin(int id)
        {
            var admin = _context.Admins.Where(admins => admins.AdminId == id).SingleOrDefault();
            _context.Remove(admin);
            _context.SaveChanges();
            return 1;
        }
        public int UpdateAdmin(Admin admin)
        {
            var admininDb = _context.Admins.Where(adminz => adminz.AdminId == admin.AdminId).SingleOrDefault();

            admininDb.AdminName = admin.AdminName;
            admininDb.AdminEmail = admin.AdminEmail;
            admininDb.AdminPassword = admin.AdminPassword;
            admininDb.IsActive = admin.IsActive;
            
            _context.SaveChanges();
            return 1;

        }
    }
}
