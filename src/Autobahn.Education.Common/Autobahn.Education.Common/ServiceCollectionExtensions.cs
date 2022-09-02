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
        serviceCollection.AddTransient<IActivity, ActivityViewModel>();
        serviceCollection.AddTransient<IActivityRecognition, ActivityRecognitionViewModel>();
        serviceCollection.AddTransient<IApipInteraction, ApipInteractionViewModel>();
        serviceCollection.AddTransient<IAssessment, AssessmentViewModel>();
        serviceCollection.AddTransient<IAssessmentAccommodation, AssessmentAccommodationViewModel>();
        serviceCollection.AddTransient<IAssessmentAdministration, AssessmentAdministrationViewModel>();
        serviceCollection.AddTransient<IAssessmentForm, AssessmentFormViewModel>();
        serviceCollection.AddTransient<IAssessmentItem, AssessmentItemViewModel>();
        serviceCollection.AddTransient<IAssessmentItemApip, AssessmentItemApipViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfile, AssessmentPersonalNeedsProfileViewModel>();
        serviceCollection.AddTransient<IAssessmentRegistration, AssessmentRegistrationViewModel>();
        serviceCollection.AddTransient<IAssessmentResult, AssessmentResultViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtest, AssessmentSubtestViewModel>();
        serviceCollection.AddTransient<IClassroom, ClassroomViewModel>();
        serviceCollection.AddTransient<ICompetencyDefinition, CompetencyDefinitionViewModel>();
        serviceCollection.AddTransient<ICompetencyFramework, CompetencyFrameworkViewModel>();
        serviceCollection.AddTransient<ICompetencySet, CompetencySetViewModel>();
        serviceCollection.AddTransient<ICoreKnowledgeArea, CoreKnowledgeAreaViewModel>();
        serviceCollection.AddTransient<ICourse, CourseViewModel>();
        serviceCollection.AddTransient<ICourseSection, CourseSectionViewModel>();
        serviceCollection.AddTransient<ICourseSectionAssessmentReporting, CourseSectionAssessmentReportingViewModel>();
        serviceCollection.AddTransient<ICourseSectionLevel, CourseSectionLevelViewModel>();
        serviceCollection.AddTransient<ICourseSectionLocation, CourseSectionLocationViewModel>();
        serviceCollection.AddTransient<ICourseSectionSchedule, CourseSectionScheduleViewModel>();
        serviceCollection.AddTransient<ICredentialAward, CredentialAwardViewModel>();
        serviceCollection.AddTransient<ICredentialAwardEvidence, CredentialAwardEvidenceViewModel>();
        serviceCollection.AddTransient<ICredentialDefinition, CredentialDefinitionViewModel>();
        serviceCollection.AddTransient<ICredentialIssuer, CredentialIssuerViewModel>();
        serviceCollection.AddTransient<IDataCollection, DataCollectionViewModel>();
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
        serviceCollection.AddTransient<IFinancialAccount, FinancialAccountViewModel>();
        serviceCollection.AddTransient<IFinancialAccountProgram, FinancialAccountProgramViewModel>();
        serviceCollection.AddTransient<IFinancialAidApplication, FinancialAidApplicationViewModel>();
        serviceCollection.AddTransient<IFinancialAidAward, FinancialAidAwardViewModel>();
        serviceCollection.AddTransient<IGoal, GoalViewModel>();
        serviceCollection.AddTransient<IGoalPerformance, GoalPerformanceViewModel>();
        serviceCollection.AddTransient<IIdeaeligibilityEvaluationCategory, IdeaeligibilityEvaluationCategoryViewModel>();
        serviceCollection.AddTransient<IIdsversion, IdsversionViewModel>();
        serviceCollection.AddTransient<IIepauthorization, IepauthorizationViewModel>();
        serviceCollection.AddTransient<IIepauthorizationRejected, IepauthorizationRejectedViewModel>();
        serviceCollection.AddTransient<IIeppresentLevel, IeppresentLevelViewModel>();
        serviceCollection.AddTransient<IIncident, IncidentViewModel>();
        serviceCollection.AddTransient<IIncidentPerson, IncidentPersonViewModel>();
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
        serviceCollection.AddTransient<IK12staffAssignment, K12staffAssignmentViewModel>();
        serviceCollection.AddTransient<IK12studentCourseSection, K12studentCourseSectionViewModel>();
        serviceCollection.AddTransient<ILearningResource, LearningResourceViewModel>();
        serviceCollection.AddTransient<ILocation, LocationViewModel>();
        serviceCollection.AddTransient<ILocationAddress, LocationAddressViewModel>();
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
        serviceCollection.AddTransient<IPdactivityEducationLevel, PdactivityEducationLevelViewModel>();
        serviceCollection.AddTransient<IPersonAddress, PersonAddressViewModel>();
        serviceCollection.AddTransient<IPersonAddressNcesSide, PersonAddressNcesSideViewModel>();
        serviceCollection.AddTransient<IPersonAllergy, PersonAllergyViewModel>();
        serviceCollection.AddTransient<IPersonAssessmentPersonalNeedsProfile, PersonAssessmentPersonalNeedsProfileViewModel>();
        serviceCollection.AddTransient<IPersonBirthplace, PersonBirthplaceViewModel>();
        serviceCollection.AddTransient<IPersonCareerEducationPlan, PersonCareerEducationPlanViewModel>();
        serviceCollection.AddTransient<IPersonCredential, PersonCredentialViewModel>();
        serviceCollection.AddTransient<IPersonDegreeOrCertificate, PersonDegreeOrCertificateViewModel>();
        serviceCollection.AddTransient<IPersonDemographicRace, PersonDemographicRaceViewModel>();
        serviceCollection.AddTransient<IPersonDetail, PersonDetailViewModel>();
        serviceCollection.AddTransient<IPersonDigitalAccess, PersonDigitalAccessViewModel>();
        serviceCollection.AddTransient<IPersonDigitalAccessSpeed, PersonDigitalAccessSpeedViewModel>();
        serviceCollection.AddTransient<IPersonDisability, PersonDisabilityViewModel>();
        serviceCollection.AddTransient<IPersonEmailAddress, PersonEmailAddressViewModel>();
        serviceCollection.AddTransient<IPersonFamily, PersonFamilyViewModel>();
        serviceCollection.AddTransient<IPersonHealth, PersonHealthViewModel>();
        serviceCollection.AddTransient<IPersonHealthBirth, PersonHealthBirthViewModel>();
        serviceCollection.AddTransient<IPersonHomelessness, PersonHomelessnessViewModel>();
        serviceCollection.AddTransient<IPersonIdentifier, PersonIdentifierViewModel>();
        serviceCollection.AddTransient<IPersonImmunization, PersonImmunizationViewModel>();
        serviceCollection.AddTransient<IPersonLanguage, PersonLanguageViewModel>();
        serviceCollection.AddTransient<IPersonLearningDevice, PersonLearningDeviceViewModel>();
        serviceCollection.AddTransient<IPersonMaster, PersonMasterViewModel>();
        serviceCollection.AddTransient<IPersonMilitary, PersonMilitaryViewModel>();
        serviceCollection.AddTransient<IPersonOtherName, PersonOtherNameViewModel>();
        serviceCollection.AddTransient<IPersonPersonalInformationVerification, PersonPersonalInformationVerificationViewModel>();
        serviceCollection.AddTransient<IPersonProgramParticipation, PersonProgramParticipationViewModel>();
        serviceCollection.AddTransient<IPersonReferral, PersonReferralViewModel>();
        serviceCollection.AddTransient<IPersonRelationship, PersonRelationshipViewModel>();
        serviceCollection.AddTransient<IPersonStatus, PersonStatusViewModel>();
        serviceCollection.AddTransient<IPersonTelephone, PersonTelephoneViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentActivity, ProfessionalDevelopmentActivityViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentRequirement, ProfessionalDevelopmentRequirementViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentSession, ProfessionalDevelopmentSessionViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentSessionInstructor, ProfessionalDevelopmentSessionInstructorViewModel>();
        serviceCollection.AddTransient<IProgram, ProgramViewModel>();
        serviceCollection.AddTransient<IProgramParticipationAe, ProgramParticipationAeViewModel>();
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
        serviceCollection.AddTransient<IRoleAttendance, RoleAttendanceViewModel>();
        serviceCollection.AddTransient<IRoleAttendanceEvent, RoleAttendanceEventViewModel>();
        serviceCollection.AddTransient<IRoleStatus, RoleStatusViewModel>();
        serviceCollection.AddTransient<IRubric, RubricViewModel>();
        serviceCollection.AddTransient<IRubricCriterion, RubricCriterionViewModel>();
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
