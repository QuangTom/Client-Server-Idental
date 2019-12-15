using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
    public class VatLieu
    {
        public int MaterialID { get; set; } 
        public string MaterialName { get; set; }
        public int AvailableAmount { get; set; }
        public string ProviderName { get; set; }
        public string PhoneNumder { get; set; }
    }
}
