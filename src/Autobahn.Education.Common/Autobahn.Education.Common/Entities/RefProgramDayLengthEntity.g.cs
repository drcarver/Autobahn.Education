//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefProgramDayLengthEntity.g.cs
//* Name:       Prekindergarten Daily Length
//* Definition: The portion of a day that a pre-kindergarten program is provided to the students it serves.
//***************************************************************************

/// <summary>
/// Prekindergarten Daily Length <see cref="RefProgramDayLength"/>
/// <para>
/// The portion of a day that a pre-kindergarten program is provided to the students it serves.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19481">Prekindergarten Daily Length</a>
/// </para>
/// </summary>
[Table("RefProgramDayLength", Schema = "Common")]
[Comment("The portion of a day that a pre-kindergarten program is provided to the students it serves.")]
public partial class RefProgramDayLengthEntity : ReferenceBaseEntity, IReferenceBase
{
}
