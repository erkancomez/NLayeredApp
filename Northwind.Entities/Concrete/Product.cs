﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public Decimal UnitPrice { get; set; }

        public Int16 UnitsInStock { get; set; }

        public string QuantityPerUnit { get; set; }
    }
}
