//**********************************************************
//* DomainName: Assessments
//* FileName:   Assessments.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Assessments domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Assessments Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddAssessmentsServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IApipInteraction, ApipInteractionViewModel>();
        serviceCollection.AddTransient<IAssessment, AssessmentViewModel>();
        serviceCollection.AddTransient<IAssessmentAccommodation, AssessmentAccommodationViewModel>();
        serviceCollection.AddTransient<IAssessmentAdministration, AssessmentAdministrationViewModel>();
        serviceCollection.AddTransient<IAssessmentAdministrationOrganization, AssessmentAdministrationOrganizationViewModel>();
        serviceCollection.AddTransient<IAssessmentAssessmentAdministration, AssessmentAssessmentAdministrationViewModel>();
        serviceCollection.AddTransient<IAssessmentAsset, AssessmentAssetViewModel>();
        serviceCollection.AddTransient<IAssessmentEldevelopmentalDomain, AssessmentEldevelopmentalDomainViewModel>();
        serviceCollection.AddTransient<IAssessmentForm, AssessmentFormViewModel>();
        serviceCollection.AddTransient<IAssessmentFormAssessmentAsset, AssessmentFormAssessmentAssetViewModel>();
        serviceCollection.AddTransient<IAssessmentFormAssessmentFormSection, AssessmentFormAssessmentFormSectionViewModel>();
        serviceCollection.AddTransient<IAssessmentFormSection, AssessmentFormSectionViewModel>();
        serviceCollection.AddTransient<IAssessmentFormSectionAssessmentAsset, AssessmentFormSectionAssessmentAssetViewModel>();
        serviceCollection.AddTransient<IAssessmentFormSectionAssessmentItem, AssessmentFormSectionAssessmentItemViewModel>();
        serviceCollection.AddTransient<IAssessmentFormSectionItem, AssessmentFormSectionItemViewModel>();
        serviceCollection.AddTransient<IAssessmentItem, AssessmentItemViewModel>();
        serviceCollection.AddTransient<IAssessmentItemApip, AssessmentItemApipViewModel>();
        serviceCollection.AddTransient<IAssessmentItemApipDescription, AssessmentItemApipDescriptionViewModel>();
        serviceCollection.AddTransient<IAssessmentItemCharacteristic, AssessmentItemCharacteristicViewModel>();
        serviceCollection.AddTransient<IAssessmentItemPossibleResponse, AssessmentItemPossibleResponseViewModel>();
        serviceCollection.AddTransient<IAssessmentItemResponse, AssessmentItemResponseViewModel>();
        serviceCollection.AddTransient<IAssessmentItemResponseTheory, AssessmentItemResponseTheoryViewModel>();
        serviceCollection.AddTransient<IAssessmentItemRubricCriterionResult, AssessmentItemRubricCriterionResultViewModel>();
        serviceCollection.AddTransient<IAssessmentLanguage, AssessmentLanguageViewModel>();
        serviceCollection.AddTransient<IAssessmentLevelsForWhichDesigned, AssessmentLevelsForWhichDesignedViewModel>();
        serviceCollection.AddTransient<IAssessmentNeedApipContent, AssessmentNeedApipContentViewModel>();
        serviceCollection.AddTransient<IAssessmentNeedApipControl, AssessmentNeedApipControlViewModel>();
        serviceCollection.AddTransient<IAssessmentNeedApipDisplay, AssessmentNeedApipDisplayViewModel>();
        serviceCollection.AddTransient<IAssessmentNeedBraille, AssessmentNeedBrailleViewModel>();
        serviceCollection.AddTransient<IAssessmentNeedScreenEnhancement, AssessmentNeedScreenEnhancementViewModel>();
        serviceCollection.AddTransient<IAssessmentParticipantSession, AssessmentParticipantSessionViewModel>();
        serviceCollection.AddTransient<IAssessmentParticipantSessionAccommodation, AssessmentParticipantSessionAccommodationViewModel>();
        serviceCollection.AddTransient<IAssessmentPerformanceLevel, AssessmentPerformanceLevelViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedLanguageLearner, AssessmentPersonalNeedLanguageLearnerViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedScreenReader, AssessmentPersonalNeedScreenReaderViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileContent, AssessmentPersonalNeedsProfileContentViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileControl, AssessmentPersonalNeedsProfileControlViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileDisplay, AssessmentPersonalNeedsProfileDisplayViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileScreenEnhancement, AssessmentPersonalNeedsProfileScreenEnhancementViewModel>();
        serviceCollection.AddTransient<IAssessmentRegistration, AssessmentRegistrationViewModel>();
        serviceCollection.AddTransient<IAssessmentRegistrationAccommodation, AssessmentRegistrationAccommodationViewModel>();
        serviceCollection.AddTransient<IAssessmentResult, AssessmentResultViewModel>();
        serviceCollection.AddTransient<IAssessmentResultPerformanceLevel, AssessmentResultPerformanceLevelViewModel>();
        serviceCollection.AddTransient<IAssessmentResultRubricCriterionResult, AssessmentResultRubricCriterionResultViewModel>();
        serviceCollection.AddTransient<IAssessmentSession, AssessmentSessionViewModel>();
        serviceCollection.AddTransient<IAssessmentSessionStaffRole, AssessmentSessionStaffRoleViewModel>();
        serviceCollection.AddTransient<IAssessmentSubTest, AssessmentSubTestViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestAssessmentItem, AssessmentSubtestAssessmentItemViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestCompetencyDefinition, AssessmentSubtestCompetencyDefinitionViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestEldevelopmentalDomain, AssessmentSubtestEldevelopmentalDomainViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestItem, AssessmentSubtestItemViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestLevelsForWhichDesigned, AssessmentSubtestLevelsForWhichDesignedViewModel>();
        serviceCollection.AddTransient<IGoal, GoalViewModel>();
        serviceCollection.AddTransient<IGoalMeasurement, GoalMeasurementViewModel>();
        serviceCollection.AddTransient<IGoalMeasurementCriterion, GoalMeasurementCriterionViewModel>();
        serviceCollection.AddTransient<IGoalPerformance, GoalPerformanceViewModel>();
        serviceCollection.AddTransient<ILearnerAction, LearnerActionViewModel>();
        serviceCollection.AddTransient<ILearnerActivity, LearnerActivityViewModel>();
        serviceCollection.AddTransient<IPersonAssessmentPersonalNeedsProfile, PersonAssessmentPersonalNeedsProfileViewModel>();
        serviceCollection.AddTransient<IRubric, RubricViewModel>();
        serviceCollection.AddTransient<IRubricCriterion, RubricCriterionViewModel>();
        serviceCollection.AddTransient<IRubricCriterionLevel, RubricCriterionLevelViewModel>();

        return serviceCollection;
    }
}
