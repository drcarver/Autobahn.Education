//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityAuditViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityAudit file
/// </summary>
public partial class FacilityAuditViewModel : ObservableValidator, IFacilityAudit
{
    #region "FacilityAuditViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityAuditViewModel Constructor
    /// </summary>
    public FacilityAuditViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityAuditViewModelConstruction();
    }

    /// <summary>
    /// FacilityAuditViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityAuditViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityAudit";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FacilityAuditDate -- (backing property for Facility Audit Date)
    private DateTime? facilityAuditDate;

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

    #region "IFacilityAudit Properties"
    /// <summary>
    /// Facility Audit Date
    /// <para>
    /// The month, day, and year of the systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20862">Facility Audit Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Audit Date")]
    public DateTime? FacilityAuditDate { get => facilityAuditDate; set => SetProperty(ref facilityAuditDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Audit Type
    /// <para>
    /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20845">Facility Audit Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Audit Type")]
    public Guid? RefFacilityAuditTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityAudit model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilityAuditDate = model.FacilityAuditDate; // Facility Audit Date
        FacilityId = model.FacilityId; // 
        RefFacilityAuditTypeId = model.RefFacilityAuditTypeId; // Facility Audit Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
