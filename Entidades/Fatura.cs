using System.Globalization;

namespace Interfaces.Entidades {
    internal class Fatura {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public Fatura(double pagamentoBasico, double taxa) {
            this.PagamentoBasico = pagamentoBasico;
            this.Taxa = taxa;
        }
        public double PagamentoTotal {
            get { return PagamentoBasico + Taxa; }
        }

        public override string ToString() {
            return "Valor Básico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nValor Total: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
