using POO_TaxCalc.Domain;
using POO_TaxCalc.Domain.Interfaces;
using POO_TaxCalc.Services.Interface;


namespace POO_TaxCalc.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public TaxCalculator()
        {
        }

        public double TaxCalculation(Salary value, ITaxTableRepository taxTableRepository)
        {
            double tax = 0;
            foreach (TaxRange range in taxTableRepository.GetTaxTable())
            {
                if(value.WorkerSalary >= range.MinValue && value.WorkerSalary <= range.MaxValue)
                {
                    tax = value.WorkerSalary * range.Aliquot - range.Deduction;
                }
            }
            return tax;
        }


       

    }
}
