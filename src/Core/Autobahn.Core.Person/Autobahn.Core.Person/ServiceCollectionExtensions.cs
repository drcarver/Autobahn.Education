//**********************************************************
//* DomainName: Person Models
//* FileName:   Person.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Person Models domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Person Models Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddPersonServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfile, AssessmentPersonalNeedsProfileViewModel>();
        serviceCollection.AddTransient<IIncident, IncidentViewModel>();
        serviceCollection.AddTransient<IIncidentPerson, IncidentPersonViewModel>();
        serviceCollection.AddTransient<IPersonAddress, PersonAddressViewModel>();
        serviceCollection.AddTransient<IPersonAddressNcesSide, PersonAddressNcesSideViewModel>();
        serviceCollection.AddTransient<IPersonAllergy, PersonAllergyViewModel>();
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

        return serviceCollection;
    }
}
