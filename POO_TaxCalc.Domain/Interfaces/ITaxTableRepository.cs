namespace POO_TaxCalc.Domain.Interfaces
{
    public interface ITaxTableRepository
    {
        List<TaxRange> GetTaxTable();
    }
}
