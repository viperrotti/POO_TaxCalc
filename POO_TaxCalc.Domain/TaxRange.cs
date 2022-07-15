namespace POO_TaxCalc.Domain
{
    public class TaxRange
    {
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public double Aliquot { get; set; }
        public double Deduction { get; set; }

        public TaxRange(double minValue, double maxValue, double aliquot, double deduction)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            Aliquot = aliquot;
            Deduction = deduction;
        }


    }
}
