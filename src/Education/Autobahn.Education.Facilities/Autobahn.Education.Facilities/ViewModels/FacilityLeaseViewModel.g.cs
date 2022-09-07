//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityLeaseViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityLease file
/// </summary>
public partial class FacilityLeaseViewModel : ObservableValidator, IFacilityLease
{
    #region "FacilityLeaseViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityLeaseViewModel Constructor
    /// </summary>
    public FacilityLeaseViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityLeaseViewModelConstruction();
    }

    /// <summary>
    /// FacilityLeaseViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityLeaseViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityLease";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FacilityLeaseAmount -- (backing property for Facility Lease Amount)
    private Decimal? facilityLeaseAmount;

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

    #region "IFacilityLease Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Lease Amount
    /// <para>
    /// The amount of money the school must pay to rent the facility that it is in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20868">Facility Lease Amount</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Lease Amount")]
    public Decimal? FacilityLeaseAmount { get => facilityLeaseAmount; set => SetProperty(ref facilityLeaseAmount, value, false); }

    /// <summary>
    /// Facility Lease Amount Category
    /// <para>
    /// The category of payment that a school must pay to rent the facility that it is in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20869">Facility Lease Amount Category</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Lease Amount Category")]
    public Guid? RefFacilityLeaseAmountCategoryId { get; set; }

    /// <summary>
    /// Facility Lease Type
    /// <para>
    /// The type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20870">Facility Lease Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Lease Type")]
    public Guid? RefFacilityLeaseTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityLease model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilityId = model.FacilityId; // 
        FacilityLeaseAmount = model.FacilityLeaseAmount; // Facility Lease Amount
        RefFacilityLeaseAmountCategoryId = model.RefFacilityLeaseAmountCategoryId; // Facility Lease Amount Category
        RefFacilityLeaseTypeId = model.RefFacilityLeaseTypeId; // Facility Lease Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
