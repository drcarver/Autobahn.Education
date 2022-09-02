//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTeacherPrepViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationTeacherPrep file
/// </summary>
public partial class ProgramParticipationTeacherPrepViewModel : ObservableValidator, IProgramParticipationTeacherPrep
{
    #region "ProgramParticipationTeacherPrepViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProgramParticipationTeacherPrepViewModel Constructor
    /// </summary>
    public ProgramParticipationTeacherPrepViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProgramParticipationTeacherPrepViewModelConstruction();
    }

    /// <summary>
    /// ProgramParticipationTeacherPrepViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProgramParticipationTeacherPrepViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProgramParticipationTeacherPrep";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ClinicalExperienceClockHours -- (backing property for Supervised Clinical Experience Clock Hours)
    private Int32? clinicalExperienceClockHours;

    // member variable for the SchoolAgeEducationPscredits property
    private Decimal? schoolAgeEducationPscredits;

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

    #region "IProgramParticipationTeacherPrep Properties"
    /// <summary>
    /// Supervised Clinical Experience Clock Hours
    /// <para>
    /// An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19755">Supervised Clinical Experience Clock Hours</a>
    /// </para>
    /// </summary>
    [DisplayName("Supervised Clinical Experience Clock Hours")]
    public Int32? ClinicalExperienceClockHours { get => clinicalExperienceClockHours; set => SetProperty(ref clinicalExperienceClockHours, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Alternative Route to Certification or Licensure
    /// <para>
    /// An indication of whether a person is enrolled in an alternative teacher preparation program as defined by Title II.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19751">Alternative Route to Certification or Licensure</a>
    /// </para>
    /// </summary>
    [DisplayName("Alternative Route to Certification or Licensure")]
    public Guid? RefAltRouteToCertificationOrLicensureId { get; set; }

    /// <summary>
    /// Critical Teacher Shortage Area Candidate
    /// <para>
    /// An indication of whether a person is pursuing licensure/certification in a field designated as a shortage area as defined by Title II.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19753">Critical Teacher Shortage Area Candidate</a>
    /// </para>
    /// </summary>
    [DisplayName("Critical Teacher Shortage Area Candidate")]
    public Guid? RefCriticalTeacherShortageCandidateId { get; set; }

    /// <summary>
    /// Supervised Clinical Experience
    /// <para>
    /// An indication of whether a person is enrolled in a supervised clinical experience (including student teaching) as part of a teacher preparation program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19754">Supervised Clinical Experience</a>
    /// </para>
    /// </summary>
    [DisplayName("Supervised Clinical Experience")]
    public Guid? RefSupervisedClinicalExperienceId { get; set; }

    /// <summary>
    /// Teacher Preparation Program Completer Status
    /// <para>
    /// An indication of whether a person completed a state-approved teacher preparation program.  The fact that a person has or has not been recommended to the state for initial certification or licensure may not be used as a criterion for determining who is a program completer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19750">Teacher Preparation Program Completer Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Teacher Preparation Program Completer Status")]
    public Guid? RefTeacherPrepCompleterStatusId { get; set; }

    /// <summary>
    /// Teacher Preparation Program Enrollment Status
    /// <para>
    /// An indication of whether a person is pursuing certification as a teacher.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19749">Teacher Preparation Program Enrollment Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Teacher Preparation Program Enrollment Status")]
    public Guid? RefTeacherPrepEnrollmentStatusId { get; set; }

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

    public Decimal? SchoolAgeEducationPscredits { get => schoolAgeEducationPscredits; set => SetProperty(ref schoolAgeEducationPscredits, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProgramParticipationTeacherPrep model)
    {
        IsBusy = true;
        Id = model.Id;
        ClinicalExperienceClockHours = model.ClinicalExperienceClockHours; // Supervised Clinical Experience Clock Hours
        PersonProgramParticipationId = model.PersonProgramParticipationId; // 
        RefAltRouteToCertificationOrLicensureId = model.RefAltRouteToCertificationOrLicensureId; // Alternative Route to Certification or Licensure
        RefCriticalTeacherShortageCandidateId = model.RefCriticalTeacherShortageCandidateId; // Critical Teacher Shortage Area Candidate
        RefSupervisedClinicalExperienceId = model.RefSupervisedClinicalExperienceId; // Supervised Clinical Experience
        RefTeacherPrepCompleterStatusId = model.RefTeacherPrepCompleterStatusId; // Teacher Preparation Program Completer Status
        RefTeacherPrepEnrollmentStatusId = model.RefTeacherPrepEnrollmentStatusId; // Teacher Preparation Program Enrollment Status
        RefTeachingCredentialBasisId = model.RefTeachingCredentialBasisId; // Teaching Credential Basis
        RefTeachingCredentialTypeId = model.RefTeachingCredentialTypeId; // Teaching Credential Type
        SchoolAgeEducationPscredits = model.SchoolAgeEducationPscredits; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
