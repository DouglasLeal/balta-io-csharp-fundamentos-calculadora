Somar();


static void Somar()
{
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float resultado = v1 + v2;
    Console.WriteLine($"{v1} + {v2} = {resultado}");
}