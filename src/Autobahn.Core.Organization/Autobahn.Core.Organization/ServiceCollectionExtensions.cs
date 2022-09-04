//**********************************************************
//* DomainName: Organization Models
//* FileName:   Autobahn.Core.Organization.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Organization Models domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Organization Models Services to add to the services Collection
    /// </summary>
    public static IServiceCollection Add(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IOrganizationCalendar, OrganizationCalendarViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarCrisis, OrganizationCalendarCrisisViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarDay, OrganizationCalendarDayViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarEvent, OrganizationCalendarEventViewModel>();
        serviceCollection.AddTransient<IOrganizationDetail, OrganizationDetailViewModel>();
        serviceCollection.AddTransient<IOrganizationEmail, OrganizationEmailViewModel>();
        serviceCollection.AddTransient<IOrganizationEmployeeBenefit, OrganizationEmployeeBenefitViewModel>();
        serviceCollection.AddTransient<IOrganizationIdentifier, OrganizationIdentifierViewModel>();
        serviceCollection.AddTransient<IOrganizationImage, OrganizationImageViewModel>();
        serviceCollection.AddTransient<IOrganizationIndicator, OrganizationIndicatorViewModel>();
        serviceCollection.AddTransient<IOrganizationLocation, OrganizationLocationViewModel>();
        serviceCollection.AddTransient<IOrganizationOperationalStatus, OrganizationOperationalStatusViewModel>();
        serviceCollection.AddTransient<IOrganizationPolicy, OrganizationPolicyViewModel>();
        serviceCollection.AddTransient<IOrganizationRelationship, OrganizationRelationshipViewModel>();
        serviceCollection.AddTransient<IOrganizationTelephone, OrganizationTelephoneViewModel>();
        serviceCollection.AddTransient<IOrganizationWebsite, OrganizationWebsiteViewModel>();

        return serviceCollection;
    }
}
