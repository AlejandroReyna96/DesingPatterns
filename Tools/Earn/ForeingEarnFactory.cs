using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class ForeingEarnFactory : EarnFactory
    {
        private decimal _percentaje;
        private decimal _extra;

        public ForeingEarnFactory(decimal percentaje, decimal extra)
        {
            _percentaje = percentaje;
            _extra = extra;
        }

        public override IEarn GetEarn()
        {
            return new ForeingEarn(_percentaje, _extra);
        }
    }
}
