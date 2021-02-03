using Microsoft.EntityFrameworkCore;
using SecondProjectEFCoreAttributes.Contexts;
using SecondProjectEFCoreAttributes.InferaStructure.IRepositories;
using SecondProjectEFCoreAttributes.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProjectEFCoreAttributes.InferaStructure.Repositories
{
    public class VendorRepository : IVendorRepository
    {
        private readonly ProjectContext _db;

        public VendorRepository(ProjectContext db)
        {
            _db = db;
        }
        public async Task<Vendor> GetVendorByIdAsync(int id)
        {
            return await _db.Vendor.Where(v => v.Id == id).Include(t => t.Tags).SingleOrDefaultAsync();
        }

        public async Task<int> DeleteVendorByIdAsync(Vendor vendor)
        {
            _db.Vendor.Remove(vendor);
            return await _db.SaveChangesAsync();
        }
        public async Task<int> UpdateVendorAsync(Vendor vendor)
        {
            _db.Vendor.Update(vendor);
            return await _db.SaveChangesAsync();
        }
        public async Task<Vendor> InsertVendorAsync(Vendor vendor)
        {
            _db.Vendor.Add(vendor);
            await _db.SaveChangesAsync();
            return vendor;
        }
        public async Task<int> SaveChangeAsync()
        {
            return await _db.SaveChangesAsync();
        }
    }
}
