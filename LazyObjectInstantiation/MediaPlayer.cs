using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    class MediaPlayer
    {
        private Lazy<AllTracks> tracks = new Lazy<AllTracks>( () =>
        {
            Console.WriteLine("Creating AllTracks object");
            return new AllTracks();
        });
        public AllTracks GetAllTracks()
        {
            return tracks.Value;
        }
        public void Play() { }
        public void Stop() { }
        public void Pause() { }
    }
}
