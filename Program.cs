using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bruno P. Filipe D. Richard Theylor
            //ATIVIDADE FAZER AS 4 OPERAÇÕES
            string nome;
            float n1, n2, soma, subtração, multiplicacao, divisio;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite um numero: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um outro numero: ");
            n2 = float.Parse(Console.ReadLine());
            soma = n1 + n2;
            subtração = n1 - n2;
            multiplicacao = n1 * n2;
            divisio = n1 / n2;
            Console.WriteLine(" ");
            Console.WriteLine(nome+ " a sua soma é: " +soma+ "\n");
            Console.WriteLine(nome + " a sua subtração é: " + subtração + "\n");
            Console.WriteLine(nome + " a sua multiplicação é: " + multiplicacao + "\n");
            Console.WriteLine(nome + " a sua divisão é: " + divisio + "\n");
        }
    }
}
