//***************************************************************************
//* DomainName: Common Models
//* FileName:   CompetencyFrameworkViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyFramework file
/// </summary>
public partial class CompetencyFrameworkViewModel : ObservableValidator, ICompetencyFramework
{
    #region "CompetencyFrameworkViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CompetencyFrameworkViewModel Constructor
    /// </summary>
    public CompetencyFrameworkViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCompetencyFrameworkViewModelConstruction();
    }

    /// <summary>
    /// CompetencyFrameworkViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCompetencyFrameworkViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CompetencyFramework";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CompetencyFrameworkPublicationDate -- (backing property for Competency Framework Publication Date)
    private DateTime? competencyFrameworkPublicationDate;

    // CompetencyFrameworkSourceUrl -- (backing property for Competency Framework Source URL)
    private System.String competencyFrameworkSourceUrl;

    // Creator -- (backing property for Competency Framework Creator)
    private System.String creator;

    // Jurisdiction -- (backing property for Competency Framework Jurisdiction)
    private System.String jurisdiction;

    // License -- (backing property for Competency Framework License)
    private System.String license;

    // Publisher -- (backing property for Competency Framework Publisher)
    private System.String publisher;

    // Rights -- (backing property for Competency Framework Rights)
    private System.String rights;

    // RightsHolder -- (backing property for Competency Framework Rights Holder)
    private System.String rightsHolder;

    // Subject -- (backing property for Competency Framework Subject)
    private System.String subject;

    // Title -- (backing property for Competency Framework Title)
    private System.String title;

    // member variable for the Uri property
    private System.String uri;

    // ValidEndDate -- (backing property for Competency Framework Valid End Date)
    private System.DateTime validEndDate;

    // ValidStartDate -- (backing property for Competency Framework Valid Start Date)
    private System.DateTime validStartDate;

    // Version -- (backing property for Competency Framework Version)
    private System.String version;

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

    #region "ICompetencyFramework Properties"
    /// <summary>
    /// Competency Framework Publication Date
    /// <para>
    /// The date on which this content was first published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20548">Competency Framework Publication Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Publication Date")]
    public DateTime? CompetencyFrameworkPublicationDate { get => competencyFrameworkPublicationDate; set => SetProperty(ref competencyFrameworkPublicationDate, value, false); }

    /// <summary>
    /// Competency Framework Source URL
    /// <para>
    /// A URL that resolves to the original or authoritative competency framework document.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20888">Competency Framework Source URL</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Source URL")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CompetencyFrameworkSourceUrl { get => competencyFrameworkSourceUrl; set => SetProperty(ref competencyFrameworkSourceUrl, value, true); }

    /// <summary>
    /// Competency Framework Creator
    /// <para>
    /// The person or organization chiefly responsible for the intellectual content of the competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19673">Competency Framework Creator</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Creator")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(120,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Creator { get => creator; set => SetProperty(ref creator, value, true); }

    /// <summary>
    /// Competency Framework Jurisdiction
    /// <para>
    /// A legal, quasi-legal, organizational or institutional domain of the entity mandating the use of the statement--e.g., California.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19676">Competency Framework Jurisdiction</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Jurisdiction")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(120,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Jurisdiction { get => jurisdiction; set => SetProperty(ref jurisdiction, value, true); }

    /// <summary>
    /// Competency Framework License
    /// <para>
    /// A legal document giving official permission to do something with the competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19882">Competency Framework License</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework License")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String License { get => license; set => SetProperty(ref license, value, true); }

    /// <summary>
    /// Competency Framework Publisher
    /// <para>
    /// The entity responsible for making the competency framework available.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19884">Competency Framework Publisher</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Publisher")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Publisher { get => publisher; set => SetProperty(ref publisher, value, true); }

    /// <summary>
    /// Competency Framework Publication Status
    /// <para>
    /// The publication status of the competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19675">Competency Framework Publication Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Publication Status")]
    public Guid? RefCompetencyFrameworkPublicationStatusId { get; set; }

    /// <summary>
    /// Competency Framework Language
    /// <para>
    /// The default language of the text used for the content in the competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19880">Competency Framework Language</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Language")]
    public Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Competency Framework Rights
    /// <para>
    /// The information about rights held in and over the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19885">Competency Framework Rights</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Rights")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Rights { get => rights; set => SetProperty(ref rights, value, true); }

    /// <summary>
    /// Competency Framework Rights Holder
    /// <para>
    /// The person or organization owning or managing rights over the competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19886">Competency Framework Rights Holder</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Rights Holder")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RightsHolder { get => rightsHolder; set => SetProperty(ref rightsHolder, value, true); }

    /// <summary>
    /// Competency Framework Subject
    /// <para>
    /// The topic or academic subject of the competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19679">Competency Framework Subject</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Subject")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Subject { get => subject; set => SetProperty(ref subject, value, true); }

    /// <summary>
    /// Competency Framework Title
    /// <para>
    /// The name of the competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19671">Competency Framework Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(120,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get => title; set => SetProperty(ref title, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Uri { get => uri; set => SetProperty(ref uri, value, true); }

    /// <summary>
    /// Competency Framework Valid End Date
    /// <para>
    /// The year, month and day the competency framework was deprecated/replaced by the jurisdiction in which it was intended to apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19678">Competency Framework Valid End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Valid End Date")]
    [Required(ErrorMessage="{0} is required.")]
    public System.DateTime ValidEndDate { get => validEndDate; set => SetProperty(ref validEndDate, value, true); }

    /// <summary>
    /// Competency Framework Valid Start Date
    /// <para>
    /// The year, month and day the competency framework was adopted by the jurisdiction in which it was intended to apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19677">Competency Framework Valid Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Valid Start Date")]
    [Required(ErrorMessage="{0} is required.")]
    public System.DateTime ValidStartDate { get => validStartDate; set => SetProperty(ref validStartDate, value, true); }

    /// <summary>
    /// Competency Framework Version
    /// <para>
    /// Defines the revision of the competency framework as a version number or date.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19672">Competency Framework Version</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Framework Version")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Version { get => version; set => SetProperty(ref version, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICompetencyFramework model)
    {
        IsBusy = true;
        Id = model.Id;
        CompetencyFrameworkPublicationDate = model.CompetencyFrameworkPublicationDate; // Competency Framework Publication Date
        CompetencyFrameworkSourceUrl = model.CompetencyFrameworkSourceUrl; // Competency Framework Source URL
        Creator = model.Creator; // Competency Framework Creator
        Jurisdiction = model.Jurisdiction; // Competency Framework Jurisdiction
        License = model.License; // Competency Framework License
        Publisher = model.Publisher; // Competency Framework Publisher
        RefCompetencyFrameworkPublicationStatusId = model.RefCompetencyFrameworkPublicationStatusId; // Competency Framework Publication Status
        RefLanguageId = model.RefLanguageId; // Competency Framework Language
        Rights = model.Rights; // Competency Framework Rights
        RightsHolder = model.RightsHolder; // Competency Framework Rights Holder
        Subject = model.Subject; // Competency Framework Subject
        Title = model.Title; // Competency Framework Title
        Uri = model.Uri; // 
        ValidEndDate = model.ValidEndDate; // Competency Framework Valid End Date
        ValidStartDate = model.ValidStartDate; // Competency Framework Valid Start Date
        Version = model.Version; // Competency Framework Version
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
