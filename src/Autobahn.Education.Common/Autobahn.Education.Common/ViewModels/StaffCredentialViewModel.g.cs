//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffCredentialViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IStaffCredential file
/// </summary>
public partial class StaffCredentialViewModel : ObservableValidator, IStaffCredential
{
    #region "StaffCredentialViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// StaffCredentialViewModel Constructor
    /// </summary>
    public StaffCredentialViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnStaffCredentialViewModelConstruction();
    }

    /// <summary>
    /// StaffCredentialViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnStaffCredentialViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from StaffCredential";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CardiopulmonaryResuscitationCertification -- (backing property for Cardiopulmonary Resuscitation Certification Expiration Date)
    private DateTime? cardiopulmonaryResuscitationCertification;

    // member variable for the CteinstructorIndustryCertification property
    private Boolean? cteinstructorIndustryCertification;

    // DiplomaOrCredentialAwardDate -- (backing property for Diploma or Credential Award Date)
    private System.String diplomaOrCredentialAwardDate;

    // FirstAidCertification -- (backing property for First Aid Certification Expiration Date)
    private DateTime? firstAidCertification;

    // TechnologySkillsStandardsMet -- (backing property for Technology Skills Standards Met)
    private Boolean? technologySkillsStandardsMet;

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

    #region "IStaffCredential Properties"
    /// <summary>
    /// Cardiopulmonary Resuscitation Certification Expiration Date
    /// <para>
    /// The date an individual's cardiopulmonary resuscitation (CPR) training certification expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20065">Cardiopulmonary Resuscitation Certification Expiration Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Cardiopulmonary Resuscitation Certification Expiration Date")]
    public DateTime? CardiopulmonaryResuscitationCertification { get => cardiopulmonaryResuscitationCertification; set => SetProperty(ref cardiopulmonaryResuscitationCertification, value, false); }

    public Boolean? CteinstructorIndustryCertification { get => cteinstructorIndustryCertification; set => SetProperty(ref cteinstructorIndustryCertification, value, false); }

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
    /// First Aid Certification Expiration Date
    /// <para>
    /// The date an individual's first aid training certification expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20066">First Aid Certification Expiration Date</a>
    /// </para>
    /// </summary>
    [DisplayName("First Aid Certification Expiration Date")]
    public DateTime? FirstAidCertification { get => firstAidCertification; set => SetProperty(ref firstAidCertification, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
    /// </summary>
    public Guid PersonCredentialId { get; set; }

    /// <summary>
    /// Adult Education Certification Type
    /// <para>
    /// An indication of the category of the adult education certification a person holds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19775">Adult Education Certification Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Adult Education Certification Type")]
    public Guid? RefAeCertificationTypeId { get; set; }

    /// <summary>
    /// Child Development Associate Type
    /// <para>
    /// Type of Child Development Associate credential as defined by options.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19805">Child Development Associate Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Child Development Associate Type")]
    public Guid? RefChildDevAssociateTypeId { get; set; }

    /// <summary>
    /// Paraprofessional Qualification Status
    /// <para>
    /// An indication of whether paraprofessionals are classified as qualified for their assignment according to state definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19207">Paraprofessional Qualification Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Paraprofessional Qualification Status")]
    public Guid? RefParaprofessionalQualificationId { get; set; }

    /// <summary>
    /// Program Sponsor Type
    /// <para>
    /// A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19692">Program Sponsor Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Program Sponsor Type")]
    public Guid? RefProgramSponsorTypeId { get; set; }

    /// <summary>
    /// Teaching Credential Basis
    /// <para>
    /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19277">Teaching Credential Basis</a>
    /// </para>
    /// </summary>
    [DisplayName("Teaching Credential Basis")]
    public Guid? RefTeachingCredentialBasisId { get; set; }

    /// <summary>
    /// Teaching Credential Type
    /// <para>
    /// An indication of the category of a legal document giving authorization to perform teaching assignment services.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19278">Teaching Credential Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Teaching Credential Type")]
    public Guid? RefTeachingCredentialTypeId { get; set; }

    /// <summary>
    /// Technology Skills Standards Met
    /// <para>
    /// An indication that the person has achieved acceptable performance on a standards-based profile of technology user skills as defined by the state.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19537">Technology Skills Standards Met</a>
    /// </para>
    /// </summary>
    [DisplayName("Technology Skills Standards Met")]
    public Boolean? TechnologySkillsStandardsMet { get => technologySkillsStandardsMet; set => SetProperty(ref technologySkillsStandardsMet, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IStaffCredential model)
    {
        IsBusy = true;
        Id = model.Id;
        CardiopulmonaryResuscitationCertification = model.CardiopulmonaryResuscitationCertification; // Cardiopulmonary Resuscitation Certification Expiration Date
        CteinstructorIndustryCertification = model.CteinstructorIndustryCertification; // 
        DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
        FirstAidCertification = model.FirstAidCertification; // First Aid Certification Expiration Date
        PersonCredentialId = model.PersonCredentialId; // 
        RefAeCertificationTypeId = model.RefAeCertificationTypeId; // Adult Education Certification Type
        RefChildDevAssociateTypeId = model.RefChildDevAssociateTypeId; // Child Development Associate Type
        RefParaprofessionalQualificationId = model.RefParaprofessionalQualificationId; // Paraprofessional Qualification Status
        RefProgramSponsorTypeId = model.RefProgramSponsorTypeId; // Program Sponsor Type
        RefTeachingCredentialBasisId = model.RefTeachingCredentialBasisId; // Teaching Credential Basis
        RefTeachingCredentialTypeId = model.RefTeachingCredentialTypeId; // Teaching Credential Type
        TechnologySkillsStandardsMet = model.TechnologySkillsStandardsMet; // Technology Skills Standards Met
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
