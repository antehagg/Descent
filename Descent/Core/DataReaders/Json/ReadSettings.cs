using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Descent.Core.Settings;
using Newtonsoft.Json;

namespace Descent.Core.DataReaders.Json
{
    public static class ReadSettings
    {
        public static ConstantSettings GetConstantConfig()
        {
            try
            {
                using (var file = File.OpenText("Config/Constants.json"))
                {
                    var serializer = new JsonSerializer();
                    var constantSettings = (ConstantSettings) serializer.Deserialize(file, typeof(ConstantSettings));
                    return constantSettings;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
