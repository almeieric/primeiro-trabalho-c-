using System;

namespace IntroduçãoAProgramaçãocomCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            /*O que aparece na janela do console, quando cada uma das instruções C# abaixo são
            executadas, para x = 2 e y = 3 ?*/

            Console.Write("\n");
            Console.WriteLine("Exercicio 2");
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

            Console.Write("\n");
            /*O que o código a seguir imprime?*/
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Ele ira saltar uma linha a cada barra n lido");
            Console.WriteLine("*\n * *\n * **\n * ***\n * ****");

            Console.Write("\n");
            /*O que o código a seguir imprime?*/
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Quando o * vier no console.Write ele ira escrever na frente do outro e quando" +
                " vier depois do write line ele ira escrever em outra linha  ");

            Console.Write("*");
            Console.Write("***");
            Console.WriteLine("*****");
            Console.Write("****");
            Console.WriteLine("**");

            /*Escreva um programa que leia o nome, o sobrenome e o número de matrícula de um
estudante. Em seguida, formate e imprima os dados lidos da seguinte forma: 
99999 - nome sobrenome, onde, o número de matrícula e nome deverão ter cores de fonte              diferentes à sua escolha. Dica: pesquise pela propriedade Console.ForegroundColor*/

            Console.Write("\n"); 
            Console.WriteLine("Exercicio 5");

            Console.WriteLine("Qual Seu Nome?");
            var name = Console.ReadLine();

            Console.WriteLine("Qual Seu Sobrenome?");
            var sobrenome = Console.ReadLine();

            Console.WriteLine("Qual Sua Maticula?");
            var matricula = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n {matricula} - {name} {sobrenome}");
            Console.ResetColor();


            Console.ReadLine();
        }


    }
}
