//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonEmailAddressViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonEmailAddress file
/// </summary>
public partial class PersonEmailAddressViewModel : ObservableValidator, IPersonEmailAddress
{
    #region "PersonEmailAddressViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonEmailAddressViewModel Constructor
    /// </summary>
    public PersonEmailAddressViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonEmailAddressViewModelConstruction();
    }

    /// <summary>
    /// PersonEmailAddressViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonEmailAddressViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonEmailAddress";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // DoNotPublishIndicator -- (backing property for Do Not Publish Indicator)
    private Boolean? doNotPublishIndicator;

    // EmailAddress -- (backing property for Electronic Mail Address)
    private System.String emailAddress;

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

    #region "IPersonEmailAddress Properties"
    /// <summary>
    /// Do Not Publish Indicator
    /// <para>
    /// An indication that the record should not be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Do Not Publish Indicator")]
    public Boolean? DoNotPublishIndicator { get => doNotPublishIndicator; set => SetProperty(ref doNotPublishIndicator, value, false); }

    /// <summary>
    /// Electronic Mail Address
    /// <para>
    /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19088">Electronic Mail Address</a>
    /// </para>
    /// </summary>
    [DisplayName("Electronic Mail Address")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(128,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EmailAddress { get => emailAddress; set => SetProperty(ref emailAddress, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Electronic Mail Address Type
    /// <para>
    /// The type of electronic mail (e-mail) address listed for a person or organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19089">Electronic Mail Address Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Electronic Mail Address Type")]
    public Guid? RefEmailTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonEmailAddress model)
    {
        IsBusy = true;
        Id = model.Id;
        DoNotPublishIndicator = model.DoNotPublishIndicator; // Do Not Publish Indicator
        EmailAddress = model.EmailAddress; // Electronic Mail Address
        PersonId = model.PersonId; // 
        RefEmailTypeId = model.RefEmailTypeId; // Electronic Mail Address Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
