using System.Globalization;
using IndividualOrCompany.Entities;

Console.Write("Enter the number of tax payers: ");
int times = int.Parse(Console.ReadLine());
List<Person> list = new List<Person>();
for(int i = 1; i <= times; i++)
{
    Console.Write($"\nTax payer #{i}:\nIndividual or company (i/c)? ");
    string p = Console.ReadLine();
    if(p == "i")
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Annual income: $ ");
        decimal annualIncome = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Health Expenses: $ ");
        decimal healthExpenses = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Person person = new IndividualPerson(name, annualIncome, healthExpenses);
        list.Add(person);
    }
    else if (p == "c")
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Annual income: $ ");
        decimal annualIncome = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        Person person = new CompanyPerson(name, annualIncome, numberOfEmployees);
        list.Add(person);
    }
    else 
    { 
        Console.WriteLine("Error!");
        break;
    }
}

Console.WriteLine("\nTAXES PAID:");
foreach(Person p in list)
{
    Console.WriteLine(p);
}
Console.WriteLine("\nTOTAL TAXES:");
decimal total = 0;
foreach(Person p in list)
{
    total += p.TaxCalculation();
}
Console.WriteLine(total);