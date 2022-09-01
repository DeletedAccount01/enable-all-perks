using ModSettings;
using System.Reflection;

namespace temp
{
    internal class tempoption : JsonModSettings
    {
        internal static tempoption Instance;
        [Name("On/off")]
        [Description("Enable all perks yes/no")]
        public bool turnallperks = true;
        
    }
}
