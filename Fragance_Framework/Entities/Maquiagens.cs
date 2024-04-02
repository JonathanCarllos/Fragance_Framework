using System.ComponentModel.DataAnnotations;

namespace Fragance_Framework.Entities
{
    public class Maquiagens
    {
        public int MaquiagensId { get; set; }

        [Display(Name = "Código Interno")]
        public string? CodInterno { get; set; }

        public string? Linha { get; set; }
        public string? Cor { get; set; }

        [Display(Name = "Descrição do Produto Fiscal")]
        public string? DescricaoProdutoFiscal { get; set; }

        [Display(Name = "Unidade Solto")]
        public string? UnidadeSolto { get; set; }

        public string? Cartucho { get; set; }

        [Display(Name = "Caixa de Embarque")]
        public string? CaixaEmbarque { get; set; }

        public string? NCM { get; set; }

        [Display(Name = "Quantidade por Caixa")]
        public string? QtdCaixa { get; set; }

        [Display(Name = "Quantidade por Cartucho")]
        public string? QtdCartucho { get; set; }

        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Profundidade { get; set; }
        public string? Peso { get; set; }
    }
}
