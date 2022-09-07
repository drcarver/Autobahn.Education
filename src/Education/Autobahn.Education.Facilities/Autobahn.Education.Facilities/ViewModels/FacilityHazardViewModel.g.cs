//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityHazardViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityHazard file
/// </summary>
public partial class FacilityHazardViewModel : ObservableValidator, IFacilityHazard
{
    #region "FacilityHazardViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityHazardViewModel Constructor
    /// </summary>
    public FacilityHazardViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityHazardViewModelConstruction();
    }

    /// <summary>
    /// FacilityHazardViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityHazardViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityHazard";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FacilityHazardousCondExpectedRemediationDate -- (backing property for Facility Hazardous Condition Expected Remediation Date)
    private DateTime? facilityHazardousCondExpectedRemediationDate;

    // FacilityLocationOfHazardousMaterials -- (backing property for Facility Location of Hazardous Materials)
    private System.String facilityLocationOfHazardousMaterials;

    // FacilityNearbyEnvHazardDescription -- (backing property for Facility Nearby Environmental Hazard Description)
    private System.String facilityNearbyEnvHazardDescription;

    // HazardousMaterialOrConditionDescription -- (backing property for Hazardous Material or Condition Description)
    private System.String hazardousMaterialOrConditionDescription;

    // HazardousMaterialOrConditionTestingDate -- (backing property for Hazardous Material or Condition Testing Date)
    private DateTime? hazardousMaterialOrConditionTestingDate;

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

    #region "IFacilityHazard Properties"
    /// <summary>
    /// Facility Hazardous Condition Expected Remediation Date
    /// <para>
    /// The month, day, and year by which a hazardous condition of a site or building is expected to be remediated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20823">Facility Hazardous Condition Expected Remediation Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Hazardous Condition Expected Remediation Date")]
    public DateTime? FacilityHazardousCondExpectedRemediationDate { get => facilityHazardousCondExpectedRemediationDate; set => SetProperty(ref facilityHazardousCondExpectedRemediationDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Location of Hazardous Materials
    /// <para>
    /// The location at which the identified hazardous material is found.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20789">Facility Location of Hazardous Materials</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Location of Hazardous Materials")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilityLocationOfHazardousMaterials { get => facilityLocationOfHazardousMaterials; set => SetProperty(ref facilityLocationOfHazardousMaterials, value, true); }

    /// <summary>
    /// Facility Nearby Environmental Hazard Description
    /// <para>
    /// Description of any type of environmental hazards within range of the facility that has the potential to seriously affect the health, safety and operation of school facilities and their occupants.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20791">Facility Nearby Environmental Hazard Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Nearby Environmental Hazard Description")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String FacilityNearbyEnvHazardDescription { get => facilityNearbyEnvHazardDescription; set => SetProperty(ref facilityNearbyEnvHazardDescription, value, true); }

    /// <summary>
    /// Hazardous Material or Condition Description
    /// <para>
    /// A description of the seriousness a threat or hazardous material poses.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20825">Hazardous Material or Condition Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Hazardous Material or Condition Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String HazardousMaterialOrConditionDescription { get => hazardousMaterialOrConditionDescription; set => SetProperty(ref hazardousMaterialOrConditionDescription, value, true); }

    /// <summary>
    /// Hazardous Material or Condition Testing Date
    /// <para>
    /// The month, day, and year that the site or building is tested for a specific hazardous material.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20826">Hazardous Material or Condition Testing Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Hazardous Material or Condition Testing Date")]
    public DateTime? HazardousMaterialOrConditionTestingDate { get => hazardousMaterialOrConditionTestingDate; set => SetProperty(ref hazardousMaterialOrConditionTestingDate, value, false); }

    /// <summary>
    /// Facility Hazardous Materials or Condition Type
    /// <para>
    /// The type of hazardous materials or conditions tested for at a site or building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20855">Facility Hazardous Materials or Condition Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Hazardous Materials or Condition Type")]
    public Guid? RefFacilityHazardousMaterialsOrCondTypeId { get; set; }

    /// <summary>
    /// Facility Naturally Occurring Hazard Type
    /// <para>
    /// Type of natural hazard that can affect the health, safety and operation of school facilities and their occupants.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20858">Facility Naturally Occurring Hazard Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Naturally Occurring Hazard Type")]
    public Guid? RefFacilityNaturallyOccurringHazardTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityHazard model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilityHazardousCondExpectedRemediationDate = model.FacilityHazardousCondExpectedRemediationDate; // Facility Hazardous Condition Expected Remediation Date
        FacilityId = model.FacilityId; // 
        FacilityLocationOfHazardousMaterials = model.FacilityLocationOfHazardousMaterials; // Facility Location of Hazardous Materials
        FacilityNearbyEnvHazardDescription = model.FacilityNearbyEnvHazardDescription; // Facility Nearby Environmental Hazard Description
        HazardousMaterialOrConditionDescription = model.HazardousMaterialOrConditionDescription; // Hazardous Material or Condition Description
        HazardousMaterialOrConditionTestingDate = model.HazardousMaterialOrConditionTestingDate; // Hazardous Material or Condition Testing Date
        RefFacilityHazardousMaterialsOrCondTypeId = model.RefFacilityHazardousMaterialsOrCondTypeId; // Facility Hazardous Materials or Condition Type
        RefFacilityNaturallyOccurringHazardTypeId = model.RefFacilityNaturallyOccurringHazardTypeId; // Facility Naturally Occurring Hazard Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
