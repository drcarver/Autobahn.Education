//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsProgramViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsProgram file
/// </summary>
public partial class PsProgramViewModel : ObservableValidator, IPsProgram
{
    #region "PsProgramViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsProgramViewModel Constructor
    /// </summary>
    public PsProgramViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsProgramViewModelConstruction();
    }

    /// <summary>
    /// PsProgramViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsProgramViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsProgram";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // NormalLengthTimeForCompletion -- (backing property for Normal Length of Time for Completion)
    private System.String normalLengthTimeForCompletion;

    // ProgramLengthHours -- (backing property for Program Length Hours)
    private Decimal? programLengthHours;

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

    #region "IPsProgram Properties"
    /// <summary>
    /// Normal Length of Time for Completion
    /// <para>
    /// The amount of time necessary for a person to complete all requirements for a degree or certificate according to the institution's catalog. This is typically 4 years (8 semesters or trimesters, or 12 quarters, excluding summer terms) for a bachelor's degree in a standard term-based institution; 2 years (4 semesters or trimesters, or 6 quarters, excluding summer terms) for an associate's degree in a standard term-based institution; and the various scheduled times for certificate programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19197">Normal Length of Time for Completion</a>
    /// </para>
    /// </summary>
    [DisplayName("Normal Length of Time for Completion")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String NormalLengthTimeForCompletion { get => normalLengthTimeForCompletion; set => SetProperty(ref normalLengthTimeForCompletion, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Program Length Hours
    /// <para>
    /// The normal length in credit/contact hours of a person's program as published in the institution's catalogue, website, or other official documents.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19223">Program Length Hours</a>
    /// </para>
    /// </summary>
    [DisplayName("Program Length Hours")]
    public Decimal? ProgramLengthHours { get => programLengthHours; set => SetProperty(ref programLengthHours, value, false); }

    /// <summary>
    /// Classification of Instructional Program Code
    /// <para>
    /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Classification of Instructional Program Code")]
    public Guid? RefCipCodeId { get; set; }

    /// <summary>
    /// Classification of Instructional Program Version
    /// <para>
    /// The version of CIP being reported.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19045">Classification of Instructional Program Version</a>
    /// </para>
    /// </summary>
    [DisplayName("Classification of Instructional Program Version")]
    public Guid? RefCipVersionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDqpcategoriesOfLearning"/> model
    /// </summary>
    public Guid? RefDqpcategoriesOfLearningId { get; set; }

    /// <summary>
    /// Program Length Hours Type
    /// <para>
    /// The type of hours (credit or contact) by which the normal length of a program of study is measured.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19224">Program Length Hours Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Program Length Hours Type")]
    public Guid? RefProgramLengthHoursTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPsprogramLevel"/> model
    /// </summary>
    public Guid? RefPsprogramLevelId { get; set; }

    /// <summary>
    /// Normal Length of Time for Completion Units
    /// <para>
    /// The unit of measurement for length of time for completion.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19198">Normal Length of Time for Completion Units</a>
    /// </para>
    /// </summary>
    [DisplayName("Normal Length of Time for Completion Units")]
    public Guid? RefTimeForCompletionUnitsId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsProgram model)
    {
        IsBusy = true;
        Id = model.Id;
        NormalLengthTimeForCompletion = model.NormalLengthTimeForCompletion; // Normal Length of Time for Completion
        OrganizationId = model.OrganizationId; // 
        ProgramLengthHours = model.ProgramLengthHours; // Program Length Hours
        RefCipCodeId = model.RefCipCodeId; // Classification of Instructional Program Code
        RefCipVersionId = model.RefCipVersionId; // Classification of Instructional Program Version
        RefDqpcategoriesOfLearningId = model.RefDqpcategoriesOfLearningId; // 
        RefProgramLengthHoursTypeId = model.RefProgramLengthHoursTypeId; // Program Length Hours Type
        RefPsprogramLevelId = model.RefPsprogramLevelId; // 
        RefTimeForCompletionUnitsId = model.RefTimeForCompletionUnitsId; // Normal Length of Time for Completion Units
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
