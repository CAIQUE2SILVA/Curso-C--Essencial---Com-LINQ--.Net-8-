Console.WriteLine("Definindo variaveis o tipo string e object e dynamic");

string nome = "Curso C#";

string titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

Console.ReadLine();

string valor = "Isso e uma string";
valor = "Isso e uma string alterada";

// Caso nessecite alterar a string e recomendavel usar StringBuilder


object nota = 10;
dynamic valor1 = 8.55m;
object nome1 = "Maria";
dynamic titulo1 = "Maria";
object ativa = true;
dynamic inativo = false;
dynamic letra = 'A';
object letra1 = 'A';

// O tipo dynamic e object aceitam qualquer entrada 


Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(titulo1);
Console.WriteLine(ativa);
Console.WriteLine(inativo);
Console.WriteLine(letra);
Console.WriteLine(letra1);