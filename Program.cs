using System;
using System.Globalization;
using Interfaces.Entidades;
using Interfaces.Servicos;

namespace Interfaces {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados do Aluguel");
            Console.Write("Modelo do Veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Data de Retirada (dd/MM/yyyy hh:mm): ");
            DateTime retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data de Devolução (dd/MM/yyyy hh:mm): ");
            DateTime devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com o Valor por Hora: ");
            double valPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o Valor por Dia: ");
            double valPorDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            LocacaoVeiculo locacaoVeiculo = new LocacaoVeiculo(retirada, devolucao, new Veiculo(modelo));

            ServicoLocacao servicoLocacao = new ServicoLocacao(valPorHora, valPorDia, new TaxaBrasil());

            servicoLocacao.ProcessamentoFatura(locacaoVeiculo);

            Console.WriteLine("Fatura:");
            Console.WriteLine(locacaoVeiculo.Fatura);

        }
    }
}