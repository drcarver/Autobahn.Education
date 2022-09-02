//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceUtilizationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSpaceUtilization file
/// </summary>
public partial class BuildingSpaceUtilizationViewModel : ObservableValidator, IBuildingSpaceUtilization
{
    #region "BuildingSpaceUtilizationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// BuildingSpaceUtilizationViewModel Constructor
    /// </summary>
    public BuildingSpaceUtilizationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnBuildingSpaceUtilizationViewModelConstruction();
    }

    /// <summary>
    /// BuildingSpaceUtilizationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnBuildingSpaceUtilizationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from BuildingSpaceUtilization";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AvailableUtilizedInstructionalSpace -- (backing property for Available Utilized Instructional Space)
    private Boolean? availableUtilizedInstructionalSpace;

    // BuildingCapacityFactorIndicator -- (backing property for Building Capacity Factor Indicator)
    private Boolean? buildingCapacityFactorIndicator;

    // BuildingSpaceUtilizationArea -- (backing property for Building Space Utilization Area)
    private Decimal? buildingSpaceUtilizationArea;

    // BuildingUnassignedSpaceIndicator -- (backing property for Building Unassigned Space Indicator)
    private Boolean? buildingUnassignedSpaceIndicator;

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

    #region "IBuildingSpaceUtilization Properties"
    /// <summary>
    /// Available Utilized Instructional Space
    /// <para>
    /// An indication that the instruction space in a school is used in the calculation of student capacity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20883">Available Utilized Instructional Space</a>
    /// </para>
    /// </summary>
    [DisplayName("Available Utilized Instructional Space")]
    public Boolean? AvailableUtilizedInstructionalSpace { get => availableUtilizedInstructionalSpace; set => SetProperty(ref availableUtilizedInstructionalSpace, value, false); }

    /// <summary>
    /// Building Capacity Factor Indicator
    /// <para>
    /// A designation as to whether the space is included in the calculation of school building capacity under state or local guidelines.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20884">Building Capacity Factor Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Capacity Factor Indicator")]
    public Boolean? BuildingCapacityFactorIndicator { get => buildingCapacityFactorIndicator; set => SetProperty(ref buildingCapacityFactorIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSpace"/> model
    /// </summary>
    public Guid BuildingSpaceId { get; set; }

    /// <summary>
    /// Building Space Utilization Area
    /// <para>
    /// The area in square feet measured between the principal wall that faces at or near floor level, including alcove spaces, and the outer limits of space designed to serve the activity. Structural space is excluded.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20842">Building Space Utilization Area</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Space Utilization Area")]
    public Decimal? BuildingSpaceUtilizationArea { get => buildingSpaceUtilizationArea; set => SetProperty(ref buildingSpaceUtilizationArea, value, false); }

    /// <summary>
    /// Building Unassigned Space Indicator
    /// <para>
    /// An indication that the space in a school, including circulation, administration offices, support spaces, and common areas, is not part of the calculation for capacity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20844">Building Unassigned Space Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Unassigned Space Indicator")]
    public Boolean? BuildingUnassignedSpaceIndicator { get => buildingUnassignedSpaceIndicator; set => SetProperty(ref buildingUnassignedSpaceIndicator, value, false); }

    /// <summary>
    /// Building Community Use Space Type
    /// <para>
    /// The space designed primarily for community or shared use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20836">Building Community Use Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Community Use Space Type")]
    public Guid? RefBuildingCommunityUseSpaceTypeId { get; set; }

    /// <summary>
    /// Building Instructional Space Factor Type
    /// <para>
    /// A designation as to whether the space is considered an instructional space under state or local guidelines.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20832">Building Instructional Space Factor Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Instructional Space Factor Type")]
    public Guid? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IBuildingSpaceUtilization model)
    {
        IsBusy = true;
        Id = model.Id;
        AvailableUtilizedInstructionalSpace = model.AvailableUtilizedInstructionalSpace; // Available Utilized Instructional Space
        BuildingCapacityFactorIndicator = model.BuildingCapacityFactorIndicator; // Building Capacity Factor Indicator
        BuildingSpaceId = model.BuildingSpaceId; // 
        BuildingSpaceUtilizationArea = model.BuildingSpaceUtilizationArea; // Building Space Utilization Area
        BuildingUnassignedSpaceIndicator = model.BuildingUnassignedSpaceIndicator; // Building Unassigned Space Indicator
        RefBuildingCommunityUseSpaceTypeId = model.RefBuildingCommunityUseSpaceTypeId; // Building Community Use Space Type
        RefBuildingInstructionalSpaceFactorTypeId = model.RefBuildingInstructionalSpaceFactorTypeId; // Building Instructional Space Factor Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
