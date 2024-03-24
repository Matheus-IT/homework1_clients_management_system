using System.Globalization;
using Management;


Console.WriteLine("Pessoa física ou jurídica? [f/j]");
var personType = Console.ReadLine();

if (personType == "f")
{
    var individual = new Individual();
    fillOutPersonalInfo(individual);

    Console.Write("Informe o RG: ");
    individual.RG = Console.ReadLine()!;

    Console.Write("Informe o CPF: ");
    individual.CPF = Console.ReadLine()!;

    Console.Write("Informe o valor da compra: ");
    individual.PayTax(float.Parse(Console.ReadLine()!));
    presentClient(individual);
}
else if (personType == "j")
{
    var legalEntity = new LegalEntity();
    fillOutPersonalInfo(legalEntity);
    Console.Write("Informe o CNPJ: ");
    legalEntity.CNPJ = Console.ReadLine()!;

    Console.Write("Informe o IE: ");
    legalEntity.IE = Console.ReadLine()!;

    Console.Write("Informe o valor da compra: ");
    legalEntity.PayTax(float.Parse(Console.ReadLine()!));
    presentClient(legalEntity);
}

static void fillOutPersonalInfo(Client c)
{
    Console.Write("Informe o nome: ");
    c.Name = Console.ReadLine()!;

    Console.Write("Informe o endereço: ");
    c.Address = Console.ReadLine()!;
}

static void presentClient(Client c)
{
    Console.WriteLine("--------------- Pessoa física ---------------");
    Console.WriteLine($"Nome ...............: {c.Name}");
    Console.WriteLine($"Endereço ...........: {c.Address}");
    if (c is Individual individual)
    {
        Console.WriteLine($"CPF ................: {individual.CPF}");
        Console.WriteLine($"RG .................: {individual.RG}");
    }
    if (c is LegalEntity legalEntity)
    {
        Console.WriteLine($"CNPJ ...............: {legalEntity.CNPJ}");
        Console.WriteLine($"IE .................: {legalEntity.IE}");
    }

    var brCultureInfo = CultureInfo.CreateSpecificCulture("pt-BR");
    Console.WriteLine($"Valor da compra ....: {c.Value.ToString("C", brCultureInfo)}");
    Console.WriteLine($"Imposto ............: {c.TaxValue.ToString("C", brCultureInfo)}");
    Console.WriteLine($"Valor total ........: {c.Total.ToString("C", brCultureInfo)}");
}
