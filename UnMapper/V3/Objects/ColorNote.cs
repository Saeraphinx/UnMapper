using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnMapper.Global;

namespace UnMapper.V3.Objects
{
    public class ColorNote : MapObject
    {
        public double beat;     // b
        public int x;           // x
        public int y;           // y
        public int color;       // c
        public int direction;   // d
        public int angleOffset; // a

        public ColorNote(double beat, int x, int y, int color, int direction, int angleOffset)
        {
            this.beat = beat;
            this.x = x;
            this.y = y;
            this.color = color;
            this.direction = direction;
            this.angleOffset = angleOffset;
        }

        public Dictionary<string, object?> GetDictionaryOut()
        {
            Dictionary<string, object?> dict = new Dictionary<string, object?>();
            string serial = JsonConvert.SerializeObject(this);
            dict = JsonConvert.DeserializeObject(serial) as Dictionary<string, object?>;
            return dict;
        }
    }

    public class MColorNote : ColorNote
    {
        float[]? coordinates;
        float[]? worldRotation;
        float[]? localRotation;
        float? noteJumpMovementSpeed;
        float? noteJumpStartBeatOffset;
        bool? interactable;

        bool isModded;

        public MColorNote(double beat, int x, int y, int color, int direction, int angleOffset) : base(beat, x, y, color, direction, angleOffset)
        {
        }

        public void setCoords(float[]? coordinates) {
            this.coordinates = coordinates;
        }

        public new Dictionary<string, object?> GetDictionaryOut()
        {
            Dictionary<string, object?> dict = new Dictionary<string, object?>();
            Dictionary<string, object?> customData = new Dictionary<string, object?>();
            dict = base.GetDictionaryOut();

            customData.Add("coordinates", coordinates);
            customData.Add("worldRotation", worldRotation);
            customData.Add("localRotation", localRotation);
            customData.Add("noteJumpMovementSpeed", noteJumpMovementSpeed);
            customData.Add("noteJumpStartBeatOffset", noteJumpStartBeatOffset);
            customData.Add("interactable", interactable);

            dict.Add("customData", customData);
            return dict;
        }
    }

    public class FakeColorNote : MColorNote {
        
    }
}
