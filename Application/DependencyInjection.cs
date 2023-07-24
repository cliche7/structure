using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection s)
    {
        var assembly = typeof(DependencyInjection).Assembly;

        s.AddMediatR(c =>
            c.RegisterServicesFromAssembly(assembly));

        s.AddValidatorsFromAssembly(assembly);

        return s;
    }
}
