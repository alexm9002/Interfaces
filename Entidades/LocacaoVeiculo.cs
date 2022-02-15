using System;

namespace Interfaces.Entidades {
    internal class LocacaoVeiculo {
        public DateTime Retirada { get; set; }
        public DateTime Devolucao { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public LocacaoVeiculo(DateTime retirada, DateTime devolucao, Veiculo veiculo) {
            this.Retirada = retirada;
            this.Devolucao = devolucao;
            this.Veiculo = veiculo;
            this.Fatura = null;
        }
    }
}
