using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace FlyoutPositionTesting.Skia.Tizen
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new FlyoutPositionTesting.App(), args);
			host.Run();
		}
	}
}
