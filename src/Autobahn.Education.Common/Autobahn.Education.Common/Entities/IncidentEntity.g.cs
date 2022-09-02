//***************************************************************************
//* DomainName: Common Models
//* FileName:   IncidentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIncident file
/// </summary>
[Table("Incident", Schema = "Common")]
public partial class IncidentEntity : EntityBase, IIncident
{
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The value of any quantifiable monetary loss directly resulting from the incident. Examples include the value of repairs necessitated by vandalism of a school facility, the value of personnel resources used for repairs or consumed by the incident, the value of stolen items, and the value of time consumed by an incident (e.g., instructional time involved in evacuating a school during a false fire alarm).  Cost may be reported by specific monetary amount or range.")]
    public System.String IncidentCost { get; set; }

    /// <summary>
    /// Incident Date
    /// <para>
    /// The year, month and day on which the incident occurred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19493">Incident Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which the incident occurred.")]
    public DateTime? IncidentDate { get; set; }

    /// <summary>
    /// Incident Description
    /// <para>
    /// The description for an incident.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19499">Incident Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The description for an incident.")]
    public System.String IncidentDescription { get; set; }

    /// <summary>
    /// Incident Identifier
    /// <para>
    /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19492">Incident Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.")]
    public System.String IncidentIdentifier { get; set; }

    /// <summary>
    /// Reporter Identifier
    /// <para>
    /// Identifies the reporter of the incident using  a pre-existing unique student identifier or unique staff identifier, when the reporter is a student or staff member.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19498">Reporter Identifier</a>
    /// </para>
    /// </summary>
    [Obsolete("The IncidentReporter property is obsolete and will be removed in a later version")]
    [ForeignKey("IncidentReporter")]
    [Comment("Identifies the reporter of the incident using  a pre-existing unique student identifier or unique staff identifier, when the reporter is a student or staff member.")]
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
    [Comment("An indication of the time of day the incident took place.")]
    public TimeSpan? IncidentTime { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [ForeignKey("OrganizationPersonRole")]
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
    [ForeignKey("RefFirearmType")]
    [Comment("The type of firearm.")]
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
    [ForeignKey("RefIncidentBehavior")]
    [Comment("Categories of behavior coded for use in describing an incident.")]
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
    [ForeignKey("RefIncidentBehaviorSecondary")]
    [Comment("Supplemental information about an incident when the primary offense is more serious in nature than alcohol or drug, etc. offenses.")]
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
    [ForeignKey("RefIncidentInjuryType")]
    [Comment("An indication of the occurrence of physical injury to participants involved in the incident and, if so, the level of injury sustained.")]
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
    [ForeignKey("RefIncidentLocation")]
    [Comment("Identifies where the incident occurred and whether or not it occurred on campus.")]
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
    [ForeignKey("RefIncidentMultipleOffenseType")]
    [Comment("An indication of whether the offense was primary or secondary in nature when a single incident included more than one type of offense.")]
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
    [ForeignKey("RefIncidentPerpetratorInjuryType")]
    [Comment("An indication of the occurrence of physical injury to the perpetrator(s) (participants) involved in the incident and, if so, the level of injury sustained.")]
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
    [ForeignKey("RefIncidentReporterType")]
    [Comment("Information on the type of person who reported the incident. When known and/or if useful, use a more specific option code (e.g., \u0022Counselor\u0022 rather than \u0022Professional Staff\u0022).")]
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
    [ForeignKey("RefIncidentTimeDescriptionCode")]
    [Comment("A code for the description of the time of day that an incident took place.")]
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
    [ForeignKey("RefWeaponType")]
    [Comment("Identifies the type of weapon used during an incident.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A description of the rule, regulation, or standard that was violated when an incident occurred (e.g., the identification of a relevant law, conduct standard, or acceptable use policy).")]
    public System.String RegulationViolatedDescription { get; set; }

    /// <summary>
    /// Incident Related to Disability Manifestation
    /// <para>
    /// An indication whether a student's behavior (offense) was a manifestation of, or related to, a disability condition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20343">Incident Related to Disability Manifestation</a>
    /// </para>
    /// </summary>
    [Comment("An indication whether a student's behavior (offense) was a manifestation of, or related to, a disability condition.")]
    public Boolean? RelatedToDisabilityManifestationInd { get; set; }

    /// <summary>
    /// Incident Reported to Law Enforcement Indicator
    /// <para>
    /// An indication that the school resource officer or any other law enforcement official was notified about the incident, regardless of whether official action is taken.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20345">Incident Reported to Law Enforcement Indicator</a>
    /// </para>
    /// </summary>
    [Comment("An indication that the school resource officer or any other law enforcement official was notified about the incident, regardless of whether official action is taken.")]
    public Boolean? ReportedToLawEnforcementInd { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// A code for the description of the time of day that an incident took place.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19506">Incident Time Description Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIncidentTimeDescriptionCodeEntity RefIncidentTimeDescriptionCodeEntity { get; set; }

    /// <summary>
    /// Categories of behavior coded for use in describing an incident.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19500">Incident Behavior</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIncidentBehaviorEntity RefIncidentBehaviorEntity { get; set; }

    /// <summary>
    /// Supplemental information about an incident when the primary offense is more serious in nature than alcohol or drug, etc. offenses.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19620">Secondary Incident Behavior</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIncidentBehaviorSecondaryEntity RefIncidentBehaviorSecondaryEntity { get; set; }

    /// <summary>
    /// An indication of the occurrence of physical injury to participants involved in the incident and, if so, the level of injury sustained.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19501">Incident Injury Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIncidentInjuryTypeEntity RefIncidentInjuryTypeEntity { get; set; }

    /// <summary>
    /// Identifies the type of weapon used during an incident.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20178">Weapon Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefWeaponTypeEntity RefWeaponTypeEntity { get; set; }

    /// <summary>
    /// Information on the type of person who reported the incident. When known and/or if useful, use a more specific option code (e.g., "Counselor" rather than "Professional Staff").
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19497">Incident Reporter Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIncidentReporterTypeEntity RefIncidentReporterTypeEntity { get; set; }

    /// <summary>
    /// Identifies where the incident occurred and whether or not it occurred on campus.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19610">Incident Location</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIncidentLocationEntity RefIncidentLocationEntity { get; set; }

    /// <summary>
    /// The type of firearm.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19548">Firearm Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFirearmTypeEntity RefFirearmTypeEntity { get; set; }

    /// <summary>
    /// An indication of whether the offense was primary or secondary in nature when a single incident included more than one type of offense.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20337">Incident Multiple Offense Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIncidentMultipleOffenseTypeEntity RefIncidentMultipleOffenseTypeEntity { get; set; }

    /// <summary>
    /// An indication of the occurrence of physical injury to the perpetrator(s) (participants) involved in the incident and, if so, the level of injury sustained.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20339">Incident Perpetrator Injury Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIncidentPerpetratorInjuryTypeEntity RefIncidentPerpetratorInjuryTypeEntity { get; set; }

    #endregion
}
