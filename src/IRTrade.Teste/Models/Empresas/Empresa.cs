using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRTrade.Teste.Models.Empresas
{
    public class Empresa
    {

        //Aqui são as propriedades que o Cadastro de Empresa deve receber.
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string UF { get; set; }

        //Aqui são os dados que cada campo do cadastro de empresa irá receber.
        public Empresa(string nome_empresa, string numcnpj , string estado)
        {
            this.Nome = nome_empresa;
            this.CNPJ = numcnpj;
            this.UF = estado;
        }
    }
}