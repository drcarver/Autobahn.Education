//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefIncidentBehaviorEntity.g.cs
//* Name:       Incident Behavior
//* Definition: Categories of behavior coded for use in describing an incident.
//***************************************************************************

/// <summary>
/// Incident Behavior <see cref="RefIncidentBehavior"/>
/// <para>
/// Categories of behavior coded for use in describing an incident.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19500">Incident Behavior</a>
/// </para>
/// </summary>
[Table("RefIncidentBehavior", Schema = "Invalid")]
[Comment("Categories of behavior coded for use in describing an incident.")]
public partial class RefIncidentBehaviorEntity : ReferenceBaseEntity, IReferenceBase
{
}
