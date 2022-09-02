//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonBirthplaceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonBirthplace file
/// </summary>
public partial class PersonBirthplaceViewModel : ObservableValidator, IPersonBirthplace
{
    #region "PersonBirthplaceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonBirthplaceViewModel Constructor
    /// </summary>
    public PersonBirthplaceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonBirthplaceViewModelConstruction();
    }

    /// <summary>
    /// PersonBirthplaceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonBirthplaceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonBirthplace";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // City -- (backing property for City of Birth)
    private System.String city;

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

    #region "IPersonBirthplace Properties"
    /// <summary>
    /// City of Birth
    /// <para>
    ///  The name of the city in which a person was born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19416">City of Birth</a>
    /// </para>
    /// </summary>
    [DisplayName("City of Birth")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String City { get => city; set => SetProperty(ref city, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Country of Birth Code
    /// <para>
    /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19051">Country of Birth Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Country of Birth Code")]
    public Guid? RefCountryId { get; set; }

    /// <summary>
    /// State of Birth Abbreviation
    /// <para>
    /// The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a person was born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19417">State of Birth Abbreviation</a>
    /// </para>
    /// </summary>
    [DisplayName("State of Birth Abbreviation")]
    public Guid? RefStateId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonBirthplace model)
    {
        IsBusy = true;
        Id = model.Id;
        City = model.City; // City of Birth
        PersonId = model.PersonId; // 
        RefCountryId = model.RefCountryId; // Country of Birth Code
        RefStateId = model.RefStateId; // State of Birth Abbreviation
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
