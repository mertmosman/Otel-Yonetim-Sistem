using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYonetim
{
    public abstract class Mekan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Konum { get; set; }
        public virtual string Tur { get; set; } // Tür belirtmek için abstract property

        public override string ToString()
        {
            return $"{Id} - {Ad} - {Konum} - {Tur}";
        }
        public abstract string BilgiGetir();
    }

}
