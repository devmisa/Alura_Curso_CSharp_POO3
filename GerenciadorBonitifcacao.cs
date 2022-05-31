using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonitifcacao
    {

        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();

        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }


    }
}
