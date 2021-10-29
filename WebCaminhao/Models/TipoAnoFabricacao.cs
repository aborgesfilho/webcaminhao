using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCaminhao.Models
{
    [Table("TipoAnoFabricacao")]
    public class TipoAnoFabricacao
    {
        [Display(Name = "Ano Fabricação")]
        [Key]
        public string AnoFabricacao { get; set; }
    }
}
