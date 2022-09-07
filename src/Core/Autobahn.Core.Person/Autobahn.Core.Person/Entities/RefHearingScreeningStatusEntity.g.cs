//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefHearingScreeningStatusEntity.g.cs
//* Name:       Hearing Screening Status
//* Definition: Status of an examination used to measure a person's ability to perceive sounds.
//***************************************************************************

/// <summary>
/// Hearing Screening Status <see cref="RefHearingScreeningStatus"/>
/// <para>
/// Status of an examination used to measure a person's ability to perceive sounds.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19309">Hearing Screening Status</a>
/// </para>
/// </summary>
[Table("RefHearingScreeningStatus", Schema = "Person")]
[Comment("Status of an examination used to measure a person's ability to perceive sounds.")]
public partial class RefHearingScreeningStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
