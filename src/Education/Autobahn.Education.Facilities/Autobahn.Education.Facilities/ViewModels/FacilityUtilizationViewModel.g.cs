//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityUtilizationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityUtilization file
/// </summary>
public partial class FacilityUtilizationViewModel : ObservableValidator, IFacilityUtilization
{
    #region "FacilityUtilizationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityUtilizationViewModel Constructor
    /// </summary>
    public FacilityUtilizationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityUtilizationViewModelConstruction();
    }

    /// <summary>
    /// FacilityUtilizationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityUtilizationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityUtilization";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // BuildingHoursOfPublicUsePerWeek -- (backing property for Building Hours of Public Use Per Week)
    private Int32? buildingHoursOfPublicUsePerWeek;

    // BuildingNetAreaOfInstructionalSpace -- (backing property for Building Net Area of Instructional Space)
    private Decimal? buildingNetAreaOfInstructionalSpace;

    // BuildingNumberOfTeachingStations -- (backing property for Building Number of Teaching Stations)
    private Int32? buildingNumberOfTeachingStations;

    // BuildingPublicUsePolicyDescription -- (backing property for Building Public Use Policy Description)
    private System.String buildingPublicUsePolicyDescription;

    // FacilityEnrollmentCapacity -- (backing property for Facility Enrollment Capacity)
    private Int32? facilityEnrollmentCapacity;

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

    #region "IFacilityUtilization Properties"
    /// <summary>
    /// Building Hours of Public Use Per Week
    /// <para>
    /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20837">Building Hours of Public Use Per Week</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Hours of Public Use Per Week")]
    public Int32? BuildingHoursOfPublicUsePerWeek { get => buildingHoursOfPublicUsePerWeek; set => SetProperty(ref buildingHoursOfPublicUsePerWeek, value, false); }

    /// <summary>
    /// Building Net Area of Instructional Space
    /// <para>
    /// The area of space directly used for instruction excluding circulation, administration, student services, and building support.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20838">Building Net Area of Instructional Space</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Net Area of Instructional Space")]
    public Decimal? BuildingNetAreaOfInstructionalSpace { get => buildingNetAreaOfInstructionalSpace; set => SetProperty(ref buildingNetAreaOfInstructionalSpace, value, false); }

    /// <summary>
    /// Building Number of Teaching Stations
    /// <para>
    /// The number of teaching stations, as defined by how many spaces have, or could have, a teacher assigned to them for classroom instruction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20839">Building Number of Teaching Stations</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Number of Teaching Stations")]
    public Int32? BuildingNumberOfTeachingStations { get => buildingNumberOfTeachingStations; set => SetProperty(ref buildingNumberOfTeachingStations, value, false); }

    /// <summary>
    /// Building Public Use Policy Description
    /// <para>
    /// A description of the policy that enables the community or other organizations to use all or part of a building for purposes other than general education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20840">Building Public Use Policy Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Public Use Policy Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingPublicUsePolicyDescription { get => buildingPublicUsePolicyDescription; set => SetProperty(ref buildingPublicUsePolicyDescription, value, true); }

    /// <summary>
    /// Facility Enrollment Capacity
    /// <para>
    /// The maximum number of age appropriate students who can be enrolled in a facility such that the district's programmatic, operational, and student/teacher work load requirements are met.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20885">Facility Enrollment Capacity</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Enrollment Capacity")]
    public Int32? FacilityEnrollmentCapacity { get => facilityEnrollmentCapacity; set => SetProperty(ref facilityEnrollmentCapacity, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityUtilization model)
    {
        IsBusy = true;
        Id = model.Id;
        BuildingHoursOfPublicUsePerWeek = model.BuildingHoursOfPublicUsePerWeek; // Building Hours of Public Use Per Week
        BuildingNetAreaOfInstructionalSpace = model.BuildingNetAreaOfInstructionalSpace; // Building Net Area of Instructional Space
        BuildingNumberOfTeachingStations = model.BuildingNumberOfTeachingStations; // Building Number of Teaching Stations
        BuildingPublicUsePolicyDescription = model.BuildingPublicUsePolicyDescription; // Building Public Use Policy Description
        FacilityEnrollmentCapacity = model.FacilityEnrollmentCapacity; // Facility Enrollment Capacity
        FacilityId = model.FacilityId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
