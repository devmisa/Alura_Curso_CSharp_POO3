using System;

namespace ByteBank.Funcionarios
{
    // 0 - Funcionário
    // 1 - Diretor
    // 2 - Designer
    // 3 - Gerente de C/C
    // 4 - Coordenador
    // N - ...
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.15);
            //Salario = Salario * 1.15;
            Salario *= 1.15;
        }


        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
