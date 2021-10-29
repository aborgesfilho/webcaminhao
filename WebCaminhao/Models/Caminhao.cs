using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCaminhao.Models
{
    [Table("Caminhao")]
    public class Caminhao
    {
        [Display(Name = "Id")]
        [Key]
        public int IdCaminhao { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Modelo")]
        [ForeignKey("Modelo")]
        public string Modelo { get; set; }
        [Display(Name = "Ano Modelo")]
        [ForeignKey("AnoModelo")]
        public string AnoModelo { get; set; }
        [Display(Name = "Ano Fabricação")]
        [ForeignKey("AnoFabricacao")]
        public string AnoFabricacao { get; set; }
    }
}
