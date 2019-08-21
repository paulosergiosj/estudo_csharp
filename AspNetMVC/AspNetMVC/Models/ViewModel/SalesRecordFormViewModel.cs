using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMVC.Models.Enums;

namespace AspNetMVC.Models.ViewModel
{
    public class SalesRecordFormViewModel
    {
        public SalesRecord SalesRecord { get; set; }
        public ICollection<Seller> Sellers { get; set; }
    }
}
