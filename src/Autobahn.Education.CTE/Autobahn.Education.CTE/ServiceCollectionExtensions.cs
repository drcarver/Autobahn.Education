//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CTE.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Career and Technical Education (CTE) domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Career and Technical Education (CTE) Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddCTEServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<ICteCourse, CteCourseViewModel>();
        serviceCollection.AddTransient<ICteStudentAcademicRecord, CteStudentAcademicRecordViewModel>();
        serviceCollection.AddTransient<IProgramParticipationCte, ProgramParticipationCteViewModel>();

        return serviceCollection;
    }
}
