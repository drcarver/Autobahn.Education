//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResources.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Learning Resources domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Learning Resources Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddLearningResourcesServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<ILearningResource, LearningResourceViewModel>();
        serviceCollection.AddTransient<ILearningResourceAdaptation, LearningResourceAdaptationViewModel>();
        serviceCollection.AddTransient<ILearningResourceMediaFeature, LearningResourceMediaFeatureViewModel>();
        serviceCollection.AddTransient<ILearningResourcePeerRating, LearningResourcePeerRatingViewModel>();
        serviceCollection.AddTransient<IPeerRatingSystem, PeerRatingSystemViewModel>();

        return serviceCollection;
    }
}
