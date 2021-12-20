using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuanLimaMinhaBoaViagem.Models
{
    public class PromocaoDestino
    {
        public int PromocaoId { get; set; }

        public Promocao Promocao { get; set; }

        public int DestinoId { get; set; }

        public Destino Destino { get; set; }


    }
}
