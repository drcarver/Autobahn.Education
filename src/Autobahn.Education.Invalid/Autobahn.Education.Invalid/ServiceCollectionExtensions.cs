//**********************************************************
//* DomainName: Unknown Models
//* FileName:   Invalid.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Unknown Models domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Unknown Models Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddInvalidServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IActivity, ActivityViewModel>();
        serviceCollection.AddTransient<IActivityRecognition, ActivityRecognitionViewModel>();
        serviceCollection.AddTransient<IClassroom, ClassroomViewModel>();
        serviceCollection.AddTransient<ICoreKnowledgeArea, CoreKnowledgeAreaViewModel>();
        serviceCollection.AddTransient<ICourse, CourseViewModel>();
        serviceCollection.AddTransient<ICourseSection, CourseSectionViewModel>();
        serviceCollection.AddTransient<ICourseSectionAssessmentReporting, CourseSectionAssessmentReportingViewModel>();
        serviceCollection.AddTransient<ICourseSectionLocation, CourseSectionLocationViewModel>();
        serviceCollection.AddTransient<ICourseSectionSchedule, CourseSectionScheduleViewModel>();
        serviceCollection.AddTransient<IDataCollection, DataCollectionViewModel>();
        serviceCollection.AddTransient<IFinancialAidApplication, FinancialAidApplicationViewModel>();
        serviceCollection.AddTransient<IFinancialAidAward, FinancialAidAwardViewModel>();
        serviceCollection.AddTransient<IIdeaeligibilityEvaluationCategory, IdeaeligibilityEvaluationCategoryViewModel>();
        serviceCollection.AddTransient<IIdsversion, IdsversionViewModel>();
        serviceCollection.AddTransient<IIepauthorization, IepauthorizationViewModel>();
        serviceCollection.AddTransient<IIepauthorizationRejected, IepauthorizationRejectedViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgram, IndividualizedProgramViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramAccommodation, IndividualizedProgramAccommodationViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramAccommodationSubject, IndividualizedProgramAccommodationSubjectViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramAmendment, IndividualizedProgramAmendmentViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramAssessment, IndividualizedProgramAssessmentViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramAssessmentAccommodation, IndividualizedProgramAssessmentAccommodationViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramEligibility, IndividualizedProgramEligibilityViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramEligibilityEvaluation, IndividualizedProgramEligibilityEvaluationViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramGoal, IndividualizedProgramGoalViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramMeeting, IndividualizedProgramMeetingViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramMeetingAttendee, IndividualizedProgramMeetingAttendeeViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramProgressGoal, IndividualizedProgramProgressGoalViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramProgressReport, IndividualizedProgramProgressReportViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramProgressReportPlan, IndividualizedProgramProgressReportPlanViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramService, IndividualizedProgramServiceViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramServicesReceived, IndividualizedProgramServicesReceivedViewModel>();
        serviceCollection.AddTransient<IIpedsfinance, IpedsfinanceViewModel>();
        serviceCollection.AddTransient<ILocation, LocationViewModel>();
        serviceCollection.AddTransient<ILocationAddress, LocationAddressViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentActivity, ProfessionalDevelopmentActivityViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentRequirement, ProfessionalDevelopmentRequirementViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentSession, ProfessionalDevelopmentSessionViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentSessionInstructor, ProfessionalDevelopmentSessionInstructorViewModel>();
        serviceCollection.AddTransient<IProgram, ProgramViewModel>();
        serviceCollection.AddTransient<IProgramParticipationAttainment, ProgramParticipationAttainmentViewModel>();
        serviceCollection.AddTransient<IProgramParticipationFoodService, ProgramParticipationFoodServiceViewModel>();
        serviceCollection.AddTransient<IProgramParticipationMigrant, ProgramParticipationMigrantViewModel>();
        serviceCollection.AddTransient<IProgramParticipationNeglected, ProgramParticipationNeglectedViewModel>();
        serviceCollection.AddTransient<IProgramParticipationSpecialEducation, ProgramParticipationSpecialEducationViewModel>();
        serviceCollection.AddTransient<IProgramParticipationTeacherPrep, ProgramParticipationTeacherPrepViewModel>();
        serviceCollection.AddTransient<IProgramParticipationTitleI, ProgramParticipationTitleIViewModel>();
        serviceCollection.AddTransient<IProgramParticipationTitleIiilep, ProgramParticipationTitleIiilepViewModel>();
        serviceCollection.AddTransient<IProgramParticipationWioa, ProgramParticipationWioaViewModel>();
        serviceCollection.AddTransient<IProgramParticipationWioabarrier, ProgramParticipationWioabarrierViewModel>();
        serviceCollection.AddTransient<IQuarterlyEmploymentRecord, QuarterlyEmploymentRecordViewModel>();
        serviceCollection.AddTransient<IRecordStatus, RecordStatusViewModel>();
        serviceCollection.AddTransient<IRecordStatusHistory, RecordStatusHistoryViewModel>();
        serviceCollection.AddTransient<IRequiredImmunization, RequiredImmunizationViewModel>();
        serviceCollection.AddTransient<IServiceFrequency, ServiceFrequencyViewModel>();
        serviceCollection.AddTransient<IServicePlan, ServicePlanViewModel>();
        serviceCollection.AddTransient<IServiceProvided, ServiceProvidedViewModel>();
        serviceCollection.AddTransient<IServiceProvider, ServiceProviderViewModel>();
        serviceCollection.AddTransient<IServicesReceived, ServicesReceivedViewModel>();
        serviceCollection.AddTransient<IServiceStaff, ServiceStaffViewModel>();
        serviceCollection.AddTransient<IStaffCompensation, StaffCompensationViewModel>();
        serviceCollection.AddTransient<IStaffCredential, StaffCredentialViewModel>();
        serviceCollection.AddTransient<IStaffEmployment, StaffEmploymentViewModel>();
        serviceCollection.AddTransient<IStaffEvaluation, StaffEvaluationViewModel>();
        serviceCollection.AddTransient<IStaffEvaluationPart, StaffEvaluationPartViewModel>();
        serviceCollection.AddTransient<IStaffExperience, StaffExperienceViewModel>();
        serviceCollection.AddTransient<IStaffProfessionalDevelopmentActivity, StaffProfessionalDevelopmentActivityViewModel>();
        serviceCollection.AddTransient<IStaffTechnicalAssistance, StaffTechnicalAssistanceViewModel>();
        serviceCollection.AddTransient<ITeacherEducationCredentialExam, TeacherEducationCredentialExamViewModel>();
        serviceCollection.AddTransient<ITeacherStudentDataLinkExclusion, TeacherStudentDataLinkExclusionViewModel>();

        return serviceCollection;
    }
}
