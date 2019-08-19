using System;
using System.Collections.Generic;

namespace AspNetMVC.Models.ViewModel
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
