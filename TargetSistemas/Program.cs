using System;

namespace TargetSistemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            Console.WriteLine("-- Exercicio 1 --");
            Console.WriteLine();
            int indice = 13, soma = 0, K = 0;

            for (int i = 0; K < indice; i++)
            {
                K++;
                soma = soma + K;
            }

            Console.WriteLine($"Resultado: {soma}" );
            Console.WriteLine();

            //Exercicio 2
            Console.WriteLine("-- Exercicio 2 --");

            Console.WriteLine();

            Console.WriteLine("Digite um número: ");
            int valor = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0, resultado = 4;

            for (int i = 0; i <= valor; i++)
            {
                c = a + b;
                if (valor == a || valor == b || valor == c)
                {
                    resultado = valor;
                }
                a = b;
                b = c;
            }
            if (resultado != 4)
            {
                Console.WriteLine($"O número {valor} pertence a sequência!");
            }
            else
            {
                Console.WriteLine($"O número {valor} não pertence a sequência!");
            }

            Console.WriteLine();

            //Exercicio 3 - Não veio o Json com os dados
            Console.WriteLine("-- Exercicio 3 - Não veio o Json/XLM com os dados --");

            //Exercicio 4
            Console.WriteLine("-- Exercicio 4 --");
            Console.WriteLine();

            double sp = 67.83643,
                       rj = 36.67866,
                       mg = 29.22988,
                       es = 27.16548,
                       outros = 19.84953,
                       total = (sp + rj + mg + es + outros),
                       psp = ((sp / total) * 100),
                       prj = ((rj / total) * 100),
                       pmg = ((mg / total) * 100),
                       pes = ((es / total) * 100),
                       poutros = ((outros / total) * 100);

            Console.WriteLine($"Porcentagem de São Paulo: {string.Format("{0:P2}", psp / 100)}");
            Console.WriteLine($"Porcentagem de Rio de Janeiro: {string.Format("{0:P2}", prj / 100)}");
            Console.WriteLine($"Porcentagem de Minas Gerais: {string.Format("{0:P2}", pmg / 100)}");
            Console.WriteLine($"Porcentagem de Espirito Santo: {string.Format("{0:P2}", pes / 100)}");
            Console.WriteLine($"Porcentagem de outros estados: {string.Format("{0:P2}", poutros / 100)}");

            Console.WriteLine();

            //Exercicio 5
            Console.WriteLine("-- Exercicio 5 --");
            Console.WriteLine();

            Console.WriteLine("Digite uma palavra: ");
            string nome = Console.ReadLine();
            char[] nomeInvertido = nome.ToCharArray();


            for (int i = 0; i < nomeInvertido.Length / 2; i++)
            {
                char ch = nomeInvertido[i];
                nomeInvertido[i] = nomeInvertido[nomeInvertido.Length - i - 1];
                nomeInvertido[nomeInvertido.Length - i - 1] = ch;
            }
            Console.WriteLine();
            Console.WriteLine(nomeInvertido);



        }
    }
}


