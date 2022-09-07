//**********************************************************
//* DomainName: Facilities
//* FileName:   Facilities.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Facilities domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Facilities Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddFacilitiesServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IBuildingSpace, BuildingSpaceViewModel>();
        serviceCollection.AddTransient<IBuildingSpaceUtilization, BuildingSpaceUtilizationViewModel>();
        serviceCollection.AddTransient<IBuildingSystemCategory, BuildingSystemCategoryViewModel>();
        serviceCollection.AddTransient<IBuildingSystemComponent, BuildingSystemComponentViewModel>();
        serviceCollection.AddTransient<IBuildingSystemComponentService, BuildingSystemComponentServiceViewModel>();
        serviceCollection.AddTransient<IFacility, FacilityViewModel>();
        serviceCollection.AddTransient<IFacilityAudit, FacilityAuditViewModel>();
        serviceCollection.AddTransient<IFacilityCompliance, FacilityComplianceViewModel>();
        serviceCollection.AddTransient<IFacilityDesign, FacilityDesignViewModel>();
        serviceCollection.AddTransient<IFacilityDesignConstruction, FacilityDesignConstructionViewModel>();
        serviceCollection.AddTransient<IFacilityEnergy, FacilityEnergyViewModel>();
        serviceCollection.AddTransient<IFacilityFinance, FacilityFinanceViewModel>();
        serviceCollection.AddTransient<IFacilityFinancial, FacilityFinancialViewModel>();
        serviceCollection.AddTransient<IFacilityHazard, FacilityHazardViewModel>();
        serviceCollection.AddTransient<IFacilityJointUse, FacilityJointUseViewModel>();
        serviceCollection.AddTransient<IFacilityLease, FacilityLeaseViewModel>();
        serviceCollection.AddTransient<IFacilityLocation, FacilityLocationViewModel>();
        serviceCollection.AddTransient<IFacilityManagement, FacilityManagementViewModel>();
        serviceCollection.AddTransient<IFacilityManagementPlan, FacilityManagementPlanViewModel>();
        serviceCollection.AddTransient<IFacilityMandate, FacilityMandateViewModel>();
        serviceCollection.AddTransient<IFacilityMortgage, FacilityMortgageViewModel>();
        serviceCollection.AddTransient<IFacilityMortgageFee, FacilityMortgageFeeViewModel>();
        serviceCollection.AddTransient<IFacilityRelationship, FacilityRelationshipViewModel>();
        serviceCollection.AddTransient<IFacilitySchoolDesign, FacilitySchoolDesignViewModel>();
        serviceCollection.AddTransient<IFacilitySite, FacilitySiteViewModel>();
        serviceCollection.AddTransient<IFacilityUtilization, FacilityUtilizationViewModel>();

        return serviceCollection;
    }
}
