
using Examen.Repositories;
using Examen.Services;
using Repositories.TestRepository;
using Services.TestService;

namespace Helpers.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<EvenimentRepository>();
        services.AddTransient<ParticipantRepository>();
        services.AddTransient<ParticipareRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {

        services.AddTransient<EvenimentService>();
        services.AddTransient<ParticipantService>();
        services.AddTransient<ParticipareService>();

        return services;
    }

    //public static IServiceCollection AddSeeders(this IServiceCollection services)
    //{
    //    services.AddTransient<TestSeeder>();

    //    return services;
    //}
}