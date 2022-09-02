//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefIncidentPersonTypeEntity.g.cs
//* Name:       Incident Perpetrator Type
//* Definition: Information on the type of individual who committed an incident. A "perpetrator" is an individual involved in an incident as an offender (the person who committed the infraction constituting the incident).
//***************************************************************************

/// <summary>
/// Incident Perpetrator Type <see cref="RefIncidentPersonType"/>
/// <para>
/// Information on the type of individual who committed an incident. A "perpetrator" is an individual involved in an incident as an offender (the person who committed the infraction constituting the incident).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20340">Incident Perpetrator Type</a>
/// </para>
/// </summary>
[Table("RefIncidentPersonType", Schema = "Common")]
[Comment("Information on the type of individual who committed an incident. A \u0022perpetrator\u0022 is an individual involved in an incident as an offender (the person who committed the infraction constituting the incident).")]
public partial class RefIncidentPersonTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
