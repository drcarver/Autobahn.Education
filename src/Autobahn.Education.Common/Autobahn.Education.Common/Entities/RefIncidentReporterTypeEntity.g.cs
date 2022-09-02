//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefIncidentReporterTypeEntity.g.cs
//* Name:       Incident Reporter Type
//* Definition: Information on the type of person who reported the incident. When known and/or if useful, use a more specific option code (e.g., "Counselor" rather than "Professional Staff").
//***************************************************************************

/// <summary>
/// Incident Reporter Type <see cref="RefIncidentReporterType"/>
/// <para>
/// Information on the type of person who reported the incident. When known and/or if useful, use a more specific option code (e.g., "Counselor" rather than "Professional Staff").
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19497">Incident Reporter Type</a>
/// </para>
/// </summary>
[Table("RefIncidentReporterType", Schema = "Common")]
[Comment("Information on the type of person who reported the incident. When known and/or if useful, use a more specific option code (e.g., \u0022Counselor\u0022 rather than \u0022Professional Staff\u0022).")]
public partial class RefIncidentReporterTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
