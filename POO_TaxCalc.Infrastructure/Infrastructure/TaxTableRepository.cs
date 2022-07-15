using POO_TaxCalc.Domain.Interfaces;

namespace POO_TaxCalc.Domain.Infrastructure
{
    public class TaxTableRepository : ITaxTableRepository
    {
        public List<TaxRange> GetTaxTable()
        {
            return new List<TaxRange>() { new TaxRange(0.00, 22847.76, 0.00, 0.00),
                                          new TaxRange(22847.77, 33919.80, 0.075, 1713.58),
                                          new TaxRange(33919.81, 45012.60, 0.15, 4257.57),
                                          new TaxRange(45012.61, 55976.16, 0.225, 7633.51),
                                          new TaxRange(55976.17, double.MaxValue, 0.275, 10432.32)};
        }
    }
}
