//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyLearning.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Early Learning (EL) domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Early Learning (EL) Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddEarlyLearningServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IEarlyChildhoodCredential, EarlyChildhoodCredentialViewModel>();
        serviceCollection.AddTransient<IEarlyChildhoodProgramTypeOffered, EarlyChildhoodProgramTypeOfferedViewModel>();

        return serviceCollection;
    }
}
