using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_League
{
    public class Team //stworz folder "Models" i tam przerzuć tą klase, tak zeby byl porzadek
    {
        public string Name { get; set; }
        public int position { get; set; } //zasada: property z wielkiej litery znaczynamy
        public int points { get; set; } //zasada: property z wielkiej litery znaczynamy
    }
}
