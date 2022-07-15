using POO_TaxCalc.Domain;
using POO_TaxCalc.Domain.Interfaces;

namespace POO_TaxCalc.Services.Interface
{
    public interface ITaxCalculator
    {
        double TaxCalculation(Salary value, ITaxTableRepository taxTableRepository);
    }
}
