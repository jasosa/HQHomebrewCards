using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards.CustomControls
{
    public class ButtonPressedEventArgs : EventArgs
    {
        MOVEMENT_DIRECTION direction;
        public ButtonPressedEventArgs(MOVEMENT_DIRECTION direction)
        {
            this.direction = direction;
        }

        public MOVEMENT_DIRECTION Direction { get { return direction; } }
    }

    public class ButtonUnPressedEventArgs : EventArgs
    {
    }
}
