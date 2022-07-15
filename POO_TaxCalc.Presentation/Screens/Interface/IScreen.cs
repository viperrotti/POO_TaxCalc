using POO_TaxCalc.Domain;

namespace POO_TaxCalc.Presentation.Screens.Interface
{
    public interface IScreen
    {
        Salary AddSalary();
        void PrintHeader();
        void ShowResult(double tax);
    }
}
