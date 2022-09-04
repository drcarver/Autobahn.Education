//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProfessionalDevelopmentSessionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentSession file
/// </summary>
public partial class ProfessionalDevelopmentSessionViewModel : ObservableValidator, IProfessionalDevelopmentSession
{
    #region "ProfessionalDevelopmentSessionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProfessionalDevelopmentSessionViewModel Constructor
    /// </summary>
    public ProfessionalDevelopmentSessionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProfessionalDevelopmentSessionViewModelConstruction();
    }

    /// <summary>
    /// ProfessionalDevelopmentSessionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProfessionalDevelopmentSessionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProfessionalDevelopmentSession";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Capacity -- (backing property for Professional Development Session Capacity)
    private Int32? capacity;

    // EndDate -- (backing property for Professional Development Session End Date)
    private DateTime? endDate;

    // EndTime -- (backing property for Professional Development Session End Time)
    private System.String endTime;

    // EvaluationMethod -- (backing property for Professional Development Session Evaluation Method)
    private System.String evaluationMethod;

    // EvaluationScore -- (backing property for Professional Development Session Evaluation Score)
    private System.String evaluationScore;

    // ExpirationDate -- (backing property for Professional Development Activity Expiration Date)
    private DateTime? expirationDate;

    // FundingSource -- (backing property for Professional Development Funding Source)
    private System.String fundingSource;

    // LocationName -- (backing property for Professional Development Session Location Name)
    private System.String locationName;

    // SessionIdentifier -- (backing property for Professional Development Session Identifier)
    private System.String sessionIdentifier;

    // SponsoringAgencyName -- (backing property for Sponsoring Agency Name)
    private System.String sponsoringAgencyName;

    // StartDate -- (backing property for Professional Development Session Start Date)
    private DateTime? startDate;

    // StartTime -- (backing property for Professional Development Session Start Time)
    private System.String startTime;

    // TrainingAndTechnicalAssistanceLevel -- (backing property for Training and Technical Assistance Level)
    private System.String trainingAndTechnicalAssistanceLevel;

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

    #region "IProfessionalDevelopmentSession Properties"
    /// <summary>
    /// Professional Development Session Capacity
    /// <para>
    /// The total number of participants that can be accommodated by a professional development session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20416">Professional Development Session Capacity</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Session Capacity")]
    public Int32? Capacity { get => capacity; set => SetProperty(ref capacity, value, false); }

    /// <summary>
    /// Professional Development Session End Date
    /// <para>
    /// The year, month and day a professional development session ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20417">Professional Development Session End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Session End Date")]
    public DateTime? EndDate { get => endDate; set => SetProperty(ref endDate, value, false); }

    /// <summary>
    /// Professional Development Session End Time
    /// <para>
    /// The time at which a professional development session ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20418">Professional Development Session End Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Session End Time")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(15,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EndTime { get => endTime; set => SetProperty(ref endTime, value, true); }

    /// <summary>
    /// Professional Development Session Evaluation Method
    /// <para>
    /// The method used to evaluate a professional development session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20419">Professional Development Session Evaluation Method</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Session Evaluation Method")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EvaluationMethod { get => evaluationMethod; set => SetProperty(ref evaluationMethod, value, true); }

    /// <summary>
    /// Professional Development Session Evaluation Score
    /// <para>
    /// The score or rating used to determine if a professional development session was successful.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20420">Professional Development Session Evaluation Score</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Session Evaluation Score")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EvaluationScore { get => evaluationScore; set => SetProperty(ref evaluationScore, value, true); }

    /// <summary>
    /// Professional Development Activity Expiration Date
    /// <para>
    /// The year, month, and day on which any certificate awarded as part of a professional development activity expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20421">Professional Development Activity Expiration Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Activity Expiration Date")]
    public DateTime? ExpirationDate { get => expirationDate; set => SetProperty(ref expirationDate, value, false); }

    /// <summary>
    /// Professional Development Funding Source
    /// <para>
    /// The primary source of funding for a professional development session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20413">Professional Development Funding Source</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Funding Source")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FundingSource { get => fundingSource; set => SetProperty(ref fundingSource, value, true); }

    /// <summary>
    /// Professional Development Session Location Name
    /// <para>
    /// The name of a location where a professional development session will be held.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20424">Professional Development Session Location Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Session Location Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LocationName { get => locationName; set => SetProperty(ref locationName, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEltrainerCoreKnowledgeArea"/> model
    /// </summary>
    public Guid? RefEltrainerCoreKnowledgeAreaId { get; set; }

    /// <summary>
    /// Professional Development Session Language
    /// <para>
    /// The language in which the professional development session is delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20357">Professional Development Session Language</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Session Language")]
    public Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPddeliveryMethod"/> model
    /// </summary>
    public Guid? RefPddeliveryMethodId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdinstructionalDeliveryMode"/> model
    /// </summary>
    public Guid? RefPdinstructionalDeliveryModeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdsessionStatus"/> model
    /// </summary>
    public Guid? RefPdsessionStatusId { get; set; }

    /// <summary>
    /// Professional Development Session Identifier
    /// <para>
    /// The unique, non-duplicated,  identification number assigned by the registry data system for a session of a particular professional development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20422">Professional Development Session Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Session Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SessionIdentifier { get => sessionIdentifier; set => SetProperty(ref sessionIdentifier, value, true); }

    /// <summary>
    /// Sponsoring Agency Name
    /// <para>
    /// The name of the sponsoring agency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20461">Sponsoring Agency Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Sponsoring Agency Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SponsoringAgencyName { get => sponsoringAgencyName; set => SetProperty(ref sponsoringAgencyName, value, true); }

    /// <summary>
    /// Professional Development Session Start Date
    /// <para>
    /// The year, month, and day a professional development session begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20426">Professional Development Session Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Session Start Date")]
    public DateTime? StartDate { get => startDate; set => SetProperty(ref startDate, value, false); }

    /// <summary>
    /// Professional Development Session Start Time
    /// <para>
    /// The time at which a professional development session begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20427">Professional Development Session Start Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Session Start Time")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(15,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String StartTime { get => startTime; set => SetProperty(ref startTime, value, true); }

    /// <summary>
    /// Training and Technical Assistance Level
    /// <para>
    /// The level of expertise an individual training and technical assistance specialist has based on a set of established criteria.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20609">Training and Technical Assistance Level</a>
    /// </para>
    /// </summary>
    [DisplayName("Training and Technical Assistance Level")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TrainingAndTechnicalAssistanceLevel { get => trainingAndTechnicalAssistanceLevel; set => SetProperty(ref trainingAndTechnicalAssistanceLevel, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProfessionalDevelopmentSession model)
    {
        IsBusy = true;
        Id = model.Id;
        Capacity = model.Capacity; // Professional Development Session Capacity
        EndDate = model.EndDate; // Professional Development Session End Date
        EndTime = model.EndTime; // Professional Development Session End Time
        EvaluationMethod = model.EvaluationMethod; // Professional Development Session Evaluation Method
        EvaluationScore = model.EvaluationScore; // Professional Development Session Evaluation Score
        ExpirationDate = model.ExpirationDate; // Professional Development Activity Expiration Date
        FundingSource = model.FundingSource; // Professional Development Funding Source
        LocationName = model.LocationName; // Professional Development Session Location Name
        ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId; // 
        RefEltrainerCoreKnowledgeAreaId = model.RefEltrainerCoreKnowledgeAreaId; // 
        RefLanguageId = model.RefLanguageId; // Professional Development Session Language
        RefPddeliveryMethodId = model.RefPddeliveryMethodId; // 
        RefPdinstructionalDeliveryModeId = model.RefPdinstructionalDeliveryModeId; // 
        RefPdsessionStatusId = model.RefPdsessionStatusId; // 
        SessionIdentifier = model.SessionIdentifier; // Professional Development Session Identifier
        SponsoringAgencyName = model.SponsoringAgencyName; // Sponsoring Agency Name
        StartDate = model.StartDate; // Professional Development Session Start Date
        StartTime = model.StartTime; // Professional Development Session Start Time
        TrainingAndTechnicalAssistanceLevel = model.TrainingAndTechnicalAssistanceLevel; // Training and Technical Assistance Level
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
