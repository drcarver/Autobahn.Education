//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedScreenEnhancementViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedScreenEnhancement file
/// </summary>
public partial class AssessmentNeedScreenEnhancementViewModel : ObservableValidator, IAssessmentNeedScreenEnhancement
{
    #region "AssessmentNeedScreenEnhancementViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentNeedScreenEnhancementViewModel Constructor
    /// </summary>
    public AssessmentNeedScreenEnhancementViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentNeedScreenEnhancementViewModelConstruction();
    }

    /// <summary>
    /// AssessmentNeedScreenEnhancementViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentNeedScreenEnhancementViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentNeedScreenEnhancement";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ForegroundColor -- (backing property for Assessment Need Foreground Color)
    private System.String foregroundColor;

    // InvertColorChoice -- (backing property for Assessment Need Invert Color Choice)
    private Boolean? invertColorChoice;

    // Magnification -- (backing property for Assessment Need Magnification)
    private Decimal? magnification;

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

    #region "IAssessmentNeedScreenEnhancement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileScreenEnhancement"/> model
    /// </summary>
    public Guid? AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }

    /// <summary>
    /// Assessment Need Foreground Color
    /// <para>
    /// This is the preferred Foreground color for screen enhancement defined as part of an Assessment Personal Needs Profile.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20058">Assessment Need Foreground Color</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Foreground Color")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ForegroundColor { get => foregroundColor; set => SetProperty(ref foregroundColor, value, true); }

    /// <summary>
    /// Assessment Need Invert Color Choice
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20033">Assessment Need Invert Color Choice</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Invert Color Choice")]
    public Boolean? InvertColorChoice { get => invertColorChoice; set => SetProperty(ref invertColorChoice, value, false); }

    /// <summary>
    /// Assessment Need Magnification
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the preferred magnification of the screen as a factor of a screen's original size.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20034">Assessment Need Magnification</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Magnification")]
    public Decimal? Magnification { get => magnification; set => SetProperty(ref magnification, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentNeedScreenEnhancement model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId; // 
        AssessmentPersonalNeedsProfileScreenEnhancementId = model.AssessmentPersonalNeedsProfileScreenEnhancementId; // 
        ForegroundColor = model.ForegroundColor; // Assessment Need Foreground Color
        InvertColorChoice = model.InvertColorChoice; // Assessment Need Invert Color Choice
        Magnification = model.Magnification; // Assessment Need Magnification
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
