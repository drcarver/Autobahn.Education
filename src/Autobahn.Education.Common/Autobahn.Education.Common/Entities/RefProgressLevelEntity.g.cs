//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefProgressLevelEntity.g.cs
//* Name:       Progress Level
//* Definition: The amount of progress shown in academic subjects.
//***************************************************************************

/// <summary>
/// Progress Level <see cref="RefProgressLevel"/>
/// <para>
/// The amount of progress shown in academic subjects.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19553">Progress Level</a>
/// </para>
/// </summary>
[Table("RefProgressLevel", Schema = "Common")]
[Comment("The amount of progress shown in academic subjects.")]
public partial class RefProgressLevelEntity : ReferenceBaseEntity, IReferenceBase
{
}
