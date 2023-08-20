namespace controleAlguel.Model
{
    public class CadastroPessoa
    {
        public int Pessoa { get; set; }
        public string nomeCompleto { get; set; }
        public string? profissao { get; set; }
        public int moradores { get; set; }
        public string renda { get; set; }
        public string email { get; set; }
        public string contato { get; set; }
        IList<controleImoveis>? controleImoveis { get; set; }

    }
}
