using System;

namespace IRTrade.Teste.Models.Fornecedores
{
    public class Fornecedor
    {
        //public string Empresa { get; set; } (Eu tenho que puxar a outra Classe Empresa

        //Aqui são as propriedades que o Cadastro de Fornecedor deve receber.
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }

        //Aqui são os dados que cada campo do cadastro de fornecedor irá receber.
        public Fornecedor(string nome,
                          string cpfCnpj,
                          string rg,
                          DateTime dataNascimento,
                          DateTime dataCadastro,
                          string telefoneFixo,
                          string telefoneCelular)
        {
            Nome = nome;
            CpfCnpj = cpfCnpj;
            Rg = rg;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
            TelefoneFixo = telefoneFixo;
            TelefoneCelular = telefoneCelular;
        }

        public Fornecedor() { }

    }
}