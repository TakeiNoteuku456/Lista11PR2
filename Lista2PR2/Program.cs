using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2
{
    internal class Program
    {
        static void ImprimirVet(int[] vetor, int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
        }
        static bool Primo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Exercício 1");
                Console.WriteLine("2. Exercício 2");
                Console.WriteLine("3. Exercício 3");
                Console.WriteLine("4. Exercício 4");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (opcao != 5);
        }

        static void Exercicio1()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanhoVet = int.Parse(Console.ReadLine());

            int[] n = new int[tamanhoVet];

            Console.WriteLine("Digite os números do vetor (entre 1 e 1000):");

            for (int i = 0; i < tamanhoVet; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                n[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Tente adivinhar um número existente no vetor.");

            int contador = 0;

            while (contador < tamanhoVet)
            {
                Console.Write("Digite um número: ");
                int tentativa = int.Parse(Console.ReadLine());

                for (int i = 0; i < contador; i++)
                {
                    if (n[i] == tentativa)
                    {
                        Console.WriteLine("Parabéns! Você acertou o número.");
                    }
                }
            }
            Console.WriteLine("Executando o exercício 1...");
        }

        static void Exercicio2()
        {
            int tamanhoVetor = 20000;
            int[] n1 = new int[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
            {
                n1[i] = i + 1;
            }

            Console.Write("Digite um número para contar as ocorrências: ");
            int numeroEscolhido = int.Parse(Console.ReadLine());

            int contador1 = 0;

            for (int i = 0; i < tamanhoVetor; i++)
            {
                if (n1[i] == numeroEscolhido)
                {
                    contador1 = contador1 + 1;
                }
            }

            Console.WriteLine("O número ", numeroEscolhido, " aparece ", contador1, " vezes no vetor.");


            Console.WriteLine("Executando o exercício 2...");
        }

        static void Exercicio3()
        {
            int[] vetor = new int[10];
            int[] vetorResultante = new int[10];
            int tamanhoVetor = vetor.GetLength(0);

            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.Write("Digite um número inteiro e positivo: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tamanhoVetor; i++)
            {
                if (i % 2 == 0)
                {
                    vetorResultante[i] = vetor[i] / 2;
                }
                else
                {
                    vetorResultante[i] = vetor[i] * 3;
                }
            }
            Console.WriteLine("Vetor original:");
            ImprimirVet(vetor, tamanhoVetor);

            Console.WriteLine("Vetor resultante:");
            ImprimirVet(vetorResultante, tamanhoVetor);

            Console.WriteLine("Executando o exercício 3...");
        }
        static void Exercicio4()
        {
            int tamanhoVetor = 5000;
            int[] vetor = new int[tamanhoVetor];

            // Ler os números e armazená-los no vetor
            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.Write("Digite o número {0}: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números primos encontrados:");

            // Verificar quais números do vetor são primos
            for (int i = 0; i < tamanhoVetor; i++)
            {
                if (Primo(vetor[i]))
                {
                    Console.WriteLine(vetor[i]);
                }
            }

            Console.WriteLine("Executando o exercício 4...");
        }
    }
}
        
