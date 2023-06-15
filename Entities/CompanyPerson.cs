using System.Globalization;

namespace IndividualOrCompany.Entities
{
    public class CompanyPerson : Person
    {
        public int NumberOfEmployees { get; protected set; }

        public CompanyPerson(string name, decimal annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override decimal TaxCalculation()
        {
            decimal tax = 0;
            if (AnnualIncome <= (decimal)20000)
            {
                if (NumberOfEmployees > 10)
                {
                    tax = AnnualIncome * (decimal)0.14;
                }
                else
                {
                    tax = AnnualIncome * (decimal)0.16;
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
