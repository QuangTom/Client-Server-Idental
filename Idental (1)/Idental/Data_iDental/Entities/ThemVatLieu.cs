﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
    public class ThemVatLieu
    {
        public string MATERIALNAME { get; set; }
        public int PROVIDERID { get; set; }
        public int AVAILABLEAMOUNT { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}
