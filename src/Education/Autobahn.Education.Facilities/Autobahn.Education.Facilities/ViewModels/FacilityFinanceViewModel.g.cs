//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinanceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityFinance file
/// </summary>
public partial class FacilityFinanceViewModel : ObservableValidator, IFacilityFinance
{
    #region "FacilityFinanceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityFinanceViewModel Constructor
    /// </summary>
    public FacilityFinanceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityFinanceViewModelConstruction();
    }

    /// <summary>
    /// FacilityFinanceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityFinanceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityFinance";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FacilityReplacementValue -- (backing property for Facility Replacement Value)
    private Decimal? facilityReplacementValue;

    // IndebtednessAmountAllowed -- (backing property for Indebtedness Amount Allowed)
    private Decimal? indebtednessAmountAllowed;

    // InsuranceDeductible -- (backing property for Insurance Deductible)
    private Decimal? insuranceDeductible;

    // PublicEducationMillRate -- (backing property for Public Education Mill Rate)
    private Decimal? publicEducationMillRate;

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

    #region "IFacilityFinance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Replacement Value
    /// <para>
    /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20765">Facility Replacement Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Replacement Value")]
    public Decimal? FacilityReplacementValue { get => facilityReplacementValue; set => SetProperty(ref facilityReplacementValue, value, false); }

    /// <summary>
    /// Indebtedness Amount Allowed
    /// <para>
    /// The amount of indebtedness allowed by law to be carried by the school district.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20874">Indebtedness Amount Allowed</a>
    /// </para>
    /// </summary>
    [DisplayName("Indebtedness Amount Allowed")]
    public Decimal? IndebtednessAmountAllowed { get => indebtednessAmountAllowed; set => SetProperty(ref indebtednessAmountAllowed, value, false); }

    /// <summary>
    /// Insurance Deductible
    /// <para>
    /// The dollar amount a school district must pay before its insurance will compensate it for loss.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20875">Insurance Deductible</a>
    /// </para>
    /// </summary>
    [DisplayName("Insurance Deductible")]
    public Decimal? InsuranceDeductible { get => insuranceDeductible; set => SetProperty(ref insuranceDeductible, value, false); }

    /// <summary>
    /// Public Education Mill Rate
    /// <para>
    /// The millage rate used to calculate property tax revenue for K-12 public education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20876">Public Education Mill Rate</a>
    /// </para>
    /// </summary>
    [DisplayName("Public Education Mill Rate")]
    public Decimal? PublicEducationMillRate { get => publicEducationMillRate; set => SetProperty(ref publicEducationMillRate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityFinance model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilityId = model.FacilityId; // 
        FacilityReplacementValue = model.FacilityReplacementValue; // Facility Replacement Value
        IndebtednessAmountAllowed = model.IndebtednessAmountAllowed; // Indebtedness Amount Allowed
        InsuranceDeductible = model.InsuranceDeductible; // Insurance Deductible
        PublicEducationMillRate = model.PublicEducationMillRate; // Public Education Mill Rate
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
