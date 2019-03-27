using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShp_MAC.Models
{
    public class Placa
    {
        public long? ID { get; set; }
        public byte[] placaImg { get; set; }
        public string modelo { get; set; }
        public string donoCPF { get; set; }
        public string placaNumero { get; set; }

    }
}
