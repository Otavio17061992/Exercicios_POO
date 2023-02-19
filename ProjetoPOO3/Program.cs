using ProjetoPOO3.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of tax payers: ");

        List<Person> Persons = new List<Person>();
        LegalPerson PJ;
        PhysicalPerson PF;

        // store numbers of payers
        int numberPayers = int.Parse(Console.ReadLine());

        // interated the numbers of payers
        for (int i = 1; i <= numberPayers; i++)
        {
            Console.WriteLine("Tax payer #{0} data: ",i);
            Console.Write("Individual or company (i/c)? ");
            char typePerson = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string nome = Console.ReadLine();

            Console.Write("Anual income: ");
            double anualIncome = double.Parse(Console.ReadLine());

            if(typePerson== 'i')
            {
                Console.Write("Health expenditures: ");
                double healthExpend = double.Parse(Console.ReadLine());

                PF = new PhysicalPerson(nome,anualIncome, healthExpend);
                Persons.Add(PF);

            }
            else
            {
                Console.Write("Number of employees: ");
                int numberOfEmp = int.Parse(Console.ReadLine());

                PJ = new LegalPerson(numberOfEmp,nome,anualIncome);
                Persons.Add(PJ);
            }
        }

        double totalTaxes = 0;

        Console.WriteLine("TAXES PAID: ");
        foreach (var item in Persons)
        {
            Console.WriteLine(item.Nome + ": $ "+ item.CalculoImposto());
            totalTaxes += item.CalculoImposto();
        }

        Console.WriteLine("TOTAL TAXES: $ " + totalTaxes);
    }
}