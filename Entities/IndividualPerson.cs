using System.Globalization;

namespace IndividualOrCompany.Entities
{
    public class IndividualPerson : Person
    {
        public decimal HealthExpenses { get; protected set; }
        public IndividualPerson(string name, decimal annualIncome, decimal healthExpenses) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }
        public override decimal TaxCalculation()
        {
            decimal tax = 0;
            if (AnnualIncome <= (decimal)20000)
            {
                if (HealthExpenses != 0)
                {
                    tax = (AnnualIncome * (decimal)0.15) - (HealthExpenses * (decimal)0.5);
                }
                else
                {
                    tax = AnnualIncome * (decimal)0.15;
                }
            }
            else if (AnnualIncome >= (decimal)20001)
            {
                if (HealthExpenses != 0)
                {
                    tax = (AnnualIncome * (decimal)0.25) - (HealthExpenses * (decimal)0.5);
                }
                else
                {
                    tax = AnnualIncome * (decimal)0.25;
                }
            }
            return tax;
        }

        public override string ToString()
        {
            return Name + ": " + TaxCalculation().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
