//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedLanguageLearnerViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedLanguageLearner file
/// </summary>
public partial class AssessmentPersonalNeedLanguageLearnerViewModel : ObservableValidator, IAssessmentPersonalNeedLanguageLearner
{
    #region "AssessmentPersonalNeedLanguageLearnerViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentPersonalNeedLanguageLearnerViewModel Constructor
    /// </summary>
    public AssessmentPersonalNeedLanguageLearnerViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentPersonalNeedLanguageLearnerViewModelConstruction();
    }

    /// <summary>
    /// AssessmentPersonalNeedLanguageLearnerViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentPersonalNeedLanguageLearnerViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentPersonalNeedLanguageLearner";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ActivateByDefault -- (backing property for Assessment Personal Needs Profile Activate by Default)
    private Boolean? activateByDefault;

    // AssignedSupport -- (backing property for Assessment Personal Needs Profile Assigned Support)
    private Boolean? assignedSupport;

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

    #region "IAssessmentPersonalNeedLanguageLearner Properties"
    /// <summary>
    /// Assessment Personal Needs Profile Activate by Default
    /// <para>
    /// Determines if the alternative accessible content is rendered as the default content for the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20008">Assessment Personal Needs Profile Activate by Default</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Personal Needs Profile Activate by Default")]
    public Boolean? ActivateByDefault { get => activateByDefault; set => SetProperty(ref activateByDefault, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentNeedsProfileContent"/> model
    /// </summary>
    public Guid AssessmentNeedsProfileContentId { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Assigned Support
    /// <para>
    /// Defines whether or not the individual needs the kind of support defined by the entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Personal Needs Profile Assigned Support")]
    public Boolean? AssignedSupport { get => assignedSupport; set => SetProperty(ref assignedSupport, value, false); }

    /// <summary>
    /// Assessment Need Language Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile a preference for the language of the user interface.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20025">Assessment Need Language Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Language Type")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentPersonalNeedLanguageLearner model)
    {
        IsBusy = true;
        Id = model.Id;
        ActivateByDefault = model.ActivateByDefault; // Assessment Personal Needs Profile Activate by Default
        AssessmentNeedsProfileContentId = model.AssessmentNeedsProfileContentId; // 
        AssignedSupport = model.AssignedSupport; // Assessment Personal Needs Profile Assigned Support
        RefAssessmentNeedsProfileContentLanguageLearnerTypeId = model.RefAssessmentNeedsProfileContentLanguageLearnerTypeId; // Assessment Need Language Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
