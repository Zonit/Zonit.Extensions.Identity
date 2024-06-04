using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Zonit.Extensions.Identity;
using Zonit.Extensions.Identity.Repositories;
using Zonit.Extensions.Identity.Services;

namespace Zonit.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddIdentityExtension(this IServiceCollection services)
    {
        if (!services.Any(x => x.ServiceType == typeof(AuthenticationOptions)))
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "ZonitIdentity";
                options.DefaultChallengeScheme = "ZonitIdentity";
            })
            .AddScheme<AuthenticationSchemeOptions, AuthenticationSchemeService>("ZonitIdentity", null);
        }

        //services.AddAuthorizationCore();
        services.AddCascadingAuthenticationState();

        services.TryAddScoped<AuthenticationStateProvider, SessionAuthenticationService>();

        services.TryAddScoped<IAuthenticatedRepository, AuthenticatedRepository>();
        services.TryAddScoped<IAuthenticatedProvider, AuthenticatedService>();

        return services;
    }
}