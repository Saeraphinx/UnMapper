using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnMapper.V3.Heck
{
    public class Track
    {
        float b; // beats
        string t; // track type
        Dictionary<string, object?> d = new Dictionary<string, object?>(); //data

        public Track(float beat)
        {
            this.b = beat;
            this.t = "AnimateTrack";
        }

        public Track(float beat, string track)
        {
            this.b = beat;
            this.t = track;
        }
    }
}
