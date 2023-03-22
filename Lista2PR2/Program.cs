using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            //Console.Write("Digite o número de laranjas compradas: ");
            //int laranjas_compradas = int.Parse(Console.ReadLine());

            //double valor_total = 0;
            //if (laranjas_compradas < 12)
            //{
            //    valor_total = laranjas_compradas * 0.35;
            //}
            //else
            //{
            //    valor_total = laranjas_compradas * 0.28;
            //}

            //Console.WriteLine("O valor total da compra é: R$ " + valor_total.ToString("F2"));

            //Exercício 2
            //Console.Write("Digite o ano de nascimento: ");
            //int anoNascimento = int.Parse(Console.ReadLine());

            //int idade = DateTime.Now.Year - anoNascimento;

            //if (idade >= 16)
            //{
            //    Console.WriteLine("Você poderá votar nas próximas eleições.");
            //}
            //else
            //{
            //    Console.WriteLine("Você ainda não poderá votar nas próximas eleições.");
            //}

            //Exercício 3
            //Console.WriteLine("Digite as medidas dos lados do triângulo:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a <= 0 || b <= 0 || c <= 0)
            //{
            //    Console.WriteLine("As medidas dos lados devem ser maiores que zero.");
            //}
            //else if (a + b <= c || b + c <= a || a + c <= b)
            //{
            //    Console.WriteLine("As medidas dos lados não formam um triângulo válido.");
            //}
            //else if (a == b && b == c)
            //{
            //    Console.WriteLine("O triângulo é equilátero.");
            //}
            //else if (a == b || b == c || a == c)
            //{
            //    Console.WriteLine("O triângulo é isósceles.");
            //}
            //else
            //{
            //    Console.WriteLine("O triângulo é escaleno.");
            //}

            //Exercício 4
            //Console.WriteLine("Digite os valores de A, B e C:");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //int delta = (b ^ 2) - (4 * a * c);

            //if (delta < 0)
            //{
            //    Console.WriteLine("A equação não possui raízes reais.");
            //}
            //else if (delta == 0)
            //{
            //    int x = -b / (2 * a);
            //    Console.WriteLine("A equação possui uma raiz real: x = " + x);
            //}
            //else
            //{
            //    int x1 = (-b + (delta)) / (2 * a);
            //    int x2 = (-b - (delta)) / (2 * a);
            //    Console.WriteLine("A equação possui duas raízes reais: x1 = " + x1 + " e x2 = " + x2);

            //Exercício 5
            //int numero = int.Parse(Console.ReadLine());

            //if (numero % 3 == 0 && numero % 5 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 3 e por 5.");
            //}
            //else if (numero % 3 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 3.");
            //}
            //else if (numero % 5 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 5.");
            //}
            //else
            //{
            //    Console.WriteLine("O número não é divisível por 3 ou 5.");

            //Execício 6
            //Console.WriteLine("Digite os três ângulos do triângulo:");

            //int angulo1 = int.Parse(Console.ReadLine());
            //int angulo2 = int.Parse(Console.ReadLine());
            //int angulo3 = int.Parse(Console.ReadLine());

            //int somaDosAngulos = angulo1 + angulo2 + angulo3;

            //if (somaDosAngulos != 180)
            //{
            //    Console.WriteLine("Os ângulos informados não formam um triângulo válido.");
            //}
            //else if (angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
            //{
            //    Console.WriteLine("O triângulo é retângulo.");
            //}
            //else if (angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
            //{
            //    Console.WriteLine("O triângulo é obtusângulo.");
            //}
            //else
            //{
            //    Console.WriteLine("O triângulo é acutângulo.");
            //}

            //Exercício 7
            //Console.WriteLine("Digite três valores inteiro");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a < b && a < c)
            //{

            //    if (b < c)
            //    {
            //        Console.WriteLine(a + "," + b + "," + c);
            //    }
            //    else
            //    {
            //        Console.WriteLine(a + ", " + c + ", " + b);
            //    }
            //}
            //else if (b < a && b < c)
            //{
            //    if (a < c)
            //    {
            //        Console.WriteLine(b + ", " + a + ", " + c);
            //    }
            //    else
            //    {
            //        Console.WriteLine(b + ", " + c + ", " + a);
            //    }
            //}
            //else
            //{
            //    if (a < b)
            //    {
            //        Console.WriteLine(c + ", " + a + ", " + b);
            //    }
            //    else
            //    {
            //        Console.WriteLine(c + ", " + b + ", " + a);
            //    }
            //}

            //Exercício 8
            //Console.Write("Informe um ano: ");
            //int ano = int.Parse(Console.ReadLine());

            //if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            //{
            //    Console.WriteLine("O ano informado é bissexto.");
            //}
            //else
            //{
            //    Console.WriteLine("O ano informado não é bissexto.");
            //}

            //Exercício 9
            //Console.Write("Digite o primeiro número: ");
            //float num1 = float.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo número: ");
            //float num2 = float.Parse(Console.ReadLine());

            //Console.Write("Digite a operação (+, -, *, /): ");
            //string operacaoStr = Console.ReadLine();
            //float resultado;
            //if (operacaoStr == "+")
            //{
            //    resultado = num1 + num2;
            //}
            //else if (operacaoStr == "-")
            //{
            //    resultado = num1 - num2;
            //}
            //else if (operacaoStr == "*")
            //{
            //    resultado = num1 * num2;
            //}
            //else if (operacaoStr == "/")
            //{
            //    resultado = num1 / num2;
            //}
            //else
            //{
            //    Console.WriteLine("Operação inválida.");
            //    return;
            //}

            //Console.WriteLine("Resultado: " + resultado);

            // exercício 10
            //Na linguagem C#, a geração de números aleatórios é realizada através da classe Random, que oferece métodos para gerar números inteiros e reais de maneira aleatória.

            //Exemplo
            //Random rand = new Random();
            //int numeroAleatorio = rand.Next(1, 101);
        }
    }
}
