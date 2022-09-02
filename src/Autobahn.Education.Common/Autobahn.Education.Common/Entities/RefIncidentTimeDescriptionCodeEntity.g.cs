//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefIncidentTimeDescriptionCodeEntity.g.cs
//* Name:       Incident Time Description Code
//* Definition: A code for the description of the time of day that an incident took place.
//***************************************************************************

/// <summary>
/// Incident Time Description Code <see cref="RefIncidentTimeDescriptionCode"/>
/// <para>
/// A code for the description of the time of day that an incident took place.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19506">Incident Time Description Code</a>
/// </para>
/// </summary>
[Table("RefIncidentTimeDescriptionCode", Schema = "Common")]
[Comment("A code for the description of the time of day that an incident took place.")]
public partial class RefIncidentTimeDescriptionCodeEntity : ReferenceBaseEntity, IReferenceBase
{
}
