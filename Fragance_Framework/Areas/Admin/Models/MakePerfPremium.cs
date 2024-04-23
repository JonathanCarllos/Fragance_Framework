using System.ComponentModel.DataAnnotations;

namespace Fragance_Framework.Areas.Admin.Models
{
    public class MakePerfPremium
    {
        //Dados Logisticos
        public int MakePerfPremiumId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Cód. Interno Avulso")]
        [StringLength(100)]
        public string? CodInternoAvulso { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? Linha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? Cor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        [Display(Name = "Desc. Produto Fiscal")]
        public string? DescProdutoFiscal { get; set; }

        //Top Beauty Make Up Studio
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        [Display(Name = "Unidade Solto")]
        public string? UnidadeSolto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? Cartucho { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        [Display(Name = "Cx Embarque")]
        public string? CaixaEmbarque { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? NCM { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        [Display(Name = "N° Processos")]
        public string? NumProcesso { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        [Display(Name = "Qtd Caixa")]
        public string? QtdCaixa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        [Display(Name = "Qtd Cartucho")]
        public string? QtdCartucho { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public double Altura { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public double Largura { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public double Profundidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public double Peso { get; set; }

    }
}
