//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonDegreeOrCertificateViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDegreeOrCertificate file
/// </summary>
public partial class PersonDegreeOrCertificateViewModel : ObservableValidator, IPersonDegreeOrCertificate
{
    #region "PersonDegreeOrCertificateViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonDegreeOrCertificateViewModel Constructor
    /// </summary>
    public PersonDegreeOrCertificateViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonDegreeOrCertificateViewModelConstruction();
    }

    /// <summary>
    /// PersonDegreeOrCertificateViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonDegreeOrCertificateViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonDegreeOrCertificate";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AwardDate -- (backing property for Diploma or Credential Award Date)
    private DateTime? awardDate;

    // DegreeOrCertificateTitleOrSubject -- (backing property for Degree or Certificate Title or Subject)
    private System.String degreeOrCertificateTitleOrSubject;

    // NameOfInstitution -- (backing property for Name of Institution)
    private System.String nameOfInstitution;

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

    #region "IPersonDegreeOrCertificate Properties"
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
    public DateTime? AwardDate { get => awardDate; set => SetProperty(ref awardDate, value, false); }

    /// <summary>
    /// Degree or Certificate Title or Subject
    /// <para>
    /// The name of the degree or certificate earned by a person. This includes honorary degrees conferred upon an individual.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19341">Degree or Certificate Title or Subject</a>
    /// </para>
    /// </summary>
    [DisplayName("Degree or Certificate Title or Subject")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(45,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DegreeOrCertificateTitleOrSubject { get => degreeOrCertificateTitleOrSubject; set => SetProperty(ref degreeOrCertificateTitleOrSubject, value, true); }

    /// <summary>
    /// Name of Institution
    /// <para>
    /// The full legally accepted name of the institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19191">Name of Institution</a>
    /// </para>
    /// </summary>
    [DisplayName("Name of Institution")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String NameOfInstitution { get => nameOfInstitution; set => SetProperty(ref nameOfInstitution, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Degree or Certificate Type
    /// <para>
    /// The type of degree or certificate earned by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19342">Degree or Certificate Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Degree or Certificate Type")]
    public Guid? RefDegreeOrCertificateTypeId { get; set; }

    /// <summary>
    /// Education Verification Method
    /// <para>
    /// The method by which the formal education is verified.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20586">Education Verification Method</a>
    /// </para>
    /// </summary>
    [DisplayName("Education Verification Method")]
    public Guid? RefEducationVerificationMethodId { get; set; }

    /// <summary>
    /// Higher Education Institution Accreditation Status
    /// <para>
    /// An indication of the accreditation status of a higher education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Higher Education Institution Accreditation Status")]
    public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonDegreeOrCertificate model)
    {
        IsBusy = true;
        Id = model.Id;
        AwardDate = model.AwardDate; // Diploma or Credential Award Date
        DegreeOrCertificateTitleOrSubject = model.DegreeOrCertificateTitleOrSubject; // Degree or Certificate Title or Subject
        NameOfInstitution = model.NameOfInstitution; // Name of Institution
        PersonId = model.PersonId; // 
        RefDegreeOrCertificateTypeId = model.RefDegreeOrCertificateTypeId; // Degree or Certificate Type
        RefEducationVerificationMethodId = model.RefEducationVerificationMethodId; // Education Verification Method
        RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId; // Higher Education Institution Accreditation Status
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
