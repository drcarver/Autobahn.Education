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
        serviceCollection.AddTransient<IClassroom, ClassroomViewModel>();
        serviceCollection.AddTransient<ICourse, CourseViewModel>();
        serviceCollection.AddTransient<ICourseSection, CourseSectionViewModel>();
        serviceCollection.AddTransient<IFinancialAccount, FinancialAccountViewModel>();
        serviceCollection.AddTransient<IFinancialAccountProgram, FinancialAccountProgramViewModel>();

        return serviceCollection;
    }
}
