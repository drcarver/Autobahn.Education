//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentAcademicRecordViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentAcademicRecord file
/// </summary>
public partial class K12studentAcademicRecordViewModel : ObservableValidator, IK12studentAcademicRecord
{
    #region "K12studentAcademicRecordViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12studentAcademicRecordViewModel Constructor
    /// </summary>
    public K12studentAcademicRecordViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12studentAcademicRecordViewModelConstruction();
    }

    /// <summary>
    /// K12studentAcademicRecordViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12studentAcademicRecordViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12studentAcademicRecord";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ClassRankingDate property
    private DateTime? classRankingDate;

    // member variable for the CreditsAttemptedCumulative property
    private Decimal? creditsAttemptedCumulative;

    // member variable for the CreditsEarnedCumulative property
    private Decimal? creditsEarnedCumulative;

    // member variable for the DiplomaOrCredentialAwardDate property
    private DateTime? diplomaOrCredentialAwardDate;

    // member variable for the GradePointAverageCumulative property
    private Decimal? gradePointAverageCumulative;

    // member variable for the GradePointsEarnedCumulative property
    private Decimal? gradePointsEarnedCumulative;

    // member variable for the HighSchoolStudentClassRank property
    private Int32? highSchoolStudentClassRank;

    // member variable for the ProjectedGraduationDate property
    private DateTime? projectedGraduationDate;

    // member variable for the TotalNumberInClass property
    private Int32? totalNumberInClass;

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

    #region "IK12studentAcademicRecord Properties"
    public DateTime? ClassRankingDate { get => classRankingDate; set => SetProperty(ref classRankingDate, value, false); }

    public Decimal? CreditsAttemptedCumulative { get => creditsAttemptedCumulative; set => SetProperty(ref creditsAttemptedCumulative, value, false); }

    public Decimal? CreditsEarnedCumulative { get => creditsEarnedCumulative; set => SetProperty(ref creditsEarnedCumulative, value, false); }

    public DateTime? DiplomaOrCredentialAwardDate { get => diplomaOrCredentialAwardDate; set => SetProperty(ref diplomaOrCredentialAwardDate, value, false); }

    public Decimal? GradePointAverageCumulative { get => gradePointAverageCumulative; set => SetProperty(ref gradePointAverageCumulative, value, false); }

    public Decimal? GradePointsEarnedCumulative { get => gradePointsEarnedCumulative; set => SetProperty(ref gradePointsEarnedCumulative, value, false); }

    public Int32? HighSchoolStudentClassRank { get => highSchoolStudentClassRank; set => SetProperty(ref highSchoolStudentClassRank, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    public DateTime? ProjectedGraduationDate { get => projectedGraduationDate; set => SetProperty(ref projectedGraduationDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
    /// </summary>
    public Guid? RefGpaWeightedIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaDistinctionType"/> model
    /// </summary>
    public Guid? RefHighSchoolDiplomaDistinctionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
    /// </summary>
    public Guid? RefHighSchoolDiplomaTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
    /// </summary>
    public Guid? RefPreAndPostTestIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
    /// </summary>
    public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
    /// </summary>
    public Guid? RefProgressLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPsEnrollmentAction"/> model
    /// </summary>
    public Guid? RefPsEnrollmentActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTechnologyLiteracyStatus"/> model
    /// </summary>
    public Guid? RefTechnologyLiteracyStatusId { get; set; }

    public Int32? TotalNumberInClass { get => totalNumberInClass; set => SetProperty(ref totalNumberInClass, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12studentAcademicRecord model)
    {
        IsBusy = true;
        Id = model.Id;
        ClassRankingDate = model.ClassRankingDate; // 
        CreditsAttemptedCumulative = model.CreditsAttemptedCumulative; // 
        CreditsEarnedCumulative = model.CreditsEarnedCumulative; // 
        DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // 
        GradePointAverageCumulative = model.GradePointAverageCumulative; // 
        GradePointsEarnedCumulative = model.GradePointsEarnedCumulative; // 
        HighSchoolStudentClassRank = model.HighSchoolStudentClassRank; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        ProjectedGraduationDate = model.ProjectedGraduationDate; // 
        RefGpaWeightedIndicatorId = model.RefGpaWeightedIndicatorId; // 
        RefHighSchoolDiplomaDistinctionTypeId = model.RefHighSchoolDiplomaDistinctionTypeId; // 
        RefHighSchoolDiplomaTypeId = model.RefHighSchoolDiplomaTypeId; // 
        RefPreAndPostTestIndicatorId = model.RefPreAndPostTestIndicatorId; // 
        RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // 
        RefProgressLevelId = model.RefProgressLevelId; // 
        RefPsEnrollmentActionId = model.RefPsEnrollmentActionId; // 
        RefTechnologyLiteracyStatusId = model.RefTechnologyLiteracyStatusId; // 
        TotalNumberInClass = model.TotalNumberInClass; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
