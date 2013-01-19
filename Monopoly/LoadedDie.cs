using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class LoadedDie : IDie
    {
        private Int32 value;

        public LoadedDie(Int32 value)
        {
            this.value = value;
        }

        public Int32 Roll()
        {
            return value;
        }

        public Int32 GetValue()
        {
            return value;
        }
    }
}
