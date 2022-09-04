//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefIncidentPersonRoleTypeEntity.g.cs
//* Name:       Incident Person Role Type
//* Definition: The role or type of participation of a person in a discipline incident.
//***************************************************************************

/// <summary>
/// Incident Person Role Type <see cref="RefIncidentPersonRoleType"/>
/// <para>
/// The role or type of participation of a person in a discipline incident.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20341">Incident Person Role Type</a>
/// </para>
/// </summary>
[Table("RefIncidentPersonRoleType", Schema = "Autobahn.Core.Person")]
[Comment("The role or type of participation of a person in a discipline incident.")]
public partial class RefIncidentPersonRoleTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
