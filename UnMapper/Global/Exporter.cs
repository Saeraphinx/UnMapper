using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnMapper.Global
{
    public class Exporter
    {
        public static void ExportMap(MapFile file, bool release = true)
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;

            if (release) { jsonSerializerSettings.Formatting = Formatting.None; } else { jsonSerializerSettings.Formatting = Formatting.Indented; }
            JsonConvert.SerializeObject(file, jsonSerializerSettings);
        }
    }
}
