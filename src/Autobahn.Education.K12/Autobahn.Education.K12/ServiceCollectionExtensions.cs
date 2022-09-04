//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Elementary and Secondary (K12) domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Elementary and Secondary (K12) Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddK12Services(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IK12charterSchoolAuthorizerAgency, K12charterSchoolAuthorizerAgencyViewModel>();
        serviceCollection.AddTransient<IK12charterSchoolManagementOrganization, K12charterSchoolManagementOrganizationViewModel>();
        serviceCollection.AddTransient<IK12course, K12courseViewModel>();
        serviceCollection.AddTransient<IK12federalFundAllocation, K12federalFundAllocationViewModel>();
        serviceCollection.AddTransient<IK12lea, K12leaViewModel>();
        serviceCollection.AddTransient<IK12leaFederalFund, K12leaFederalFundViewModel>();
        serviceCollection.AddTransient<IK12leaFederalReporting, K12leaFederalReportingViewModel>();
        serviceCollection.AddTransient<IK12leaGradeLevelsApproved, K12leaGradeLevelsApprovedViewModel>();
        serviceCollection.AddTransient<IK12leaGradeOffered, K12leaGradeOfferedViewModel>();
        serviceCollection.AddTransient<IK12leaPreKeligibility, K12leaPreKeligibilityViewModel>();
        serviceCollection.AddTransient<IK12leaPreKeligibleAgesIdea, K12leaPreKeligibleAgesIdeaViewModel>();
        serviceCollection.AddTransient<IK12leaSafeDrugFree, K12leaSafeDrugFreeViewModel>();
        serviceCollection.AddTransient<IK12leaTitleIiiprofessionalDevelopment, K12leaTitleIiiprofessionalDevelopmentViewModel>();
        serviceCollection.AddTransient<IK12leaTitleIsupportService, K12leaTitleIsupportServiceViewModel>();
        serviceCollection.AddTransient<IK12organizationStudentResponsibility, K12organizationStudentResponsibilityViewModel>();
        serviceCollection.AddTransient<IK12programOrService, K12programOrServiceViewModel>();
        serviceCollection.AddTransient<IK12school, K12schoolViewModel>();
        serviceCollection.AddTransient<IK12schoolCorrectiveAction, K12schoolCorrectiveActionViewModel>();
        serviceCollection.AddTransient<IK12schoolGradeLevelsApproved, K12schoolGradeLevelsApprovedViewModel>();
        serviceCollection.AddTransient<IK12schoolGradeOffered, K12schoolGradeOfferedViewModel>();
        serviceCollection.AddTransient<IK12schoolImprovement, K12schoolImprovementViewModel>();
        serviceCollection.AddTransient<IK12schoolIndicatorStatus, K12schoolIndicatorStatusViewModel>();
        serviceCollection.AddTransient<IK12schoolStatus, K12schoolStatusViewModel>();
        serviceCollection.AddTransient<IK12sea, K12seaViewModel>();
        serviceCollection.AddTransient<IK12seaAlternateFundUse, K12seaAlternateFundUseViewModel>();
        serviceCollection.AddTransient<IK12seaFederalFund, K12seaFederalFundViewModel>();
        serviceCollection.AddTransient<IK12staffAssignment, K12staffAssignmentViewModel>();
        serviceCollection.AddTransient<IK12staffEmployment, K12staffEmploymentViewModel>();
        serviceCollection.AddTransient<IK12studentAcademicHonor, K12studentAcademicHonorViewModel>();
        serviceCollection.AddTransient<IK12studentAcademicRecord, K12studentAcademicRecordViewModel>();
        serviceCollection.AddTransient<IK12studentActivity, K12studentActivityViewModel>();
        serviceCollection.AddTransient<IK12studentCohort, K12studentCohortViewModel>();
        serviceCollection.AddTransient<IK12studentCourseSection, K12studentCourseSectionViewModel>();
        serviceCollection.AddTransient<IK12studentCourseSectionMark, K12studentCourseSectionMarkViewModel>();
        serviceCollection.AddTransient<IK12studentDiscipline, K12studentDisciplineViewModel>();
        serviceCollection.AddTransient<IK12studentEmployment, K12studentEmploymentViewModel>();
        serviceCollection.AddTransient<IK12studentEnrollment, K12studentEnrollmentViewModel>();
        serviceCollection.AddTransient<IK12studentGraduationPlan, K12studentGraduationPlanViewModel>();
        serviceCollection.AddTransient<IK12studentHomeLanguageSurvey, K12studentHomeLanguageSurveyViewModel>();
        serviceCollection.AddTransient<IK12studentLiteracyAssessment, K12studentLiteracyAssessmentViewModel>();
        serviceCollection.AddTransient<IK12studentSession, K12studentSessionViewModel>();
        serviceCollection.AddTransient<IK12titleIiilanguageInstruction, K12titleIiilanguageInstructionViewModel>();

        return serviceCollection;
    }
}
