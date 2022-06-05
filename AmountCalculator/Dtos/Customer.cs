using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmountCalculator.Dtos
{
    public class Customer:CustomerBase
    {

        public bool IsAffiliate { get; set; }
        public DateTime CustStartDate { get; set; }
        public override decimal CalculateDiscount(decimal amount)
        {
            
            if(CustStartDate.AddYears(2)<DateTime.Now)
            {
                return amount * 5 / 100;
            }

            return base.CalculateDiscount(amount);
        }

    }

    public class CustomerAffiliate:CustomerBase
    {
        public override decimal CalculateDiscount(decimal amount)
        {
            return amount * 10 / 100;
        }
    }
}
