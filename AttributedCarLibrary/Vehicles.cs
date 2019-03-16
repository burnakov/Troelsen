using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]

namespace AttributedCarLibrary
{
    [Serializable]
    [VehicleDescription(Description = ("My rockin' harley"))]
    public class Motorcycle
    {
    }
    [SerializableAttribute]
    [VehicleDescription("The old gray mare, she ain't what she used to be...")]
    public class HorseAndBuggy
    {
    }
    [VehicleDescription("A very long, slow, but feature-reach auto...")]
    public class Winnebago
    {
        //public ulong compliant;
        [VehicleDescription("My rockin' cd player")]
        public void PlayMusic(bool musicOn)
        {

        }
    }
}
