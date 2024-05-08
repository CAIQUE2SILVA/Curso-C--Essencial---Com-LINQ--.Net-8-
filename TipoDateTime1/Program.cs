// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Struct DateTime  ##\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

Console.ReadLine();

// criar uma data especifica usa formato : aaaa,mm,dd
DateTime dataHoje = new DateTime(2024, 05, 08);
Console.WriteLine(dataHoje);

Console.ReadLine();

// extraindo informaçoes da data atual 
DateTime DataDeHoje = DateTime.Now;

Console.WriteLine(DataDeHoje.Year);
Console.WriteLine(DataDeHoje.Day);
Console.WriteLine(DataDeHoje.Month);
Console.ReadLine();

//adicionando valores 
Console.WriteLine(DataDeHoje.AddDays(30));
Console.WriteLine(DataDeHoje.AddMonths(1));
Console.WriteLine(DataDeHoje.AddHours(2));
Console.WriteLine(DataDeHoje.AddYears(2));

Console.ReadLine();

// obter no formato longo e curto
Console.WriteLine(DataDeHoje.ToLongDateString());
Console.WriteLine(DataDeHoje.ToShortDateString());
Console.WriteLine(DataDeHoje.ToLongTimeString());
Console.WriteLine(DataDeHoje.ToShortTimeString());

Console.ReadLine();

