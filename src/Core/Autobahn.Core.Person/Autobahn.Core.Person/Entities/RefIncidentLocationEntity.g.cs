//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefIncidentLocationEntity.g.cs
//* Name:       Incident Location
//* Definition: Identifies where the incident occurred and whether or not it occurred on campus.
//***************************************************************************

/// <summary>
/// Incident Location <see cref="RefIncidentLocation"/>
/// <para>
/// Identifies where the incident occurred and whether or not it occurred on campus.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19610">Incident Location</a>
/// </para>
/// </summary>
[Table("RefIncidentLocation", Schema = "Person")]
[Comment("Identifies where the incident occurred and whether or not it occurred on campus.")]
public partial class RefIncidentLocationEntity : ReferenceBaseEntity, IReferenceBase
{
}
