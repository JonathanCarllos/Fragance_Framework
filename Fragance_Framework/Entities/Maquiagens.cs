namespace Fragance_Framework.Entities
{
    public class Maquiagens
    {
        public int MaquiagensId { get; set; }
        public string? CodInterno { get; set; }
        public string? Linha { get; set; }
        public string? Cor { get; set; }
        public string? DescricaoProdutoFiscal { get; set; }
        public string? UnidadeSolto { get; set; }
        public string? Cartucho {  get; set; }
        public string? CaixaEmbarque { get; set; }
        public string? NCM { get; set; }
        public string? QtdCaixa { get; set; }
        public string? QtdCartucho { get; set; }
        public double Altura {  get; set; }
        public double Largura { get; set; }
        public double Profundidade {  get; set; }
        public string? Peso { get; set; }
    }
}
