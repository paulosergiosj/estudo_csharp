using AspNetMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMVC.Models
{
    public class SalesRecord
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Sale's Date")]
        public DateTime Date { get; set; } = DateTime.Now;
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "{0} required")]
        [Range(100.00, 500000.0, ErrorMessage = "{0} must be between {1} to {2}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }
        [Display(Name = "Seller")]
        public int SellerID { get; set; }

        public SalesRecord() { }

        public SalesRecord(int iD, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            ID = iD;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
