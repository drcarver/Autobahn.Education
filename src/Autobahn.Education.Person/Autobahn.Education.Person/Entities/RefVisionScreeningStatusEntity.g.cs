//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefVisionScreeningStatusEntity.g.cs
//* Name:       Vision Screening Status
//* Definition: Status of an examination used to measure a person's ability to see.
//***************************************************************************

/// <summary>
/// Vision Screening Status <see cref="RefVisionScreeningStatus"/>
/// <para>
/// Status of an examination used to measure a person's ability to see.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19308">Vision Screening Status</a>
/// </para>
/// </summary>
[Table("RefVisionScreeningStatus", Schema = "Person")]
[Comment("Status of an examination used to measure a person's ability to see.")]
public partial class RefVisionScreeningStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
