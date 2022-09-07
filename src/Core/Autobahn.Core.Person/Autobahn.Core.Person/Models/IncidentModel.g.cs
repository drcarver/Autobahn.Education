//***************************************************************************
//* DomainName: Person Models
//* FileName:   IncidentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIncident file
/// </summary>
public partial class IncidentModel : AutobahnBaseModel, IIncident
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
    public TimeSpan? IncidentTime { get; set; }

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
    public Boolean? ReportedToLawEnforcementInd { get; set; }

    #endregion
}
