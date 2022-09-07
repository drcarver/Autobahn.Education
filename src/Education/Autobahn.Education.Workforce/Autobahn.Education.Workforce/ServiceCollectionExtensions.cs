//**********************************************************
//* DomainName: Workforce
//* FileName:   Workforce.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Workforce domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Workforce Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddWorkforceServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IWorkforceEmploymentQuarterlyDatum, WorkforceEmploymentQuarterlyDatumViewModel>();
        serviceCollection.AddTransient<IWorkforceProgramParticipantCohort, WorkforceProgramParticipantCohortViewModel>();
        serviceCollection.AddTransient<IWorkforceProgramParticipation, WorkforceProgramParticipationViewModel>();

        return serviceCollection;
    }
}
