using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace IRTrade.Teste.Models.Fornecedores
{
    public class Fornecedor
    {
        //public string Empresa { get; set; } (Eu tenho que puxar a outra Classe Empresa
        
        //Aqui são as propriedades que o Cadastro de Fornecedor deve receber.
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DataSet DataNascimento { get; set; }
        public DataSetDateTime DataCadastro { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }

        //Aqui são os dados que cada campo do cadastro de fornecedor irá receber.
        public Fornecedor(string nome_fornecedor, string cnpj, string cpf, string rg, DataSet datanasc, DataSetDateTime data_cadastro, string telfixo, string telcel)
        {
            this.Nome = nome_fornecedor;
            this.CNPJ = cnpj;
            this.CPF = cpf;
            this.RG = rg;
            this.DataNascimento = datanasc;
            this.DataCadastro = data_cadastro;
            this.TelefoneFixo = telfixo;
            this.TelefoneCelular = telcel;
        }


    }
}