using System.Linq;
using System.Collections.Generic;
using BBMS.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BBMS.Repositories
{
    public class HospitalRepository:IHospitalRepository
    {
        private readonly BBMSContext _context;
        public HospitalRepository(BBMSContext context)
        {
            this._context = context;
        }

        //To add new Hospital entry in database
        public int AddHospital(Hospital hospital)
        {
            _context.Hospitals.Add(hospital);
            _context.SaveChanges();
            return 1;
        }
        //To Check if the hospital is valid user using its email and password
        public async Task<Hospital> CheckIfHospitalIsValid(string email, string password)
        {
            return await _context.Hospitals.Where(hospital => hospital.Email == email && hospital.Password == password).SingleOrDefaultAsync();
        }
        // To Delete Hospital record using hospital id
        public int DeleteHospital(int id)
        {
           var hospital = _context.Hospitals.Where(hospitals => hospitals.HospitalId==id).SingleOrDefault();
            _context.Remove(hospital);
            _context.SaveChanges();
            return 1;
        }
        //To get details of All registered Hospitals
        public async Task<IEnumerable<Hospital>> GetAllHospital()
        {
            return await _context.Hospitals.ToListAsync();
        }
        //To get specific hospital by hospital id
        public async Task<Hospital> GetHospitalById(int id)
        {
            return await _context.Hospitals.Where(hospital => hospital.HospitalId == id).SingleOrDefaultAsync();
        }
        //To Update hospital details
        public int UpdateHospital(Hospital hospital)
        {
            var hospitalinDb = _context.Hospitals.Where(hospitalz => hospitalz.HospitalId == hospital.HospitalId).SingleOrDefault();
            
            hospitalinDb.HospitalName = hospital.HospitalName;
            hospitalinDb.Password = hospital.Password;
            hospitalinDb.PhoneNo = hospital.PhoneNo;
            hospitalinDb.Requests = hospital.Requests;
            hospitalinDb.Address = hospital.Address;
            hospitalinDb.City = hospital.City;
            hospitalinDb.Email = hospital.Email;
            _context.SaveChanges();
            return 1;
        
        }
    }
}
