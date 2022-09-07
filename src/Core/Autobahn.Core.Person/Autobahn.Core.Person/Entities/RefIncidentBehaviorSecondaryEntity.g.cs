//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefIncidentBehaviorSecondaryEntity.g.cs
//* Name:       Secondary Incident Behavior
//* Definition: Supplemental information about an incident when the primary offense is more serious in nature than alcohol or drug, etc. offenses.
//***************************************************************************

/// <summary>
/// Secondary Incident Behavior <see cref="RefIncidentBehaviorSecondary"/>
/// <para>
/// Supplemental information about an incident when the primary offense is more serious in nature than alcohol or drug, etc. offenses.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19620">Secondary Incident Behavior</a>
/// </para>
/// </summary>
[Table("RefIncidentBehaviorSecondary", Schema = "Person")]
[Comment("Supplemental information about an incident when the primary offense is more serious in nature than alcohol or drug, etc. offenses.")]
public partial class RefIncidentBehaviorSecondaryEntity : ReferenceBaseEntity, IReferenceBase
{
}
