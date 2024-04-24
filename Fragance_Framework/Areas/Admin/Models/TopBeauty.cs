namespace Fragance_Framework.Areas.Admin.Models
{
    public class TopBeauty
    {
        public int TopBeautyId { get; set; }
        public string? CodInternoAvulso { get; set; }
        public string? Linha { get; set; }
        public string? DescProduto { get; set; }

        //esmalte avulso
        public string? UnidadeSolto { get; set; }
        public string? Cartucho { get; set;} //com 6 unidades
        public string? CaixaEmbalagem { get; set; } //Cx. Emb. 120 unid

        //esmalte blister
        public string? UnidadeBlister {  get; set; }
        public string? Cartucho12 { get; set; } //Cx. Emb. 120 unid
        public string? CaixaEmbalagem144 { get; set; } //Cx. Emb. 144 und

        public string? NumProcesso { get; set; }
        public string? NCM { get; set; }
        public string? QtdCaixa { get; set; }
        public string? QtdCartucho { get; set; }

        //MEDIDAS E PESO PRODUTOS ESMALTE A VULSO
        public double Altura { get; set; }
        public double Largura {  get; set; }
        public double Profundidade {  get; set; }
        public double Peso { get; set; }

        //MEDIDAS CAIXA EMBARQUE E PESO ESMALTE A VULSO
        public double Altura2 { get; set; }
        public double Largura2 { get; set; }
        public double Profundidade2 { get; set; }
        public double Peso2 { get; set; }

        //MEDIDAS CAIXA EMBARQUE E PESO ESMALTE BLISTER
        public double Altura3 { get; set; }
        public double Largura3 { get; set; }
        public double Profundidade3 { get; set; }
        public double Peso3 { get; set; }

        //MEDIDAS E PESO PRODUTOS ESMALTE BLISTER
        public double Altura4 { get; set; }
        public double Largura4 { get; set; }
        public double Profundidade4 { get; set; }
        public double Peso4 { get; set; }


    }
}
