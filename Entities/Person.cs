
namespace IndividualOrCompany.Entities
{
    public abstract class Person
    {
        public string Name { get; protected set; }
        public decimal AnnualIncome { get; protected set; }

        public Person(string name, decimal annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract decimal TaxCalculation();
    }
}
