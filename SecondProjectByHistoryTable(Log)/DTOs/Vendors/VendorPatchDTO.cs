using SecondProjectEFCoreAttributes.DTOs.Tags;
using System;
using System.ComponentModel.DataAnnotations;

namespace SecondProjectEFCoreAttributes.DTOs.Vendors
{
    public class VendorPatchDTO
    {
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        [MaxLength(128)]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public TagDTO Tags { get; set; }
    }
}
