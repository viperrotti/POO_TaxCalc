using POO_TaxCalc.Domain;
using POO_TaxCalc.Domain.Interfaces;
using POO_TaxCalc.Interface;
using POO_TaxCalc.Presentation.Screens.Interface;
using POO_TaxCalc.Services.Interface;

namespace POO_TaxCalc
{
    public class CalculationFlow : ICalculationFlow
    {
        private readonly IScreen screen;
        private readonly ITaxCalculator taxCalculator;
        private readonly ITaxTableRepository taxTableRepository;


        public CalculationFlow(IScreen screen, ITaxCalculator taxCalculator, ITaxTableRepository taxTableRepository)
        {
            this.screen = screen;
            this.taxCalculator = taxCalculator;
            this.taxTableRepository = taxTableRepository;
        }

        public void Start()
        {
            screen.PrintHeader();
            Salary salary = screen.AddSalary();
            double tax = taxCalculator.TaxCalculation(salary, taxTableRepository);
            screen.ShowResult(tax);
        }
    }
}
