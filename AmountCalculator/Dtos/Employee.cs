namespace AmountCalculator.Dtos
{
    public class Employee:CustomerBase
    {
        public override decimal CalculateDiscount(decimal amount)
        {
           return amount * 30 / 100;
        }
    }
}
