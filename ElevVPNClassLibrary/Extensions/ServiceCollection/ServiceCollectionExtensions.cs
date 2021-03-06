using ElevVPNClassLibrary.Common.Users.Factories;
using ElevVPNClassLibrary.Common.Users.Repositories;
using ElevVPNClassLibrary.Common.Users.Services;
using ElevVPNClassLibrary.Core.Database.Factories;
using ElevVPNClassLibrary.Core.Database.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace ElevVPNClassLibrary.Extensions.ServiceCollection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEntityServices(this IServiceCollection services)
            => services
            .AddScoped<IUserService, UserService>();

        public static IServiceCollection AddRepositories(this IServiceCollection services)
            => services
            .AddScoped<IUserRepository, UserRepository>();

        public static IServiceCollection AddFactories(this IServiceCollection services)
            => services
            .AddSingleton<ISqlDbFactory, SqlDbFactory>()
            .AddSingleton<UserEntityFactory>();

        public static IServiceCollection AddManagers(this IServiceCollection services)
            => services
           .AddSingleton<ISqlDbManager, SqlDbManager>();
    }
}
