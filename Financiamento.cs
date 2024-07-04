using System;

namespace Financiamentos
{
    public abstract class Financiamento
    {
        public decimal Montante { get; set; }
        public int Prazo { get; set; } // em meses
        public decimal TaxaJuroAnual { get; set; }

        public Financiamento(decimal montante, int prazo, decimal taxaJuroAnual)
        {
            Montante = montante;
            Prazo = prazo;
            TaxaJuroAnual = taxaJuroAnual;
        }

        public abstract decimal CalcularMensalidade();
    }

    public class FinanciamentoDeCarro : Financiamento
    {
        private const decimal ComissaoAbertura = 0.0001m;
        private const decimal ValorResidual = 0.01m;
        private const int PrazoMaximo = 60;

        public FinanciamentoDeCarro(decimal montante, int prazo, decimal taxaJuroAnual)
            : base(montante, prazo > PrazoMaximo ? PrazoMaximo : prazo, taxaJuroAnual)
        {
        }

        public override decimal CalcularMensalidade()
        {
            decimal principal = Montante * (1 - ValorResidual);
            decimal jurosMensal = TaxaJuroAnual / 12 / 100;
            decimal comissao = Montante * ComissaoAbertura;

            decimal mensalidade = (principal * jurosMensal) / (1 - (decimal)Math.Pow((double)(1 + jurosMensal), -Prazo));
            return mensalidade + comissao / Prazo;
        }
    }

    public class FinanciamentoDeCasa : Financiamento
    {
        private const decimal Spread = 1.5m;

        public string FiadorNome { get; set; }
        public string FiadorMorada { get; set; }
        public string FiadorTelefone { get; set; }
        public string FiadorNIF { get; set; }
        public decimal FiadorRendimentoAnual { get; set; }

        public FinanciamentoDeCasa(decimal montante, int prazo, decimal taxaJuroAnual, string fiadorNome, string fiadorMorada, string fiadorTelefone, string fiadorNIF, decimal fiadorRendimentoAnual)
            : base(montante, prazo, taxaJuroAnual + Spread)
        {
            FiadorNome = fiadorNome;
            FiadorMorada = fiadorMorada;
            FiadorTelefone = fiadorTelefone;
            FiadorNIF = fiadorNIF;
            FiadorRendimentoAnual = fiadorRendimentoAnual;
        }

        public override decimal CalcularMensalidade()
        {
            decimal jurosMensal = TaxaJuroAnual / 12 / 100;
            decimal mensalidade = (Montante * jurosMensal) / (1 - (decimal)Math.Pow((double)(1 + jurosMensal), -Prazo));
            return mensalidade;
        }
    }

    public class OutrosFinanciamentos : Financiamento
    {
        private const decimal ComissaoAbertura = 0.01m;
        private const decimal TaxaAmortizacaoAntecipada = 0.0005m;

        public OutrosFinanciamentos(decimal montante, int prazo, decimal taxaJuroAnual)
            : base(montante, prazo, taxaJuroAnual)
        {
        }

        public override decimal CalcularMensalidade()
        {
            decimal jurosMensal = TaxaJuroAnual / 12 / 100;
            decimal comissao = Montante * ComissaoAbertura;
            decimal mensalidade = (Montante * jurosMensal) / (1 - (decimal)Math.Pow((double)(1 + jurosMensal), -Prazo));
            return mensalidade + comissao / Prazo;
        }
    }
}

