using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject07febAssess.Support
{
    public class Mult
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
        public int Mul()
        {
            int res;
            res = Fnum * Snum;
            return res;
        }

        public int Sub()
        {
            int res;
            res = Fnum - Snum;
            return res;
        }

        
    }
}
