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
        serviceCollection.AddTransient<IAssessmentPerformanceLevel, AssessmentPerformanceLevelViewModel>();
        serviceCollection.AddTransient<IAssessmentResultPerformanceLevel, AssessmentResultPerformanceLevelViewModel>();
        serviceCollection.AddTransient<ICompetencyDefEducationLevel, CompetencyDefEducationLevelViewModel>();
        serviceCollection.AddTransient<ICourseSectionLevel, CourseSectionLevelViewModel>();
        serviceCollection.AddTransient<IEarlyChildhoodCredential, EarlyChildhoodCredentialViewModel>();
        serviceCollection.AddTransient<IEarlyChildhoodProgramTypeOffered, EarlyChildhoodProgramTypeOfferedViewModel>();
        serviceCollection.AddTransient<IElchildDemographic, ElchildDemographicViewModel>();
        serviceCollection.AddTransient<IElchildDevelopmentalAssessment, ElchildDevelopmentalAssessmentViewModel>();
        serviceCollection.AddTransient<IElchildHealth, ElchildHealthViewModel>();
        serviceCollection.AddTransient<IElchildIndividualizedProgram, ElchildIndividualizedProgramViewModel>();
        serviceCollection.AddTransient<IElchildOutcomeSummary, ElchildOutcomeSummaryViewModel>();
        serviceCollection.AddTransient<IElchildProgramEligibility, ElchildProgramEligibilityViewModel>();
        serviceCollection.AddTransient<IElchildService, ElchildServiceViewModel>();
        serviceCollection.AddTransient<IElchildServicesApplication, ElchildServicesApplicationViewModel>();
        serviceCollection.AddTransient<IElchildTransitionPlan, ElchildTransitionPlanViewModel>();
        serviceCollection.AddTransient<IElclassSection, ElclassSectionViewModel>();
        serviceCollection.AddTransient<IElclassSectionService, ElclassSectionServiceViewModel>();
        serviceCollection.AddTransient<IElenrollment, ElenrollmentViewModel>();
        serviceCollection.AddTransient<IElenrollmentOtherFunding, ElenrollmentOtherFundingViewModel>();
        serviceCollection.AddTransient<IElfacilityLicensing, ElfacilityLicensingViewModel>();
        serviceCollection.AddTransient<IEligibilityEvaluation, EligibilityEvaluationViewModel>();
        serviceCollection.AddTransient<IElorganization, ElorganizationViewModel>();
        serviceCollection.AddTransient<IElorganizationAvailability, ElorganizationAvailabilityViewModel>();
        serviceCollection.AddTransient<IElorganizationFund, ElorganizationFundViewModel>();
        serviceCollection.AddTransient<IElorganizationMonitoring, ElorganizationMonitoringViewModel>();
        serviceCollection.AddTransient<IElprogramLicensing, ElprogramLicensingViewModel>();
        serviceCollection.AddTransient<IElqualityInitiative, ElqualityInitiativeViewModel>();
        serviceCollection.AddTransient<IElqualityRatingImprovement, ElqualityRatingImprovementViewModel>();
        serviceCollection.AddTransient<IElservicePartner, ElservicePartnerViewModel>();
        serviceCollection.AddTransient<IElstaff, ElstaffViewModel>();
        serviceCollection.AddTransient<IElstaffAssignment, ElstaffAssignmentViewModel>();
        serviceCollection.AddTransient<IElstaffEducation, ElstaffEducationViewModel>();
        serviceCollection.AddTransient<IElstaffEmployment, ElstaffEmploymentViewModel>();
        serviceCollection.AddTransient<IIeppresentLevel, IeppresentLevelViewModel>();
        serviceCollection.AddTransient<ILearningResourceEducationLevel, LearningResourceEducationLevelViewModel>();
        serviceCollection.AddTransient<IPdactivityEducationLevel, PdactivityEducationLevelViewModel>();
        serviceCollection.AddTransient<IRubricCriterionLevel, RubricCriterionLevelViewModel>();

        return serviceCollection;
    }
}
