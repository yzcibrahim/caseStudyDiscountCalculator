using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmountCalculator.Dtos
{
    public class Invoice
    {
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }

    }
}
