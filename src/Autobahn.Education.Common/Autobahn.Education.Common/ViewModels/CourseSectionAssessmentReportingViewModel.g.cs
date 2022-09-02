//***************************************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionAssessmentReportingViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionAssessmentReporting file
/// </summary>
public partial class CourseSectionAssessmentReportingViewModel : ObservableValidator, ICourseSectionAssessmentReporting
{
    #region "CourseSectionAssessmentReportingViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CourseSectionAssessmentReportingViewModel Constructor
    /// </summary>
    public CourseSectionAssessmentReportingViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCourseSectionAssessmentReportingViewModelConstruction();
    }

    /// <summary>
    /// CourseSectionAssessmentReportingViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCourseSectionAssessmentReportingViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CourseSectionAssessmentReporting";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

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

    #region "ICourseSectionAssessmentReporting Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    public Guid? CourseSectionId { get; set; }

    /// <summary>
    /// Course Section Assessment Reporting Method
    /// <para>
    /// The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19027">Course Section Assessment Reporting Method</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Section Assessment Reporting Method")]
    public Guid? RefCourseSectionAssessmentReportingMethodId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICourseSectionAssessmentReporting model)
    {
        IsBusy = true;
        Id = model.Id;
        CourseSectionId = model.CourseSectionId; // 
        RefCourseSectionAssessmentReportingMethodId = model.RefCourseSectionAssessmentReportingMethodId; // Course Section Assessment Reporting Method
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
