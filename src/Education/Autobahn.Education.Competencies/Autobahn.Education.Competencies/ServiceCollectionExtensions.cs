//**********************************************************
//* DomainName: Competencies
//* FileName:   Competencies.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Competencies domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Competencies Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddCompetenciesServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<ICompetencyDefAssociation, CompetencyDefAssociationViewModel>();
        serviceCollection.AddTransient<ICompetencyDefinition, CompetencyDefinitionViewModel>();
        serviceCollection.AddTransient<ICompetencyDefinitionCompetencySet, CompetencyDefinitionCompetencySetViewModel>();
        serviceCollection.AddTransient<ICompetencyFramework, CompetencyFrameworkViewModel>();
        serviceCollection.AddTransient<ICompetencySet, CompetencySetViewModel>();
        serviceCollection.AddTransient<ICompetencySetRubric, CompetencySetRubricViewModel>();
        serviceCollection.AddTransient<ICompetencySetRubricCriterion, CompetencySetRubricCriterionViewModel>();
        serviceCollection.AddTransient<IRubric, RubricViewModel>();
        serviceCollection.AddTransient<IRubricCriterion, RubricCriterionViewModel>();

        return serviceCollection;
    }
}
