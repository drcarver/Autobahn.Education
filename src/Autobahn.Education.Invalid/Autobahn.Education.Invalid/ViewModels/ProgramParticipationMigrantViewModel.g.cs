//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProgramParticipationMigrantViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationMigrant file
/// </summary>
public partial class ProgramParticipationMigrantViewModel : ObservableValidator, IProgramParticipationMigrant
{
    #region "ProgramParticipationMigrantViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProgramParticipationMigrantViewModel Constructor
    /// </summary>
    public ProgramParticipationMigrantViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProgramParticipationMigrantViewModelConstruction();
    }

    /// <summary>
    /// ProgramParticipationMigrantViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProgramParticipationMigrantViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProgramParticipationMigrant";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // BirthdateVerification -- (backing property for Birthdate Verification)
    private System.String birthdateVerification;

    // ContinuationOfServicesStatus -- (backing property for Migrant Education Program Continuation of Services Status)
    private Boolean? continuationOfServicesStatus;

    // ImmunizationRecordFlag -- (backing property for Immunization Record Flag)
    private Boolean? immunizationRecordFlag;

    // LastQualifyingMoveDate -- (backing property for Last Qualifying Move Date)
    private DateTime? lastQualifyingMoveDate;

    // MepEligibilityExpirationDate -- (backing property for Migrant Education Program Eligibility Expiration Date)
    private DateTime? mepEligibilityExpirationDate;

    // MigrantStudentQualifyingArrivalDate -- (backing property for Migrant Student Qualifying Arrival Date)
    private DateTime? migrantStudentQualifyingArrivalDate;

    // PrioritizedForServices -- (backing property for Migrant Prioritized for Services)
    private Boolean? prioritizedForServices;

    // QualifyingMoveFromCity -- (backing property for Qualifying Move From City)
    private System.String qualifyingMoveFromCity;

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

    #region "IProgramParticipationMigrant Properties"
    /// <summary>
    /// Birthdate Verification
    /// <para>
    /// The evidence by which a child's date of birth is confirmed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19418">Birthdate Verification</a>
    /// </para>
    /// </summary>
    [DisplayName("Birthdate Verification")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BirthdateVerification { get => birthdateVerification; set => SetProperty(ref birthdateVerification, value, true); }

    /// <summary>
    /// Migrant Education Program Continuation of Services Status
    /// <para>
    /// An indication that migrant children are receiving instructional or support services under the continuation of services authority ESEA Title III Section 1304(e)(2)-(3).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19555">Migrant Education Program Continuation of Services Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Migrant Education Program Continuation of Services Status")]
    public Boolean? ContinuationOfServicesStatus { get => continuationOfServicesStatus; set => SetProperty(ref continuationOfServicesStatus, value, false); }

    /// <summary>
    /// Designated Graduation School Identifier
    /// <para>
    /// The NCES school identification number that identifies the school or facility from which a student expects to graduate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19426">Designated Graduation School Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Designated Graduation School Identifier")]
    public Guid? DesignatedGraduationSchoolId { get; set; }

    /// <summary>
    /// Immunization Record Flag
    /// <para>
    /// Indicates whether the school or MEP program has immunization records on file for the student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19428">Immunization Record Flag</a>
    /// </para>
    /// </summary>
    [DisplayName("Immunization Record Flag")]
    public Boolean? ImmunizationRecordFlag { get => immunizationRecordFlag; set => SetProperty(ref immunizationRecordFlag, value, false); }

    /// <summary>
    /// Last Qualifying Move Date
    /// <para>
    /// The year, month and day of the last qualifying move of a migrant student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19171">Last Qualifying Move Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Last Qualifying Move Date")]
    public DateTime? LastQualifyingMoveDate { get => lastQualifyingMoveDate; set => SetProperty(ref lastQualifyingMoveDate, value, false); }

    /// <summary>
    /// Migrant Education Program Eligibility Expiration Date
    /// <para>
    /// The year, month, and day on which the child is no longer eligible for the Migrant Education Program. This date should initially be a date equal to 36 months from the Qualifying Arrival Date to indicate the end of MEP eligibility or the student reaches 22 years of age, whichever comes first.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19420">Migrant Education Program Eligibility Expiration Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Migrant Education Program Eligibility Expiration Date")]
    public DateTime? MepEligibilityExpirationDate { get => mepEligibilityExpirationDate; set => SetProperty(ref mepEligibilityExpirationDate, value, false); }

    /// <summary>
    /// Migrant Student Qualifying Arrival Date
    /// <para>
    /// The qualifying arrival date (QAD) is the month, date, and year that the child completed a move with his or her parent to enable the parent to find qualifying employment. In some cases, the child and worker may not always move together, in which case the QAD would be the date that the child joins the worker who has  already moved, or the date the worker joins the child who has already moved. The QAD is the date the child's eligibility for the Migrant Education Program begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19422">Migrant Student Qualifying Arrival Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Migrant Student Qualifying Arrival Date")]
    public DateTime? MigrantStudentQualifyingArrivalDate { get => migrantStudentQualifyingArrivalDate; set => SetProperty(ref migrantStudentQualifyingArrivalDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Migrant Prioritized for Services
    /// <para>
    /// An indication that a migratory child 1) is failing to meet, or most at risk of failing to meet, the state's challenging academic content standards and student academic achievement standards; and 2) has experienced interruptions in their education during the regular school year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19554">Migrant Prioritized for Services</a>
    /// </para>
    /// </summary>
    [DisplayName("Migrant Prioritized for Services")]
    public Boolean? PrioritizedForServices { get => prioritizedForServices; set => SetProperty(ref prioritizedForServices, value, false); }

    /// <summary>
    /// Qualifying Move From City
    /// <para>
    /// The name of the city in which the child resided prior to the qualifying move.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19423">Qualifying Move From City</a>
    /// </para>
    /// </summary>
    [DisplayName("Qualifying Move From City")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String QualifyingMoveFromCity { get => qualifyingMoveFromCity; set => SetProperty(ref qualifyingMoveFromCity, value, true); }

    /// <summary>
    /// Continuation of Services Reason
    /// <para>
    /// Reason why the student is being served under the continuation of services provision of the MEP.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19419">Continuation of Services Reason</a>
    /// </para>
    /// </summary>
    [DisplayName("Continuation of Services Reason")]
    public Guid? RefContinuationOfServicesReasonId { get; set; }

    /// <summary>
    /// Migrant Education Program Enrollment Type
    /// <para>
    /// The type of school/migrant education project in which instruction and/or support services are provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19427">Migrant Education Program Enrollment Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Migrant Education Program Enrollment Type")]
    public Guid? RefMepEnrollmentTypeId { get; set; }

    /// <summary>
    /// Migrant Education Program Project Based
    /// <para>
    /// Indicates the type of MEP project based on the location where the MEP services are held.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19430">Migrant Education Program Project Based</a>
    /// </para>
    /// </summary>
    [DisplayName("Migrant Education Program Project Based")]
    public Guid? RefMepProjectBasedId { get; set; }

    /// <summary>
    /// Migrant Education Program Services Type
    /// <para>
    /// The type of services received by participating migrant students in the migrant education program (MEP).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19186">Migrant Education Program Services Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Migrant Education Program Services Type")]
    public Guid? RefMepServiceTypeId { get; set; }

    /// <summary>
    /// Qualifying Move From Country
    /// <para>
    /// The abbreviation code for a country (other than the US) area in which the child resided prior to the qualifying move.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19424">Qualifying Move From Country</a>
    /// </para>
    /// </summary>
    [DisplayName("Qualifying Move From Country")]
    public Guid? RefQualifyingMoveFromCountryId { get; set; }

    /// <summary>
    /// Qualifying Move From State
    /// <para>
    /// The postal abbreviation code for a state (within the United States) or outlying area in which the child resided prior to the qualifying move.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19425">Qualifying Move From State</a>
    /// </para>
    /// </summary>
    [DisplayName("Qualifying Move From State")]
    public Guid? RefQualifyingMoveFromStateId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProgramParticipationMigrant model)
    {
        IsBusy = true;
        Id = model.Id;
        BirthdateVerification = model.BirthdateVerification; // Birthdate Verification
        ContinuationOfServicesStatus = model.ContinuationOfServicesStatus; // Migrant Education Program Continuation of Services Status
        DesignatedGraduationSchoolId = model.DesignatedGraduationSchoolId; // Designated Graduation School Identifier
        ImmunizationRecordFlag = model.ImmunizationRecordFlag; // Immunization Record Flag
        LastQualifyingMoveDate = model.LastQualifyingMoveDate; // Last Qualifying Move Date
        MepEligibilityExpirationDate = model.MepEligibilityExpirationDate; // Migrant Education Program Eligibility Expiration Date
        MigrantStudentQualifyingArrivalDate = model.MigrantStudentQualifyingArrivalDate; // Migrant Student Qualifying Arrival Date
        PersonProgramParticipationId = model.PersonProgramParticipationId; // 
        PrioritizedForServices = model.PrioritizedForServices; // Migrant Prioritized for Services
        QualifyingMoveFromCity = model.QualifyingMoveFromCity; // Qualifying Move From City
        RefContinuationOfServicesReasonId = model.RefContinuationOfServicesReasonId; // Continuation of Services Reason
        RefMepEnrollmentTypeId = model.RefMepEnrollmentTypeId; // Migrant Education Program Enrollment Type
        RefMepProjectBasedId = model.RefMepProjectBasedId; // Migrant Education Program Project Based
        RefMepServiceTypeId = model.RefMepServiceTypeId; // Migrant Education Program Services Type
        RefQualifyingMoveFromCountryId = model.RefQualifyingMoveFromCountryId; // Qualifying Move From Country
        RefQualifyingMoveFromStateId = model.RefQualifyingMoveFromStateId; // Qualifying Move From State
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
