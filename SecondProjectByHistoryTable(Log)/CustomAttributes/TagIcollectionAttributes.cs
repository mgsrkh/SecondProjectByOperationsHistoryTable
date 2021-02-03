using System;
using System.ComponentModel.DataAnnotations;

namespace SecondProjectByHistoryTable_Log_.CustomAttributes
{
    public class TagIcollectionAttributes : Attribute
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [StringLength(128)]
        public string Value { get; set; }
    }
}
