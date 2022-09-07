//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonLanguageViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonLanguage file
/// </summary>
public partial class PersonLanguageViewModel : ObservableValidator, IPersonLanguage
{
    #region "PersonLanguageViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonLanguageViewModel Constructor
    /// </summary>
    public PersonLanguageViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonLanguageViewModelConstruction();
    }

    /// <summary>
    /// PersonLanguageViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonLanguageViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonLanguage";

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

    #region "IPersonLanguage Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// ISO 639-2 Language Code
    /// <para>
    /// The code for the specific language or dialect that a person uses to communicate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19317">ISO 639-2 Language Code</a>
    /// </para>
    /// </summary>
    [DisplayName("ISO 639-2 Language Code")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefLanguageId { get; set; }

    /// <summary>
    /// Language Type
    /// <para>
    /// An indication of the function and context in which a person uses a language to communicate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19316">Language Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Language Type")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefLanguageUseTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonLanguage model)
    {
        IsBusy = true;
        Id = model.Id;
        PersonId = model.PersonId; // 
        RefLanguageId = model.RefLanguageId; // ISO 639-2 Language Code
        RefLanguageUseTypeId = model.RefLanguageUseTypeId; // Language Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
