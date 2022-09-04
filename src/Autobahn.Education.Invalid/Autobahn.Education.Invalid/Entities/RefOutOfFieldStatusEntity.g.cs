//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefOutOfFieldStatusEntity.g.cs
//* Name:       EDFacts Teacher Out of Field Status
//* Definition: An indication of whether teachers have been identified as teaching a subject or field for which they are not certified or licensed as defined by the state.
//***************************************************************************

/// <summary>
/// EDFacts Teacher Out of Field Status <see cref="RefOutOfFieldStatus"/>
/// <para>
/// An indication of whether teachers have been identified as teaching a subject or field for which they are not certified or licensed as defined by the state.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20930">EDFacts Teacher Out of Field Status</a>
/// </para>
/// </summary>
[Table("RefOutOfFieldStatus", Schema = "Invalid")]
[Comment("An indication of whether teachers have been identified as teaching a subject or field for which they are not certified or licensed as defined by the state.")]
public partial class RefOutOfFieldStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
