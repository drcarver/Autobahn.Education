//**********************************************************
//* DomainName: Common Models
//* FileName:   Common.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Common Models domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Common Models Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddCommonServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IFinancialAccount, FinancialAccountViewModel>();
        serviceCollection.AddTransient<IFinancialAccountProgram, FinancialAccountProgramViewModel>();
        serviceCollection.AddTransient<IOrganizationAccreditation, OrganizationAccreditationViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarSession, OrganizationCalendarSessionViewModel>();
        serviceCollection.AddTransient<IOrganizationFederalAccountability, OrganizationFederalAccountabilityViewModel>();
        serviceCollection.AddTransient<IOrganizationFinancial, OrganizationFinancialViewModel>();
        serviceCollection.AddTransient<IOrganizationPopulationServed, OrganizationPopulationServedViewModel>();
        serviceCollection.AddTransient<IOrganizationProgramType, OrganizationProgramTypeViewModel>();
        serviceCollection.AddTransient<IOrganizationService, OrganizationServiceViewModel>();
        serviceCollection.AddTransient<IOrganizationTechnicalAssistance, OrganizationTechnicalAssistanceViewModel>();

        return serviceCollection;
    }
}
