using System.ComponentModel.DataAnnotations;

namespace Fragance_Framework.Areas.Admin.Models
{
    public class SosUnhas
    {
        public int SosUnhasId { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Cód. Interno a vulso")]
        public string? CodInterno { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Linha { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Descrição dos Produtos")]
        public string? DescProdutos { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Descrição dos Produtos Fiscal")]
        public string? DescProdutoFiscal { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Unidade Solto")]
        public string? UnidadeSolto { get; set; }

        [StringLength(100)]       
        [Display(Name = "Cartucho c/ 06 und")]
        public string? Cartucho { get; set;}

        [StringLength(100)]
        [Display(Name = "Cx. Emb. 120 unid")]
        public string? CaixaEmbalagem { get; set; }

        [StringLength(100)]
        [Display(Name = "N° Processo")]
        public string? NumProcesso { get; set; }

        [StringLength(100)]
        public string? NCM { get; set; }

        [StringLength(100)]
        [Display(Name = "Qtd. Caixa")]
        public string? QtdCaixa { get; set; }

        [StringLength(100)]
        [Display(Name = "Qtd. Cartucho")]
        public string? QtdCartucho {  get; set; }

        //MEDIDAS E PESO PRODUTOS ESMALTE A VULSO
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public decimal Profundidade { get; set; }
        public decimal Peso { get; set; }

        //MEDIDAS CAIXA EMBARQUE E PESO ESMALTE A VULSO
        [Display(Name = "Altura")]
        public decimal Altura2 { get; set; }

        [Display(Name = "Largura")]
        public decimal Largura2 { get; set; }

        [Display(Name = "Profundidade")]
        public decimal Profundidade2 { get; set; }

        [Display(Name = "Peso")]
        public decimal Peso2 { get; set; }

        //MEDIDAS CAIXA EMBARQUE E PESO ESMALTE BLISTER
        [Display(Name = "Altura")]
        public decimal Altura3 { get; set; }

        [Display(Name = "Largura")]
        public decimal Largura3 { get; set; }

        [Display(Name = "Profundidade")]
        public decimal Profundidade3 { get; set; }

        [Display(Name = "Peso")]
        public decimal Peso3 { get; set; }

        //MEDIDAS E PESO PRODUTOS ESMALTE BLISTER
        [Display(Name = "Altura")]
        public decimal Altura4 { get; set; }

        [Display(Name = "Largura")]
        public decimal Largura4 { get; set; }

        [Display(Name = "Profundidade")]
        public decimal Profundidade4 { get; set; }

        [Display(Name = "Peso")]
        public decimal Peso4 { get; set; }

    }
}
