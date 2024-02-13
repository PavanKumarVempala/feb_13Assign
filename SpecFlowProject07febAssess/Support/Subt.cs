using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject07febAssess.Support
{
    public class Subt
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
             

        public int Sub()
        {
            int res;
            res = Fnum - Snum;
            return res;
        }
    }
}
