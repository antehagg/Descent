using Descent.Core.DataReaders.Json;

namespace Descent.Core.Settings
{
    public class ApplicationSettings
    {
        public ConstantSettings Constants;

        public ApplicationSettings()
        {
            Constants = ReadSettings.GetConstantConfig();
        }
    }
}
