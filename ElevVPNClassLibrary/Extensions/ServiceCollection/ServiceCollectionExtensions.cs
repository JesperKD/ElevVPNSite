using ElevVPNClassLibrary.Common.Users.Factories;
using ElevVPNClassLibrary.Common.Users.Repositories;
using ElevVPNClassLibrary.Common.Users.Services;
using ElevVPNClassLibrary.Core.Database.Managers;
using ElevVPNClassLibrary.Security.Cryptography;
using ElevVPNClassLibrary.Security.Cryptography.Hashing;
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
            .AddSingleton<UserEntityFactory>();

        public static IServiceCollection AddManagers(this IServiceCollection services)
            => services
           .AddSingleton<ISqlDbManager, SqlDbManager>()
           .AddTransient<ICryptographyService, HashingService>();
    }
}
