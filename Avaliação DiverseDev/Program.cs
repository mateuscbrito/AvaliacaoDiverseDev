using System;
using System.Drawing;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Avaliação_DiverseDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Escreva um programa que faça a leitura de 5 valores Inteiros do usuário.
            //Em seguida, o programa deve exibir no console a informação de quantos dos valores digitados são pares,
            //quantos dos valores digitados são ímpares, quantos deles são positivos e, por fim, quantos são negativos.
            //Cada uma das informações deve ser escrita em uma linha diferente.

            //    int quantidadevalores = 5;
            //    int numpares = 0;
            //    int numimpares = 0;
            //    int numpositivos = 0;
            //    int numnegativos = 0;

            //    for (int i = 1; i <= quantidadevalores; i++)
            //    {
            //        Console.Write($"Escreva o {i}º valor: ");
            //        int valor;

            //        if (int.TryParse(Console.ReadLine(), out valor))
            //        {

            //            if (valor % 2 == 0)
            //            //verifica se o valor é par
            //            {
            //                numpares++;
            //            }
            //            else
            //            {
            //                numimpares++;
            //            }
            //            //usei um if sem else pois o valor pode ser par e negativo, ou par e positivo etc.
            //            if (valor > 0)
            //            {
            //                numpositivos++;
            //            }
            //            else if (valor < 0)
            //            {
            //                numnegativos++;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            //            i--; 
            //            // Diminuí o valor de i em 1 para que retorne ao ponto que parou e o usuário possa colocar 5 valores válidos.
            //        }
            //    }

            //    Console.WriteLine($"Quantidade de valores pares: {numpares}");
            //    Console.WriteLine($"Quantidade de valores impares: {numimpares}");
            //    Console.WriteLine($"Quantidade de valores positivos: {numpositivos}");
            //    Console.WriteLine($"Quantidade de valores negativos: {numnegativos}");
            //
            //
            //------------------------------------------------------------------------------------------------------------
            //2 - Escreva um programa que calcule e escreva a multiplicação e a divisão inteira de dois números inteiros,
            //N1 por N2, que devem ser lidos do teclado.É importante observar que a máquina que irá executar este programa
            //é capaz de efetuar apenas duas operações matemáticas: adição e subtração.Ou seja, você não poderá usar os
            //operadores de multiplicação, divisão, módulo etc. bem como truncamentos.

            //int num1, num2;
            //int multiplicacao = 0;
            //int divisao = 0;
            //bool sinal = true; //criei essa variavel pra definir o sinal da operação, vi que existe um metodo Math.Abs para ver o valor absoluto, mas quis criar a lógica sem método

            //while (true)
            //{
            //    Console.Write("Digite o primeiro número: ");
            //    if (!int.TryParse(Console.ReadLine(), out num1))
            //    {
            //        Console.WriteLine("Não é um número inteiro. Digite outro: ");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //while (true)
            //{
            //    Console.Write("Digite o outro número: ");
            //    if (!int.TryParse(Console.ReadLine(), out num2))
            //    {
            //        Console.WriteLine("Não é um número inteiro. Digite outro: ");
            //    }
            //    else if (num2 == 0)
            //    {
            //        Console.WriteLine("O divisor não pode ser zero. Digite outro: ");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //// Verifica o sinal dos resultados, para trocar no fim da operação
            //if ((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0))
            //{
            //    sinal = false;
            //}
            //// Checando se os numeros são positivos
            //if (num1 < 0)
            //    num1 = -num1;
            //if (num2 < 0)
            //    num2 = -num2;

            //for (int i = 0; i < num2; i++)
            //{
            //    multiplicacao += num1;
            //}

            //while (num1 >= num2)
            //{
            //    num1 -= num2;
            //    divisao++;
            //}



            //if (sinal == false)
            //{
            //    Console.WriteLine($"Resultado da multiplicação: {-multiplicacao}");
            //    Console.WriteLine($"Resultado da divisão inteira: {-divisao}");

            //}
            //else 
            //{
            //    Console.WriteLine($"Resultado da multiplicação: {multiplicacao}");
            //    Console.WriteLine($"Resultado da divisão inteira: {divisao}");
            //}



            //-------------------------------------------------------------------------------------------------------
            //3 - Escreva um programa que recebe como entrada uma frase do usuário.
            //Como saída o programa deve exibir no console as seguintes informações:
            //quantas palavras são maiúsculas, quantas palavras são minúsculas, quantas palavras iniciam com letra maiúscula,
            //quantas palavras iniciam com letra minúscula e a quantidade de palavras.


            //Console.WriteLine("Digite uma frase:");
            //string frase = Console.ReadLine();

            //// Pesquisei esse Regex para remover os sinais, pois eles estavam contando como letras maiusculas e deixei o "-" para palavras compostas, considerando ser só 1
            //string FraseSemSimbolos = Regex.Replace(frase, @"[.,\/#!$%\^&\*;:{}=\-_`~()]", "");

            //// Divide a frase em palavras usando espaço como separador
            //string[] palavras = FraseSemSimbolos.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //int maiusculas = 0;
            //int minusculas = 0;
            //int comecoMaiusculo = 0;
            //int comecoMinusculo = 0;

            //foreach (string palavra in palavras)
            //{
            //    if (string.IsNullOrEmpty(palavra))
            //        continue;
            //    //Fiz um tratamento pois os números estavam criando problemas e as vezes se transformando em palavras maiusculas e as vezes em minusculas
            //    if (char.IsUpper(palavra[0]) && !palavra.All(char.IsDigit))
            //        comecoMaiusculo++;
            //    else if (char.IsLower(palavra[0]) && !palavra.All(char.IsDigit))
            //        comecoMinusculo++;

            //    if (palavra == palavra.ToUpper() && !palavra.All(char.IsDigit))
            //        maiusculas++;
            //    else if (palavra == palavra.ToLower() && !palavra.All(char.IsDigit))
            //        minusculas++;
            //    //Considerei que uma palavra que tenha um número e as letras sejam minusculas é considerada uma palavra minuscula
            //}

            //int palavrastotais = palavras.Length;

            //Console.WriteLine($"Palavras maiúsculas: {maiusculas}");
            //Console.WriteLine($"Palavras minúsculas: {minusculas}");
            //Console.WriteLine($"Palavras iniciadas com letra maiúscula: {comecoMaiusculo}");
            //Console.WriteLine($"Palavras iniciadas com letra minúscula: {comecoMinusculo}");
            //Console.WriteLine($"Total de palavras: {palavrastotais}");





            //-----------------------------------------------------------------------------------------------

            //4 - Ao executar o código a seguir será exibido qual valor no terminal? Justifique sua resposta.


            //Int32 numero;
            //numero = Convert.ToInt16(!(21 > 21));
            //Console.WriteLine(numero);
            //A) -1;
            //B) 0;

            //C) 1;

            //D) 21;

            //E) Irá dar erro

            //Resposta: LETRA C (1)
            //21 não é maior que 21, que seria falso, mas a (!) nega a expressão, tornando ela verdadeira
            //O convert vai transformar o booleano de verdadeiro em um inteiro que é 1





            //-----------------------------------------------------------------------------------------------
            //5 - Analise o código a seguir.

            //            for (int i = -5; i <= 7; i += 3)
            //            {
            //                Console.WriteLine(i);
            //            }
            //            Assinale a opção que apresenta corretamente o resultado produzido pela execução do trecho acima. Justifique o porque dessa opção.

            //A) –2, 1, 4, 7, 10

            //B) –5, –2, 1, 4, 10

            //C) –2, 1, 4, 7

            //D) –5, –2, 1, 4

            //E) –5, –2, 1, 4, 7


            //Resposta: Letra E ( –5, –2, 1, 4, 7 )
            //O for vai rodar até o i ser maior que 7 e vai imprimir cada vez desde o -5, somando +3 a cada vez. E no i=7 vai rodar ainda pois ela só para quando o i for maior que 7



        }
    }
}