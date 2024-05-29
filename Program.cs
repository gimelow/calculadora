using System;
using System.Globalization;


void Menu()
{
    Console.WriteLine("calculadora");
    Console.WriteLine("-----------");
    Console.WriteLine("1 - adição");
    Console.WriteLine("2 - subtração");
    Console.WriteLine("3 - multiplicação");
    Console.WriteLine("4 - divisão");
    Console.WriteLine("5 - resto da divisão");
    Console.WriteLine("6 - potenciação");

    Console.WriteLine("digite a opção que deseja");
    int opcao = int.Parse(Console.ReadLine()!);
    switch (opcao)
    {
        case 1:
            Adicao();
            break;
        case 2:
            Subtracao();
            break;
        case 3:
            Multiplicacao();
            break;
        case 4:
            Divisao();
            break;
        case 5:
            RestoDaDivisao();
            break;
        case 6:
            Potenciacao();
            break;
        default:
            Menu();
            break;
    }
}

void Adicao()
{
    Console.Clear();
    Console.WriteLine("digite o primeiro número> ");
    double x = Convert.ToDouble(Console.ReadLine()!);
    Console.WriteLine("digite o segundo número> ");
    double y = Convert.ToDouble(Console.ReadLine()!);
    double soma = x + y;
    Console.WriteLine($"a soma de {x} e {y} é: {soma}");
    Thread.Sleep(2000);
    Console.WriteLine("digite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void Subtracao()
{
    Console.Clear();
    Console.WriteLine("digite o primeiro número> ");
    double x = Convert.ToDouble(Console.ReadLine()!);
    Console.WriteLine("digite o segundo número> ");
    double y = Convert.ToDouble(Console.ReadLine()!);
    double sub = x - y;
    Console.WriteLine($"a subtração de {x} e {y} é: {sub}");
    Thread.Sleep(2000);
    Console.WriteLine("digite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("digite o primeiro número> ");
    double x = Convert.ToDouble(Console.ReadLine()!);
    Console.WriteLine("digite o segundo número> ");
    double y = Convert.ToDouble(Console.ReadLine()!);
    double mult = x * y;
    Console.WriteLine($"a multiplicação de {x} e {y} é: {mult}");
    Thread.Sleep(2000);
    Console.WriteLine("digite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void Divisao()
{
    Console.Clear();
    Console.WriteLine("digite o primeiro número> ");
    double x = Convert.ToDouble(Console.ReadLine()!);
    Console.WriteLine("digite o segundo número> ");
    double y = Convert.ToDouble(Console.ReadLine()!);
    if(y == 0)
    {
        Console.WriteLine("não é possível fazer divisão por zero");
        Thread.Sleep(2000);
        Console.WriteLine("digite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    else
    {
        double div = x / y;
        Console.WriteLine($"a divisão de {x} e {y} é: {div}");
        Thread.Sleep(2000);
        Console.WriteLine("digite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    
}

void RestoDaDivisao()
{
    Console.Clear();
    Console.WriteLine("digite o primeiro número> ");
    double x = Convert.ToDouble(Console.ReadLine()!);
    Console.WriteLine("digite o segundo número> ");
    double y = Convert.ToDouble(Console.ReadLine()!);

    if (y == 0)
    {
        Console.WriteLine("não é possível fazer divisão por zero");
        Thread.Sleep(2000);
        Console.WriteLine("digite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    else
    {
        double div = x % y;
        Console.WriteLine($"o resto da divisão de {x} e {y} é: {div}");
        Thread.Sleep(2000);
        Console.WriteLine("digite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}

void Potenciacao()
{
    Console.Clear();
    Console.WriteLine("digite o número da base> ");
    double x = Convert.ToDouble(Console.ReadLine()!);
    Console.WriteLine("digite o expoente> ");
    double y = Convert.ToDouble(Console.ReadLine()!);
    if (y == 0)
    {
        Console.WriteLine($"o resultado da base {x} elevada ao expoente {y} é 1.");
        Thread.Sleep(2000);
        Console.WriteLine("digite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    else
    {
        double pot = Math.Pow(x, y);
        Console.WriteLine($"o resultado da base {x} elevada ao expoente {y} é {pot}.");
        Thread.Sleep(2000);
        Console.WriteLine("digite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}

Menu();

