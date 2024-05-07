using System.ComponentModel.DataAnnotations;

namespace Fragance_Framework.Areas.Admin.Models
{
    public class Alcool
    {
        public int AlcoolId {  get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Cód. Interno")]
        [StringLength(100)]
        public string? CodSistema { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? Linha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Fragância")]
        [StringLength(100)]
        public string? Fragancia { get; set; }

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
        [Display(Name = "Cartucho")]
        [StringLength(100)]
        public string? Cartucho { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Cx. Embarque")]
        [StringLength(100)]
        public string? CaixaEmbalagem { get; set; }
       

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? NCM { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Qtd. Caixa")]
        [StringLength(100)]
        public string? QtdCaixa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Qtd. Cartucho")]
        [StringLength(100)]
        public string? QtdCartucho { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Altura cm")]
        public double Altura { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Largura cm")]
        public double Largura { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Profundidade cm")]
        public double Profundidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public double Peso { get; set; }
    }
}