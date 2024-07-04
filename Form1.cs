using Financiamentos;
using System;
using System.Windows.Forms;

namespace HerançaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal montante = decimal.Parse(txtMontante.Text);
            int prazo = int.Parse(txtPrazo.Text);
            decimal taxaJuroAnual = decimal.Parse(txtTaxaJuro.Text);

            Financiamento financiamento;

            if (cbTipoFinanciamento.SelectedItem.ToString() == "Carro")
            {
                financiamento = new FinanciamentoDeCarro(montante, prazo, taxaJuroAnual);
            }
            else if (cbTipoFinanciamento.SelectedItem.ToString() == "Casa")
            {
                string fiadorNome = txtFiadorNome.Text;
                string fiadorMorada = txtFiadorMorada.Text;
                string fiadorTelefone = txtFiadorTelefone.Text;
                string fiadorNIF = txtFiadorNIF.Text;
                decimal fiadorRendimentoAnual = decimal.Parse(txtFiadorRendimento.Text);

                financiamento = new FinanciamentoDeCasa(montante, prazo, taxaJuroAnual, fiadorNome, fiadorMorada, fiadorTelefone, fiadorNIF, fiadorRendimentoAnual);
            }
            else
            {
                financiamento = new OutrosFinanciamentos(montante, prazo, taxaJuroAnual);
            }

            decimal mensalidade = financiamento.CalcularMensalidade();
            lblResultado.Text = $"Mensalidade: {mensalidade:C2}";
        }

        private void cbTipoFinanciamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoFinanciamento.SelectedItem.ToString() == "Casa")
            {
                panelFiador.Visible = true;
            }
            else
            {
                panelFiador.Visible = false;
            }
        }
    }
}

