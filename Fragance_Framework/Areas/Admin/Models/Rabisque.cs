using System.ComponentModel.DataAnnotations;

namespace Fragance_Framework.Areas.Admin.Models
{
    public class Rabisque
    {
        public int RabisqueId { get;set; }

        [Display(Name = "Cód. Sistema")]
        [StringLength(100)]
        public string? CodSistema { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? Linha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Desc. Produto")]
        [StringLength(100)]
        public string? DescProduto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Desc. Produto Fiscal")]
        [StringLength(100)]
        public string? DescProdutoFiscal { get; set; }

        //Esmalte avulso
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Unidade Solto")]
        [StringLength(100)]
        public string? UnidadeSolto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Cartucho c/ 06 und")]
        [StringLength(100)]
        public string? Cartucho { get; set; } //6 unidades

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Cx. Emb. 240 unid")]
        [StringLength(100)]
        public string? CaixaEmbalagem { get; set; } //240 unidades

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "N° Processo")]
        [StringLength(100)]
        public string? NumProcesso { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Qtd. Caixa")]
        [StringLength(100)]
        public string? QtdCaixa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Qtd. Cartucho")]
        [StringLength(100)]
        public string? QtdCartucho { get; set; }
      
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "NCM")]
        [StringLength (100)]
        public string? NCM { get; set; }
    }
}