//**********************************************************
//* DomainName: Organization Models
//* FileName:   Organization.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Organization Models domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Organization Models Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddOrganizationServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IActivity, ActivityViewModel>();
        serviceCollection.AddTransient<IActivityRecognition, ActivityRecognitionViewModel>();
        serviceCollection.AddTransient<IOrganizationAccreditation, OrganizationAccreditationViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendar, OrganizationCalendarViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarCrisis, OrganizationCalendarCrisisViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarDay, OrganizationCalendarDayViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarEvent, OrganizationCalendarEventViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarSession, OrganizationCalendarSessionViewModel>();
        serviceCollection.AddTransient<IOrganizationDetail, OrganizationDetailViewModel>();
        serviceCollection.AddTransient<IOrganizationEmail, OrganizationEmailViewModel>();
        serviceCollection.AddTransient<IOrganizationEmployeeBenefit, OrganizationEmployeeBenefitViewModel>();
        serviceCollection.AddTransient<IOrganizationFederalAccountability, OrganizationFederalAccountabilityViewModel>();
        serviceCollection.AddTransient<IOrganizationFinancial, OrganizationFinancialViewModel>();
        serviceCollection.AddTransient<IOrganizationIdentifier, OrganizationIdentifierViewModel>();
        serviceCollection.AddTransient<IOrganizationImage, OrganizationImageViewModel>();
        serviceCollection.AddTransient<IOrganizationIndicator, OrganizationIndicatorViewModel>();
        serviceCollection.AddTransient<IOrganizationLocation, OrganizationLocationViewModel>();
        serviceCollection.AddTransient<IOrganizationOperationalStatus, OrganizationOperationalStatusViewModel>();
        serviceCollection.AddTransient<IOrganizationPersonRoleApplication, OrganizationPersonRoleApplicationViewModel>();
        serviceCollection.AddTransient<IOrganizationPersonRoleFte, OrganizationPersonRoleFteViewModel>();
        serviceCollection.AddTransient<IOrganizationPersonRoleRelationship, OrganizationPersonRoleRelationshipViewModel>();
        serviceCollection.AddTransient<IOrganizationPolicy, OrganizationPolicyViewModel>();
        serviceCollection.AddTransient<IOrganizationPopulationServed, OrganizationPopulationServedViewModel>();
        serviceCollection.AddTransient<IOrganizationProgramType, OrganizationProgramTypeViewModel>();
        serviceCollection.AddTransient<IOrganizationRelationship, OrganizationRelationshipViewModel>();
        serviceCollection.AddTransient<IOrganizationService, OrganizationServiceViewModel>();
        serviceCollection.AddTransient<IOrganizationTechnicalAssistance, OrganizationTechnicalAssistanceViewModel>();
        serviceCollection.AddTransient<IOrganizationTelephone, OrganizationTelephoneViewModel>();
        serviceCollection.AddTransient<IOrganizationWebsite, OrganizationWebsiteViewModel>();

        return serviceCollection;
    }
}
