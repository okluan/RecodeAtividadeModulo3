using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuanLimaMinhaBoaViagem.Models
{
    public class Destino
    {
        public int DestinoId { get; set; }
        public int CPF { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public double Valor { get; set; }
        public string Hotel { get; set; }
        public DateTime Embarque { get; set; }
        public DateTime Desembarque { get; set; }
        public int Parcelas { get; set; }
        public int Pessoas { get; set; }


        public ICollection<PromocaoDestino> Promocaos { get; set; }


    }
}
