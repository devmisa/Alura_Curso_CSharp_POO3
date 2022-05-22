using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonitifcacao gerenciador = new GerenciadorBonitifcacao();

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "987.654.321-01";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.CPF = "123.456.789-10";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Funcionario robertaTeste = roberta;

            Console.WriteLine($"Bonificação de uma referência de Diretor: {roberta.GetBonificacao()}");
            Console.WriteLine($"Bonificação de uma referência de Funcionário: {robertaTeste.GetBonificacao()}\n");


            Console.WriteLine($"Nome do funcionário: {roberta.Nome}");
            Console.WriteLine($"Bonificação: {roberta.GetBonificacao()}\n");

            Console.WriteLine($"Nome do funcionário: {carlos.Nome}");
            Console.WriteLine($"Bonificação: {carlos.GetBonificacao()}");

            Console.WriteLine($"Total de bonificações: {gerenciador.GetTotalBonificacao()}");

            Console.ReadLine();
        }
    }
}
