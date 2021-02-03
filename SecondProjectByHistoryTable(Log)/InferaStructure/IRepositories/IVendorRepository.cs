using SecondProjectEFCoreAttributes.Models;
using System.Threading.Tasks;

namespace SecondProjectEFCoreAttributes.InferaStructure.IRepositories
{
    public interface IVendorRepository
    {
        Task<Vendor> GetVendorByIdAsync(int id);
        Task<int> DeleteVendorByIdAsync(Vendor vendor);
        Task<int> UpdateVendorAsync(Vendor vendor);
        Task<Vendor> InsertVendorAsync(Vendor vendor);
        Task<int> SaveChangeAsync();
    }
}
