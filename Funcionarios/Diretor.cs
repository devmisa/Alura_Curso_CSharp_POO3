using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}
