using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using UnMapper.Global;

/*
{
  "version":"3.0.0", // There must be no whitespace after :
  "bpmEvents": [],
  "rotationEvents": [],
  "colorNotes": [],
  "bombNotes": [],
  "obstacles": [],
  "sliders": [],
  "burstSliders": [],
  "waypoints": [],
  "basicBeatmapEvents": [],
  "colorBoostBeatmapEvents": [],
  "lightColorEventBoxGroups": [],
  "lightRotationEventBoxGroups": [],
  "basicEventTypesWithKeywords": {},
  "useNormalEventsAsCompatibleEvents": false
}
*/
namespace UnMapper.V3
{
    public class Difficulty
    {
        string v = "3.0.0";
        BpmEvent[]? epmEvents;
        RotationEvent[]? rotationEvents;
        ColorNote[]? colorNotes;
        Bomb[]? bombNotes;
        Wall[]? obstacles;
        Arc[]? sliders;
        Chain[]? burstSliders;
        BasicEvent[]? basicBeatmapEvents;
        BoostEvent[]? lightColorEventBoxGroups;
        V3LightColorEvent[]? lightColorEvent;
        V3LightRotationEvent[]? lightRotationEvent;
        V3BasicEventTypeKeyword? basicEventTypesWithKeywords;
        bool useNormalEventsAsCompatibleEvents = false;
        CustomData[]? customData;
    }
}