using System;
namespace Monopoly
{
    public interface IDie
    {
        Int32 GetValue();
        Int32 Roll();
    }
}
