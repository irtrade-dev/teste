namespace IRTrade.Teste.Models.Telefones
{
    public class Telefone
    {
        public string CodigoPais { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }

        public Telefone(string codigoPais, string ddd, string numero)
        {
            CodigoPais = codigoPais;
            Ddd = ddd;
            Numero = numero;
        }

        public Telefone() { }
    }
}