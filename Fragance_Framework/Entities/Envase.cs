using System.ComponentModel.DataAnnotations;

namespace Fragance_Framework.Entities
{
    public class Envase
    {
        [Key]
        public int EnvaseSetupId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(100)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(100)]
        public string? Produto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(100)]
        public string? Equipe { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Função")]
        public string? Funcao { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Máquina")]
        [StringLength(50)]
        public string? Maquina { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Frasco { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Tampa { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Responsável")]
        public string? Responsavel { get; set; }

        [StringLength(50)]
        public string? Polivalente { get; set; }

        //public int CodSistema {get;set;} chave estrangeira

        [StringLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Referência")]
        public string? Referencia { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Categoria { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Qtd Prevista")]
        public int QtdPrevista { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Lote N° Envase")]
        public int LoteNumEnvase { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(50)]
        public string? Validade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(50)]
        [Display(Name = "COR-CÓD.Tampa")]
        public string? CorCodTampa { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Intercorrência")]
        public bool Intercorrencia { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(244)]
        [Display(Name = "Observação")]
        public string? Observacao { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(6)]
        [Display(Name = "Hora Inicial")]
        public string? HoraInicial { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(6)]
        [Display(Name = "Hora Final")]
        public string? HoraFinal { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Qtd Final")]
        public int QtdFinal { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(6)]
        [Display(Name = "Limpeza Inicio")]
        public string? LimpezaInicio { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(6)]
        [Display(Name = "Limpeza Final")]
        public string? LimpezaFinal { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Cód. BULK/GRANEL")]
        public bool CodBulkGranel { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(6)]
        [Display(Name = "Horário Aquecimento Fusor")]
        public string? HorarioAquecimentoFusor { get; set; }

        [StringLength(100)]
        [Display(Name = "Processo")]
        public string? Processo { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Descrição Intercorrência")]
        public string? DescricaoIntercorrencia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Produção Liberada")]
        public bool ProducaoLiberada { get; set; }
    }
}