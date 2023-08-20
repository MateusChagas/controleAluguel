namespace controleAlguel.Model
{
    public class controleImoveis
    {
        public int imovel { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public int comodos { get; set; }
        public bool locado { get; set; }
        public string valorAnunciado { get; set; }

        IList<CadastroPessoa>? cadastroPessoas { get; set; }

    }
}
