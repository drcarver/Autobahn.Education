//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipContentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedApipContent file
/// </summary>
public partial class AssessmentNeedApipContentViewModel : ObservableValidator, IAssessmentNeedApipContent
{
    #region "AssessmentNeedApipContentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentNeedApipContentViewModel Constructor
    /// </summary>
    public AssessmentNeedApipContentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentNeedApipContentViewModelConstruction();
    }

    /// <summary>
    /// AssessmentNeedApipContentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentNeedApipContentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentNeedApipContent";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AssessmentNeedDirectionsOnlyIndicator -- (backing property for Assessment Need Directions Only)
    private Boolean? assessmentNeedDirectionsOnlyIndicator;

    // ReadAtStartPreferenceIndicator -- (backing property for Assessment Need Read at Start Preference)
    private Boolean? readAtStartPreferenceIndicator;

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

    #region "IAssessmentNeedApipContent Properties"
    /// <summary>
    /// Assessment Need Directions Only
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile whether or not the verbal alternative content presentation should be applied to directive content only.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20050">Assessment Need Directions Only</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Directions Only")]
    public Boolean? AssessmentNeedDirectionsOnlyIndicator { get => assessmentNeedDirectionsOnlyIndicator; set => SetProperty(ref assessmentNeedDirectionsOnlyIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileContent"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileContentId { get; set; }

    /// <summary>
    /// Assessment Need Item Translation Display Language Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20042">Assessment Need Item Translation Display Language Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Item Translation Display Language Type")]
    public Guid? ItemTranslationDisplayLanguageTypeId { get; set; }

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
    public Guid? KeywordTranslationLanguageTypeId { get; set; }

    /// <summary>
    /// Assessment Need Read at Start Preference
    /// <para>
    /// Used as part of an Assessment Personal Needs Profile to define if the spoken play-back should commence from the start of a recording or not.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20048">Assessment Need Read at Start Preference</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Read at Start Preference")]
    public Boolean? ReadAtStartPreferenceIndicator { get => readAtStartPreferenceIndicator; set => SetProperty(ref readAtStartPreferenceIndicator, value, false); }

    /// <summary>
    /// Assessment Need Alternative Representation Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the default presentation mode of the associated Alternative Representations accessibility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20045">Assessment Need Alternative Representation Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Alternative Representation Type")]
    public Guid? RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }

    /// <summary>
    /// Assessment Need Signing Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the type of signing preferred by the user.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20044">Assessment Need Signing Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Signing Type")]
    public Guid? RefAssessmentNeedSigningTypeId { get; set; }

    /// <summary>
    /// Assessment Need Spoken Source Preference Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the preferred spoken audio form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20046">Assessment Need Spoken Source Preference Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Spoken Source Preference Type")]
    public Guid? RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }

    /// <summary>
    /// Assessment Need User Spoken Preference Type
    /// <para>
    /// Used as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20049">Assessment Need User Spoken Preference Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need User Spoken Preference Type")]
    public Guid? RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentNeedApipContent model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentNeedDirectionsOnlyIndicator = model.AssessmentNeedDirectionsOnlyIndicator; // Assessment Need Directions Only
        AssessmentPersonalNeedsProfileContentId = model.AssessmentPersonalNeedsProfileContentId; // 
        ItemTranslationDisplayLanguageTypeId = model.ItemTranslationDisplayLanguageTypeId; // Assessment Need Item Translation Display Language Type
        KeywordTranslationLanguageTypeId = model.KeywordTranslationLanguageTypeId; // Assessment Need Keyword Translation Language Type
        ReadAtStartPreferenceIndicator = model.ReadAtStartPreferenceIndicator; // Assessment Need Read at Start Preference
        RefAssessmentNeedAlternativeRepresentationTypeId = model.RefAssessmentNeedAlternativeRepresentationTypeId; // Assessment Need Alternative Representation Type
        RefAssessmentNeedSigningTypeId = model.RefAssessmentNeedSigningTypeId; // Assessment Need Signing Type
        RefAssessmentNeedSpokenSourcePreferenceTypeId = model.RefAssessmentNeedSpokenSourcePreferenceTypeId; // Assessment Need Spoken Source Preference Type
        RefAssessmentNeedUserSpokenPreferenceTypeId = model.RefAssessmentNeedUserSpokenPreferenceTypeId; // Assessment Need User Spoken Preference Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
