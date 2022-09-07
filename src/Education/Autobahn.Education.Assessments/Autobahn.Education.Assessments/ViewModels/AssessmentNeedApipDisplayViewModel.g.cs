//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipDisplayViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedApipDisplay file
/// </summary>
public partial class AssessmentNeedApipDisplayViewModel : ObservableValidator, IAssessmentNeedApipDisplay
{
    #region "AssessmentNeedApipDisplayViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentNeedApipDisplayViewModel Constructor
    /// </summary>
    public AssessmentNeedApipDisplayViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentNeedApipDisplayViewModelConstruction();
    }

    /// <summary>
    /// AssessmentNeedApipDisplayViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentNeedApipDisplayViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentNeedApipDisplay";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // EncouragementActivateByDefaultIndicator -- (backing property for Assessment Personal Needs Profile Activate by Default)
    private Boolean? encouragementActivateByDefaultIndicator;

    // EncouragementAssignedSupportIndicator -- (backing property for Assessment Personal Needs Profile Assigned Support)
    private Boolean? encouragementAssignedSupportIndicator;

    // EncouragementSoundFileUrl -- (backing property for Assessment Need Sound File URL)
    private System.String encouragementSoundFileUrl;

    // EncouragementTextMessagingString -- (backing property for Assessment Need Text Messaging String)
    private System.String encouragementTextMessagingString;

    // MaskingActivateByDefaultIndicator -- (backing property for Assessment Personal Needs Profile Activate by Default)
    private Boolean? maskingActivateByDefaultIndicator;

    // MaskingAssignedSupportIndicator -- (backing property for Assessment Personal Needs Profile Assigned Support)
    private Boolean? maskingAssignedSupportIndicator;

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

    #region "IAssessmentNeedApipDisplay Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

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
    public Boolean? EncouragementActivateByDefaultIndicator { get => encouragementActivateByDefaultIndicator; set => SetProperty(ref encouragementActivateByDefaultIndicator, value, false); }

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
    public Boolean? EncouragementAssignedSupportIndicator { get => encouragementAssignedSupportIndicator; set => SetProperty(ref encouragementAssignedSupportIndicator, value, false); }

    /// <summary>
    /// Assessment Need Sound File URL
    /// <para>
    /// The URI of the sound file that is to be played to the user as an expression of encouragement when Masking is specified as part of an Assessment Personal Needs Profile. It is left to the system to determine when to play this audio file.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20053">Assessment Need Sound File URL</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Sound File URL")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EncouragementSoundFileUrl { get => encouragementSoundFileUrl; set => SetProperty(ref encouragementSoundFileUrl, value, true); }

    /// <summary>
    /// Assessment Need Text Messaging String
    /// <para>
    /// The text string that is to be displayed to the user as an expression of encouragement when Masking is specified as part of an Assessment Personal Needs Profile.  It is left to the system to determine when to display this string.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20052">Assessment Need Text Messaging String</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Text Messaging String")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4000,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EncouragementTextMessagingString { get => encouragementTextMessagingString; set => SetProperty(ref encouragementTextMessagingString, value, true); }

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
    public Boolean? MaskingActivateByDefaultIndicator { get => maskingActivateByDefaultIndicator; set => SetProperty(ref maskingActivateByDefaultIndicator, value, false); }

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
    public Boolean? MaskingAssignedSupportIndicator { get => maskingAssignedSupportIndicator; set => SetProperty(ref maskingAssignedSupportIndicator, value, false); }

    /// <summary>
    /// Assessment Need Masking Type
    /// <para>
    /// Specifies as part of an Assessment Personal Needs Profile the type of masks the user is able to create  to cover portions of the question until needed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20051">Assessment Need Masking Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Masking Type")]
    public Guid? RefAssessmentNeedMaskingTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentNeedApipDisplay model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId; // 
        EncouragementActivateByDefaultIndicator = model.EncouragementActivateByDefaultIndicator; // Assessment Personal Needs Profile Activate by Default
        EncouragementAssignedSupportIndicator = model.EncouragementAssignedSupportIndicator; // Assessment Personal Needs Profile Assigned Support
        EncouragementSoundFileUrl = model.EncouragementSoundFileUrl; // Assessment Need Sound File URL
        EncouragementTextMessagingString = model.EncouragementTextMessagingString; // Assessment Need Text Messaging String
        MaskingActivateByDefaultIndicator = model.MaskingActivateByDefaultIndicator; // Assessment Personal Needs Profile Activate by Default
        MaskingAssignedSupportIndicator = model.MaskingAssignedSupportIndicator; // Assessment Personal Needs Profile Assigned Support
        RefAssessmentNeedMaskingTypeId = model.RefAssessmentNeedMaskingTypeId; // Assessment Need Masking Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
