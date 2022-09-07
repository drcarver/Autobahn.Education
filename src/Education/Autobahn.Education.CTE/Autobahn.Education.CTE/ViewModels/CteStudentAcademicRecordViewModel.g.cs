//***************************************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteStudentAcademicRecordViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICteStudentAcademicRecord file
/// </summary>
public partial class CteStudentAcademicRecordViewModel : ObservableValidator, ICteStudentAcademicRecord
{
    #region "CteStudentAcademicRecordViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CteStudentAcademicRecordViewModel Constructor
    /// </summary>
    public CteStudentAcademicRecordViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCteStudentAcademicRecordViewModelConstruction();
    }

    /// <summary>
    /// CteStudentAcademicRecordViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCteStudentAcademicRecordViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CteStudentAcademicRecord";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CreditsAttemptedCumulative -- (backing property for Credits Attempted Cumulative)
    private Decimal? creditsAttemptedCumulative;

    // CreditsEarnedCumulative -- (backing property for Credits Earned Cumulative)
    private Decimal? creditsEarnedCumulative;

    // DiplomaOrCredentialAwardDate -- (backing property for Diploma or Credential Award Date)
    private System.String diplomaOrCredentialAwardDate;

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

    #region "ICteStudentAcademicRecord Properties"
    /// <summary>
    /// Credits Attempted Cumulative
    /// <para>
    /// The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19073">Credits Attempted Cumulative</a>
    /// </para>
    /// </summary>
    [DisplayName("Credits Attempted Cumulative")]
    public Decimal? CreditsAttemptedCumulative { get => creditsAttemptedCumulative; set => SetProperty(ref creditsAttemptedCumulative, value, false); }

    /// <summary>
    /// Credits Earned Cumulative
    /// <para>
    /// The cumulative number of credits a person earns by completing courses or examinations during their enrollment in the current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19074">Credits Earned Cumulative</a>
    /// </para>
    /// </summary>
    [DisplayName("Credits Earned Cumulative")]
    public Decimal? CreditsEarnedCumulative { get => creditsEarnedCumulative; set => SetProperty(ref creditsEarnedCumulative, value, false); }

    /// <summary>
    /// Diploma or Credential Award Date
    /// <para>
    /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Diploma or Credential Award Date")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(7,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DiplomaOrCredentialAwardDate { get => diplomaOrCredentialAwardDate; set => SetProperty(ref diplomaOrCredentialAwardDate, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Professional or Technical Credential Conferred
    /// <para>
    /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional or Technical Credential Conferred")]
    public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICteStudentAcademicRecord model)
    {
        IsBusy = true;
        Id = model.Id;
        CreditsAttemptedCumulative = model.CreditsAttemptedCumulative; // Credits Attempted Cumulative
        CreditsEarnedCumulative = model.CreditsEarnedCumulative; // Credits Earned Cumulative
        DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // Professional or Technical Credential Conferred
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
