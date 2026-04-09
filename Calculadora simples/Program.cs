using System;
using System.Collections;
using System.ComponentModel.Design;
//Calculadora simples usando switch case para escolher a operação, e if para verificar se o segundo numero é 0 para evitar divisão por zero

void calculadora()
{
    Console.WriteLine("Digite o primeiro numero");
    double num1 = Convert.ToDouble(Console.ReadLine()); //! para dizer que não é nulo, ou seja, o usuário tem que digitar um numero

    Console.WriteLine("Escolha uma operação: +, -, *, /");
    string operacao = Console.ReadLine()!;

    Console.WriteLine("Digite o segundo numero");
    double num2 = Convert.ToDouble(Console.ReadLine());

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
            Console.WriteLine("Operação invalida");
            break;

    }
}
calculadora();

