//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityComplianceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityCompliance file
/// </summary>
public partial class FacilityComplianceViewModel : ObservableValidator, IFacilityCompliance
{
    #region "FacilityComplianceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityComplianceViewModel Constructor
    /// </summary>
    public FacilityComplianceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityComplianceViewModelConstruction();
    }

    /// <summary>
    /// FacilityComplianceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityComplianceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityCompliance";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ComponentOrFixtureCheckDate -- (backing property for Component or Fixture Check Date)
    private DateTime? componentOrFixtureCheckDate;

    // FacilityComplianceDeterminationDate -- (backing property for Facility Compliance Determination Date)
    private DateTime? facilityComplianceDeterminationDate;

    // FacilityComplianceName -- (backing property for Facility Compliance Name)
    private System.String facilityComplianceName;

    // FacilityComponentDeficiencyDescription -- (backing property for Facility Component Deficiency Description)
    private System.String facilityComponentDeficiencyDescription;

    // FacilityEstimatedCostToEliminateDeferredMaint -- (backing property for Facility Estimated Cost to Eliminate Deferred Maintenance)
    private Decimal? facilityEstimatedCostToEliminateDeferredMaint;

    // FacilityInspectionScoreResultDescription -- (backing property for Facility Inspection Score Result Description)
    private System.String facilityInspectionScoreResultDescription;

    // FacilityInspectionViolationDescription -- (backing property for Facility Inspection Violation Description)
    private System.String facilityInspectionViolationDescription;

    #endregion

    #region "IAutobahnBase Properties"
    /// <summary>
    /// The title of the View Model
    /// </summary>
    public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

    /// <summary>
    /// The IsNew property is set if the view model has been created but not saved to the database
    /// </summary>
    public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

    /// <summary>
    /// The IsDeleted property is set if the view model is to be delted from the database
    /// </summary>
    public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

    /// <summary>
    /// The primary key of the view model
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The view model is changed and needs to be save to the database.
    /// </summary>
    public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

    /// <summary>
    /// The view model is performing a long running task
    /// </summary>
    public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

    /// <summary>
    /// The view model's changes have been save so update its tracking properties
    /// </summary>
    public void AcceptChanges()
    {
        IsNew = false;
        IsChanged = false;
    }
    #endregion

    #region "IFacilityCompliance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
    /// </summary>
    public Guid? BuildingSystemComponentId { get; set; }

    /// <summary>
    /// Component or Fixture Check Date
    /// <para>
    /// The month, day, and year that the condition of a system, component, equipment, or fixture was  checked.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20879">Component or Fixture Check Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Component or Fixture Check Date")]
    public DateTime? ComponentOrFixtureCheckDate { get => componentOrFixtureCheckDate; set => SetProperty(ref componentOrFixtureCheckDate, value, false); }

    /// <summary>
    /// Facility Compliance Determination Date
    /// <para>
    /// The month, day, and year that the school, building, site, system, component, equipment, or fixture compliance status was determined.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20818">Facility Compliance Determination Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Compliance Determination Date")]
    public DateTime? FacilityComplianceDeterminationDate { get => facilityComplianceDeterminationDate; set => SetProperty(ref facilityComplianceDeterminationDate, value, false); }

    /// <summary>
    /// Facility Compliance Name
    /// <para>
    /// The name of the inspection or process that indicates conformity to the requirements or standards specified in federal, state, or local standards or codes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20819">Facility Compliance Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Compliance Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilityComplianceName { get => facilityComplianceName; set => SetProperty(ref facilityComplianceName, value, true); }

    /// <summary>
    /// Facility Component Deficiency Description
    /// <para>
    /// A description of the component, system, or finish that needs replacement, repair, or maintenance to perform at an optimal level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20820">Facility Component Deficiency Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Component Deficiency Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilityComponentDeficiencyDescription { get => facilityComponentDeficiencyDescription; set => SetProperty(ref facilityComponentDeficiencyDescription, value, true); }

    /// <summary>
    /// Facility Estimated Cost to Eliminate Deferred Maintenance
    /// <para>
    /// The estimated cost to bring systems, components, finishes, fixtures, or equipment to a state of good repair.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20822">Facility Estimated Cost to Eliminate Deferred Maintenance</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Estimated Cost to Eliminate Deferred Maintenance")]
    public Decimal? FacilityEstimatedCostToEliminateDeferredMaint { get => facilityEstimatedCostToEliminateDeferredMaint; set => SetProperty(ref facilityEstimatedCostToEliminateDeferredMaint, value, false); }

    /// <summary>
    /// Facility Inspection Score Result Description
    /// <para>
    /// The description of a meaningful raw score of statistical expression of the performance on an inspection.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20827">Facility Inspection Score Result Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Inspection Score Result Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(35,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilityInspectionScoreResultDescription { get => facilityInspectionScoreResultDescription; set => SetProperty(ref facilityInspectionScoreResultDescription, value, true); }

    /// <summary>
    /// Facility Inspection Violation Description
    /// <para>
    /// A description of the standard violation(s) found in the inspection.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20828">Facility Inspection Violation Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Inspection Violation Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilityInspectionViolationDescription { get => facilityInspectionViolationDescription; set => SetProperty(ref facilityInspectionViolationDescription, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMandate"/> model
    /// </summary>
    public Guid? FacilityMandateId { get; set; }

    /// <summary>
    /// Facility Compliance Status
    /// <para>
    /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20773">Facility Compliance Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Compliance Status")]
    public Guid? RefFacilityComplianceStatusId { get; set; }

    /// <summary>
    /// Facility Maintenance Standard Type
    /// <para>
    /// The standard for maintenance of a component, system, or building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20857">Facility Maintenance Standard Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Maintenance Standard Type")]
    public Guid? RefFacilityMaintStandardTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityCompliance model)
    {
        IsBusy = true;
        Id = model.Id;
        BuildingSystemComponentId = model.BuildingSystemComponentId; // 
        ComponentOrFixtureCheckDate = model.ComponentOrFixtureCheckDate; // Component or Fixture Check Date
        FacilityComplianceDeterminationDate = model.FacilityComplianceDeterminationDate; // Facility Compliance Determination Date
        FacilityComplianceName = model.FacilityComplianceName; // Facility Compliance Name
        FacilityComponentDeficiencyDescription = model.FacilityComponentDeficiencyDescription; // Facility Component Deficiency Description
        FacilityEstimatedCostToEliminateDeferredMaint = model.FacilityEstimatedCostToEliminateDeferredMaint; // Facility Estimated Cost to Eliminate Deferred Maintenance
        FacilityInspectionScoreResultDescription = model.FacilityInspectionScoreResultDescription; // Facility Inspection Score Result Description
        FacilityInspectionViolationDescription = model.FacilityInspectionViolationDescription; // Facility Inspection Violation Description
        FacilityMandateId = model.FacilityMandateId; // 
        RefFacilityComplianceStatusId = model.RefFacilityComplianceStatusId; // Facility Compliance Status
        RefFacilityMaintStandardTypeId = model.RefFacilityMaintStandardTypeId; // Facility Maintenance Standard Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
