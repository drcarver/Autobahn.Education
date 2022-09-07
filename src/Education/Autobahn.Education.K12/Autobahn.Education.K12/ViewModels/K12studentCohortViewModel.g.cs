//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCohortViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCohort file
/// </summary>
public partial class K12studentCohortViewModel : ObservableValidator, IK12studentCohort
{
    #region "K12studentCohortViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12studentCohortViewModel Constructor
    /// </summary>
    public K12studentCohortViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12studentCohortViewModelConstruction();
    }

    /// <summary>
    /// K12studentCohortViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12studentCohortViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12studentCohort";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the CohortDescription property
    private System.String cohortDescription;

    // member variable for the CohortGraduationYear property
    private System.String cohortGraduationYear;

    // member variable for the CohortYear property
    private System.String cohortYear;

    // member variable for the GraduationRateSurveyCohortYear property
    private System.String graduationRateSurveyCohortYear;

    // member variable for the GraduationRateSurveyIndicator property
    private Boolean? graduationRateSurveyIndicator;

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

    #region "IK12studentCohort Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CohortDescription { get => cohortDescription; set => SetProperty(ref cohortDescription, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CohortGraduationYear { get => cohortGraduationYear; set => SetProperty(ref cohortGraduationYear, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CohortYear { get => cohortYear; set => SetProperty(ref cohortYear, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GraduationRateSurveyCohortYear { get => graduationRateSurveyCohortYear; set => SetProperty(ref graduationRateSurveyCohortYear, value, true); }

    public Boolean? GraduationRateSurveyIndicator { get => graduationRateSurveyIndicator; set => SetProperty(ref graduationRateSurveyIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12studentCohort model)
    {
        IsBusy = true;
        Id = model.Id;
        CohortDescription = model.CohortDescription; // 
        CohortGraduationYear = model.CohortGraduationYear; // 
        CohortYear = model.CohortYear; // 
        GraduationRateSurveyCohortYear = model.GraduationRateSurveyCohortYear; // 
        GraduationRateSurveyIndicator = model.GraduationRateSurveyIndicator; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
