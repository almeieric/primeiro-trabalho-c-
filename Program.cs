using System;

namespace IntroduçãoAProgramaçãocomCSharp
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.Write("Exercicio 1 \n");
            /*Escreva um aplicativo que apresente os números 
             * de 1 a 40 separados por um espaço em
             * branco, da seguinte maneira:*/

            /*int n = 0;
            do
            {
                Console.Write(n + "\t");
                n++;
            } while (n <= 40);
            */

            /*a.Use uma única instrução Console.Write*/
            Console.Write("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 ");

            /*b. Use quatro instruções Console.Write*/
            Console.Write("\n1 2 3 4 5 6 7 8 9 10\t");
            Console.Write("11 12 13 14 15 16 17 18 19 20\t");
            Console.Write("21 22 23 24 25 26 27 28 29 30\t");
            Console.Write("31 32 33 34 35 36 37 38 39 40\t");

            Console.ReadKey(true);
            Console.Clear();
            Console.Write("\n");
            Console.WriteLine("Exercicio 2");

            /*O que aparece na janela do console, quando cada uma das instruções C# abaixo são
        executadas, para x = 2 e y = 3 ?*/

            int x = 2;
            int y = 3;
            Console.Write("a/");
            Console.WriteLine("x = " + x);
            Console.Write("b/");
            Console.WriteLine("O valor de x + x é " + (x + x));
            Console.Write("c/");
            Console.WriteLine("x = ");
            Console.Write("d/");
            Console.WriteLine((x + y) + " = " + (y + x));

            Console.ReadKey(true);
            Console.Clear();
            Console.Write("\n");
            Console.WriteLine("Exercicio 3");
            /*O que o código a seguir imprime?*/

            Console.WriteLine("Ele ira saltar uma linha a cada barra n lido");
            Console.WriteLine("*\n * *\n * **\n * ***\n * ****");

            Console.ReadKey(true);
            Console.Clear();
            Console.Write("\n");
            Console.WriteLine("Exercicio 4");
            /*O que o código a seguir imprime?*/

            Console.WriteLine("Quando o * vier no console.Write ele ira escrever na frente do outro e quando" +
                " vier depois do write line ele ira escrever em outra linha  ");

            Console.Write("*");
            Console.Write("***");
            Console.WriteLine("*****");
            Console.Write("****");
            Console.WriteLine("**");

            Console.ReadKey(true);
            Console.Clear();
            Console.Write("\n");
            Console.WriteLine("Exercicio 5");
            /*Escreva um programa que leia o nome, o sobrenome e o número de matrícula de um
             * estudante. Em seguida, formate e imprima os dados lidos da seguinte forma: 
             * 99999 - nome sobrenome, onde, o número de matrícula e nome deverão ter cores de fonte
             * diferentes à sua escolha. Dica: pesquise pela propriedade Console.ForegroundColor*/

            Console.WriteLine("Qual Seu Nome?");
            var name = Console.ReadLine();

            Console.WriteLine("Qual Seu Sobrenome?");
            var sobrenome = Console.ReadLine();

            Console.WriteLine("Qual Sua Maticula?");
            var matricula = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n {matricula} - {name} {sobrenome}");
            Console.ResetColor();



            Console.ReadKey(true);
            Console.Clear();
            Console.Write("\n");
            Console.WriteLine("Exercicio 6");
            /*Escreva um programa que solicite do usuário dois números, e imprima o resultado da
soma, subtração, multiplicação e divisão*/

            Console.WriteLine("Calcule");
            Console.WriteLine("\nInforme Primeiro Numero");
            int Num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme Segundo Numero");
            int Num2 = Int32.Parse(Console.ReadLine());


            //somar
            Console.WriteLine("\no valor é " + (Num1 + Num2));
            //subtrair
            Console.WriteLine("\no valor é " + (Num1 - Num2));
            //dividir
            Console.WriteLine("\no valor é " + (Num1 / Num2));
            //multiplicar
            Console.WriteLine("\no valor é " + (Num1 * Num2));

            Console.ReadKey(true);
            Console.Clear();

            Console.Write("\n");
            Console.WriteLine("Exercicio 7");

            /*Escreva um programa que receba como entrada o raio de um círculo e imprima o
             * diâmetro, a circunferência e a área. Para isso, utilize as fórmulas: diâmetro = 2r;
             * circunferência = 2πr, área = πr²*/

            Console.ReadKey(true);
            Console.Clear();

            Console.Write("\n");
            Console.WriteLine("Exercicio 8");
            /*Escreva um programa que leia dois números inteiros e determine e verifique se o primeiro
             * é um múltiplo do segundo. Por exemplo: se o usuário digitar 15 e 3, o primeiro número
             * será múltiplo do segundo; se o usuário digitar 2 e 4, o primeiro número não será múltiplo
             * do segundo. Dica: use o operador módulo para obter o resto da divisão.*/


            Console.WriteLine("\nConferindo multiplos");


            Console.WriteLine("\nInforme Primeiro Numero");
            int mult1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme Segundo Numero");
            int mult2 = Int32.Parse(Console.ReadLine());
            int multest = mult1 % mult2;


            if (multest == 0)
            {
                Console.WriteLine("Eles são multiplos");
                Console.Write("Resultado= ");
                Console.Write(mult1 / mult2);
            }
            else
            {
                Console.WriteLine("Eles não são multiplos");
            }
            Console.ReadKey(true);
            Console.Clear();

            Console.Write("\n");
            Console.WriteLine("Exercicio 9");

            /*Escreva um programa que receba como entrada um número de 5 dígitos, separe o número
             * em dígitos individuais e os imprima separados por 3 espaços cada um. Por exemplo, se o
             * usuário digitar 42339, o programa deverá imprimir: 4 2 3 3 9. Dica: utilize as
             * operações de divisão e módulo para extrair cada dígito do número*/

            Console.WriteLine("Insira 5 digitos");


            int digite = Int32.Parse(Console.ReadLine());


            Console.ReadKey(true);
            Console.Clear();

            Console.Write("\n");
            Console.WriteLine("Exercicio 10");

            /*Escreva um programa que calcule o quadrado e o cubo dos números de 0 a 10, e imprima
             * os valores em forma de tabela.*/

            for (int n = 0; n <= 10; n++) 
            { 
            Console.Write((n) + (n * n) + (n * n * n));
            }






        }//fim do main


    }//fim do program
}//fim do system

