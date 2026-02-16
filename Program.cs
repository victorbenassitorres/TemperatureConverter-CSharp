using System;
using System.Data;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;

double celsius;
double fahrenheit;
int option;

do
{
    Console.WriteLine("1 - Celsius para Fahrenheit\n2 - Fahrenheit para Celsius\n3 - Sair\nEscolha uma opção:");
    option = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (option)
    {
        case 1: Console.WriteLine("Digite a temperatura em Celsius:");
        celsius = double.Parse(Console.ReadLine());
        Console.WriteLine($"{celsius}°C equivalem a {(celsius * 9 / 5) + 32}°F");
        break;
        
        case 2: Console.WriteLine("Digite a temperatura em Fahrenheit");
        fahrenheit = double.Parse(Console.ReadLine());
        Console.WriteLine($"{fahrenheit}°F equivalem a {(fahrenheit - 32) * 5 / 9}°C");
        break;
        
        case 3: Console.WriteLine("O programa foi finalizado");
        break;
        
        default: Console.WriteLine("Opção inválida, tente novamente");
        break;
        
        Console.Clear();
    }

} while(option != 3);