﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
   public class Service
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int UnitPrice { get; set; }
        public string Notes { get; set; }

    }
}
