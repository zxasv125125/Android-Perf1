using System;
using StardewModdingAPI;

namespace AndroidPerf
{
    public class AndroidPerf : Mod
    {
        public override void Entry(IModHelper helper)
        {
            this.Monitor.Log("AndroidPerf Dummy mod loaded successfully.", LogLevel.Info);
        }
    }
}
