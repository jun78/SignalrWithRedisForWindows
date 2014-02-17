using Owin;
using Microsoft.Owin;
using Microsoft.AspNet.SignalR;
[assembly: OwinStartup(typeof(SignalRwithRedis.Startup))]

namespace SignalRwithRedis
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// Any connection or hub wire up and configuration should go here
      //Use the line below to use signalr only.  
			//app.MapSignalR();

			GlobalHost.DependencyResolver.UseRedis("localhost", 6379, string.Empty, "myApp");
			app.MapHubs();
		}
	}
}