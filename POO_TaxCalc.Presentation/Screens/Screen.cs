using POO_TaxCalc.Domain;
using POO_TaxCalc.Presentation.Screens.Interface;

namespace POO_TaxCalc.Presentation.Screens
{
    public class Screen : IScreen
    {
        public Salary AddSalary()
        {
            bool valid;
            double salary;
            Console.Write("Digite o valor do salário anual: R$ ");
            do
            {
                valid = double.TryParse(Console.ReadLine(), out salary) && salary >= 0.00;
                if (!valid)
                    Console.Write("Valor inválido. Digite novamente: R$ ");
            } while (!valid);
            Salary workerSalary = new Salary(salary);
            return workerSalary;
        }

        public void PrintHeader()
        {
            Console.WriteLine("=== Cálculo de Imposto de Renda Anual - Pessoa Física ===\n");
        }
        public void ShowResult(double tax)
        {
            Console.WriteLine("Valor do imposto calculado: R$ " + tax.ToString("F2"));
        }
    }
}
