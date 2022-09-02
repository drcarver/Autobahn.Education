//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTechnologyLiteracyStatusEntity.g.cs
//* Name:       Technology Literacy Status in 8th Grade
//* Definition: An indication of the technology literacy of 8th graders.
//***************************************************************************

/// <summary>
/// Technology Literacy Status in 8th Grade <see cref="RefTechnologyLiteracyStatus"/>
/// <para>
/// An indication of the technology literacy of 8th graders.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19558">Technology Literacy Status in 8th Grade</a>
/// </para>
/// </summary>
[Table("RefTechnologyLiteracyStatus", Schema = "Common")]
[Comment("An indication of the technology literacy of 8th graders.")]
public partial class RefTechnologyLiteracyStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
