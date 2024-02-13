using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject07febAssess.Support
{
    public class Divi
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
             

        public int Div()
        {
            int res;
            res = Fnum / Snum;
            return res;
        }
    }
}
