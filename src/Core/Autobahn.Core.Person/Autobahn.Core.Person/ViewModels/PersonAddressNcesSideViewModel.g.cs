//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonAddressNcesSideViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAddressNcesSide file
/// </summary>
public partial class PersonAddressNcesSideViewModel : ObservableValidator, IPersonAddressNcesSide
{
    #region "PersonAddressNcesSideViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonAddressNcesSideViewModel Constructor
    /// </summary>
    public PersonAddressNcesSideViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonAddressNcesSideViewModelConstruction();
    }

    /// <summary>
    /// PersonAddressNcesSideViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonAddressNcesSideViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonAddressNcesSide";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // NcesSideDateProcessed -- (backing property for NCES SIDE Date Processed)
    private DateTime? ncesSideDateProcessed;

    // NcesSideEstimate -- (backing property for NCES SIDE Estimate)
    private Decimal? ncesSideEstimate;

    // NcesSideStandardError -- (backing property for NCES SIDE Standard Error)
    private Decimal? ncesSideStandardError;

    // NcesSideVintageBeginYear -- (backing property for NCES SIDE Vintage Begin Year)
    private System.String ncesSideVintageBeginYear;

    // NcesSideVintageEndYear -- (backing property for NCES SIDE Vintage End Year)
    private System.String ncesSideVintageEndYear;

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

    #region "IPersonAddressNcesSide Properties"
    /// <summary>
    /// NCES SIDE Date Processed
    /// <para>
    /// The year, month, and day on which the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) was processed through the BlindSIDE resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20943">NCES SIDE Date Processed</a>
    /// </para>
    /// </summary>
    [DisplayName("NCES SIDE Date Processed")]
    public DateTime? NcesSideDateProcessed { get => ncesSideDateProcessed; set => SetProperty(ref ncesSideDateProcessed, value, false); }

    /// <summary>
    /// NCES SIDE Estimate
    /// <para>
    /// The National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) based on the person's latitude and longitude location.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20944">NCES SIDE Estimate</a>
    /// </para>
    /// </summary>
    [DisplayName("NCES SIDE Estimate")]
    public Decimal? NcesSideEstimate { get => ncesSideEstimate; set => SetProperty(ref ncesSideEstimate, value, false); }

    /// <summary>
    /// NCES SIDE Standard Error
    /// <para>
    /// The standard error applied to the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20945">NCES SIDE Standard Error</a>
    /// </para>
    /// </summary>
    [DisplayName("NCES SIDE Standard Error")]
    public Decimal? NcesSideStandardError { get => ncesSideStandardError; set => SetProperty(ref ncesSideStandardError, value, false); }

    /// <summary>
    /// NCES SIDE Vintage Begin Year
    /// <para>
    /// The begin year for the American Community Survey (ACS) period estimates used to construct the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20946">NCES SIDE Vintage Begin Year</a>
    /// </para>
    /// </summary>
    [DisplayName("NCES SIDE Vintage Begin Year")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String NcesSideVintageBeginYear { get => ncesSideVintageBeginYear; set => SetProperty(ref ncesSideVintageBeginYear, value, true); }

    /// <summary>
    /// NCES SIDE Vintage End Year
    /// <para>
    /// The end year for the American Community Survey (ACS) period estimates used to construct the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20947">NCES SIDE Vintage End Year</a>
    /// </para>
    /// </summary>
    [DisplayName("NCES SIDE Vintage End Year")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String NcesSideVintageEndYear { get => ncesSideVintageEndYear; set => SetProperty(ref ncesSideVintageEndYear, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
    /// </summary>
    public Guid PersonAddressId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonAddressNcesSide model)
    {
        IsBusy = true;
        Id = model.Id;
        NcesSideDateProcessed = model.NcesSideDateProcessed; // NCES SIDE Date Processed
        NcesSideEstimate = model.NcesSideEstimate; // NCES SIDE Estimate
        NcesSideStandardError = model.NcesSideStandardError; // NCES SIDE Standard Error
        NcesSideVintageBeginYear = model.NcesSideVintageBeginYear; // NCES SIDE Vintage Begin Year
        NcesSideVintageEndYear = model.NcesSideVintageEndYear; // NCES SIDE Vintage End Year
        PersonAddressId = model.PersonAddressId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
