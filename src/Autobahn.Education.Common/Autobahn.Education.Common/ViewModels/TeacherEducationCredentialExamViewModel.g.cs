//***************************************************************************
//* DomainName: Common Models
//* FileName:   TeacherEducationCredentialExamViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ITeacherEducationCredentialExam file
/// </summary>
public partial class TeacherEducationCredentialExamViewModel : ObservableValidator, ITeacherEducationCredentialExam
{
    #region "TeacherEducationCredentialExamViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// TeacherEducationCredentialExamViewModel Constructor
    /// </summary>
    public TeacherEducationCredentialExamViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnTeacherEducationCredentialExamViewModelConstruction();
    }

    /// <summary>
    /// TeacherEducationCredentialExamViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnTeacherEducationCredentialExamViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from TeacherEducationCredentialExam";

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

    #region "ITeacherEducationCredentialExam Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProgramParticipationTeacherPrep"/> model
    /// </summary>
    public Guid ProgramParticipationTeacherPrepId { get; set; }

    /// <summary>
    /// Teacher Education Credential Exam Type
    /// <para>
    /// The type of examination used to assess teacher candidate's knowledge and skills.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19756">Teacher Education Credential Exam Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Teacher Education Credential Exam Type")]
    public Guid? RefTeacherEducationCredentialExamId { get; set; }

    /// <summary>
    /// Teacher Education Credential Exam Score Type
    /// <para>
    /// An indication of the type of credential exam associated with a given exam score.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19757">Teacher Education Credential Exam Score Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Teacher Education Credential Exam Score Type")]
    public Guid? RefTeacherEducationExamScoreTypeId { get; set; }

    /// <summary>
    /// Teacher Education Test Company
    /// <para>
    /// The name of the company that provides the examination used in the teacher education program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19748">Teacher Education Test Company</a>
    /// </para>
    /// </summary>
    [DisplayName("Teacher Education Test Company")]
    public Guid? RefTeacherEducationTestCompanyId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ITeacherEducationCredentialExam model)
    {
        IsBusy = true;
        Id = model.Id;
        ProgramParticipationTeacherPrepId = model.ProgramParticipationTeacherPrepId; // 
        RefTeacherEducationCredentialExamId = model.RefTeacherEducationCredentialExamId; // Teacher Education Credential Exam Type
        RefTeacherEducationExamScoreTypeId = model.RefTeacherEducationExamScoreTypeId; // Teacher Education Credential Exam Score Type
        RefTeacherEducationTestCompanyId = model.RefTeacherEducationTestCompanyId; // Teacher Education Test Company
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
