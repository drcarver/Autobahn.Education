//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonDetailViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDetail file
/// </summary>
public partial class PersonDetailViewModel : ObservableValidator, IPersonDetail
{
    #region "PersonDetailViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonDetailViewModel Constructor
    /// </summary>
    public PersonDetailViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonDetailViewModelConstruction();
    }

    /// <summary>
    /// PersonDetailViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonDetailViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonDetail";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Birthdate -- (backing property for Birthdate)
    private DateTime? birthdate;

    // BirthdateVerification -- (backing property for Birthdate Verification)
    private System.String birthdateVerification;

    // FirstName -- (backing property for First Name)
    private System.String firstName;

    // GenerationCode -- (backing property for Generation Code or Suffix)
    private System.String generationCode;

    // HispanicLatinoEthnicity -- (backing property for Hispanic or Latino Ethnicity)
    private Boolean? hispanicLatinoEthnicity;

    // LastName -- (backing property for Last or Surname)
    private System.String lastName;

    // MiddleName -- (backing property for Middle Name)
    private System.String middleName;

    // Prefix -- (backing property for Personal Title or Prefix)
    private System.String prefix;

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

    #region "IPersonDetail Properties"
    /// <summary>
    /// Birthdate
    /// <para>
    /// The year, month and day on which a person was born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19033">Birthdate</a>
    /// </para>
    /// </summary>
    [DisplayName("Birthdate")]
    public DateTime? Birthdate { get => birthdate; set => SetProperty(ref birthdate, value, false); }

    /// <summary>
    /// Birthdate Verification
    /// <para>
    /// The evidence by which a child's date of birth is confirmed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19418">Birthdate Verification</a>
    /// </para>
    /// </summary>
    [DisplayName("Birthdate Verification")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BirthdateVerification { get => birthdateVerification; set => SetProperty(ref birthdateVerification, value, true); }

    /// <summary>
    /// First Name
    /// <para>
    /// The full legal first name given to a person at birth, baptism, or through legal change.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19115">First Name</a>
    /// </para>
    /// </summary>
    [DisplayName("First Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(75,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FirstName { get => firstName; set => SetProperty(ref firstName, value, true); }

    /// <summary>
    /// Generation Code or Suffix
    /// <para>
    /// An appendage, if any, used to denote a person's generation in his family (e.g., Jr., Sr., III).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19121">Generation Code or Suffix</a>
    /// </para>
    /// </summary>
    [DisplayName("Generation Code or Suffix")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(10,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GenerationCode { get => generationCode; set => SetProperty(ref generationCode, value, true); }

    /// <summary>
    /// Hispanic or Latino Ethnicity
    /// <para>
    /// An indication that the person traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central and South America, and other Spanish cultures, regardless of race.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19144">Hispanic or Latino Ethnicity</a>
    /// </para>
    /// </summary>
    [DisplayName("Hispanic or Latino Ethnicity")]
    public Boolean? HispanicLatinoEthnicity { get => hispanicLatinoEthnicity; set => SetProperty(ref hispanicLatinoEthnicity, value, false); }

    /// <summary>
    /// Last or Surname
    /// <para>
    /// The full legal last name borne in common by members of a family.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19172">Last or Surname</a>
    /// </para>
    /// </summary>
    [DisplayName("Last or Surname")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(75,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LastName { get => lastName; set => SetProperty(ref lastName, value, true); }

    /// <summary>
    /// Middle Name
    /// <para>
    /// A full legal middle name given to a person at birth, baptism, or through legal change.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19184">Middle Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Middle Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(75,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MiddleName { get => middleName; set => SetProperty(ref middleName, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Personal Title or Prefix
    /// <para>
    /// An appellation, if any, used to denote rank, placement, or status (e.g., Mr., Ms., Reverend, Sister, Dr., Colonel).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19212">Personal Title or Prefix</a>
    /// </para>
    /// </summary>
    [DisplayName("Personal Title or Prefix")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Prefix { get => prefix; set => SetProperty(ref prefix, value, true); }

    /// <summary>
    /// Highest Level of Education Completed
    /// <para>
    /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19141">Highest Level of Education Completed</a>
    /// </para>
    /// </summary>
    [DisplayName("Highest Level of Education Completed")]
    public Guid? RefHighestEducationLevelCompletedId { get; set; }

    /// <summary>
    /// Proof of Residency Type
    /// <para>
    /// An accepted form of proof of residency in the district/county/other locality.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19305">Proof of Residency Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Proof of Residency Type")]
    public Guid? RefProofOfResidencyTypeId { get; set; }

    /// <summary>
    /// Sex
    /// <para>
    /// The concept describing the biological traits that distinguish the males and females of a species.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19255">Sex</a>
    /// </para>
    /// </summary>
    [DisplayName("Sex")]
    public Guid? RefSexId { get; set; }

    /// <summary>
    /// State of Residence
    /// <para>
    /// An person's permanent address as determined by such evidence as a driver's license or voter registration. For entering freshmen, state of residence may be the legal state of residence of a parent or guardian.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19268">State of Residence</a>
    /// </para>
    /// </summary>
    [DisplayName("State of Residence")]
    public Guid? RefStateOfResidenceId { get; set; }

    /// <summary>
    /// Tribal Affiliation
    /// <para>
    /// The Native American tribal entity recognized and eligible to receive services from the United States Bureau of Indian Affairs to which a person is affiliated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20638">Tribal Affiliation</a>
    /// </para>
    /// </summary>
    [DisplayName("Tribal Affiliation")]
    public Guid? RefTribalAffiliationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefUscitizenshipStatus"/> model
    /// </summary>
    public Guid? RefUscitizenshipStatusId { get; set; }

    /// <summary>
    /// Visa Type
    /// <para>
    /// An indicator of a non-US citizen's Visa type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19196">Visa Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Visa Type")]
    public Guid? RefVisaTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonDetail model)
    {
        IsBusy = true;
        Id = model.Id;
        Birthdate = model.Birthdate; // Birthdate
        BirthdateVerification = model.BirthdateVerification; // Birthdate Verification
        FirstName = model.FirstName; // First Name
        GenerationCode = model.GenerationCode; // Generation Code or Suffix
        HispanicLatinoEthnicity = model.HispanicLatinoEthnicity; // Hispanic or Latino Ethnicity
        LastName = model.LastName; // Last or Surname
        MiddleName = model.MiddleName; // Middle Name
        PersonId = model.PersonId; // 
        Prefix = model.Prefix; // Personal Title or Prefix
        RefHighestEducationLevelCompletedId = model.RefHighestEducationLevelCompletedId; // Highest Level of Education Completed
        RefProofOfResidencyTypeId = model.RefProofOfResidencyTypeId; // Proof of Residency Type
        RefSexId = model.RefSexId; // Sex
        RefStateOfResidenceId = model.RefStateOfResidenceId; // State of Residence
        RefTribalAffiliationId = model.RefTribalAffiliationId; // Tribal Affiliation
        RefUscitizenshipStatusId = model.RefUscitizenshipStatusId; // 
        RefVisaTypeId = model.RefVisaTypeId; // Visa Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
