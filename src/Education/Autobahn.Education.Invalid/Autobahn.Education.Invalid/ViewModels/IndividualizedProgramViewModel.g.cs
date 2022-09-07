//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgram file
/// </summary>
public partial class IndividualizedProgramViewModel : ObservableValidator, IIndividualizedProgram
{
    #region "IndividualizedProgramViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IndividualizedProgramViewModel Constructor
    /// </summary>
    public IndividualizedProgramViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIndividualizedProgramViewModelConstruction();
    }

    /// <summary>
    /// IndividualizedProgramViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIndividualizedProgramViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from IndividualizedProgram";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // InclusionMinutesPerWeek -- (backing property for Individualized Program Inclusion Minutes Per Week)
    private Int32? inclusionMinutesPerWeek;

    // InclusiveSettingIndicator -- (backing property for Inclusive Setting Indicator)
    private Boolean? inclusiveSettingIndicator;

    // IndividualizedProgramDate -- (backing property for Individualized Program Date)
    private DateTime? individualizedProgramDate;

    // NonInclusionMinutesPerWeek -- (backing property for Individualized Program NonInclusion Minutes Per Week)
    private Int32? nonInclusionMinutesPerWeek;

    // RefIndividualizedProgramDateType -- (backing property for Individualized Program Service Plan Date Type)
    private Int32? refIndividualizedProgramDateType;

    // ServicePlanDate -- (backing property for Individualized Program Service Plan Date)
    private DateTime? servicePlanDate;

    // ServicePlanEndDate -- (backing property for Individualized Program Service Plan End Date)
    private DateTime? servicePlanEndDate;

    // ServicePlanMeetingParticipants -- (backing property for Individualized Program Service Plan Meeting Participants)
    private System.String servicePlanMeetingParticipants;

    // ServicePlanReevaluationDate -- (backing property for Individualized Program Service Plan Reevaluation Date)
    private DateTime? servicePlanReevaluationDate;

    // ServicePlanSignatureDate -- (backing property for Individualized Program Service Plan Signature Date)
    private DateTime? servicePlanSignatureDate;

    // ServicePlanSignedBy -- (backing property for Individualized Program Service Plan Signed By)
    private System.String servicePlanSignedBy;

    // TransferOfRightsStatement -- (backing property for IEP Transfer of Rights Statement)
    private System.String transferOfRightsStatement;

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

    #region "IIndividualizedProgram Properties"
    /// <summary>
    /// Individualized Program Inclusion Minutes Per Week
    /// <para>
    /// The number of minutes per week that a student with disabilities is served in a special education setting separate from his or her non-disabled peers.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20199">Individualized Program Inclusion Minutes Per Week</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Inclusion Minutes Per Week")]
    public Int32? InclusionMinutesPerWeek { get => inclusionMinutesPerWeek; set => SetProperty(ref inclusionMinutesPerWeek, value, false); }

    /// <summary>
    /// Inclusive Setting Indicator
    /// <para>
    /// Indicates that services are provided to the child in a place where children of all abilities learn together.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Inclusive Setting Indicator")]
    public Boolean? InclusiveSettingIndicator { get => inclusiveSettingIndicator; set => SetProperty(ref inclusiveSettingIndicator, value, false); }

    /// <summary>
    /// Individualized Program Date
    /// <para>
    /// The year, month and day on which the status of an individualized program for a student is significantly altered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20197">Individualized Program Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Date")]
    public DateTime? IndividualizedProgramDate { get => individualizedProgramDate; set => SetProperty(ref individualizedProgramDate, value, false); }

    /// <summary>
    /// Individualized Program NonInclusion Minutes Per Week
    /// <para>
    /// The number of minutes per week that a student with disabilities is served in a regular classroom with his or her non-disabled peers.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20198">Individualized Program NonInclusion Minutes Per Week</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program NonInclusion Minutes Per Week")]
    public Int32? NonInclusionMinutesPerWeek { get => nonInclusionMinutesPerWeek; set => SetProperty(ref nonInclusionMinutesPerWeek, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Date Type
    /// <para>
    /// An indication of the significance of a date to an individualized program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20196">Individualized Program Service Plan Date Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Date Type")]
    public Int32? RefIndividualizedProgramDateType { get => refIndividualizedProgramDateType; set => SetProperty(ref refIndividualizedProgramDateType, value, false); }

    /// <summary>
    /// Individualized Program Service Plan Meeting Location
    /// <para>
    /// The place in which a child's service plan meeting is held.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20202">Individualized Program Service Plan Meeting Location</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Meeting Location")]
    public Guid? RefIndividualizedProgramLocationId { get; set; }

    /// <summary>
    /// Individualized Program Transition Plan Type
    /// <para>
    /// The post-school transition plan for the student recorded on their Individualized Education Program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20200">Individualized Program Transition Plan Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Transition Plan Type")]
    public Guid? RefIndividualizedProgramTransitionTypeId { get; set; }

    /// <summary>
    /// Individualized Program Type
    /// <para>
    /// A designation of the type of program developed for a student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19320">Individualized Program Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Type")]
    public Guid? RefIndividualizedProgramTypeId { get; set; }

    /// <summary>
    /// Student Support Service Type
    /// <para>
    /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19273">Student Support Service Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Student Support Service Type")]
    public Guid? RefStudentSupportServiceTypeId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Date
    /// <para>
    /// The year, month and day on which the status of the service plan for a child is established or significantly altered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20201">Individualized Program Service Plan Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Date")]
    public DateTime? ServicePlanDate { get => servicePlanDate; set => SetProperty(ref servicePlanDate, value, false); }

    /// <summary>
    /// Individualized Program Service Plan End Date
    /// <para>
    /// The year, month and day on which the status of the service plan for a child effectively ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20664">Individualized Program Service Plan End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan End Date")]
    public DateTime? ServicePlanEndDate { get => servicePlanEndDate; set => SetProperty(ref servicePlanEndDate, value, false); }

    /// <summary>
    /// Individualized Program Service Plan Meeting Participants
    /// <para>
    /// The position titles of individuals who attend the service plan meeting.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20203">Individualized Program Service Plan Meeting Participants</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Meeting Participants")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4000,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ServicePlanMeetingParticipants { get => servicePlanMeetingParticipants; set => SetProperty(ref servicePlanMeetingParticipants, value, true); }

    /// <summary>
    /// Individualized Program Service Plan Reevaluation Date
    /// <para>
    /// Date student will be reevaluated for continued placement in a support program(s).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20207">Individualized Program Service Plan Reevaluation Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Reevaluation Date")]
    public DateTime? ServicePlanReevaluationDate { get => servicePlanReevaluationDate; set => SetProperty(ref servicePlanReevaluationDate, value, false); }

    /// <summary>
    /// Individualized Program Service Plan Signature Date
    /// <para>
    /// The year, month and day on which the service plan document is signed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20205">Individualized Program Service Plan Signature Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Signature Date")]
    public DateTime? ServicePlanSignatureDate { get => servicePlanSignatureDate; set => SetProperty(ref servicePlanSignatureDate, value, false); }

    /// <summary>
    /// Individualized Program Service Plan Signed By
    /// <para>
    /// The position titles of individuals who sign a written service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20204">Individualized Program Service Plan Signed By</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Signed By")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4000,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ServicePlanSignedBy { get => servicePlanSignedBy; set => SetProperty(ref servicePlanSignedBy, value, true); }

    /// <summary>
    /// IEP Transfer of Rights Statement
    /// <para>
    /// Beginning not later than one year before the child reaches the age of majority under State law, the IEP must include a statement that the child has been informed of the child's rights under Part B of the Individuals with Disabilities Education Act, if any, that will transfer to the child on reaching the age of majority under 300.520.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20663">IEP Transfer of Rights Statement</a>
    /// </para>
    /// </summary>
    [DisplayName("IEP Transfer of Rights Statement")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String TransferOfRightsStatement { get => transferOfRightsStatement; set => SetProperty(ref transferOfRightsStatement, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIndividualizedProgram model)
    {
        IsBusy = true;
        Id = model.Id;
        InclusionMinutesPerWeek = model.InclusionMinutesPerWeek; // Individualized Program Inclusion Minutes Per Week
        InclusiveSettingIndicator = model.InclusiveSettingIndicator; // Inclusive Setting Indicator
        IndividualizedProgramDate = model.IndividualizedProgramDate; // Individualized Program Date
        NonInclusionMinutesPerWeek = model.NonInclusionMinutesPerWeek; // Individualized Program NonInclusion Minutes Per Week
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefIndividualizedProgramDateType = model.RefIndividualizedProgramDateType; // Individualized Program Service Plan Date Type
        RefIndividualizedProgramLocationId = model.RefIndividualizedProgramLocationId; // Individualized Program Service Plan Meeting Location
        RefIndividualizedProgramTransitionTypeId = model.RefIndividualizedProgramTransitionTypeId; // Individualized Program Transition Plan Type
        RefIndividualizedProgramTypeId = model.RefIndividualizedProgramTypeId; // Individualized Program Type
        RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId; // Student Support Service Type
        ServicePlanDate = model.ServicePlanDate; // Individualized Program Service Plan Date
        ServicePlanEndDate = model.ServicePlanEndDate; // Individualized Program Service Plan End Date
        ServicePlanMeetingParticipants = model.ServicePlanMeetingParticipants; // Individualized Program Service Plan Meeting Participants
        ServicePlanReevaluationDate = model.ServicePlanReevaluationDate; // Individualized Program Service Plan Reevaluation Date
        ServicePlanSignatureDate = model.ServicePlanSignatureDate; // Individualized Program Service Plan Signature Date
        ServicePlanSignedBy = model.ServicePlanSignedBy; // Individualized Program Service Plan Signed By
        TransferOfRightsStatement = model.TransferOfRightsStatement; // IEP Transfer of Rights Statement
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
