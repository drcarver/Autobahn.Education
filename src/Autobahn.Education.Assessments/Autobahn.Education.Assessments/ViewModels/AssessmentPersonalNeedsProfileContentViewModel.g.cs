//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileContentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileContent file
/// </summary>
public partial class AssessmentPersonalNeedsProfileContentViewModel : ObservableValidator, IAssessmentPersonalNeedsProfileContent
{
    #region "AssessmentPersonalNeedsProfileContentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentPersonalNeedsProfileContentViewModel Constructor
    /// </summary>
    public AssessmentPersonalNeedsProfileContentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentPersonalNeedsProfileContentViewModelConstruction();
    }

    /// <summary>
    /// AssessmentPersonalNeedsProfileContentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentPersonalNeedsProfileContentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentPersonalNeedsProfileContent";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ChunkingActivateByDefaultIndicator property
    private Boolean? chunkingActivateByDefaultIndicator;

    // member variable for the ChunkingAssignedSupportIndicator property
    private Boolean? chunkingAssignedSupportIndicator;

    // member variable for the CognitiveGuidanceActivateByDefaultIndicator property
    private Boolean? cognitiveGuidanceActivateByDefaultIndicator;

    // member variable for the CognitiveGuidanceAssignedSupportIndicator property
    private Boolean? cognitiveGuidanceAssignedSupportIndicator;

    // member variable for the KeywordEmphasisActivateByDefaultIndicator property
    private Boolean? keywordEmphasisActivateByDefaultIndicator;

    // member variable for the KeywordEmphasisAssignedSupportIndicator property
    private Boolean? keywordEmphasisAssignedSupportIndicator;

    // member variable for the KeywordTranslationsActivateByDefaultIndicator property
    private Boolean? keywordTranslationsActivateByDefaultIndicator;

    // member variable for the KeywordTranslationsAssignedSupportIndicator property
    private Boolean? keywordTranslationsAssignedSupportIndicator;

    // member variable for the NegativesRemovedActivateByDefaultIndicator property
    private Boolean? negativesRemovedActivateByDefaultIndicator;

    // member variable for the NegativesRemovedAssignedSupportIndicator property
    private Boolean? negativesRemovedAssignedSupportIndicator;

    // member variable for the ReducedAnswersActivateByDefaultIndicator property
    private Boolean? reducedAnswersActivateByDefaultIndicator;

    // member variable for the ReducedAnswersAssignedSupportIndicator property
    private Boolean? reducedAnswersAssignedSupportIndicator;

    // member variable for the ScaffoldingActivateByDefaultIndicator property
    private Boolean? scaffoldingActivateByDefaultIndicator;

    // member variable for the ScaffoldingAssignedSupportIndicator property
    private Boolean? scaffoldingAssignedSupportIndicator;

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

    #region "IAssessmentPersonalNeedsProfileContent Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileId { get; set; }

    public Boolean? ChunkingActivateByDefaultIndicator { get => chunkingActivateByDefaultIndicator; set => SetProperty(ref chunkingActivateByDefaultIndicator, value, false); }

    public Boolean? ChunkingAssignedSupportIndicator { get => chunkingAssignedSupportIndicator; set => SetProperty(ref chunkingAssignedSupportIndicator, value, false); }

    public Boolean? CognitiveGuidanceActivateByDefaultIndicator { get => cognitiveGuidanceActivateByDefaultIndicator; set => SetProperty(ref cognitiveGuidanceActivateByDefaultIndicator, value, false); }

    public Boolean? CognitiveGuidanceAssignedSupportIndicator { get => cognitiveGuidanceAssignedSupportIndicator; set => SetProperty(ref cognitiveGuidanceAssignedSupportIndicator, value, false); }

    public Boolean? KeywordEmphasisActivateByDefaultIndicator { get => keywordEmphasisActivateByDefaultIndicator; set => SetProperty(ref keywordEmphasisActivateByDefaultIndicator, value, false); }

    public Boolean? KeywordEmphasisAssignedSupportIndicator { get => keywordEmphasisAssignedSupportIndicator; set => SetProperty(ref keywordEmphasisAssignedSupportIndicator, value, false); }

    public Boolean? KeywordTranslationsActivateByDefaultIndicator { get => keywordTranslationsActivateByDefaultIndicator; set => SetProperty(ref keywordTranslationsActivateByDefaultIndicator, value, false); }

    public Boolean? KeywordTranslationsAssignedSupportIndicator { get => keywordTranslationsAssignedSupportIndicator; set => SetProperty(ref keywordTranslationsAssignedSupportIndicator, value, false); }

    public Boolean? NegativesRemovedActivateByDefaultIndicator { get => negativesRemovedActivateByDefaultIndicator; set => SetProperty(ref negativesRemovedActivateByDefaultIndicator, value, false); }

    public Boolean? NegativesRemovedAssignedSupportIndicator { get => negativesRemovedAssignedSupportIndicator; set => SetProperty(ref negativesRemovedAssignedSupportIndicator, value, false); }

    public Boolean? ReducedAnswersActivateByDefaultIndicator { get => reducedAnswersActivateByDefaultIndicator; set => SetProperty(ref reducedAnswersActivateByDefaultIndicator, value, false); }

    public Boolean? ReducedAnswersAssignedSupportIndicator { get => reducedAnswersAssignedSupportIndicator; set => SetProperty(ref reducedAnswersAssignedSupportIndicator, value, false); }

    /// <summary>
    /// Assessment Need Hazard Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20026">Assessment Need Hazard Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Hazard Type")]
    public Guid? RefAssessmentNeedHazardTypeId { get; set; }

    /// <summary>
    /// Assessment Need Support Tool Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the electronic tool associated with a resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20027">Assessment Need Support Tool Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Support Tool Type")]
    public Guid? RefAssessmentNeedSupportToolId { get; set; }

    /// <summary>
    /// Assessment Need Keyword Translation Language Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the default language for the keyword translation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20043">Assessment Need Keyword Translation Language Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Keyword Translation Language Type")]
    public Guid? RefKeywordTranslationsLanguageId { get; set; }

    public Boolean? ScaffoldingActivateByDefaultIndicator { get => scaffoldingActivateByDefaultIndicator; set => SetProperty(ref scaffoldingActivateByDefaultIndicator, value, false); }

    public Boolean? ScaffoldingAssignedSupportIndicator { get => scaffoldingAssignedSupportIndicator; set => SetProperty(ref scaffoldingAssignedSupportIndicator, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentPersonalNeedsProfileContent model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentPersonalNeedsProfileId = model.AssessmentPersonalNeedsProfileId; // 
        ChunkingActivateByDefaultIndicator = model.ChunkingActivateByDefaultIndicator; // 
        ChunkingAssignedSupportIndicator = model.ChunkingAssignedSupportIndicator; // 
        CognitiveGuidanceActivateByDefaultIndicator = model.CognitiveGuidanceActivateByDefaultIndicator; // 
        CognitiveGuidanceAssignedSupportIndicator = model.CognitiveGuidanceAssignedSupportIndicator; // 
        KeywordEmphasisActivateByDefaultIndicator = model.KeywordEmphasisActivateByDefaultIndicator; // 
        KeywordEmphasisAssignedSupportIndicator = model.KeywordEmphasisAssignedSupportIndicator; // 
        KeywordTranslationsActivateByDefaultIndicator = model.KeywordTranslationsActivateByDefaultIndicator; // 
        KeywordTranslationsAssignedSupportIndicator = model.KeywordTranslationsAssignedSupportIndicator; // 
        NegativesRemovedActivateByDefaultIndicator = model.NegativesRemovedActivateByDefaultIndicator; // 
        NegativesRemovedAssignedSupportIndicator = model.NegativesRemovedAssignedSupportIndicator; // 
        ReducedAnswersActivateByDefaultIndicator = model.ReducedAnswersActivateByDefaultIndicator; // 
        ReducedAnswersAssignedSupportIndicator = model.ReducedAnswersAssignedSupportIndicator; // 
        RefAssessmentNeedHazardTypeId = model.RefAssessmentNeedHazardTypeId; // Assessment Need Hazard Type
        RefAssessmentNeedSupportToolId = model.RefAssessmentNeedSupportToolId; // Assessment Need Support Tool Type
        RefKeywordTranslationsLanguageId = model.RefKeywordTranslationsLanguageId; // Assessment Need Keyword Translation Language Type
        ScaffoldingActivateByDefaultIndicator = model.ScaffoldingActivateByDefaultIndicator; // 
        ScaffoldingAssignedSupportIndicator = model.ScaffoldingAssignedSupportIndicator; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
