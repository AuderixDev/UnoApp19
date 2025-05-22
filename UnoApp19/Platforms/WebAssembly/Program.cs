using Uno.UI.Hosting;
using UnoApp19;

var host = UnoPlatformHostBuilder.Create()
    .App(() => new App())
    .UseWebAssembly()
    .Build();

await host.RunAsync();
