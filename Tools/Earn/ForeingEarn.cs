using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    class ForeingEarn : IEarn
    {
        private decimal _percentaje;
        private decimal _extra;

        public ForeingEarn(decimal percentaje, decimal extra)
        {
            _percentaje = percentaje;
            _extra = extra;
        }

        public decimal Earn(decimal amount)
        {
            return (amount * _percentaje) + _extra;
        }
    }
}
