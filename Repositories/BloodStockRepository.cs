using System.Linq;
using System.Collections.Generic;
using BBMS.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BBMS.Repositories
{
    public class BloodStockRepository:IBloodStockRepository
    {
        private readonly BBMSContext _context;
        public BloodStockRepository(BBMSContext context)
        {
            this._context=context;
        }
        // To Add new Blood stock entry in database
        public int AddNewBloodStock(Bloodstock stock)
        {
            _context.Bloodstocks.Add(stock);
            _context.SaveChanges();  // It saves changes made
            return 1;  // after successfull change it will return 1
        }
        // To Delete Blood stock entry from database using stockid
        public int DeleteBloodStock(int id)
        {

            var bloodstock = _context.Bloodstocks.Where(stock => stock.StockId == id).SingleOrDefault();
            _context.Bloodstocks.Remove(bloodstock);
            _context.SaveChanges();
            return 1;
        }

        //To Get list of all available Blood stock in blood bank
        public async Task<IEnumerable<Bloodstock>> GetAllBloodStock()
        {
            return await _context.Bloodstocks.ToListAsync();
        }
        //To get particular Blood group all details using bloodtype
        public async Task<Bloodstock> GetSpecificBloodStock(string bloodtype)
        {
            return await _context.Bloodstocks.Where(stock => stock.BloodGroup == bloodtype).SingleOrDefaultAsync();
        }
        //To Update all the details of blood group
        public int UpdateBloodStock(Bloodstock bloodstock)
        {
            var stockInDb = _context.Bloodstocks.Where(stock => stock.BloodGroup == bloodstock.BloodGroup).SingleOrDefault();
            stockInDb.BloodGroup = bloodstock.BloodGroup;
            stockInDb.BagQuantity = bloodstock.BagQuantity;
            stockInDb.Status = bloodstock.Status;
            _context.SaveChanges();
            return 1;
        
        }
    }

      
    }

