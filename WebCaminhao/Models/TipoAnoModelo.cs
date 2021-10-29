using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCaminhao.Models
{
    [Table("TipoAnoModelo")]
    public class TipoAnoModelo
    {
        [Display(Name = "Ano Modelo")]
        [Key]
        public string AnoModelo { get; set; }
    }
}
