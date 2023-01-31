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

    switch (opcao)
    {
        case 1: Somar(); break;
        case 2: Subtrair(); break;
        case 3: Multiplicar(); break;
        case 4: Dividir(); break;
        case 0: Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Somar()
{
    Console.Clear();
    Console.WriteLine("SOMAR");
    Console.WriteLine("-----------");
    Console.WriteLine();

    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float resultado = v1 + v2;
    Console.WriteLine($"{v1} + {v2} = {resultado}");

    Console.WriteLine();
    Console.Write("Pressione [ENTER] para voltar ao menu.");
    Console.ReadKey();

    Menu();
}

static void Subtrair()
{
    Console.Clear();
    Console.WriteLine("SUBTRAIR");
    Console.WriteLine("-----------");
    Console.WriteLine();

    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float resultado = v1 - v2;
    Console.WriteLine($"{v1} - {v2} = {resultado}");

    Console.WriteLine();
    Console.Write("Pressione [ENTER] para voltar ao menu.");
    Console.ReadKey();

    Menu();
}

static void Multiplicar()
{
    Console.Clear();
    Console.WriteLine("MULTIPLICAR");
    Console.WriteLine("-----------");
    Console.WriteLine();

    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float resultado = v1 * v2;
    Console.WriteLine($"{v1} * {v2} = {resultado}");

    Console.WriteLine();
    Console.Write("Pressione [ENTER] para voltar ao menu.");
    Console.ReadKey();

    Menu();
}

static void Dividir()
{
    Console.Clear();
    Console.WriteLine("DIVIDIR");
    Console.WriteLine("-----------");
    Console.WriteLine();

    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float resultado = v1 / v2;
    Console.WriteLine($"{v1} / {v2} = {resultado}");

    Console.WriteLine();
    Console.Write("Pressione [ENTER] para voltar ao menu.");
    Console.ReadKey();

    Menu();
}