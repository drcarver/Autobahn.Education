//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   Postsecondary.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Postsecondary (PS) domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Postsecondary (PS) Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddPostsecondaryServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IPsCourse, PsCourseViewModel>();
        serviceCollection.AddTransient<IPsInstitution, PsInstitutionViewModel>();
        serviceCollection.AddTransient<IPsPriceOfAttendance, PsPriceOfAttendanceViewModel>();
        serviceCollection.AddTransient<IPsProgram, PsProgramViewModel>();
        serviceCollection.AddTransient<IPsSection, PsSectionViewModel>();
        serviceCollection.AddTransient<IPsSectionLocation, PsSectionLocationViewModel>();
        serviceCollection.AddTransient<IPsStaffEmployment, PsStaffEmploymentViewModel>();
        serviceCollection.AddTransient<IPsStudentAcademicAward, PsStudentAcademicAwardViewModel>();
        serviceCollection.AddTransient<IPsStudentAcademicRecord, PsStudentAcademicRecordViewModel>();
        serviceCollection.AddTransient<IPsStudentAdmissionTest, PsStudentAdmissionTestViewModel>();
        serviceCollection.AddTransient<IPsStudentApplication, PsStudentApplicationViewModel>();
        serviceCollection.AddTransient<IPsStudentCohort, PsStudentCohortViewModel>();
        serviceCollection.AddTransient<IPsStudentCourseSectionMark, PsStudentCourseSectionMarkViewModel>();
        serviceCollection.AddTransient<IPsStudentDemographic, PsStudentDemographicViewModel>();
        serviceCollection.AddTransient<IPsStudentEmployment, PsStudentEmploymentViewModel>();
        serviceCollection.AddTransient<IPsStudentEnrollment, PsStudentEnrollmentViewModel>();
        serviceCollection.AddTransient<IPsStudentFinancialAid, PsStudentFinancialAidViewModel>();
        serviceCollection.AddTransient<IPsstudentProgram, PsstudentProgramViewModel>();
        serviceCollection.AddTransient<IPsStudentSection, PsStudentSectionViewModel>();

        return serviceCollection;
    }
}
