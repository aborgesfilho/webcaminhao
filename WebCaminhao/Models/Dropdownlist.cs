using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCaminhao.Models
{
    public class Dropdownlist
    {
        public List<TipoModelo> tipoModelos { get; set; }
        public List<TipoAnoModelo> tiposAnoModelo { get; set; }
        public List<TipoAnoFabricacao> tiposAnoFabricacao { get; set; }
    }
}
