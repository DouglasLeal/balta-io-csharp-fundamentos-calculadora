Menu();



static void Menu()
{
    Console.Clear();

    Console.WriteLine("Calculadora");
    Console.WriteLine("-----------");
    Console.WriteLine();

    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine();
    Console.WriteLine("0 - Sair");
    Console.WriteLine();
    Console.WriteLine("-----------");
    Console.WriteLine();

    Console.Write("Operação desejada: ");
    short opcao = short.Parse(Console.ReadLine());
}

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

static void Subtrair()
{
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float resultado = v1 - v2;
    Console.WriteLine($"{v1} - {v2} = {resultado}");
}

static void Multiplicar()
{
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float resultado = v1 * v2;
    Console.WriteLine($"{v1} * {v2} = {resultado}");
}

static void Dividir()
{
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float resultado = v1 / v2;
    Console.WriteLine($"{v1} / {v2} = {resultado}");
}