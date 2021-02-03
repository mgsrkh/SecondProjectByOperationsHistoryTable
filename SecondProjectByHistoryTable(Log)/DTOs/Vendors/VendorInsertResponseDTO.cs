using SecondProjectEFCoreAttributes.DTOs.Vendors;
using System.ComponentModel.DataAnnotations;

namespace FirstProject.DTOs.Vendors
{
    public class VendorInsertResponseDTO : VendorInsertDTO
    {
        [Required]
        public int Id { get; set; }
    }
}
