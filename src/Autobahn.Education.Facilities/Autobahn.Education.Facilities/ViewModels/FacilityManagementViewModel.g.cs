//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityManagement file
/// </summary>
public partial class FacilityManagementViewModel : ObservableValidator, IFacilityManagement
{
    #region "FacilityManagementViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityManagementViewModel Constructor
    /// </summary>
    public FacilityManagementViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityManagementViewModelConstruction();
    }

    /// <summary>
    /// FacilityManagementViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityManagementViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityManagement";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

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

    #region "IFacilityManagement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Building Charter School Realty Access Type
    /// <para>
    /// The type of real estate vehicle through which a public charter school has access and control of its building space.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20846">Building Charter School Realty Access Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Charter School Realty Access Type")]
    public Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

    /// <summary>
    /// Building Cleaning Standard Type
    /// <para>
    /// The standard for cleanliness, and benchmarks for how much space can be assigned to one properly supplied custodian to meet these standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20847">Building Cleaning Standard Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Cleaning Standard Type")]
    public Guid? RefBuildingCleaningStandardTypeId { get; set; }

    /// <summary>
    /// Facility Capital Program Management Type
    /// <para>
    /// The type of management organization for planning, design, and construction of major capital projects.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20853">Facility Capital Program Management Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Capital Program Management Type")]
    public Guid? RefFacilityCapitalProgramMgmtTypeId { get; set; }

    /// <summary>
    /// Facility Compliance Agency Type
    /// <para>
    /// The type of agency that has ultimate responsibility for the compliance determination.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20848">Facility Compliance Agency Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Compliance Agency Type")]
    public Guid? RefFacilityComplianceAgencyTypeId { get; set; }

    /// <summary>
    /// Facility Operations Management Type
    /// <para>
    /// The type of management arrangements whereby a district oversees and manages its facilities operations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20854">Facility Operations Management Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Operations Management Type")]
    public Guid? RefFacilityOperationsMgmtTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityManagement model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilityId = model.FacilityId; // 
        RefBuildingCharterSchoolRealtyAccessTypeId = model.RefBuildingCharterSchoolRealtyAccessTypeId; // Building Charter School Realty Access Type
        RefBuildingCleaningStandardTypeId = model.RefBuildingCleaningStandardTypeId; // Building Cleaning Standard Type
        RefFacilityCapitalProgramMgmtTypeId = model.RefFacilityCapitalProgramMgmtTypeId; // Facility Capital Program Management Type
        RefFacilityComplianceAgencyTypeId = model.RefFacilityComplianceAgencyTypeId; // Facility Compliance Agency Type
        RefFacilityOperationsMgmtTypeId = model.RefFacilityOperationsMgmtTypeId; // Facility Operations Management Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
