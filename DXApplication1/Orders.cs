using DevExpress.Utils.DPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

namespace DXApplication1
{
    public class Orders
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        [Display(Name = "Postal Code")]
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
