namespace Projeto.Dominio
{
    public class Cliente
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
    }
}
