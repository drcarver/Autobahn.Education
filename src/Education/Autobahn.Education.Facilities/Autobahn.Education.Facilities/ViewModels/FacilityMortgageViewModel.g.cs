//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityMortgage file
/// </summary>
public partial class FacilityMortgageViewModel : ObservableValidator, IFacilityMortgage
{
    #region "FacilityMortgageViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityMortgageViewModel Constructor
    /// </summary>
    public FacilityMortgageViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityMortgageViewModelConstruction();
    }

    /// <summary>
    /// FacilityMortgageViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityMortgageViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityMortgage";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FacilityMortgageInterestAmount -- (backing property for Facility Mortgage Interest Amount)
    private Decimal? facilityMortgageInterestAmount;

    // FacilityTotalAssessedValue -- (backing property for Facility Total Assessed Value)
    private Decimal? facilityTotalAssessedValue;

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

    #region "IFacilityMortgage Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Mortgage Interest Amount
    /// <para>
    /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20871">Facility Mortgage Interest Amount</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Mortgage Interest Amount")]
    public Decimal? FacilityMortgageInterestAmount { get => facilityMortgageInterestAmount; set => SetProperty(ref facilityMortgageInterestAmount, value, false); }

    /// <summary>
    /// Facility Total Assessed Value
    /// <para>
    /// The total assessed value of property that constitutes the basis for public borrowing.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20877">Facility Total Assessed Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Total Assessed Value")]
    public Decimal? FacilityTotalAssessedValue { get => facilityTotalAssessedValue; set => SetProperty(ref facilityTotalAssessedValue, value, false); }

    /// <summary>
    /// Facility Mortgage Interest Type
    /// <para>
    /// The type of interest paid on a mortgage to the lender to compensate the lender for the use of money to purchase a building or facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20872">Facility Mortgage Interest Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Mortgage Interest Type")]
    public Guid? RefFacilityMortgageInterestTypeId { get; set; }

    /// <summary>
    /// Facility Mortgage Type
    /// <para>
    /// The status of a mortgage as it relates to priority of payment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20873">Facility Mortgage Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Mortgage Type")]
    public Guid? RefFacilityMortgageTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityMortgage model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilityId = model.FacilityId; // 
        FacilityMortgageInterestAmount = model.FacilityMortgageInterestAmount; // Facility Mortgage Interest Amount
        FacilityTotalAssessedValue = model.FacilityTotalAssessedValue; // Facility Total Assessed Value
        RefFacilityMortgageInterestTypeId = model.RefFacilityMortgageInterestTypeId; // Facility Mortgage Interest Type
        RefFacilityMortgageTypeId = model.RefFacilityMortgageTypeId; // Facility Mortgage Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
