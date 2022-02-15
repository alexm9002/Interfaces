using System;
using Interfaces.Entidades;

namespace Interfaces.Servicos {
    internal class ServicoLocacao {
        public double ValorPorHora { get; private set; }
        public double ValorPorDia { get; private set; }

        private ITaxaServico _taxaServico;

        public ServicoLocacao(double valorPorHora, double valorPorDia, ITaxaServico taxaServico) {
            this.ValorPorHora = valorPorHora;
            this.ValorPorDia = valorPorDia;
            this._taxaServico = taxaServico;
        }
        public void ProcessamentoFatura(LocacaoVeiculo locacaoVeiculo) {
            TimeSpan duracao = locacaoVeiculo.Devolucao.Subtract(locacaoVeiculo.Retirada);
            double pagamentoBasico = 0.0;
            if (duracao.TotalHours <= 12.0) {
                pagamentoBasico = ValorPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else {
                pagamentoBasico = ValorPorDia * Math.Ceiling(duracao.TotalDays);
            }
            
            double Taxa = _taxaServico.Taxa(pagamentoBasico);
            locacaoVeiculo.Fatura = new Fatura(pagamentoBasico, Taxa);

        }
    }
}
