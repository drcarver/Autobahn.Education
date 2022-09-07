//***************************************************************************
//* DomainName: Person Models
//* FileName:   IncidentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIncident file
/// </summary>
public partial class IncidentViewModel : ObservableValidator, IIncident
{
    #region "IncidentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IncidentViewModel Constructor
    /// </summary>
    public IncidentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIncidentViewModelConstruction();
    }

    /// <summary>
    /// IncidentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIncidentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Incident";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // IncidentCost -- (backing property for Incident Cost)
    private System.String incidentCost;

    // IncidentDate -- (backing property for Incident Date)
    private DateTime? incidentDate;

    // IncidentDescription -- (backing property for Incident Description)
    private System.String incidentDescription;

    // IncidentIdentifier -- (backing property for Incident Identifier)
    private System.String incidentIdentifier;

    // IncidentTime -- (backing property for Incident Time)
    private TimeSpan? incidentTime;

    // RegulationViolatedDescription -- (backing property for Incident Regulation Violated Description)
    private System.String regulationViolatedDescription;

    // RelatedToDisabilityManifestationInd -- (backing property for Incident Related to Disability Manifestation)
    private Boolean? relatedToDisabilityManifestationInd;

    // ReportedToLawEnforcementInd -- (backing property for Incident Reported to Law Enforcement Indicator)
    private Boolean? reportedToLawEnforcementInd;

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

    #region "IIncident Properties"
    /// <summary>
    /// Incident Cost
    /// <para>
    /// The value of any quantifiable monetary loss directly resulting from the incident. Examples include the value of repairs necessitated by vandalism of a school facility, the value of personnel resources used for repairs or consumed by the incident, the value of stolen items, and the value of time consumed by an incident (e.g., instructional time involved in evacuating a school during a false fire alarm).  Cost may be reported by specific monetary amount or range.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19496">Incident Cost</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Cost")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IncidentCost { get => incidentCost; set => SetProperty(ref incidentCost, value, true); }

    /// <summary>
    /// Incident Date
    /// <para>
    /// The year, month and day on which the incident occurred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19493">Incident Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Date")]
    public DateTime? IncidentDate { get => incidentDate; set => SetProperty(ref incidentDate, value, false); }

    /// <summary>
    /// Incident Description
    /// <para>
    /// The description for an incident.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19499">Incident Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Description")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String IncidentDescription { get => incidentDescription; set => SetProperty(ref incidentDescription, value, true); }

    /// <summary>
    /// Incident Identifier
    /// <para>
    /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19492">Incident Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IncidentIdentifier { get => incidentIdentifier; set => SetProperty(ref incidentIdentifier, value, true); }

    /// <summary>
    /// Reporter Identifier
    /// <para>
    /// Identifies the reporter of the incident using  a pre-existing unique student identifier or unique staff identifier, when the reporter is a student or staff member.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19498">Reporter Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Reporter Identifier")]
    public Guid? IncidentReporterId { get; set; }

    /// <summary>
    /// Incident Time
    /// <para>
    /// An indication of the time of day the incident took place.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19494">Incident Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Time")]
    public TimeSpan? IncidentTime { get => incidentTime; set => SetProperty(ref incidentTime, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid? OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Firearm Type
    /// <para>
    /// The type of firearm.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19548">Firearm Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Firearm Type")]
    public Guid? RefFirearmTypeId { get; set; }

    /// <summary>
    /// Incident Behavior
    /// <para>
    /// Categories of behavior coded for use in describing an incident.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19500">Incident Behavior</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Behavior")]
    public Guid? RefIncidentBehaviorId { get; set; }

    /// <summary>
    /// Secondary Incident Behavior
    /// <para>
    /// Supplemental information about an incident when the primary offense is more serious in nature than alcohol or drug, etc. offenses.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19620">Secondary Incident Behavior</a>
    /// </para>
    /// </summary>
    [DisplayName("Secondary Incident Behavior")]
    public Guid? RefIncidentBehaviorSecondaryId { get; set; }

    /// <summary>
    /// Incident Injury Type
    /// <para>
    /// An indication of the occurrence of physical injury to participants involved in the incident and, if so, the level of injury sustained.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19501">Incident Injury Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Injury Type")]
    public Guid? RefIncidentInjuryTypeId { get; set; }

    /// <summary>
    /// Incident Location
    /// <para>
    /// Identifies where the incident occurred and whether or not it occurred on campus.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19610">Incident Location</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Location")]
    public Guid? RefIncidentLocationId { get; set; }

    /// <summary>
    /// Incident Multiple Offense Type
    /// <para>
    /// An indication of whether the offense was primary or secondary in nature when a single incident included more than one type of offense.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20337">Incident Multiple Offense Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Multiple Offense Type")]
    public Guid? RefIncidentMultipleOffenseTypeId { get; set; }

    /// <summary>
    /// Incident Perpetrator Injury Type
    /// <para>
    /// An indication of the occurrence of physical injury to the perpetrator(s) (participants) involved in the incident and, if so, the level of injury sustained.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20339">Incident Perpetrator Injury Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Perpetrator Injury Type")]
    public Guid? RefIncidentPerpetratorInjuryTypeId { get; set; }

    /// <summary>
    /// Incident Reporter Type
    /// <para>
    /// Information on the type of person who reported the incident. When known and/or if useful, use a more specific option code (e.g., "Counselor" rather than "Professional Staff").
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19497">Incident Reporter Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Reporter Type")]
    public Guid? RefIncidentReporterTypeId { get; set; }

    /// <summary>
    /// Incident Time Description Code
    /// <para>
    /// A code for the description of the time of day that an incident took place.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19506">Incident Time Description Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Time Description Code")]
    public Guid? RefIncidentTimeDescriptionCodeId { get; set; }

    /// <summary>
    /// Weapon Type
    /// <para>
    /// Identifies the type of weapon used during an incident.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20178">Weapon Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Weapon Type")]
    public Guid? RefWeaponTypeId { get; set; }

    /// <summary>
    /// Incident Regulation Violated Description
    /// <para>
    /// A description of the rule, regulation, or standard that was violated when an incident occurred (e.g., the identification of a relevant law, conduct standard, or acceptable use policy).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20342">Incident Regulation Violated Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Regulation Violated Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RegulationViolatedDescription { get => regulationViolatedDescription; set => SetProperty(ref regulationViolatedDescription, value, true); }

    /// <summary>
    /// Incident Related to Disability Manifestation
    /// <para>
    /// An indication whether a student's behavior (offense) was a manifestation of, or related to, a disability condition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20343">Incident Related to Disability Manifestation</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Related to Disability Manifestation")]
    public Boolean? RelatedToDisabilityManifestationInd { get => relatedToDisabilityManifestationInd; set => SetProperty(ref relatedToDisabilityManifestationInd, value, false); }

    /// <summary>
    /// Incident Reported to Law Enforcement Indicator
    /// <para>
    /// An indication that the school resource officer or any other law enforcement official was notified about the incident, regardless of whether official action is taken.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20345">Incident Reported to Law Enforcement Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Reported to Law Enforcement Indicator")]
    public Boolean? ReportedToLawEnforcementInd { get => reportedToLawEnforcementInd; set => SetProperty(ref reportedToLawEnforcementInd, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIncident model)
    {
        IsBusy = true;
        Id = model.Id;
        IncidentCost = model.IncidentCost; // Incident Cost
        IncidentDate = model.IncidentDate; // Incident Date
        IncidentDescription = model.IncidentDescription; // Incident Description
        IncidentIdentifier = model.IncidentIdentifier; // Incident Identifier
        IncidentReporterId = model.IncidentReporterId; // Reporter Identifier
        IncidentTime = model.IncidentTime; // Incident Time
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefFirearmTypeId = model.RefFirearmTypeId; // Firearm Type
        RefIncidentBehaviorId = model.RefIncidentBehaviorId; // Incident Behavior
        RefIncidentBehaviorSecondaryId = model.RefIncidentBehaviorSecondaryId; // Secondary Incident Behavior
        RefIncidentInjuryTypeId = model.RefIncidentInjuryTypeId; // Incident Injury Type
        RefIncidentLocationId = model.RefIncidentLocationId; // Incident Location
        RefIncidentMultipleOffenseTypeId = model.RefIncidentMultipleOffenseTypeId; // Incident Multiple Offense Type
        RefIncidentPerpetratorInjuryTypeId = model.RefIncidentPerpetratorInjuryTypeId; // Incident Perpetrator Injury Type
        RefIncidentReporterTypeId = model.RefIncidentReporterTypeId; // Incident Reporter Type
        RefIncidentTimeDescriptionCodeId = model.RefIncidentTimeDescriptionCodeId; // Incident Time Description Code
        RefWeaponTypeId = model.RefWeaponTypeId; // Weapon Type
        RegulationViolatedDescription = model.RegulationViolatedDescription; // Incident Regulation Violated Description
        RelatedToDisabilityManifestationInd = model.RelatedToDisabilityManifestationInd; // Incident Related to Disability Manifestation
        ReportedToLawEnforcementInd = model.ReportedToLawEnforcementInd; // Incident Reported to Law Enforcement Indicator
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
