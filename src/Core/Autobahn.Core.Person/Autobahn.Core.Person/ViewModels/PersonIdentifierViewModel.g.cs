//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonIdentifierViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonIdentifier file
/// </summary>
public partial class PersonIdentifierViewModel : ObservableValidator, IPersonIdentifier
{
    #region "PersonIdentifierViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonIdentifierViewModel Constructor
    /// </summary>
    public PersonIdentifierViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonIdentifierViewModelConstruction();
    }

    /// <summary>
    /// PersonIdentifierViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonIdentifierViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonIdentifier";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Identifier -- (backing property for Staff Member Identifier)
    private System.String identifier;

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

    #region "IPersonIdentifier Properties"
    /// <summary>
    /// Staff Member Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19156">Staff Member Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Member Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Personal Information Verification
    /// <para>
    /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
    /// </para>
    /// </summary>
    [DisplayName("Personal Information Verification")]
    public Guid? RefPersonalInformationVerificationId { get; set; }

    /// <summary>
    /// Staff Member Identification System
    /// <para>
    /// A coding scheme that is used for identification and record-keeping purposes by schools, social services, registry, or other agencies to refer to a staff member.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19162">Staff Member Identification System</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Member Identification System")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefPersonIdentificationSystemId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonIdentifier model)
    {
        IsBusy = true;
        Id = model.Id;
        Identifier = model.Identifier; // Staff Member Identifier
        PersonId = model.PersonId; // 
        RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId; // Personal Information Verification
        RefPersonIdentificationSystemId = model.RefPersonIdentificationSystemId; // Staff Member Identification System
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
