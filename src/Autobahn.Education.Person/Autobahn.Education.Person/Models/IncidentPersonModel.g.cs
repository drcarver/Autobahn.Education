//***************************************************************************
//* DomainName: Person Models
//* FileName:   IncidentPersonEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIncidentPerson file
/// </summary>
public partial class IncidentPersonModel : AutobahnBaseModel, IIncidentPerson
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
    public System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIncident"/> model
    /// </summary>
    public Guid IncidentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
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
    public Guid? RefIncidentPersonTypeId { get; set; }

    #endregion
}
