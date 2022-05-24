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

            Funcionario carlos = new Funcionario(2000, "987.654.321-01");

            carlos.Nome = "Carlos";

            carlos.AumentarSalario();
            Console.WriteLine($"Novo salário do Carlos: {carlos.Salario}");

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor(5000, "123.456.789-10");

            roberta.Nome = "Roberta";

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(roberta);

            Funcionario robertaTeste = roberta;

            roberta.AumentarSalario();
            Console.WriteLine($"Novo salário de Roberta: {roberta.Salario}");

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
