using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmRepo
{
     public class Gmap
    {
         public int ID { get; set; }
         public string Googlelat { get; set; }
         public string Googlelng { get; set; }
         public string Wgs84lat { get; set; }
         public string Wgs84lng { get; set; }
         public string Beskrivelse { get; set; }
         public string Type { get; set; }
         public string Overskrift { get; set; }
    }
}
