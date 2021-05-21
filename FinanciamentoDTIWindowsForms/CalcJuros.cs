using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinanciamentoDTIWindowsForms
{
    public partial class CalcJuros : Form
    {
        public CalcJuros()
        {
            InitializeComponent();
            ComparaEmpresas();
        }

        //Monta a lista de Empresas para realizar o comparativo entre as empresas
        private void ComparaEmpresas()
        {
            List<Empresa> empresas = new List<Empresa>
            {
                new Empresa()
                {
                    NomeEmpresa = lblEmpresaA.Text,
                    Entrada = Convert.ToDouble(lblEntrEmpA.Text),
                    TaxaJuros = Convert.ToDouble(lblTxA.Text),
                    ValorParcela = Convert.ToDouble(lblVlA.Text),
                    QtdAnosParcelamento = Convert.ToInt32(lblAnosA.Text)
                }
            };

            empresas.Add(new Empresa()
            {
                NomeEmpresa = lblEmpresaB.Text,
                Entrada = Convert.ToDouble(lblEntrEmpB.Text),
                TaxaJuros = Convert.ToDouble(lblTxB.Text),
                ValorParcela = Convert.ToDouble(lblVlB.Text),
                QtdAnosParcelamento = Convert.ToInt32(lblAnosB.Text)
            });

            empresas.Add(new Empresa()
            {
                NomeEmpresa = lblEmpresaC.Text,
                Entrada = Convert.ToDouble(lblEntrEmpC.Text),
                TaxaJuros = Convert.ToDouble(lblTxC.Text),
                ValorParcela = Convert.ToDouble(lblVlC.Text),
                QtdAnosParcelamento = Convert.ToInt32(lblAnosC.Text)
            });

            empresas.Add(new Empresa()
            {
                NomeEmpresa = lblEmpresaD.Text,
                Entrada = Convert.ToDouble(lblEntrEmpD.Text),
                TaxaJuros = Convert.ToDouble(lblTxD.Text),
                ValorParcela = Convert.ToDouble(lblVlD.Text),
                QtdAnosParcelamento = Convert.ToInt32(lblAnosD.Text)
            });

            CalculaMontante(empresas);

            ImprimeResultado(RetornaEmpresaMenorMontante(empresas));            
        }

        //Imprime o resultado do comparativo em tela
        private void ImprimeResultado(Empresa empresa)
        {
            lblTituloResult.Text = String.Format("A empresa {0} tem o menor valor final do montante: {1}", empresa.NomeEmpresa, empresa.Montante.ToString("C"));
        }

        //Retorna a empresa com o menor valor final de montante
        private Empresa RetornaEmpresaMenorMontante(List<Empresa> empresas)
        {
            Empresa empresa = empresas.OrderBy(p => p.Montante).First();
            return empresa;
        }

        //Aplica a fórmula de cálculo de juros compostos com aporte mensal mais o valor de entrada
        private void CalculaMontante(List<Empresa> empresas)
        {
            foreach (var empresa in empresas)
            {
                int nMeses = empresa.QtdAnosParcelamento * 12;
                double txJuros = empresa.TaxaJuros / 100;

                empresa.Montante = (empresa.ValorParcela * ((Math.Pow((1 + txJuros), nMeses) - 1) / txJuros)) + empresa.Entrada;
            }
        }

        //Botão para fechar a aplicação
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalcJuros_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar da aplicação?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
