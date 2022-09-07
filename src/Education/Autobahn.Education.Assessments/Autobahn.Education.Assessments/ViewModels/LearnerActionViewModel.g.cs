//***************************************************************************
//* DomainName: Assessments
//* FileName:   LearnerActionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ILearnerAction file
/// </summary>
public partial class LearnerActionViewModel : ObservableValidator, ILearnerAction
{
    #region "LearnerActionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// LearnerActionViewModel Constructor
    /// </summary>
    public LearnerActionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnLearnerActionViewModelConstruction();
    }

    /// <summary>
    /// LearnerActionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnLearnerActionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from LearnerAction";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // LearnerActionActorIdentifier -- (backing property for Learner Action Actor Identifier)
    private System.String learnerActionActorIdentifier;

    // LearnerActionDateTime -- (backing property for Learner Action Date Time)
    private DateTime? learnerActionDateTime;

    // LearnerActionObjectDescription -- (backing property for Learner Action Object Description)
    private System.String learnerActionObjectDescription;

    // LearnerActionObjectIdentifier -- (backing property for Learner Action Object Identifier)
    private System.String learnerActionObjectIdentifier;

    // LearnerActionObjectType -- (backing property for Learner Action Object Type)
    private System.String learnerActionObjectType;

    // Value -- (backing property for Learner Action Value)
    private System.String value;

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

    #region "ILearnerAction Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> model
    /// </summary>
    public Guid? AssessmentItemResponseId { get; set; }

    /// <summary>
    /// Learner Action Actor Identifier
    /// <para>
    ///  A unique identifier for the person performing the learner action.  The identifier should be encrypted when integrating learning experience data across systems to secure the privacy of the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20533">Learner Action Actor Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Action Actor Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearnerActionActorIdentifier { get => learnerActionActorIdentifier; set => SetProperty(ref learnerActionActorIdentifier, value, true); }

    /// <summary>
    /// Learner Action Date Time
    /// <para>
    /// The date and time at which the action was taken.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19938">Learner Action Date Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Action Date Time")]
    public DateTime? LearnerActionDateTime { get => learnerActionDateTime; set => SetProperty(ref learnerActionDateTime, value, false); }

    /// <summary>
    /// Learner Action Object Description
    /// <para>
    /// A description of the object upon which the person has performed the Learner Action.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20534">Learner Action Object Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Action Object Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearnerActionObjectDescription { get => learnerActionObjectDescription; set => SetProperty(ref learnerActionObjectDescription, value, true); }

    /// <summary>
    /// Learner Action Object Identifier
    /// <para>
    /// A globally unique identifier for the object upon which the learning has performed the Learner Action which may be a URL with information about a learning resource or to launch the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20535">Learner Action Object Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Action Object Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearnerActionObjectIdentifier { get => learnerActionObjectIdentifier; set => SetProperty(ref learnerActionObjectIdentifier, value, true); }

    /// <summary>
    /// Learner Action Object Type
    /// <para>
    /// The type of object upon which a person has performed the Learner Action.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20536">Learner Action Object Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Action Object Type")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearnerActionObjectType { get => learnerActionObjectType; set => SetProperty(ref learnerActionObjectType, value, true); }

    /// <summary>
    /// Learner Action Type
    /// <para>
    /// The type of action taken by the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19935">Learner Action Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Action Type")]
    public Guid? RefLearnerActionTypeId { get; set; }

    /// <summary>
    /// Learner Action Value
    /// <para>
    /// The value representing input by the learner using an online system, such as a value entered in response to an assessment question, or the URL of a learning resource link clicked.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19936">Learner Action Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Action Value")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Value { get => value; set => SetProperty(ref value, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ILearnerAction model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentItemResponseId = model.AssessmentItemResponseId; // 
        LearnerActionActorIdentifier = model.LearnerActionActorIdentifier; // Learner Action Actor Identifier
        LearnerActionDateTime = model.LearnerActionDateTime; // Learner Action Date Time
        LearnerActionObjectDescription = model.LearnerActionObjectDescription; // Learner Action Object Description
        LearnerActionObjectIdentifier = model.LearnerActionObjectIdentifier; // Learner Action Object Identifier
        LearnerActionObjectType = model.LearnerActionObjectType; // Learner Action Object Type
        RefLearnerActionTypeId = model.RefLearnerActionTypeId; // Learner Action Type
        Value = model.Value; // Learner Action Value
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
