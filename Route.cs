using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithmV2
{
    internal class Route
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Distance { get; set; }

        public Route(string frm, string _to, double dst)
        {
            From = frm;
            To = _to;
            Distance = dst;
        }
    }
}
