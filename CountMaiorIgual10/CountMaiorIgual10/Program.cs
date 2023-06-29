
Console.WriteLine("Exercicios do chefe \n");

Console.WriteLine("Insira a quantidade de exercicios resolvidos na 1° semana:");
int primeiraS = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a quantidade de exercicios resolvidos na 2° semana:");
int segundaS = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a quantidade de exercicios resolvidos na 3° semana:");
int terceiraS = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a quantidade de exercicios resolvidos na 4° semana:");
int quartaS = int.Parse(Console.ReadLine());



int countTimes = 0;


if (primeiraS >= 10)
{
    countTimes++;
}
if (segundaS >= 10)
{
    countTimes++;
}
if (terceiraS >= 10)
{
    countTimes++;
}
if (quartaS >= 10)
{
    countTimes++;
}


Console.WriteLine("\n O chefe atingiu " + countTimes +" vezes a meta");