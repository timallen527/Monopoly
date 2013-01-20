using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public interface IPlayer
    {
        Int32 Location { get; set; }
        Boolean Enabled { get; set; }
        Int32 Cash { get; set; }
    }
}
