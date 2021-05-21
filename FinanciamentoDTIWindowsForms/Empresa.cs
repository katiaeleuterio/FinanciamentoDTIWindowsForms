namespace FinanciamentoDTIWindowsForms
{
    public class Empresa
    {
        /// <summary>
        /// Nome da Empresa
        /// </summary>
        public string NomeEmpresa { get; set; }

        /// <summary>
        /// Valor da entrada a ser paga
        /// </summary>
        public double Entrada { get; set; }

        /// <summary>
        /// Valor da taxa de juros do financiamento
        /// </summary>
        public double TaxaJuros { get; set; }

        /// <summary>
        /// Valor da parcela mensal do financiamento
        /// </summary>
        public double ValorParcela { get; set; }

        /// <summary>
        /// Quantidade de anos em que o financiamento será pago
        /// </summary>
        public int QtdAnosParcelamento { get; set; }

        public double Montante { get; set; }
    }
}