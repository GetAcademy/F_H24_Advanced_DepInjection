using LineCounter.LineSources;
using Microsoft.Extensions.DependencyInjection;

namespace LineCounter;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLineCountDependencies(this IServiceCollection services)
    {
        services.AddTransient<ILineCountService, LineCountService>();
        services.AddTransient<ILineSourceFactory, LineSourceFactory>();
        services.AddTransient<ITextMatchService, TextMatchService>();

        return services;
    }
}