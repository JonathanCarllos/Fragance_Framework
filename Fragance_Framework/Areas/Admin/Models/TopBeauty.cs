using System.ComponentModel.DataAnnotations;

namespace Fragance_Framework.Areas.Admin.Models
{
    public class TopBeauty
    {
        public int TopBeautyId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Cód. Interno Avulso")]
        [StringLength(100)]
        public string? CodInternoAvulso { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(100)]
        public string? Linha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Desc. Produto")]
        [StringLength(100)]
        public string? DescProduto { get; set; }

        //esmalte avulso        
        [Display(Name = "Unidade Solto")]
        [StringLength(100)]
        public string? UnidadeSolto { get; set; }

        [Display(Name = "Cartucho com 6 unid.")]
        [StringLength(100)]
        public string? Cartucho { get; set;} //com 6 unidades

        [Display(Name = "Cx Embaalagem 120 unid.")]
        [StringLength(100)]
        public string? CaixaEmbalagem { get; set; } //Cx. Emb. 120 unid

        //esmalte blister
        [Display(Name = "Unidade Blister")]
        [StringLength(100)]
        public string? UnidadeBlister {  get; set; }

        [Display(Name = "Cartucho 120 unid.")]
        [StringLength(100)]
        public string? Cartucho12 { get; set; } //Cx. Emb. 120 unid

        [Display(Name = "Cx Embalagem 144 unid.")]
        [StringLength(100)]
        public string? CaixaEmbalagem144 { get; set; } //Cx. Emb. 144 und

        [Display(Name = "Num. Processo")]
        [StringLength(100)]
        public string? NumProcesso { get; set; }

        [StringLength(100)]
        public string? NCM { get; set; }

        [Display(Name = "Qtd. Caixa")]
        [StringLength(100)]
        public string? QtdCaixa { get; set; }

        [Display(Name = "Qtd. Cartucho")]
        [StringLength(100)]
        public string? QtdCartucho { get; set; }

        //MEDIDAS E PESO PRODUTOS ESMALTE A VULSO
        public double Altura { get; set; }
        public double Largura {  get; set; }
        public double Profundidade {  get; set; }
        public double Peso { get; set; }

        //MEDIDAS CAIXA EMBARQUE E PESO ESMALTE A VULSO
        [Display(Name = "Altura")]
        public double Altura2 { get; set; }

        [Display(Name = "Largura")]
        public double Largura2 { get; set; }

        [Display(Name = "Profundidade")]
        public double Profundidade2 { get; set; }

        [Display(Name = "Peso")]
        public double Peso2 { get; set; }

        //MEDIDAS CAIXA EMBARQUE E PESO ESMALTE BLISTER
        [Display(Name = "Altura")]
        public double Altura3 { get; set; }

        [Display(Name = "Largura")]
        public double Largura3 { get; set; }

        [Display(Name = "Profundidade")]
        public double Profundidade3 { get; set; }

        [Display(Name = "Peso")]
        public double Peso3 { get; set; }

        //MEDIDAS E PESO PRODUTOS ESMALTE BLISTER
        [Display(Name = "Altura")]
        public double Altura4 { get; set; }

        [Display(Name = "Largura")]
        public double Largura4 { get; set; }

        [Display(Name = "Profundidade")]
        public double Profundidade4 { get; set; }

        [Display(Name = "Peso")]
        public double Peso4 { get; set; }


    }
}
