

Console.WriteLine("Digite sua Idade");
int idade= Convert.ToInt32(Console.ReadLine());

if (idade >= 18 )

{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Voce é maior de Idade.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Voce e menor de Idade.");
}
Console.ResetColor();
Console.WriteLine("Obrigado");



