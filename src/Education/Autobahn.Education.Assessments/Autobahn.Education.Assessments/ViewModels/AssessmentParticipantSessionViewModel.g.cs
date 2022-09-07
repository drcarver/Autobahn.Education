//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentParticipantSession file
/// </summary>
public partial class AssessmentParticipantSessionViewModel : ObservableValidator, IAssessmentParticipantSession
{
    #region "AssessmentParticipantSessionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentParticipantSessionViewModel Constructor
    /// </summary>
    public AssessmentParticipantSessionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentParticipantSessionViewModelConstruction();
    }

    /// <summary>
    /// AssessmentParticipantSessionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentParticipantSessionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentParticipantSession";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ActualEndDateTime -- (backing property for Assessment Session Actual End Date Time)
    private DateTime? actualEndDateTime;

    // ActualStartDateTime -- (backing property for Assessment Session Actual Start Date Time)
    private DateTime? actualStartDateTime;

    // AssessmentParticipantSessionDatabaseName -- (backing property for Assessment Participant Session Database Name)
    private System.String assessmentParticipantSessionDatabaseName;

    // member variable for the AssessmentParticipantSessionGuid property
    private System.String assessmentParticipantSessionGuid;

    // DeliveryDeviceDetails -- (backing property for Assessment Participant Session Delivery Device Details)
    private System.String deliveryDeviceDetails;

    // PlatformUserAgent -- (backing property for Assessment Participant Session Platform User Agent)
    private System.String platformUserAgent;

    // SecurityIssue -- (backing property for Assessment Participant Session Security Issue)
    private System.String securityIssue;

    // SpecialEventDescription -- (backing property for Assessment Session Special Event Description)
    private System.String specialEventDescription;

    // TimeAssessed -- (backing property for Assessment Participant Session Time Assessed)
    private System.String timeAssessed;

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

    #region "IAssessmentParticipantSession Properties"
    /// <summary>
    /// Assessment Session Actual End Date Time
    /// <para>
    /// Date and time the assessment actually ended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20024">Assessment Session Actual End Date Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Actual End Date Time")]
    public DateTime? ActualEndDateTime { get => actualEndDateTime; set => SetProperty(ref actualEndDateTime, value, false); }

    /// <summary>
    /// Assessment Session Actual Start Date Time
    /// <para>
    /// Date and time the assessment actually began.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20023">Assessment Session Actual Start Date Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Actual Start Date Time")]
    public DateTime? ActualStartDateTime { get => actualStartDateTime; set => SetProperty(ref actualStartDateTime, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    public Guid? AssessmentFormSectionId { get; set; }

    /// <summary>
    /// Assessment Participant Session Database Name
    /// <para>
    /// The name of the database that was used to administer the test.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20514">Assessment Participant Session Database Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Participant Session Database Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentParticipantSessionDatabaseName { get => assessmentParticipantSessionDatabaseName; set => SetProperty(ref assessmentParticipantSessionDatabaseName, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentParticipantSessionGuid { get => assessmentParticipantSessionGuid; set => SetProperty(ref assessmentParticipantSessionGuid, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
    /// </summary>
    public Guid? AssessmentRegistrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSession"/> model
    /// </summary>
    public Guid AssessmentSessionId { get; set; }

    /// <summary>
    /// Assessment Participant Session Delivery Device Details
    /// <para>
    /// The details about the device or platform by with which the assessment was delivered to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20006">Assessment Participant Session Delivery Device Details</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Participant Session Delivery Device Details")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DeliveryDeviceDetails { get => deliveryDeviceDetails; set => SetProperty(ref deliveryDeviceDetails, value, true); }

    /// <summary>
    /// Assessment Session Location
    /// <para>
    ///  The description of the place where an assessment is administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19590">Assessment Session Location</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Location")]
    public Guid? LocationId { get; set; }

    /// <summary>
    /// Assessment Participant Session Platform User Agent
    /// <para>
    ///  A list of product tokens (keywords) with optional comments that identifies the client hardware and software with which the assessment was delivered to the student during the assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20112">Assessment Participant Session Platform User Agent</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Participant Session Platform User Agent")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String PlatformUserAgent { get => platformUserAgent; set => SetProperty(ref platformUserAgent, value, true); }

    /// <summary>
    /// Assessment Participant Session Platform Type
    /// <para>
    /// The platform with which the assessment was delivered to the student during the assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19377">Assessment Participant Session Platform Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Participant Session Platform Type")]
    public Guid? RefAssessmentPlatformTypeId { get; set; }

    /// <summary>
    /// Assessment Session Special Circumstance Type
    /// <para>
    /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19380">Assessment Session Special Circumstance Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Special Circumstance Type")]
    public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

    /// <summary>
    /// Assessment Participant Session Language
    /// <para>
    /// The language that the assessment is administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19370">Assessment Participant Session Language</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Participant Session Language")]
    public Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Assessment Participant Session Security Issue
    /// <para>
    /// Describes an issue related to the security of a testing instrument identified during a specific instance of delivering an assessment to a specific person during a specific time period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20102">Assessment Participant Session Security Issue</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Participant Session Security Issue")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SecurityIssue { get => securityIssue; set => SetProperty(ref securityIssue, value, true); }

    /// <summary>
    /// Assessment Session Special Event Description
    /// <para>
    /// Describes special events that occur before during or after the assessment session that may impact use of results according to rules related to the Assessment Registration Testing Indicator.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20077">Assessment Session Special Event Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Special Event Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SpecialEventDescription { get => specialEventDescription; set => SetProperty(ref specialEventDescription, value, true); }

    /// <summary>
    /// Assessment Participant Session Time Assessed
    /// <para>
    /// The overall time a learner actually spent during the  assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19398">Assessment Participant Session Time Assessed</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Participant Session Time Assessed")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TimeAssessed { get => timeAssessed; set => SetProperty(ref timeAssessed, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentParticipantSession model)
    {
        IsBusy = true;
        Id = model.Id;
        ActualEndDateTime = model.ActualEndDateTime; // Assessment Session Actual End Date Time
        ActualStartDateTime = model.ActualStartDateTime; // Assessment Session Actual Start Date Time
        AssessmentFormSectionId = model.AssessmentFormSectionId; // 
        AssessmentParticipantSessionDatabaseName = model.AssessmentParticipantSessionDatabaseName; // Assessment Participant Session Database Name
        AssessmentParticipantSessionGuid = model.AssessmentParticipantSessionGuid; // 
        AssessmentRegistrationId = model.AssessmentRegistrationId; // 
        AssessmentSessionId = model.AssessmentSessionId; // 
        DeliveryDeviceDetails = model.DeliveryDeviceDetails; // Assessment Participant Session Delivery Device Details
        LocationId = model.LocationId; // Assessment Session Location
        PlatformUserAgent = model.PlatformUserAgent; // Assessment Participant Session Platform User Agent
        RefAssessmentPlatformTypeId = model.RefAssessmentPlatformTypeId; // Assessment Participant Session Platform Type
        RefAssessmentSessionSpecialCircumstanceTypeId = model.RefAssessmentSessionSpecialCircumstanceTypeId; // Assessment Session Special Circumstance Type
        RefLanguageId = model.RefLanguageId; // Assessment Participant Session Language
        SecurityIssue = model.SecurityIssue; // Assessment Participant Session Security Issue
        SpecialEventDescription = model.SpecialEventDescription; // Assessment Session Special Event Description
        TimeAssessed = model.TimeAssessed; // Assessment Participant Session Time Assessed
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
