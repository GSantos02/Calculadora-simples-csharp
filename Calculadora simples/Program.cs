using System;
using System.Collections;
using System.ComponentModel.Design;
//Calculadora simples usando switch case para escolher a operação, e if para verificar se o segundo numero é 0 para evitar divisão por zero

void calculadora()
{
    Console.WriteLine("Digite o primeiro numero");
    if (!double.TryParse(Console.ReadLine(), out double num1)) //verificar se a entrada é um numero valido
    {
        Console.WriteLine("Entrada inválida.");
        return;
    } 

    Console.WriteLine("Escolha uma operação: +, -, *, /"); //pedir para o usuario escolher a operação
    string operacao = Console.ReadLine()!; 

    Console.WriteLine("Digite o segundo numero");
    if (!double.TryParse(Console.ReadLine(), out double num2)) //verificar se a entrada é um numero valido
    {
        Console.WriteLine("Entrada inválida.");
        return;
    }

    switch (operacao) //switch para escolher a operação
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
            if (num2 == 0) //verificar se o segundo numero é 0 para evitar divisão por zero
            {
                Console.WriteLine("Operação invalida com 0");
            }
            else
            {
                Console.WriteLine($"O resultado é: {num1 / num2}");
            }
            break;

        default:
            Console.WriteLine("Operação invalida"); //caso o usuario digite uma operação invalida
            break;

    }
}
calculadora();

