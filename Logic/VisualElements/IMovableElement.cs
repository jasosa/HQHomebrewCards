using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards.Logic
{
    public interface IMovableElement
    {
        int PositionX { get; set; }
        int PositionY { get; set; }

        event EventHandler PositionChanged;
    }
}
