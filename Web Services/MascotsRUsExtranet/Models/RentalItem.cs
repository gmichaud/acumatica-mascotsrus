using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MascotsRUsExtranet.Models
{
    public class RentalItem
    {
        [Required]
        [StringLength(30)]
        [Display(Name="Rental Item Code")]
        public string RentalItemCode { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Cost")]
        public decimal Cost { get; set; }

        [StringLength(50)]
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
    }
}