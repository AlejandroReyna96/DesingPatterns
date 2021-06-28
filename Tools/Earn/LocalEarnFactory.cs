using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class LocalEarnFactory : EarnFactory
    {
        private decimal _percentaje;

        public LocalEarnFactory(decimal percentaje)
        {
            _percentaje = percentaje;
        }

        public override IEarn GetEarn()
        {
            return new LocalEarn(_percentaje);
        }
    }
}
