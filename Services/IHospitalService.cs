using System.Collections.Generic;
using System.Threading.Tasks;
using BBMS.Models;
namespace BBMS.Services
{
    public interface IHospitalService
    {
        int AddHospital(Hospital hospital);
        int UpdateHospital(Hospital hospital);
        int DeleteHospital(int id);
        Task<IEnumerable<Hospital>> GetAllHospital();
        Task<Hospital> GetHospitalById(int id);
        Task<Hospital> CheckIfHospitalIsValid(string email, string password);

    }
}
