//***************************************************************************
//* DomainName: Person Models
//* FileName:   IncidentPersonEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIncidentPerson file
/// </summary>
[Table("IncidentPerson", Schema = "Person")]
public partial class IncidentPersonEntity : EntityBase, IIncidentPerson
{
    #region "IIncidentPerson Properties"
    /// <summary>
    /// Incident Perpetrator Identifier
    /// <para>
    /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20338">Incident Perpetrator Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.")]
    public System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIncident"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Incident")]
    public Guid IncidentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Incident Person Role Type
    /// <para>
    /// The role or type of participation of a person in a discipline incident.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20341">Incident Person Role Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefIncidentPersonRoleType")]
    [Comment("The role or type of participation of a person in a discipline incident.")]
    public Guid RefIncidentPersonRoleTypeId { get; set; }

    /// <summary>
    /// Incident Perpetrator Type
    /// <para>
    /// Information on the type of individual who committed an incident. A "perpetrator" is an individual involved in an incident as an offender (the person who committed the infraction constituting the incident).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20340">Incident Perpetrator Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefIncidentPersonType")]
    [Comment("Information on the type of individual who committed an incident. A \u0022perpetrator\u0022 is an individual involved in an incident as an offender (the person who committed the infraction constituting the incident).")]
    public Guid? RefIncidentPersonTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIncident"/> implementation
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual IncidentEntity IncidentEntity { get; set; }

    /// <summary>
    /// The role or type of participation of a person in a discipline incident.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20341">Incident Person Role Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual RefIncidentPersonRoleTypeEntity RefIncidentPersonRoleTypeEntity { get; set; }

    /// <summary>
    /// Information on the type of individual who committed an incident. A "perpetrator" is an individual involved in an incident as an offender (the person who committed the infraction constituting the incident).
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20340">Incident Perpetrator Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual RefIncidentPersonTypeEntity? RefIncidentPersonTypeEntity { get; set; }

    #endregion
}
