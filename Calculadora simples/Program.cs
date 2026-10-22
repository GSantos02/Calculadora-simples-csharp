using System;
using System.Collections;
using System.ComponentModel.Design;
//Calculadora simples usando switch case para escolher a operação, e if para verificar se o segundo numero é 0 para evitar divisão por zero

void calculadora()
{
    Console.WriteLine("Digite o primeiro numero");
    if (!double.TryParse(Console.ReadLine(), out double num1)) 
    {
        Console.WriteLine("Entrada inválida.");
        return;
    } 

    Console.WriteLine("Escolha uma operação: +, -, *, /"); 
    string operacao = Console.ReadLine()!; 

    Console.WriteLine("Digite o segundo numero");
    if (!double.TryParse(Console.ReadLine(), out double num2)) 
    {
        Console.WriteLine("Entrada inválida.");
        return;
    }

    switch (operacao) 
    {
        case "+":
            Console.WriteLine($"O resultado é: {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"O resultado é: {num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"O resultado é: {num1 * num2}");
            break;
        case "/":
            if (num2 == 0) 
            {
                Console.WriteLine("Operação invalida com 0");
            }
            else
            {
                Console.WriteLine($"O resultado é: {num1 / num2}");
            }
            break;

        default:
            Console.WriteLine("Operação invalida"); 
            break;

    }
}
calculadora();

