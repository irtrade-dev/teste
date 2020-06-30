using IRTrade.Teste.Models.Empresas;
using IRTrade.Teste.Models.Telefones;
using System;
using System.Collections.Generic;

namespace IRTrade.Teste.Models.Fornecedores
{
    public class Fornecedor
    {
        //Aqui são as propriedades que o Cadastro de Fornecedor deve receber.
        public long FornecedorId { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Telefone> Telefones { get; set; }
        public virtual Empresa Empresa { get; set; }

        //Aqui são os dados que cada campo do cadastro de fornecedor irá receber.
        public Fornecedor(long fornecedorId,
                          string nome,
                          string cpfCnpj,
                          string rg,
                          DateTime dataNascimento,
                          DateTime dataCadastro,
                          List<Telefone> telefones,
                          Empresa empresa)
        {
            FornecedorId = fornecedorId;
            Nome = nome;
            CpfCnpj = cpfCnpj;
            Rg = rg;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
            Telefones = telefones;
            Empresa = empresa;
        }

        public Fornecedor() { }
    }
}