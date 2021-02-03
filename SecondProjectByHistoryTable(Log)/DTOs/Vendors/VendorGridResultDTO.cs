using System.Collections.Generic;

namespace SecondProjectEFCoreAttributes.DTOs.Vendors
{
    public class VendorGridResultDTO
    {
        public VendorGridResultDTO(ICollection<VendorDTO> vendorDTOs)
        {
            VendorDTOs = vendorDTOs;
        }
        public ICollection<VendorDTO> VendorDTOs { get; set; }
    }
}
