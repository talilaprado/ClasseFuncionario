
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu setor: ");
            string setor = Console.ReadLine();
            Console.WriteLine("Digite sua data de contratação: ");
            string dataContrat = (Console.ReadLine());
            Console.WriteLine("Digite seu salario: ");
            double salario = double.Parse(Console.ReadLine());


            Console.Clear();

            var f = new Funcionario(nome, email, idade, setor, dataContrat, salario);

            Console.WriteLine(f.TodasInfos());
            Console.WriteLine(f.SalarioLiquido());

            Console.ReadKey();
        }
    }
}
