using System;

namespace AmountCalculator.Dtos
{
    public abstract class CustomerBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual decimal CalculateDiscount(decimal amount)
        {
            return  Math.Floor(amount / 100) * 5;
            
        }
    }
}
