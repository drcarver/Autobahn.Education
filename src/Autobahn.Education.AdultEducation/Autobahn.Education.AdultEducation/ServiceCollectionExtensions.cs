//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AdultEducation.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Adult Education (AE) domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Adult Education (AE) Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddAdultEducationServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IAeCourse, AeCourseViewModel>();
        serviceCollection.AddTransient<IAeProvider, AeProviderViewModel>();
        serviceCollection.AddTransient<IAeStaff, AeStaffViewModel>();
        serviceCollection.AddTransient<IAeStudentAcademicRecord, AeStudentAcademicRecordViewModel>();
        serviceCollection.AddTransient<IAeStudentEmployment, AeStudentEmploymentViewModel>();

        return serviceCollection;
    }
}
