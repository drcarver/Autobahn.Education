//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedScreenReaderViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedScreenReader file
/// </summary>
public partial class AssessmentPersonalNeedScreenReaderViewModel : ObservableValidator, IAssessmentPersonalNeedScreenReader
{
    #region "AssessmentPersonalNeedScreenReaderViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentPersonalNeedScreenReaderViewModel Constructor
    /// </summary>
    public AssessmentPersonalNeedScreenReaderViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentPersonalNeedScreenReaderViewModelConstruction();
    }

    /// <summary>
    /// AssessmentPersonalNeedScreenReaderViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentPersonalNeedScreenReaderViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentPersonalNeedScreenReader";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Pitch -- (backing property for Assessment Need Pitch)
    private Decimal? pitch;

    // SpeechRate -- (backing property for Assessment Need Speech Rate)
    private Int32? speechRate;

    // Volume -- (backing property for Assessment Need Volume)
    private Decimal? volume;

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

    #region "IAssessmentPersonalNeedScreenReader Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

    /// <summary>
    /// Assessment Need Pitch
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the pitch of a speech synthesizer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20031">Assessment Need Pitch</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Pitch")]
    public Decimal? Pitch { get => pitch; set => SetProperty(ref pitch, value, false); }

    /// <summary>
    /// Assessment Need Link Indication Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the characteristics of presentation for a hyperlink when using a screen reader.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20029">Assessment Need Link Indication Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Link Indication Type")]
    public Guid? RefAssessmentNeedLinkIndicationTypeId { get; set; }

    /// <summary>
    /// Assessment Need Usage Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20028">Assessment Need Usage Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Usage Type")]
    public Guid? RefAssessmentNeedUsageTypeId { get; set; }

    /// <summary>
    /// Assessment Need Speech Rate
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the rate of speech of a speech synthesizer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20030">Assessment Need Speech Rate</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Speech Rate")]
    public Int32? SpeechRate { get => speechRate; set => SetProperty(ref speechRate, value, false); }

    /// <summary>
    /// Assessment Need Volume
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the volume of a speech synthesizer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20032">Assessment Need Volume</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Volume")]
    public Decimal? Volume { get => volume; set => SetProperty(ref volume, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentPersonalNeedScreenReader model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId; // 
        Pitch = model.Pitch; // Assessment Need Pitch
        RefAssessmentNeedLinkIndicationTypeId = model.RefAssessmentNeedLinkIndicationTypeId; // Assessment Need Link Indication Type
        RefAssessmentNeedUsageTypeId = model.RefAssessmentNeedUsageTypeId; // Assessment Need Usage Type
        SpeechRate = model.SpeechRate; // Assessment Need Speech Rate
        Volume = model.Volume; // Assessment Need Volume
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
