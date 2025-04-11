using System.Collections;
using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Sellers Sellers { get; set; }
        public ICollection<Department>  Departments { get; set; }
    }
}
