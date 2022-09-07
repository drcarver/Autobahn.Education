//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStudentAcademicRecordViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAeStudentAcademicRecord file
/// </summary>
public partial class AeStudentAcademicRecordViewModel : ObservableValidator, IAeStudentAcademicRecord
{
    #region "AeStudentAcademicRecordViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AeStudentAcademicRecordViewModel Constructor
    /// </summary>
    public AeStudentAcademicRecordViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAeStudentAcademicRecordViewModelConstruction();
    }

    /// <summary>
    /// AeStudentAcademicRecordViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAeStudentAcademicRecordViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AeStudentAcademicRecord";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

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

    #region "IAeStudentAcademicRecord Properties"
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
    /// High School Diploma Type
    /// <para>
    /// The type of diploma/credential that is awarded to a person in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19138">High School Diploma Type</a>
    /// </para>
    /// </summary>
    [DisplayName("High School Diploma Type")]
    public Guid? RefHighSchoolDiplomaTypeId { get; set; }

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
    public void Load(IAeStudentAcademicRecord model)
    {
        IsBusy = true;
        Id = model.Id;
        DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefHighSchoolDiplomaTypeId = model.RefHighSchoolDiplomaTypeId; // High School Diploma Type
        RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // Professional or Technical Credential Conferred
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
