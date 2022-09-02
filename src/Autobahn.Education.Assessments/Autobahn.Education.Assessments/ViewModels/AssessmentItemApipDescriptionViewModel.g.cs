//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemApipDescriptionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemApipDescription file
/// </summary>
public partial class AssessmentItemApipDescriptionViewModel : ObservableValidator, IAssessmentItemApipDescription
{
    #region "AssessmentItemApipDescriptionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentItemApipDescriptionViewModel Constructor
    /// </summary>
    public AssessmentItemApipDescriptionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentItemApipDescriptionViewModelConstruction();
    }

    /// <summary>
    /// AssessmentItemApipDescriptionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentItemApipDescriptionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentItemApipDescription";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the AslIndicator property
    private Boolean? aslIndicator;

    // member variable for the AslOnDemandIndicator property
    private Boolean? aslOnDemandIndicator;

    // member variable for the BrailleIndicator property
    private Boolean? brailleIndicator;

    // member variable for the ChunkingActivateByDefaultIndicator property
    private Boolean? chunkingActivateByDefaultIndicator;

    // member variable for the ChunkingAssignedSupportIndicator property
    private Boolean? chunkingAssignedSupportIndicator;

    // member variable for the CognitiveGuidanceActivateByDefaultIndicator property
    private Boolean? cognitiveGuidanceActivateByDefaultIndicator;

    // member variable for the CognitiveGuidanceAssignedSupportIndicator property
    private Boolean? cognitiveGuidanceAssignedSupportIndicator;

    // member variable for the GraphicsOnlyIndicator property
    private Boolean? graphicsOnlyIndicator;

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

    // member variable for the NonVisualIndicator property
    private Boolean? nonVisualIndicator;

    // member variable for the ReducedAnswersActivateByDefaultIndicator property
    private Boolean? reducedAnswersActivateByDefaultIndicator;

    // member variable for the ReducedAnswersAssignedSupportIndicator property
    private Boolean? reducedAnswersAssignedSupportIndicator;

    // member variable for the ScaffoldingActivateByDefaultIndicator property
    private Boolean? scaffoldingActivateByDefaultIndicator;

    // member variable for the ScaffoldingAssignedSupportIndicator property
    private Boolean? scaffoldingAssignedSupportIndicator;

    // member variable for the SignedEnglishIndicator property
    private Boolean? signedEnglishIndicator;

    // member variable for the SignedEnglishOnDemandIndicator property
    private Boolean? signedEnglishOnDemandIndicator;

    // member variable for the TextGraphicsIndicator property
    private Boolean? textGraphicsIndicator;

    // member variable for the TextOnlyIndicator property
    private Boolean? textOnlyIndicator;

    // member variable for the TextOnlyOnDemandIndicator property
    private Boolean? textOnlyOnDemandIndicator;

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

    #region "IAssessmentItemApipDescription Properties"
    public Boolean? AslIndicator { get => aslIndicator; set => SetProperty(ref aslIndicator, value, false); }

    public Boolean? AslOnDemandIndicator { get => aslOnDemandIndicator; set => SetProperty(ref aslOnDemandIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemApip"/> model
    /// </summary>
    public Guid AssessmentItemApipId { get; set; }

    public Boolean? BrailleIndicator { get => brailleIndicator; set => SetProperty(ref brailleIndicator, value, false); }

    public Boolean? ChunkingActivateByDefaultIndicator { get => chunkingActivateByDefaultIndicator; set => SetProperty(ref chunkingActivateByDefaultIndicator, value, false); }

    public Boolean? ChunkingAssignedSupportIndicator { get => chunkingAssignedSupportIndicator; set => SetProperty(ref chunkingAssignedSupportIndicator, value, false); }

    public Boolean? CognitiveGuidanceActivateByDefaultIndicator { get => cognitiveGuidanceActivateByDefaultIndicator; set => SetProperty(ref cognitiveGuidanceActivateByDefaultIndicator, value, false); }

    public Boolean? CognitiveGuidanceAssignedSupportIndicator { get => cognitiveGuidanceAssignedSupportIndicator; set => SetProperty(ref cognitiveGuidanceAssignedSupportIndicator, value, false); }

    public Boolean? GraphicsOnlyIndicator { get => graphicsOnlyIndicator; set => SetProperty(ref graphicsOnlyIndicator, value, false); }

    public Boolean? KeywordEmphasisActivateByDefaultIndicator { get => keywordEmphasisActivateByDefaultIndicator; set => SetProperty(ref keywordEmphasisActivateByDefaultIndicator, value, false); }

    public Boolean? KeywordEmphasisAssignedSupportIndicator { get => keywordEmphasisAssignedSupportIndicator; set => SetProperty(ref keywordEmphasisAssignedSupportIndicator, value, false); }

    public Boolean? KeywordTranslationsActivateByDefaultIndicator { get => keywordTranslationsActivateByDefaultIndicator; set => SetProperty(ref keywordTranslationsActivateByDefaultIndicator, value, false); }

    public Boolean? KeywordTranslationsAssignedSupportIndicator { get => keywordTranslationsAssignedSupportIndicator; set => SetProperty(ref keywordTranslationsAssignedSupportIndicator, value, false); }

    public Boolean? NegativesRemovedActivateByDefaultIndicator { get => negativesRemovedActivateByDefaultIndicator; set => SetProperty(ref negativesRemovedActivateByDefaultIndicator, value, false); }

    public Boolean? NegativesRemovedAssignedSupportIndicator { get => negativesRemovedAssignedSupportIndicator; set => SetProperty(ref negativesRemovedAssignedSupportIndicator, value, false); }

    public Boolean? NonVisualIndicator { get => nonVisualIndicator; set => SetProperty(ref nonVisualIndicator, value, false); }

    public Boolean? ReducedAnswersActivateByDefaultIndicator { get => reducedAnswersActivateByDefaultIndicator; set => SetProperty(ref reducedAnswersActivateByDefaultIndicator, value, false); }

    public Boolean? ReducedAnswersAssignedSupportIndicator { get => reducedAnswersAssignedSupportIndicator; set => SetProperty(ref reducedAnswersAssignedSupportIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefHazardType"/> model
    /// </summary>
    public Guid? RefHazardTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefKeywordTranslationLanguage"/> model
    /// </summary>
    public Guid? RefKeywordTranslationLanguageId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSupportToolType"/> model
    /// </summary>
    public Guid? RefSupportToolTypeId { get; set; }

    public Boolean? ScaffoldingActivateByDefaultIndicator { get => scaffoldingActivateByDefaultIndicator; set => SetProperty(ref scaffoldingActivateByDefaultIndicator, value, false); }

    public Boolean? ScaffoldingAssignedSupportIndicator { get => scaffoldingAssignedSupportIndicator; set => SetProperty(ref scaffoldingAssignedSupportIndicator, value, false); }

    public Boolean? SignedEnglishIndicator { get => signedEnglishIndicator; set => SetProperty(ref signedEnglishIndicator, value, false); }

    public Boolean? SignedEnglishOnDemandIndicator { get => signedEnglishOnDemandIndicator; set => SetProperty(ref signedEnglishOnDemandIndicator, value, false); }

    public Boolean? TextGraphicsIndicator { get => textGraphicsIndicator; set => SetProperty(ref textGraphicsIndicator, value, false); }

    public Boolean? TextOnlyIndicator { get => textOnlyIndicator; set => SetProperty(ref textOnlyIndicator, value, false); }

    public Boolean? TextOnlyOnDemandIndicator { get => textOnlyOnDemandIndicator; set => SetProperty(ref textOnlyOnDemandIndicator, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentItemApipDescription model)
    {
        IsBusy = true;
        Id = model.Id;
        AslIndicator = model.AslIndicator; // 
        AslOnDemandIndicator = model.AslOnDemandIndicator; // 
        AssessmentItemApipId = model.AssessmentItemApipId; // 
        BrailleIndicator = model.BrailleIndicator; // 
        ChunkingActivateByDefaultIndicator = model.ChunkingActivateByDefaultIndicator; // 
        ChunkingAssignedSupportIndicator = model.ChunkingAssignedSupportIndicator; // 
        CognitiveGuidanceActivateByDefaultIndicator = model.CognitiveGuidanceActivateByDefaultIndicator; // 
        CognitiveGuidanceAssignedSupportIndicator = model.CognitiveGuidanceAssignedSupportIndicator; // 
        GraphicsOnlyIndicator = model.GraphicsOnlyIndicator; // 
        KeywordEmphasisActivateByDefaultIndicator = model.KeywordEmphasisActivateByDefaultIndicator; // 
        KeywordEmphasisAssignedSupportIndicator = model.KeywordEmphasisAssignedSupportIndicator; // 
        KeywordTranslationsActivateByDefaultIndicator = model.KeywordTranslationsActivateByDefaultIndicator; // 
        KeywordTranslationsAssignedSupportIndicator = model.KeywordTranslationsAssignedSupportIndicator; // 
        NegativesRemovedActivateByDefaultIndicator = model.NegativesRemovedActivateByDefaultIndicator; // 
        NegativesRemovedAssignedSupportIndicator = model.NegativesRemovedAssignedSupportIndicator; // 
        NonVisualIndicator = model.NonVisualIndicator; // 
        ReducedAnswersActivateByDefaultIndicator = model.ReducedAnswersActivateByDefaultIndicator; // 
        ReducedAnswersAssignedSupportIndicator = model.ReducedAnswersAssignedSupportIndicator; // 
        RefHazardTypeId = model.RefHazardTypeId; // 
        RefKeywordTranslationLanguageId = model.RefKeywordTranslationLanguageId; // 
        RefSupportToolTypeId = model.RefSupportToolTypeId; // 
        ScaffoldingActivateByDefaultIndicator = model.ScaffoldingActivateByDefaultIndicator; // 
        ScaffoldingAssignedSupportIndicator = model.ScaffoldingAssignedSupportIndicator; // 
        SignedEnglishIndicator = model.SignedEnglishIndicator; // 
        SignedEnglishOnDemandIndicator = model.SignedEnglishOnDemandIndicator; // 
        TextGraphicsIndicator = model.TextGraphicsIndicator; // 
        TextOnlyIndicator = model.TextOnlyIndicator; // 
        TextOnlyOnDemandIndicator = model.TextOnlyOnDemandIndicator; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
