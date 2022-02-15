
namespace Interfaces.Servicos {
    internal class TaxaBrasil : ITaxaServico {
        public double Taxa(double valor) {
            if (valor <= 100.0) {
                return valor * 0.2;
            }
            else {
                return valor * 0.15;
            }

        }
    }
}
