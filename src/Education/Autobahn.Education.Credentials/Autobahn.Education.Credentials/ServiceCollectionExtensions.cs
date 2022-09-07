//**********************************************************
//* DomainName: Credentials
//* FileName:   Credentials.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Credentials domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Credentials Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddCredentialsServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<ICredentialAward, CredentialAwardViewModel>();
        serviceCollection.AddTransient<ICredentialAwardCredit, CredentialAwardCreditViewModel>();
        serviceCollection.AddTransient<ICredentialAwardEvidence, CredentialAwardEvidenceViewModel>();
        serviceCollection.AddTransient<ICredentialCriteriaCourse, CredentialCriteriaCourseViewModel>();
        serviceCollection.AddTransient<ICredentialDefAgent, CredentialDefAgentViewModel>();
        serviceCollection.AddTransient<ICredentialDefAgentCredential, CredentialDefAgentCredentialViewModel>();
        serviceCollection.AddTransient<ICredentialDefCategory, CredentialDefCategoryViewModel>();
        serviceCollection.AddTransient<ICredentialDefCriterion, CredentialDefCriterionViewModel>();
        serviceCollection.AddTransient<ICredentialDefIdentifier, CredentialDefIdentifierViewModel>();
        serviceCollection.AddTransient<ICredentialDefinition, CredentialDefinitionViewModel>();
        serviceCollection.AddTransient<ICredentialIssuer, CredentialIssuerViewModel>();
        serviceCollection.AddTransient<ICredentialOffered, CredentialOfferedViewModel>();

        return serviceCollection;
    }
}
