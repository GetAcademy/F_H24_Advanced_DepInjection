
using LineCounter;
using LineCounter.LineSources;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddLineCountDependencies();

var host = builder.Build();

var service = host.Services.GetRequiredService<ILineCountService>();
var stats = service.GetStats("er");
stats.Show();