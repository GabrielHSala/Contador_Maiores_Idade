int pessoas = 5;
string[] nome = new string[pessoas];
int[] idades = new int[pessoas];
int maiores = 0;

for (int i = 0; i < pessoas; i++)
{
    Console.WriteLine("Digite seu nome:");
    nome[i] = Console.ReadLine();
    Console.Clear();

    Console.WriteLine($"{nome[i]} digite sua idade:");
    idades[i] = int.Parse(Console.ReadLine());
    Console.Clear();

    if (idades[i] >= 18)
        maiores++;
}

Console.WriteLine($"número de pessoas maiores de idade = {maiores} ");