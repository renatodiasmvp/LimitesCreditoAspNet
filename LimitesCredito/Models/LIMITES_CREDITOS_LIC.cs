namespace LimitesCredito.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LIMITES_CREDITOS_LIC
    {
        [Key]
        public int IDE_LIMITE_CREDITO { get; set; }

        public int IDE_CONTRATO_TERCEIRO { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DAT_EXPIRA_LIMITE { get; set; }

        [StringLength(255)]
        public string DES_OBSERVACAO { get; set; }

        public int QTD_PARCELAS_APROVACAO { get; set; }

        [Column(TypeName = "money")]
        public decimal VLR_TOTAL_APROVACAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PER_TAXA_OPERACAO { get; set; }

        [Column(TypeName = "money")]
        public decimal? VLR_TARIFA_OPERACAO { get; set; }

        [Column(TypeName = "money")]
        public decimal? VLR_TOTAL_DESCONTOS { get; set; }

        [Column(TypeName = "money")]
        public decimal VLR_LIQUIDO_APROVACAO { get; set; }

        public int? NUM_PARCELA_INICIAL { get; set; }

        public int? IDE_MOTIVO { get; set; }

        [Required]
        [StringLength(20)]
        public string LIS_SITUACAO { get; set; }

        [StringLength(255)]
        public string NOM_LOGIN_APROVACAO { get; set; }

        public DateTime? DAT_APROVACAO { get; set; }

        [StringLength(255)]
        public string DES_APROVACAO { get; set; }

        [Required]
        [StringLength(1)]
        public string STS_LIMITE { get; set; }

        public DateTime? DAT_INCLUSAO { get; set; }

        [StringLength(255)]
        public string NOM_LOGIN_INCLUSAO { get; set; }

        [StringLength(50)]
        public string NUM_IP_INCLUSAO { get; set; }

        public DateTime? DAT_ALTERACAO { get; set; }

        [StringLength(255)]
        public string NOM_LOGIN_ALTERACAO { get; set; }
    }
}
