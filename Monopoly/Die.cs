using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Die : IDie
    {
        private Int32 value;
        private Random random;

        public Die()
        {
            random = new Random();
        }

        public Int32 Roll()
        {
            value = random.Next(1, 7);
            return value;
        }

        public Int32 GetValue()
        {
            return value;
        }
    }
}
