using System.ComponentModel.DataAnnotations;

namespace Fragance_Framework.Areas.Admin.Models
{
    public class Maquiagens
    {
        public int MaquiagensId { get; set; }

        [Required(ErrorMessage ="Campo obrigatório!")]
        [Display(Name = "Código Interno")]
        public string? CodInterno { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? Linha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? Cor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Desc. Produto Fiscal")]
        public string? DescricaoProdutoFiscal { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Unidade Solto")]
        public string? UnidadeSolto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? Cartucho { get; set; }

        [Display(Name = "Caixa de Embarque")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? CaixaEmbarque { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? NCM { get; set; }

        [Display(Name = "Qtd. por Caixa")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? QtdCaixa { get; set; }

        [Display(Name = "Qtd. por Cartucho")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? QtdCartucho { get; set; }

        [Display(Name ="Altura (cm)")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public double Altura { get; set; }

        [Display(Name = "Largura (cm)")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public double Largura { get; set; }

        [Display(Name = "Profundidade (cm)")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public double Profundidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? Peso { get; set; }
    }
}
