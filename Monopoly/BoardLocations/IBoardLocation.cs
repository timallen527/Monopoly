using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public interface IBoardLocation
    {
        void LandedOn(IPlayer player);
        void PassedBy(IPlayer player);
    }
}
