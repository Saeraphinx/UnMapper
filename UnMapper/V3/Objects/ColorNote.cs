using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using UnMapper.Global;

namespace UnMapper.V3.Objects
{
    public class ColorNote
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
    }
}
