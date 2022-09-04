//**********************************************************
//* DomainName: Role Models
//* FileName:   Autobahn.Core.Role.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Role Models domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Role Models Services to add to the services Collection
    /// </summary>
    public static IServiceCollection Add(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IRoleAttendance, RoleAttendanceViewModel>();
        serviceCollection.AddTransient<IRoleAttendanceEvent, RoleAttendanceEventViewModel>();
        serviceCollection.AddTransient<IRoleStatus, RoleStatusViewModel>();

        return serviceCollection;
    }
}
