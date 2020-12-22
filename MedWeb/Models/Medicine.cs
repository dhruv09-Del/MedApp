using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedWeb.Models
{
    public class Medicine
    {
        [Required(ErrorMessage = "Medicine's name is required")]
        [Display(Name = "Name")]
        [StringLength(100, ErrorMessage = "Medicine's name is too long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Brand's name is required")]
        [Display(Name = "Brand")]
        [StringLength(100, ErrorMessage = "Brand's name is too long")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price")]
        [DataType(DataType.Currency, ErrorMessage = "Price format is not valid ")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "It is required")]
        [Display(Name = "ExpiryDate")]
        [DataType(DataType.Date, ErrorMessage = "Expiry Date format is not valid")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExpiryDate { get; set; }

        [Required(ErrorMessage = "It is required")]
        [Display(Name = "Notes")]
        public string Notes { get; set; }
    }

    public class MedList
    {
        public Medicine[] items { get; set; }
    }
}
