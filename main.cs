using System;
using StardewModdingAPI;

namespace AndroidPerf;

public class AndroidPerf : Mod
namespace AndroidPerf
{
	public override void Entry(IModHelper helper)
	{
		((Mod)this).Monitor.Log("Using AndroidPerf", (LogLevel)2);
	}
    public class AndroidPerf : Mod
    {
        public override void Entry(IModHelper helper)
        {
            this.Monitor.Log("AndroidPerf Dummy Loaded", LogLevel.Info);
        }
    }
}
