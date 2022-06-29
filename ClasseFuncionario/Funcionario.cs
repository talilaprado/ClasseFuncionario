using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    internal class Funcionario
    {
        private string Nome;
        private string Email;
        private int Idade;
        private string Setor;
        private string DataContratacao;
        private string dataContratacao;
        double Salario;

        public Funcionario(string nome, string email, int idade, string setor, string dataContratacao, double salario)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
            Setor = setor;
            DataContratacao = dataContratacao;
            Salario = salario;
        }

        public double SalarioLiquido()
        {
            return Salario * 0.80;
        }

        public string TodasInfos()
        {
            string infos;
            infos = "Nome: " + Nome + "\n" +
                "E-Mail: " + Email + "\n" +
                "Idade: " + Idade + "\n" +
                "Setor: " + Setor + "\n" +
                "Data de Contratação: " + dataContratacao + "\n" +
                "Salário: " + Salario;
            return infos;

        }


    }
}
