using StardewModdingAPI;

namespace AndroidPerf;

public class AndroidPerf : Mod
{
	public override void Entry(IModHelper helper)
	{
		((Mod)this).Monitor.Log("Using AndroidPerf", (LogLevel)2);
	}
}
