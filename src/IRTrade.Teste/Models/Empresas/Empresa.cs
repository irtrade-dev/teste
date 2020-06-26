namespace IRTrade.Teste.Models.Empresas
{
    public class Empresa
    {
        //Aqui são as propriedades que o Cadastro de Empresa deve receber.
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Uf { get; set; }

        /// <summary>
        /// Aqui são os dados que cada campo do cadastro de empresa irá receber.
        /// </summary>
        /// <param name="nomeFantasia"></param>
        /// <param name="cnpj"></param>
        /// <param name="uf"></param>
        public Empresa(string nomeFantasia, string cnpj, string uf)
        {
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            Uf = uf;
        }

        public Empresa() { }
    }
}