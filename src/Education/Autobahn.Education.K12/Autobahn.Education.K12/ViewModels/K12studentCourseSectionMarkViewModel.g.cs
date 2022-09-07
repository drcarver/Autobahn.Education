//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCourseSectionMarkViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCourseSectionMark file
/// </summary>
public partial class K12studentCourseSectionMarkViewModel : ObservableValidator, IK12studentCourseSectionMark
{
    #region "K12studentCourseSectionMarkViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12studentCourseSectionMarkViewModel Constructor
    /// </summary>
    public K12studentCourseSectionMarkViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12studentCourseSectionMarkViewModelConstruction();
    }

    /// <summary>
    /// K12studentCourseSectionMarkViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12studentCourseSectionMarkViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12studentCourseSectionMark";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the FinalIndicator property
    private Boolean? finalIndicator;

    // member variable for the GradeEarned property
    private System.String gradeEarned;

    // member variable for the GradeValueQualifier property
    private System.String gradeValueQualifier;

    // member variable for the MarkingPeriodName property
    private System.String markingPeriodName;

    // member variable for the MidTermMark property
    private System.String midTermMark;

    // member variable for the StudentCourseSectionGradeNarrative property
    private System.String studentCourseSectionGradeNarrative;

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

    #region "IK12studentCourseSectionMark Properties"
    public Boolean? FinalIndicator { get => finalIndicator; set => SetProperty(ref finalIndicator, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(15,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GradeEarned { get => gradeEarned; set => SetProperty(ref gradeEarned, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GradeValueQualifier { get => gradeValueQualifier; set => SetProperty(ref gradeValueQualifier, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12studentCourseSection"/> model
    /// </summary>
    public Guid K12studentCourseSectionId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MarkingPeriodName { get => markingPeriodName; set => SetProperty(ref markingPeriodName, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(15,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MidTermMark { get => midTermMark; set => SetProperty(ref midTermMark, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String StudentCourseSectionGradeNarrative { get => studentCourseSectionGradeNarrative; set => SetProperty(ref studentCourseSectionGradeNarrative, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12studentCourseSectionMark model)
    {
        IsBusy = true;
        Id = model.Id;
        FinalIndicator = model.FinalIndicator; // 
        GradeEarned = model.GradeEarned; // 
        GradeValueQualifier = model.GradeValueQualifier; // 
        K12studentCourseSectionId = model.K12studentCourseSectionId; // 
        MarkingPeriodName = model.MarkingPeriodName; // 
        MidTermMark = model.MidTermMark; // 
        StudentCourseSectionGradeNarrative = model.StudentCourseSectionGradeNarrative; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
