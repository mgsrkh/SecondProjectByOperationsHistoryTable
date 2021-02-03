using FirstProject.DTOs.Vendors;
using SecondProjectEFCoreAttributes.DTOs.Vendors;
using System.Threading.Tasks;

namespace SecondProjectByHistoryTable_Log_.ApplicationServices.IServices
{
    public interface IVendorService
    {
        Task<VendorDTO> GetVendorByIdAsync(int id);
        Task<bool> DeleteVendorByIdAsync(int id);
        Task<int> UpdateVendorAsync(VendorUpdateDTO DTO, int Id);
        Task<VendorInsertResponseDTO> InsertVendorAsync(VendorInsertDTO dto);
    }
}
