using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.Abtract
{
    public abstract class AbtractEmployee
    {
        public abstract decimal GetBonus();
        public abstract decimal GetPay();

        protected decimal _dTotal  { get; set; }
        public virtual decimal GetTotalWithVitual()
        {
            _dTotal = 10;
            return _dTotal;
        }

    }
}
