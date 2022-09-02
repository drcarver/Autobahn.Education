//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipControlViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedApipControl file
/// </summary>
public partial class AssessmentNeedApipControlViewModel : ObservableValidator, IAssessmentNeedApipControl
{
    #region "AssessmentNeedApipControlViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentNeedApipControlViewModel Constructor
    /// </summary>
    public AssessmentNeedApipControlViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentNeedApipControlViewModelConstruction();
    }

    /// <summary>
    /// AssessmentNeedApipControlViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentNeedApipControlViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentNeedApipControl";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AssessmentNeedTimeMultiplier -- (backing property for Assessment Need Time Multiplier)
    private System.String assessmentNeedTimeMultiplier;

    // BackgroundColor -- (backing property for Assessment Need Background Color)
    private System.String backgroundColor;

    // LineReaderHighlightColor -- (backing property for Assessment Need Line Reader Highlight Color)
    private System.String lineReaderHighlightColor;

    // OverlayColor -- (backing property for Assessment Need Overlay Color)
    private System.String overlayColor;

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

    #region "IAssessmentNeedApipControl Properties"
    /// <summary>
    /// Assessment Need Time Multiplier
    /// <para>
    /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20055">Assessment Need Time Multiplier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Time Multiplier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(9,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentNeedTimeMultiplier { get => assessmentNeedTimeMultiplier; set => SetProperty(ref assessmentNeedTimeMultiplier, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileControl"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileControlId { get; set; }

    /// <summary>
    /// Assessment Need Background Color
    /// <para>
    /// This is the preferred Background color for screen enhancement defined as part of an Assessment Personal Needs Profile.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20059">Assessment Need Background Color</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Background Color")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BackgroundColor { get => backgroundColor; set => SetProperty(ref backgroundColor, value, true); }

    /// <summary>
    /// Assessment Need Line Reader Highlight Color
    /// <para>
    /// The color defined as part of an Assessment Personal Needs Profile to be used to highlight the point of line reader activity i.e. the line being read.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20056">Assessment Need Line Reader Highlight Color</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Line Reader Highlight Color")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LineReaderHighlightColor { get => lineReaderHighlightColor; set => SetProperty(ref lineReaderHighlightColor, value, true); }

    /// <summary>
    /// Assessment Need Overlay Color
    /// <para>
    /// This is the preferred color for the overlay for screen enhancement defined as part of an Assessment Personal Needs Profile.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20057">Assessment Need Overlay Color</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Overlay Color")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OverlayColor { get => overlayColor; set => SetProperty(ref overlayColor, value, true); }

    /// <summary>
    /// Assessment Need Increased Whitespacing Type
    /// <para>
    /// Defines the user preferences for white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20060">Assessment Need Increased Whitespacing Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Increased Whitespacing Type")]
    public Guid? RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentNeedApipControl model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentNeedTimeMultiplier = model.AssessmentNeedTimeMultiplier; // Assessment Need Time Multiplier
        AssessmentPersonalNeedsProfileControlId = model.AssessmentPersonalNeedsProfileControlId; // 
        BackgroundColor = model.BackgroundColor; // Assessment Need Background Color
        LineReaderHighlightColor = model.LineReaderHighlightColor; // Assessment Need Line Reader Highlight Color
        OverlayColor = model.OverlayColor; // Assessment Need Overlay Color
        RefAssessmentNeedIncreasedWhitespacingTypeId = model.RefAssessmentNeedIncreasedWhitespacingTypeId; // Assessment Need Increased Whitespacing Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
