using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyingAttributes
{
    [Serializable]
    class Motorcycle
    {
        [NonSerialized]
        float wieghtOfCurrentPassangers;

        bool hasRadioSystem;
        bool hasHeadSeat;
        bool hasSissyBar;
    }
}
