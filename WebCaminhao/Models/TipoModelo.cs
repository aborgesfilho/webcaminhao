using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCaminhao.Models
{
    [Table("TipoModelo")]
    public class TipoModelo
    {
        [Display(Name = "Modelo")]
        [Key]
        public string Modelo { get; set; }
    }
}
