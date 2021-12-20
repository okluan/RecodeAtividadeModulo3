using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuanLimaMinhaBoaViagem.Models
{
    public class Promocao
    {
        public int Id { get; set; }

        public int CPF { get; set; }
        public int Cupom { get; set; }

        public Double Valor { get; set; }


        public ICollection<PromocaoDestino> Destinos { get; set; }


    }
}
