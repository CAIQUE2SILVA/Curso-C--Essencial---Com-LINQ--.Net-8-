// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Nullable Types ##\n");

Nullable<int> i = null;
Nullable<bool> f = null;
Nullable<double> d = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(f);

Console.ReadLine();

// simplifianddo a declaraçao 

int? i1 = null;
double? d1 = null;
bool? b1 = null;

Console.WriteLine(i1);
Console.WriteLine(d1);
Console.WriteLine(b1);

Console.ReadLine();

// definindo valor em um nullable Type

int? a = null;

int b = a ?? 0 ;

Console.WriteLine(b);

Console.ReadLine();


// Atribuir um nullable Type a um tipo por valor : expressoes

int? x = 4;
int? y = 5;
int? z = x * y;

Console.WriteLine(z);



// Propriedades somente leitura : HasValue e Value

int? t = null;

if (t.HasValue)
{
    Console.WriteLine($" t = {t.Value}");
}
else { Console.WriteLine("t nao possui um numero ");
}


Console.ReadLine();
