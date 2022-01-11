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
    }
}
