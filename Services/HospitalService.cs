using System.Collections.Generic;
using System.Threading.Tasks;
using BBMS.Models;
using BBMS.Repositories;

namespace BBMS.Services
{
    public class HospitalService:IHospitalService
    {
        private readonly IHospitalRepository _hospitalRepository;

        public HospitalService(IHospitalRepository hospitalRepository)
        {
            this._hospitalRepository = hospitalRepository;
        }

        public int AddHospital(Hospital hospital)
        {
            return _hospitalRepository.AddHospital(hospital);
        }

        public async Task<Hospital> CheckIfHospitalIsValid(string email, string password)
        {
            return await _hospitalRepository.CheckIfHospitalIsValid(email, password);
        }

        public int DeleteHospital(int id)
        {
            return _hospitalRepository.DeleteHospital(id);  
        }

        public async Task<IEnumerable<Hospital>> GetAllHospital()
        {
           return await _hospitalRepository.GetAllHospital();
        }

        public async Task<Hospital> GetHospitalById(int id)
        {
            return await _hospitalRepository.GetHospitalById(id);
        }

        public int UpdateHospital(Hospital hospital)
        {
            return _hospitalRepository.UpdateHospital(hospital);
        }
    }
}
