using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class ContaBancaria
    {
        public string NAgencia { get; private set; }
        public string NConta { get; private set; }
        public string CPF { get; private set; }
        public double Saldo { get; private set; }

        private List<OperacaoBancaria> _operacoes;

        public ContaBancaria(string nAgencia, string nConta, string cpf)
        {
            if (string.IsNullOrWhiteSpace(nAgencia) || nAgencia.Length < 4)
            {
                throw new Exception("Número agência deve ser informada e possuir pelo menos 4 caracteres.");
            }
            if (string.IsNullOrWhiteSpace(nConta) || nConta.Length < 7 || nConta.Length > 10)
            {
                throw new Exception("Número conta deve ser informada e possuir entre 7 e 10 caracteres.");
            }
            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
            {
                throw new Exception("CPF inválido.");
            }
            this.NAgencia = nAgencia;
            this.NConta = nConta;
            this.CPF = cpf;
            this._operacoes = new List<OperacaoBancaria>();
        }


        public RespostaOperacaoBancaria Depositar(double quantia)
        {
            RespostaOperacaoBancaria resposta = new RespostaOperacaoBancaria();

            if (quantia < 10)
            {
                resposta.Mensagem = "Quantia inválida.";
                resposta.Sucesso = false;
                return resposta;
            }

            this.Saldo += quantia;
            resposta.Mensagem = "Depósito realizado com sucesso.";
            resposta.Sucesso = true;

            this.AuditarOperacao(quantia, TipoOperacao.Deposito);

            return resposta;
        }

        public RespostaOperacaoBancaria Sacar(double quantia)
        {
            RespostaOperacaoBancaria resposta = new RespostaOperacaoBancaria();

            if (quantia < 10)
            {
                resposta.Mensagem = "Quantia inválida.";
                resposta.Sucesso = false;
                return resposta;
            }
            if (quantia > this.Saldo)
            {
                resposta.Mensagem = "Saldo insuficiente.";
                resposta.Sucesso = false;
                return resposta;
            }
            this.Saldo -= quantia;
            resposta.Mensagem = "Saque realizado com sucesso.";
            resposta.Sucesso = true;

            this.AuditarOperacao(quantia, TipoOperacao.Saque);

            return resposta;
        }

        public string ImprimirExtrato()
        {
            StringBuilder sb = new StringBuilder();
            foreach (OperacaoBancaria operacao in _operacoes)
            {
                sb.Append(operacao.ToString());
            }
            return sb.ToString();
        }

        public string ImprimirExtrato(TipoOperacao tipo, int mes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (OperacaoBancaria operacao in _operacoes)
            {
                if (operacao.Tipo == tipo && operacao.Data.Month == mes)
                {
                    sb.Append(operacao.ToString());
                }
            }
            return sb.ToString();
        }

        public string ImprimirExtrato(TipoOperacao tipo)
        {
            StringBuilder sb = new StringBuilder();
            foreach (OperacaoBancaria operacao in _operacoes)
            {
                if (operacao.Tipo == tipo && operacao.Quantia >= 500)
                {
                    sb.Append(operacao.ToString());
                }
            }
            return sb.ToString();
        }

        public RespostaOperacaoBancaria Transferir(double quantia, ContaBancaria conta)
        {
            RespostaOperacaoBancaria resposta = this.Sacar(quantia);
            if (resposta.Sucesso)
            {
                return conta.Depositar(quantia);
            }
            return resposta;
        }


        private void AuditarOperacao(double quantia, TipoOperacao tipo)
        {
            OperacaoBancaria operacao = new OperacaoBancaria();
            operacao.Quantia = quantia;
            operacao.SaldoPosOperacao = this.Saldo;
            operacao.Tipo = tipo;
            this._operacoes.Add(operacao);
        }




    }
}
